using UnityEngine;
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

using System.Collections;
using System.Collections.Generic;
using System;
using LuaInterface;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SLua
{
	class Helper : LuaObject
	{

		static string classfunc = @"
local getmetatable=getmetatable
local function Class(base,static,instance)

	local mt = getmetatable(base)

	local class=static or {}
	setmetatable(class, 
		{
			__call=function(...)
				local r = mt.__call(...)
				local ret = instance or {}
				ret.__base=r

				local ret = setmetatable(ret,{
					__index=function(t,k)
						return r[k]
					end,

					__newindex=function(t,k,v)
						r[k]=v
					end,
				})

				return ret
			end,
		}
	)
	return class
end
return Class
";

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int _iter(IntPtr l)
		{
			object obj = checkObj(l, LuaDLL.lua_upvalueindex(1));
			IEnumerator it = (IEnumerator)obj;
			if (it.MoveNext())
			{
				pushVar(l, it.Current);
				return 1;
			}
			else
			{
				if (obj is IDisposable)
					(obj as IDisposable).Dispose();
			}
			return 0;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int iter(IntPtr l)
		{
			object o = checkObj(l, 1);
			if (o is IEnumerable)
			{
				IEnumerable e = o as IEnumerable;
				IEnumerator iter = e.GetEnumerator();

				pushObject(l, iter);
				LuaDLL.lua_pushcclosure(l, _iter, 1);
				return 1;
			}
			LuaDLL.luaL_error(l, "passed in object isn't enumerable");
			return 0;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int CreateClass(IntPtr l)
		{
			try
			{
				string cls;
				checkType(l, 1, out cls);
				Type t = Type.GetType(cls);
				if (t == null)
				{
					LuaDLL.luaL_error(l, "Can't find {0} to create", cls);
					return 0;
				}

				ConstructorInfo[] cis = t.GetConstructors();
				ConstructorInfo target = null;
				for (int n = 0; n < cis.Length; n++)
				{
					ConstructorInfo ci = cis[n];
					if (matchType(l, LuaDLL.lua_gettop(l), 2, ci.GetParameters()))
					{
						target = ci;
						break;
					}
				}

				if (target != null)
				{
					ParameterInfo[] pis = target.GetParameters();
					object[] args = new object[pis.Length];
					for (int n = 0; n < pis.Length; n++)
						args[n] = Convert.ChangeType(checkVar(l, n + 2), pis[n].ParameterType);

					object ret = target.Invoke(args);
					pushVar(l, ret);
					return 1;
				}
				return 0;
			}
			catch (Exception e)
			{
				LuaDLL.luaL_error(l, e.ToString());
				return 0;
			}
		}


		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public new int ToString(IntPtr l)
		{
			object o = checkObj(l, 1);
			if (o == null)
			{
				LuaDLL.lua_pushnil(l);
				return 1;
			}

			if (o is byte[])
			{
				byte[] b = (byte[])o;
				LuaDLL.lua_pushlstring(l, b, b.Length);
			}
			else
			{
				pushValue(l, o.ToString());
			}
			return 1;
		}

		static public void reg(IntPtr l)
		{
			reg(l, CreateClass, "Slua");
			reg(l, iter, "Slua");
			reg(l, ToString, "Slua");


			newTypeTable(l, "Slua");
			if (LuaDLL.luaL_dostring(l, classfunc) != 0)
			{
				throwLuaError(l);
				return;
			}
			LuaDLL.lua_setfield(l, -2, "Class");
			LuaDLL.lua_pop(l, 1);
		}
	}
}
