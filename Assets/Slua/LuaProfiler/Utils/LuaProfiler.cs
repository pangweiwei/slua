#pragma warning disable CS0219//故意在c#这里产生于lua那边的等量GC
#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_5_5_OR_NEWER
using UnityEngine.Profiling;
#endif
using SLua;
using LuaLib = SLua.LuaDLL;
using System.Runtime.InteropServices;
using System.Reflection;
using UnityEditorInternal;
using UnityEditor;

namespace MikuLuaProfiler
{

    [InitializeOnLoad]
    static class HookSetup
    {
#if !UNITY_2017_1_OR_NEWER
        static bool isPlaying = false;
#endif
        static HookSetup()
        {
#if UNITY_2017_1_OR_NEWER
            EditorApplication.playModeStateChanged += OnEditorPlaying;
#else
            EditorApplication.playmodeStateChanged += () =>
            {

                if (isPlaying == true && EditorApplication.isPlaying == false)
                {
                    LuaProfiler.SetMainLuaEnv(null);
                }

                isPlaying = EditorApplication.isPlaying;
            };
#endif
        }

#if UNITY_2017_1_OR_NEWER
        public static void OnEditorPlaying(PlayModeStateChange playModeStateChange)
        {
            if (playModeStateChange == PlayModeStateChange.ExitingPlayMode)
            {
                LuaProfiler.SetMainLuaEnv(null);
            }
        }
#endif

        #region hook

        #region hook tostring

        public class LuaDll
        {
            #region luastring
            public static readonly Dictionary<long, string> stringDict = new Dictionary<long, string>();
            public static bool TryGetLuaString(IntPtr p, out string result)
            {

                return stringDict.TryGetValue((long)p, out result);
            }
            public static void RefString(IntPtr strPoint, int index, string s, IntPtr L)
            {
                int oldTop = LuaLib.lua_gettop(L);
                LuaLib.lua_pushvalue(L, index);
                //把字符串ref了之后就不GC了
                LuaLib.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
                LuaLib.lua_settop(L, oldTop);
                stringDict[(long)strPoint] = s;
            }
            #endregion

            public static int luaL_loadbuffer(IntPtr L, byte[] buff, int size, string name)
            {
                if (LuaDeepProfilerSetting.Instance.isDeepProfiler 
                    && LuaProfiler.mainEnv.L == L)//&& name != "chunk"
                {
                    var utf8WithoutBom = new System.Text.UTF8Encoding(true);
                    string fileName = name.Replace("@", "").Replace("/", ".") + ".lua";
                    string value = utf8WithoutBom.GetString(buff);
                    value = Parse.InsertSample(value, fileName);

                    //System.IO.File.WriteAllText(fileName, value);

                    buff = utf8WithoutBom.GetBytes(value);
                    size = buff.Length;
                }

                return ProxyLoadbuffer(L, buff, size, name);
            }

            public static int ProxyLoadbuffer(IntPtr L, byte[] buff, int size, string name)
            {
                return 0;
            }

            public static string lua_tostring(IntPtr luaState, int index)
            {
                int strlen;

                IntPtr str = LuaLib.luaS_tolstring32(luaState, index, out strlen); // fix il2cpp 64 bit
                string s = null;
                if (TryGetLuaString(str, out s))
                {
                    return s;
                }

                if (strlen > 0 && str != IntPtr.Zero)
                {
                    s = Marshal.PtrToStringAnsi(str);
                    // fallback method
                    if (s == null)
                    {
                        byte[] b = new byte[strlen];
                        Marshal.Copy(str, b, 0, strlen);
                        s = System.Text.Encoding.Default.GetString(b);
                    }
                }
                if (s != null)
                {
                    RefString(str, index, s, luaState);
                }

                return (s == null) ? string.Empty : s;
            }

            public static string PoxyToString(IntPtr L, int index)
            {
                return null;
            }
        }
        #endregion


        #region hook profiler
        public class Profiler
        {
            private static Stack<string> m_Stack = new Stack<string>();
            private static int m_currentFrame = 0;
            public static void BeginSampleOnly(string name)
            {
                if (ProfilerDriver.deepProfiling) return;
                if (Time.frameCount != m_currentFrame)
                {
                    m_Stack.Clear();
                    m_currentFrame = Time.frameCount;
                }
                m_Stack.Push(name);
                ProxyBeginSample(name);
            }
            public static void BeginSample(string name, UnityEngine.Object targetObject)
            {
                if (ProfilerDriver.deepProfiling) return;
                m_Stack.Push(name);
                ProxyBeginSample(name, targetObject);
            }

