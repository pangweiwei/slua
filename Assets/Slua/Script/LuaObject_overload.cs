﻿// The MIT License (MIT)

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
	public partial class LuaObject
	{

		static public bool checkType(IntPtr l, int p, out Vector4 v)
		{
			float x, y, z, w;
			LuaDLL.luaS_checkVector4(l, p, out x, out y, out z, out w);
			v = new Vector4(x, y, z, w);
			return true;
		}


		static public bool checkType(IntPtr l, int p, out Vector3 v)
		{
			float x, y, z;
			LuaDLL.luaS_checkVector3(l, p, out x, out y, out z);
			v = new Vector3(x, y, z);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out Vector2 v)
		{
			float x, y;
			LuaDLL.luaS_checkVector2(l, p, out x, out y);
			v = new Vector2(x, y);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out Quaternion q)
		{
			float x, y, z, w;
			LuaDLL.luaS_checkQuaternion(l, p, out x, out y, out z, out w);
			q = new Quaternion(x, y, z, w);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out Color c)
		{
			float x, y, z, w;
			LuaDLL.luaS_checkColor(l, p, out x, out y, out z, out w);
			c = new Color(x, y, z, w);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out LayerMask lm)
		{
			int v;
			checkType(l, p, out v);
			lm = v;
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
			if (o == null)
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

		public static void pushValue(IntPtr l, Quaternion o)
		{
			LuaDLL.luaS_pushQuaternion(l, o.x, o.y, o.z, o.w);
		}

		public static void pushValue(IntPtr l, Vector2 o)
		{
			LuaDLL.luaS_pushVector2(l, o.x, o.y);
		}



		public static void pushValue(IntPtr l, Vector3 o)
		{
			LuaDLL.luaS_pushVector3(l, o.x, o.y, o.z);
		}



		public static void pushValue(IntPtr l, Vector4 o)
		{
			LuaDLL.luaS_pushVector4(l, o.x, o.y, o.z, o.w);
		}

		public static void pushValue(IntPtr l, Color o)
		{
			LuaDLL.luaS_pushColor(l, o.r, o.g, o.b, o.a);
		}
	}
}