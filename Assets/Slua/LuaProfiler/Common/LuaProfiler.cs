#pragma warning disable CS0219//故意在c#这里产生于lua那边的等量GC
#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_5_5_OR_NEWER
using UnityEngine.Profiling;
#endif
using UnityEditorInternal;

namespace MikuLuaProfiler
{
    public class LuaProfiler
    {
        private static IntPtr _mainL = IntPtr.Zero;
        public static IntPtr mainL
        {
            get
            {
                return _mainL;
            }
            set
            {
                _mainL = value;
            }
        }

        public static string GetLuaMemory()
        {
            long result = 0;
            if (mainL != IntPtr.Zero)
            {
                try
                {
                    result = LuaLib.GetLuaMemory(mainL);
                }
                catch { }
            }

            return GetMemoryString(result);
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
            if (mainL != IntPtr.Zero)
            {
                BeginSample(mainL, name);
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
            long memoryCount = LuaLib.GetLuaMemory(luaState);
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
            if (_mainL != IntPtr.Zero)
            {
                EndSample(_mainL);
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
            long nowMemoryCount = LuaLib.GetLuaMemory(luaState);
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
}
#endif