            public static void EndSample()
            {
                if (ProfilerDriver.deepProfiling) return;
                if (m_Stack.Count <= 0)
                {
                    return;
                }
                m_Stack.Pop();
                ProxyEndSample();
            }

            public static void ProxyBeginSample(string name)
            {
            }
            public static void ProxyBeginSample(string name, UnityEngine.Object targetObject)
            {
            }

            public static void ProxyEndSample()
            {
            }
        }
        #endregion

        #region do hook
        private static MethodHooker beginSampeOnly;
        private static MethodHooker beginObjetSample;
        private static MethodHooker endSample;
        private static MethodHooker tostringHook;
        private static MethodHooker loaderHook;

        private static bool m_hooked = false;
        public static void HookLuaFuns()
        {
            if (m_hooked) return;
            if (tostringHook == null)
            {
                Type typeLogReplace = typeof(LuaDll);
                Type typeLog = typeof(LuaLib);
                MethodInfo tostringFun = typeLog.GetMethod("lua_tostring");
                MethodInfo tostringReplace = typeLogReplace.GetMethod("lua_tostring");
                MethodInfo tostringProxy = typeLogReplace.GetMethod("ProxyToString");

                tostringHook = new MethodHooker(tostringFun, tostringReplace, tostringProxy);
                tostringHook.Install();

                tostringFun = typeLog.GetMethod("luaL_loadbuffer");
                tostringReplace = typeLogReplace.GetMethod("luaL_loadbuffer");
                tostringProxy = typeLogReplace.GetMethod("ProxyLoadbuffer");

                tostringHook = new MethodHooker(tostringFun, tostringReplace, tostringProxy);
                tostringHook.Install();
            }

            if (beginSampeOnly == null)
            {
                Type typeTarget = typeof(UnityEngine.Profiling.Profiler);
                Type typeReplace = typeof(Profiler);

                MethodInfo hookTarget = typeTarget.GetMethod("BeginSampleOnly", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { typeof(string) }, null);
                MethodInfo hookReplace = typeReplace.GetMethod("BeginSampleOnly");
                MethodInfo hookProxy = typeReplace.GetMethod("ProxyBeginSample", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string) }, null);
                beginSampeOnly = new MethodHooker(hookTarget, hookReplace, hookProxy);
                beginSampeOnly.Install();

