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

namespace SLua
{
	using System.Collections;
	using System;
	using LuaInterface;
	using System.Reflection;

    class Helper : LuaObject
	{

		static string classfunc = @"
local getmetatable = getmetatable
local function Class(base,static,instance)

    local mt = getmetatable(base)

    local class = static or {}
    setmetatable(class, 
        {
            __index = base,
            __call = function(...)
                local r = mt.__call(...)
                local ret = instance or {}

                local ins_ret = setmetatable(
                    {
                        __base = r,
                    },

                    {
                        __index = function(t, k)
                            local ret_field
                            ret_field = ret[k]
                            if nil == ret_field then
                                ret_field = r[k]
                            end

                            return ret_field
                        end,

                        __newindex = function(t,k,v)
                            if not pcall(function() r[k]=v end) then
                                rawset(t,k,v)
                            end
                        end,
                    })

                if ret.ctor then
                    ret.ctor(ins_ret, ...)
                end

                return ins_ret
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
				pushValue(l, true);
				pushObject(l, iter);
				LuaDLL.lua_pushcclosure(l, _iter, 1);
				return 2;
			}
			return error(l,"passed in object isn't enumerable");
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int CreateClass(IntPtr l)
		{
			try
			{
				string cls;
				checkType(l, 1, out cls);
				Type t = LuaObject.FindType(cls);
				if (t == null)
				{
					return error(l, string.Format("Can't find {0} to create", cls));
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
					pushValue(l, true);
					pushVar(l, ret);
					return 2;
				}
				pushValue(l, true);
				return 1;
			}
			catch (Exception e)
			{
				return error(l,e);
			}
		}




		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int GetClass(IntPtr l)
		{
			try
			{
				string cls;
				checkType(l, 1, out cls);
				Type t = LuaObject.FindType(cls);
				if (t == null)
				{
					return error(l, "Can't find {0} to create", cls);
				}

				LuaClassObject co = new LuaClassObject(t);
				pushValue(l, true);
				LuaObject.pushObject(l,co);
				return 2;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public new int ToString(IntPtr l)
		{
			try
			{
				object o = checkObj(l, 1);
				if (o == null)
				{
					pushValue(l, true);
					LuaDLL.lua_pushnil(l);
					return 2;
				}

				pushValue(l, true);
				if (o is byte[])
				{
					byte[] b = (byte[])o;
					LuaDLL.lua_pushlstring(l, b, b.Length);
				}
				else
				{
					pushValue(l, o.ToString());
				}
				return 2;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int As(IntPtr l)
		{
			try
			{
				if (!isTypeTable(l, 2))
				{
					return error(l, "No matched type of param 2");
				}
				string meta = LuaDLL.lua_tostring(l, -1);
				LuaDLL.luaL_getmetatable(l, meta);
				LuaDLL.lua_setmetatable(l, 1);
				pushValue(l, true);
				LuaDLL.lua_pushvalue(l, 1);
				return 2;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int IsNull(IntPtr l)
        {
			try
			{
				LuaTypes t = LuaDLL.lua_type(l, 1);
				pushValue(l, true);

				if (t == LuaTypes.LUA_TNIL)
				{
					pushValue(l, true);
				}
				// LUA_TUSERDATA or LUA_TTABLE(Class inherited from Unity Native)
				else if (t == LuaTypes.LUA_TUSERDATA || isLuaClass(l, 1))
				{
					object o = checkObj(l, 1);
					if( o is UnityEngine.Object )
					{
						pushValue(l, (o as UnityEngine.Object) == null);
					}
					else
						pushValue(l, o == null);
				}
				else
					pushValue(l, false);

				return 2;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
        }

        static LuaOut luaOut = new LuaOut();
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int get_out(IntPtr l)
        {
			pushValue(l, true);
            pushObject(l, luaOut);
            return 2;
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int get_version(IntPtr l)
		{
			pushValue(l, true);
			pushValue(l, VersionNumber);
			return 2;
		}

        static public void reg(IntPtr l)
		{
            getTypeTable(l, "Slua");
            addMember(l, CreateClass, false);
            addMember(l, GetClass, false);
            addMember(l, iter, false);
            addMember(l, ToString, false);
            addMember(l, As, false);
            addMember(l, IsNull, false);
			addMember(l, "out", get_out, null, false);
			addMember(l, "version", get_version, null, false);

			LuaFunction func = LuaState.get(l).doString(classfunc) as LuaFunction;
			func.push(l);
			LuaDLL.lua_setfield(l, -3, "Class");


            createTypeMetatable(l, null, typeof(Helper));
        }
	}
}
