// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

// uncomment this will use static binder(class BindCustom/BindUnity), 
// init will not use reflection to speed up the speed
//#define USE_STATIC_BINDER  

namespace SLua
{
	using System;
	using System.Threading;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using LuaInterface;
	using System.Reflection;
	using Debug = UnityEngine.Debug;

    public partial class Bind
    {
        public void BindAll(ref List<Action<IntPtr>> list)
        {
            Type t = this.GetType();

            ///
            /// FIX:make sure unity should bind first!
            ///

            var mi = t.GetMethod("BindUnity", BindingFlags.Static | BindingFlags.Public);
            if(mi != null)
            {
                var mi2 = t.GetMethod("BindUnityStaticFunctionNameHash", BindingFlags.Public | BindingFlags.Instance);
                int[] nameHashs = (int[])mi2.Invoke(this, null);
                for (int j = 0; j < nameHashs.Length; j++)
                {
                    int v;
                    if (!LuaObject.cachedStaticFunctionNameHashs.TryGetValue(nameHashs[j], out v))
                        LuaObject.cachedStaticFunctionNameHashs.Add(nameHashs[j], 0);
                }
                list.AddRange((Action<IntPtr>[])mi.Invoke(null, null));
            }

            mi = t.GetMethod("BindUnityUI", BindingFlags.Static | BindingFlags.Public);
            if (mi != null)
            {
                var mi2 = t.GetMethod("BindUnityUIStaticFunctionNameHash", BindingFlags.Public | BindingFlags.Instance);
                int[] nameHashs = (int[])mi2.Invoke(this, null);
                for (int j = 0; j < nameHashs.Length; j++)
                {
                    int v;
                    if (!LuaObject.cachedStaticFunctionNameHashs.TryGetValue(nameHashs[j], out v))
                        LuaObject.cachedStaticFunctionNameHashs.Add(nameHashs[j], 0);
                }
                list.AddRange((Action<IntPtr>[])mi.Invoke(null, null));
            }

            mi = t.GetMethod("BindCustom", BindingFlags.Static | BindingFlags.Public);
            if (mi != null)
            {
                var mi2 = t.GetMethod("BindCustomStaticFunctionNameHash", BindingFlags.Public | BindingFlags.Instance);
                int[] nameHashs = (int[])mi2.Invoke(this, null);
                for (int j = 0; j < nameHashs.Length; j++)
                {
                    int v;
                    if (!LuaObject.cachedStaticFunctionNameHashs.TryGetValue(nameHashs[j], out v))
                        LuaObject.cachedStaticFunctionNameHashs.Add(nameHashs[j], 0);
                }
                list.AddRange((Action<IntPtr>[])mi.Invoke(null, null));
            }

            mi = t.GetMethod("BindDll", BindingFlags.Static | BindingFlags.Public);
            if (mi != null)
            {
                var mi2 = t.GetMethod("BindDllStaticFunctionNameHash", BindingFlags.Public | BindingFlags.Instance);
                int[] nameHashs = (int[])mi2.Invoke(this, null);
                for (int j = 0; j < nameHashs.Length; j++)
                {
                    int v;
                    if (!LuaObject.cachedStaticFunctionNameHashs.TryGetValue(nameHashs[j], out v))
                        LuaObject.cachedStaticFunctionNameHashs.Add(nameHashs[j], 0);
                }
                list.AddRange((Action<IntPtr>[])mi.Invoke(null, null));
            }

            //release memory.
            //LuaObject.cachedStaticFunctionNameHashs = null;
        }
    }

	public class LuaSvr 
	{
		public LuaState luaState;
		static LuaSvrGameObject lgo;
		int errorReported = 0;
		public bool inited = false;

		public LuaSvr()
		{
			GameObject go = new GameObject("LuaSvrProxy");
			lgo = go.AddComponent<LuaSvrGameObject>();
			GameObject.DontDestroyOnLoad(go);
		}

		public IEnumerator waitForDebugConnection(Action complete)
		{
			lgo.skipDebugger = false;
			Debug.Log("Waiting for debug connection");
			while (true)
			{
				yield return new WaitForSeconds(0.1f);
				if (lgo.skipDebugger) break;
			}
			complete();
		}

		private volatile int bindProgress = 0;
		private void doBind(object state)
		{
			IntPtr L = (IntPtr)state;

            List<Action<IntPtr>> list = new List<Action<IntPtr>>();
            
            //bind all.
            new Bind().BindAll(ref list);
			
			bindProgress = 2;
			
			int count = list.Count;
			for (int n = 0; n < count; n++)
			{
				Action<IntPtr> action = list[n];
				action(L);
				bindProgress = (int)(((float)n / count) * 98.0) + 2;
			}

			//after optimized used their name hash should clear from memory.
            LuaObject.cachedStaticFunctionNameHashs = null;

			bindProgress = 100;
		}
		
		public IEnumerator waitForBind(Action<int> tick, Action complete)
		{
			int lastProgress = 0;
			do {
				if (tick != null)
					tick (bindProgress);
				// too many yield return will increase binding time
				// so check progress and skip odd progress
				if (lastProgress != bindProgress && bindProgress % 2 == 0)
				{
					lastProgress = bindProgress;
					yield return null;
				}
			} while (bindProgress != 100);
			
			if (tick != null)
				tick (bindProgress);
			
			complete();
		}

		void doinit(IntPtr L)
		{
			LuaTimer.reg(L);
			LuaCoroutine.reg(L, lgo);
			Helper.reg(L);
			LuaValueType.reg(L);
			SLuaDebug.reg(L);
			LuaDLL.luaS_openextlibs(L);
			Lua3rdDLL.open(L);

			lgo.state = luaState;
			lgo.onUpdate = this.tick;
			lgo.init();
			
			inited = true;
		}

		void checkTop(IntPtr L)
		{
			if (LuaDLL.lua_gettop(luaState.L) != errorReported)
			{
				Debug.LogError("Some function not remove temp value from lua stack. You should fix it.");
				errorReported = LuaDLL.lua_gettop(luaState.L);
			}
		}

        public void init(Action<int> tick,Action complete,bool debug=false)
        {
			LuaState luaState = new LuaState();

			IntPtr L = luaState.L;
			LuaObject.init(L);

			ThreadPool.QueueUserWorkItem(doBind, L);

			lgo.StartCoroutine(waitForBind(tick, () =>
			{
				this.luaState = luaState;
				doinit(L);
				if (debug)
				{
					lgo.StartCoroutine(waitForDebugConnection(() =>
					{
						complete();
						checkTop(L);
					}));
				}
				else
				{
					complete();
					checkTop(L);
				}
			}));
        }

		//add sync init
		//immediate create the LuaSvr.
        public void init()
        {
            this.luaState = new LuaState();
            IntPtr L = luaState.L;
            LuaObject.init(L);
            doBind(L);
            doinit(L);
        }


		public object start(string main)
		{
			if (main != null)
			{
				luaState.doFile(main);
				LuaFunction func = (LuaFunction)luaState["main"];
				if(func!=null)
					return func.call();
			}
			return null;
		}

		void tick()
		{
			if (!inited)
				return;

			if (LuaDLL.lua_gettop(luaState.L) != errorReported)
			{
				errorReported = LuaDLL.lua_gettop(luaState.L);
				Debug.LogError(string.Format("Some function not remove temp value({0}) from lua stack. You should fix it.",LuaDLL.luaL_typename(luaState.L,errorReported)));
			}

			luaState.checkRef();
			LuaTimer.tick(Time.deltaTime);
		}
	}
}
