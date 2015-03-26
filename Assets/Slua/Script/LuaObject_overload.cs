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

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using LuaInterface;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SLua
{
	public partial class LuaObject {

		//         static public bool checkType(IntPtr l, int p, out Vector4 v)
		//         {
		//             v = Vector4.zero;
		//             if (!luaTypeCheck(l, p, "Vector4"))
		//                 return false;
		// 
		//             LuaDLL.lua_getfield(l, p, "x");
		//             v.x = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "y");
		//             v.y = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "z");
		//             v.z = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "w");
		//             v.w = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_pop(l, 4);
		//             return true;
		//         }
		
		
        static public bool checkType(IntPtr l, int p, out Vector3 v)
        {
            float x, y, z;
            LuaDLL.lua_getref(l, LuaValueType.Vector3Check);
            LuaDLL.lua_pushvalue(l, p);
            LuaDLL.lua_call(l, 1, 3);
            x = (float)LuaDLL.lua_tonumber(l, -3);
            y = (float)LuaDLL.lua_tonumber(l, -2);
            z = (float)LuaDLL.lua_tonumber(l, -1);
            LuaDLL.lua_pop(l, 3);
            v = new Vector3(x, y, z);
            return true;
        }
		
		//         static public bool checkType(IntPtr l, int p, out Vector2 v)
		//         {
		//             v = Vector3.zero;
		//             if (!luaTypeCheck(l, p, "Vector2"))
		//                 return false;
		// 
		//             LuaDLL.lua_getfield(l, p, "x");
		//             v.x = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "y");
		//             v.y = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_pop(l, 2);
		//             return true;
		//         }
		// 
		//         static public bool checkType(IntPtr l, int p, out Quaternion q)
		//         {
		//             q = Quaternion.identity;
		//             if (!luaTypeCheck(l, p, "Quaternion"))
		//                 return false;
		// 
		//             LuaDLL.lua_getfield(l, p, "x");
		//             q.x = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "y");
		//             q.y = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "z");
		//             q.z = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_getfield(l, p, "w");
		//             q.w = (float)LuaDLL.lua_tonumber(l, -1);
		//             LuaDLL.lua_pop(l, 4);
		//             return true;
		//         }

		static public bool checkType(IntPtr l, int p, out LayerMask lm) {
			int v;
			checkType (l,p,out v);
			lm=v;
			return true;
		}

		static internal bool checkParams(IntPtr l, int p, out Vector2[] pars)
		{
			int top = LuaDLL.lua_gettop(l);
			if (top - p >= 0)
			{
				pars = new Vector2[top - p + 1];
				for (int n = p, k = 0; n <= top; n++, k++)
				{
					checkType(l, n, out pars[k]);
				}
				return true;
			}
			pars = new Vector2[0];
			return true;
		}

		//        public static void pushValue(IntPtr l, byte[] o)
		//        {
		//            LuaDLL.lua_pushlstring(l, o, o.Length);
		//        }
		
		// i don't know why c# find a wrong generic function
		// push T will push object not a real push<T>
		
		//         public static void pushValue<T>(IntPtr l, List<T> list)
		//         {
		//             LuaDLL.lua_newtable(l);
		//             for (int n = 0; n < list.Count; n++)
		//             {
		//                 pushValue(l, (T)list[n]);
		//                 LuaDLL.lua_rawseti(l, -2, n + 1);
		//             }
		//         }
		// 
		//         public static void pushValue<K,V>(IntPtr l, Dictionary<K,V> dict)
		//         {
		//             LuaDLL.lua_newtable(l);
		//             foreach (K k in dict.Keys)
		//             {
		//                 pushValue(l, (K)k);
		//                 pushValue(l, (V)dict[k]);
		//                 LuaDLL.lua_rawset(l, -3);
		//             }
		//         }



		public static void pushValue(IntPtr l, UnityEngine.Object o)
		{
			pushObject(l, o);
		}
		
		public static void pushValue(IntPtr l, UnityEngine.Object[] o)
		{
			if( o == null)
			{
				LuaDLL.lua_pushnil(l);
				return;
			}
			LuaDLL.lua_newtable(l);
			for (int n = 0; n < o.Length; n++)
			{
				pushValue(l, o[n]);
				LuaDLL.lua_rawseti(l, -2, n + 1);
			}
		}

		//         public static void pushValue(IntPtr l, Quaternion o)
		//         {
		//             LuaDLL.lua_newtable(l);
		//             LuaDLL.lua_pushnumber(l, o.x);
		//             LuaDLL.lua_setfield(l, -2, "x");
		//             LuaDLL.lua_pushnumber(l, o.y);
		//             LuaDLL.lua_setfield(l, -2, "y");
		//             LuaDLL.lua_pushnumber(l, o.z);
		//             LuaDLL.lua_setfield(l, -2, "z");
		//             LuaDLL.lua_pushnumber(l, o.w);
		//             LuaDLL.lua_setfield(l, -2, "w");
		//             LuaDLL.lua_pushstring(l, "Quaternion");
		//             LuaDLL.lua_setfield(l, -2, "__typename");
		// 
		//             LuaDLL.lua_getglobal(l, "Quaternion_mt");
		//             LuaDLL.lua_setmetatable(l, -2);
		//         }
		// 
		//        public static void pushValue(IntPtr l, Vector2 o)
		//        {
		//            LuaDLL.lua_newtable(l);
		//            LuaDLL.lua_pushnumber(l, o.x);
		//            LuaDLL.lua_setfield(l, -2, "x");
		//            LuaDLL.lua_pushnumber(l, o.y);
		//            LuaDLL.lua_setfield(l, -2, "y");
		//            LuaDLL.lua_pushstring(l, "Vector2");
		//            LuaDLL.lua_setfield(l, -2, "__typename");
		// 
		//            LuaDLL.lua_getglobal(l, "Vector2_mt");
		//            LuaDLL.lua_setmetatable(l, -2);
		//        }



        public static void pushValue(IntPtr l, Vector3 o)
        {
            LuaDLL.lua_getref(l, LuaValueType.Vector3Create);
            LuaDLL.lua_pushnumber(l, o.x);
            LuaDLL.lua_pushnumber(l, o.y);
            LuaDLL.lua_pushnumber(l, o.z);
            LuaDLL.lua_call(l, 3, 1);
        }
		
		
		
		//        public static void pushValue(IntPtr l, Vector4 o)
		//        {
		//            LuaDLL.lua_newtable(l);
		//            LuaDLL.lua_pushnumber(l, o.x);
		//            LuaDLL.lua_setfield(l, -2, "x");
		//            LuaDLL.lua_pushnumber(l, o.y);
		//            LuaDLL.lua_setfield(l, -2, "y");
		//            LuaDLL.lua_pushnumber(l, o.z);
		//            LuaDLL.lua_setfield(l, -2, "z");
		//            LuaDLL.lua_pushnumber(l, o.w);
		//            LuaDLL.lua_setfield(l, -2, "w");
		//            LuaDLL.lua_pushstring(l, "Vector4");
		//            LuaDLL.lua_setfield(l, -2, "__typename");
		// 
		//            LuaDLL.lua_getglobal(l, "Vector4_mt");
		//            LuaDLL.lua_setmetatable(l, -2);
		//        }
	}
}