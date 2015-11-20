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
            
#if !USE_STATIC_BINDER
			Assembly[] ams = AppDomain.CurrentDomain.GetAssemblies();
			
			bindProgress = 0;

			List<Type> bindlist = new List<Type>();
			for (int n = 0; n < ams.Length;n++ )
			{
				Assembly a = ams[n];
				Type[] ts = null;
				try
				{
					ts = a.GetExportedTypes();
				}
				catch
				{
					continue;
				}
				for (int k = 0; k < ts.Length; k++)
				{
					Type t = ts[k];
					if (t.GetCustomAttributes(typeof(LuaBinderAttribute), false).Length > 0)
					{
						bindlist.Add(t);
					}
				}
			}
			
			bindProgress = 1;
			
			bindlist.Sort(new System.Comparison<Type>((Type a, Type b) => {
				LuaBinderAttribute la = (LuaBinderAttribute)a.GetCustomAttributes(typeof(LuaBinderAttribute), false)[0];
				LuaBinderAttribute lb = (LuaBinderAttribute)b.GetCustomAttributes(typeof(LuaBinderAttribute), false)[0];
				
				return la.order.CompareTo(lb.order);
			}));
			
			for (int n = 0; n < bindlist.Count; n++)
			{
				Type t = bindlist[n];
				var sublist = (Action<IntPtr>[])t.GetMethod("GetBindList").Invoke(null, null);
				list.AddRange(sublist);
			}
#else
            list.AddRange(BindUnity.GetBindList());
            list.AddRange(BindCustom.GetBindList());
#endif
			
			bindProgress = 2;
			
			int count = list.Count;
			for (int n = 0; n < count; n++)
			{
				Action<IntPtr> action = list[n];
				action(L);
				bindProgress = (int)(((float)n / count) * 98.0) + 2;
			}
			
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