                hookTarget = typeTarget.GetMethod("BeginSample", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string), typeof(UnityEngine.Object) }, null);
                hookReplace = typeReplace.GetMethod("BeginSample");
                hookProxy = typeReplace.GetMethod("ProxyBeginSample", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string), typeof(UnityEngine.Object) }, null);
                beginObjetSample = new MethodHooker(hookTarget, hookReplace, hookProxy);
                beginObjetSample.Install();

                hookTarget = typeTarget.GetMethod("EndSample", BindingFlags.Public | BindingFlags.Static, null, new Type[] { }, null);
                hookReplace = typeReplace.GetMethod("EndSample");
                hookProxy = typeReplace.GetMethod("ProxyEndSample", BindingFlags.Public | BindingFlags.Static, null, new Type[] { }, null);
                endSample = new MethodHooker(hookTarget, hookReplace, hookProxy);
                endSample.Install();
            }

            m_hooked = true;
        }

        public static void Uninstall()
        {
            if (beginSampeOnly != null)
            {
                beginSampeOnly.Uninstall();
                beginSampeOnly = null;
            }
            if (beginObjetSample != null)
            {
                beginObjetSample.Uninstall();
                beginObjetSample = null;
            }
            if (endSample != null)
            {
                endSample.Uninstall();
                endSample = null;
            }
            if (tostringHook != null)
            {
                tostringHook.Uninstall();
                tostringHook = null;
            }
            if (loaderHook != null)
            {
                loaderHook.Uninstall();
                loaderHook = null;
            }

            m_hooked = false;
        }
        #endregion

        #endregion
    }

    public class LuaProfiler
    {
        public static LuaState mainEnv
        {
            get
            {
                return _mainEnv;
            }
        }
        private static LuaState _mainEnv;
        public static void SetMainLuaEnv(LuaState env)
        {
            //不支持多栈
            if (_mainEnv != null && env != null) return;

            _mainEnv = env;
            if (LuaDeepProfilerSetting.Instance.isDeepProfiler)
            {
                if (env != null)
                {
                    Lua_MikuLuaProfiler_LuaProfiler.reg(env.L);
                    env.doString(@"
BeginMikuSample = MikuLuaProfiler.LuaProfiler.BeginSample
EndMikuSample = MikuLuaProfiler.LuaProfiler.EndSample

function miku_unpack_return_value(...)
	EndMikuSample()
	return ...
end
");
                    HookSetup.HookLuaFuns();
                }
            }

            if (env == null)
            {
                HookSetup.Uninstall();
            }
        }

        public static string GetLuaMemory()
        {
            long result = 0;
            if (_mainEnv != null)
            {
                try
                {
                    result = GetLuaMemory(_mainEnv.L);
                }
                catch { }
            }

            return GetMemoryString(result);
        }

        public static long GetLuaMemory(IntPtr luaState)
        {
            long result = 0;

            result = LuaLib.lua_gc(luaState, LuaGCOptions.LUA_GCCOUNT, 0);
            result = result * 1024 + LuaLib.lua_gc(luaState, LuaGCOptions.LUA_GCCOUNTB, 0);

            return result;
        }

        public class Sample
        {
            private static ObjectPool<Sample> samplePool = new ObjectPool<Sample>(250);
            public static Sample Create(float time, long memory, string name)
            {
                Sample s = samplePool.GetObject();
                s.currentTime = time;
                s.currentLuaMemory = memory;
                s.realCurrentLuaMemory = memory;
                s.costGC = 0;
                s.name = name;
                s.costTime = 0;
                s.childs.Clear();
                s._father = null;
                s._fullName = null;

                return s;
            }

            public void Restore()
            {
                for (int i = 0, imax = childs.Count; i < imax; i++)
                {
                    childs[i].Restore();
                }
                samplePool.Store(this);
            }

            public int oneFrameCall
            {
                get
                {
                    return 1;
                }
            }
            public float currentTime { private set; get; }
            public long realCurrentLuaMemory { private set; get; }
            private string _name;
            public string name
            {
                private set
                {
                    _name = value;
                }
                get
                {
                    return _name;
                }
            }

            private static Dictionary<string, Dictionary<string, string>> m_fullNamePool = new Dictionary<string, Dictionary<string, string>>();
            private string _fullName = null;
            public string fullName
            {
                get
                {
                    if (_father == null) return _name;

                    if (_fullName == null)
                    {
                        Dictionary<string, string> childDict;
                        if (!m_fullNamePool.TryGetValue(_father.fullName, out childDict))
                        {
                            childDict = new Dictionary<string, string>();
                            m_fullNamePool.Add(_father.fullName, childDict);
                        }

                        if (!childDict.TryGetValue(_name, out _fullName))
                        {
                            string value = _name;
                            var f = _father;
                            while (f != null)
                            {
                                value = f.name + value;
                                f = f.fahter;
                            }
                            _fullName = value;
                            childDict[_name] = _fullName;
                        }

                        return _fullName;
                    }
                    else
                    {
                        return _fullName;
                    }
                }
            }
            //这玩意在统计的window里面没啥卵用
            public long currentLuaMemory { set; get; }

            private float _costTime;
            public float costTime
            {
                set
                {
                    _costTime = value;
                }
                get
                {
                    float result = _costTime;
                    return result;
                }
            }

            private long _costGC;
            public long costGC
            {
                set
                {
                    _costGC = value;
                }
                get
                {
                    return _costGC;
                }
            }
            private Sample _father;
            public Sample fahter
            {
                set
                {
                    _father = value;
                    if (_father != null)
                    {
                        _father.childs.Add(this);
                    }
                }
                get
                {
                    return _father;
                }
            }

            public readonly List<Sample> childs = new List<Sample>(256);
        }
        //开始采样时候的lua内存情况，因为中间有可能会有二次采样，所以要丢到一个盏中
        public static readonly List<Sample> beginSampleMemoryStack = new List<Sample>();

        private static Action<Sample> m_SampleEndAction;

        private static bool isDeep
        {
            get
            {
#if UNITY_EDITOR
                return ProfilerDriver.deepProfiling;
#else
            return false;
#endif
            }
        }
        public static void SetSampleEnd(Action<Sample> action)
        {
            m_SampleEndAction = action;
        }
        public static void BeginSample(string name)
        {
#if DEBUG
            if (_mainEnv != null)
            {
                BeginSample(_mainEnv.L, name);
            }
#endif
        }
        public static void BeginSample(IntPtr luaState)
        {
#if DEBUG
            BeginSample(luaState, "lua gc");
#endif
        }
        private static int m_currentFrame = 0;
        public static void BeginSample(IntPtr luaState, string name)
        {
            if (m_currentFrame != Time.frameCount)
            {
                PopAllSampleWhenLateUpdate();
                m_currentFrame = Time.frameCount;
            }

#if DEBUG
            //if (beginSampleMemoryStack.Count == 0 && LuaDeepProfilerSetting.Instance.isDeepProfiler)
            //    LuaLib.lua_gc(luaState, LuaGCOptions.LUA_GCSTOP, 0);

            long memoryCount = GetLuaMemory(luaState);
            Sample sample = Sample.Create(Time.realtimeSinceStartup, memoryCount, name);

            beginSampleMemoryStack.Add(sample);
            if (!isDeep)
            {
                Profiler.BeginSample(name);
            }
#endif
        }
        public static void PopAllSampleWhenLateUpdate()
        {
            for (int i = 0, imax = beginSampleMemoryStack.Count; i < imax; i++)
            {
                var item = beginSampleMemoryStack[i];
                if (item.fahter == null)
                {
                    item.Restore();
                }
            }
            beginSampleMemoryStack.Clear();
        }
        public static void EndSample()
        {
#if DEBUG
            if (_mainEnv != null)
            {
                EndSample(_mainEnv.L);
            }
#endif
        }
        public static void EndSample(IntPtr luaState)
        {
#if DEBUG
            if (beginSampleMemoryStack.Count <= 0)
            {
                return;
            }
            int count = beginSampleMemoryStack.Count;
            Sample sample = beginSampleMemoryStack[beginSampleMemoryStack.Count - 1];
            long oldMemoryCount = sample.currentLuaMemory;
            beginSampleMemoryStack.RemoveAt(count - 1);
            long nowMemoryCount = GetLuaMemory(luaState);
            sample.fahter = count > 1 ? beginSampleMemoryStack[count - 2] : null;

            if (!isDeep)
            {
                long delta = nowMemoryCount - oldMemoryCount;

                long tmpDelta = delta;
                if (delta > 0)
                {
                    delta = Math.Max(delta - 40, 0);//byte[0] 的字节占用是40
                    byte[] luagc = new byte[delta];
                }
                for (int i = 0, imax = beginSampleMemoryStack.Count; i < imax; i++)
                {
                    Sample s = beginSampleMemoryStack[i];
                    s.currentLuaMemory += tmpDelta;
                    beginSampleMemoryStack[i] = s;
                }
                Profiler.EndSample();
            }

            sample.costTime = Time.realtimeSinceStartup - sample.currentTime;
            var gc = nowMemoryCount - sample.realCurrentLuaMemory;
            sample.costGC = gc > 0 ? gc : 0;
            //if (beginSampleMemoryStack.Count == 0 && LuaDeepProfilerSetting.Instance.isDeepProfiler)
            //{
            //    LuaLib.lua_gc(luaState, LuaGCOptions.LUA_GCRESTART, 0);
            //    LuaLib.lua_gc(luaState, LuaGCOptions.LUA_GCCOLLECT, 0);
            //}


            if (m_SampleEndAction != null && beginSampleMemoryStack.Count == 0)
            {
                m_SampleEndAction(sample);
            }

            if (sample.fahter == null)
            {
                sample.Restore();
            }
#endif
        }

        const long MaxB = 1024;
        const long MaxK = MaxB * 1024;
        const long MaxM = MaxK * 1024;
        const long MaxG = MaxM * 1024;

        public static string GetMemoryString(long value, string unit = "B")
        {
            string result = null;
            if (value < MaxB)
            {
                result = string.Format("{0}{1}", value, unit);
            }
            else if (value < MaxK)
            {
                result = string.Format("{0:N2}K{1}", (float)value / MaxB, unit);
            }
            else if (value < MaxM)
            {
                result = string.Format("{0:N2}M{1}", (float)value / MaxK, unit);
            }
            else if (value < MaxG)
            {
                result = string.Format("{0:N2}G{1}", (float)value / MaxM, unit);
            }
            return result;
        }
    }

    #region bind
    [UnityEngine.Scripting.Preserve]
    public class Lua_MikuLuaProfiler_LuaProfiler : LuaObject
    {
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int constructor(IntPtr l)
        {
            try
            {
                MikuLuaProfiler.LuaProfiler o;
                o = new MikuLuaProfiler.LuaProfiler();
                pushValue(l, true);
                pushValue(l, o);
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int GetLuaMemory_s(IntPtr l)
        {
            try
            {
                int argc = LuaDLL.lua_gettop(l);
                if (argc == 0)
                {
                    var ret = MikuLuaProfiler.LuaProfiler.GetLuaMemory();
                    pushValue(l, true);
                    pushValue(l, ret);
                    return 2;
                }
                else if (argc == 1)
                {
                    System.IntPtr a1;
                    checkType(l, 1, out a1);
                    var ret = MikuLuaProfiler.LuaProfiler.GetLuaMemory(a1);
                    pushValue(l, true);
                    pushValue(l, ret);
                    return 2;
                }
                pushValue(l, false);
                LuaDLL.lua_pushstring(l, "No matched override function GetLuaMemory to call");
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int SetSampleEnd_s(IntPtr l)
        {
            try
            {
                System.Action<MikuLuaProfiler.LuaProfiler.Sample> a1;
                checkDelegate(l, 1, out a1);
                MikuLuaProfiler.LuaProfiler.SetSampleEnd(a1);
                pushValue(l, true);
                return 1;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int BeginSample_s(IntPtr l)
        {
            try
            {
                int argc = LuaDLL.lua_gettop(l);
                if (matchType(l, argc, 1, typeof(System.IntPtr)))
                {
                    System.IntPtr a1;
                    checkType(l, 1, out a1);
                    MikuLuaProfiler.LuaProfiler.BeginSample(a1);
                    pushValue(l, true);
                    return 1;
                }
                else if (matchType(l, argc, 1, typeof(string)))
                {
                    System.String a1;
                    checkType(l, 1, out a1);
                    MikuLuaProfiler.LuaProfiler.BeginSample(a1);
                    pushValue(l, true);
                    return 1;
                }
                else if (argc == 2)
                {
                    System.IntPtr a1;
                    checkType(l, 1, out a1);
                    System.String a2;
                    checkType(l, 2, out a2);
                    MikuLuaProfiler.LuaProfiler.BeginSample(a1, a2);
                    pushValue(l, true);
                    return 1;
                }
                pushValue(l, false);
                LuaDLL.lua_pushstring(l, "No matched override function BeginSample to call");
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int PopAllSampleWhenLateUpdate_s(IntPtr l)
        {
            try
            {
                MikuLuaProfiler.LuaProfiler.PopAllSampleWhenLateUpdate();
                pushValue(l, true);
                return 1;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int EndSample_s(IntPtr l)
        {
            try
            {
                int argc = LuaDLL.lua_gettop(l);
                if (argc == 0)
                {
                    MikuLuaProfiler.LuaProfiler.EndSample();
                    pushValue(l, true);
                    return 1;
                }
                else if (argc == 1)
                {
                    System.IntPtr a1;
                    checkType(l, 1, out a1);
                    MikuLuaProfiler.LuaProfiler.EndSample(a1);
                    pushValue(l, true);
                    return 1;
                }
                pushValue(l, false);
                LuaDLL.lua_pushstring(l, "No matched override function EndSample to call");
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int GetMemoryString_s(IntPtr l)
        {
            try
            {
                System.Int64 a1;
                checkType(l, 1, out a1);
                System.String a2;
                checkType(l, 2, out a2);
                var ret = MikuLuaProfiler.LuaProfiler.GetMemoryString(a1, a2);
                pushValue(l, true);
                pushValue(l, ret);
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int get_beginSampleMemoryStack(IntPtr l)
        {
            try
            {
                pushValue(l, true);
                pushValue(l, MikuLuaProfiler.LuaProfiler.beginSampleMemoryStack);
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        [UnityEngine.Scripting.Preserve]
        static public int get_mainEnv(IntPtr l)
        {
            try
            {
                pushValue(l, true);
                pushValue(l, MikuLuaProfiler.LuaProfiler.mainEnv);
                return 2;
            }
            catch (Exception e)
            {
                return error(l, e);
            }
        }
        [UnityEngine.Scripting.Preserve]
        static public void reg(IntPtr l)
        {
            getTypeTable(l, "MikuLuaProfiler.LuaProfiler");
            addMember(l, GetLuaMemory_s);
            addMember(l, SetSampleEnd_s);
            addMember(l, BeginSample_s);
            addMember(l, PopAllSampleWhenLateUpdate_s);
            addMember(l, EndSample_s);
            addMember(l, GetMemoryString_s);
            addMember(l, "beginSampleMemoryStack", get_beginSampleMemoryStack, null, false);
            addMember(l, "mainEnv", get_mainEnv, null, false);
            createTypeMetatable(l, constructor, typeof(MikuLuaProfiler.LuaProfiler));
        }
    }
    #endregion

}

#endif

