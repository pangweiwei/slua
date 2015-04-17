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

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
public class CustomLuaClassAttribute : System.Attribute
{
	public CustomLuaClassAttribute()
	{
		//
	}
}

public class DoNotToLuaAttribute : System.Attribute
{
	public DoNotToLuaAttribute()
	{
		//
	}
}

public class LuaBinderAttribute : System.Attribute
{
	public int order;
	public LuaBinderAttribute(int order)
	{
		this.order = order;
	}
}

[AttributeUsage(AttributeTargets.Method)]
public class StaticExportAttribute : System.Attribute
{
	public StaticExportAttribute()
	{
		//
	}
}

namespace SLua
{

	public partial class LuaObject
	{

		static protected LuaCSFunction lua_gc = new LuaCSFunction(luaGC);
		static protected LuaCSFunction lua_add = new LuaCSFunction(luaAdd);
		static protected LuaCSFunction lua_sub = new LuaCSFunction(luaSub);
		static protected LuaCSFunction lua_mul = new LuaCSFunction(luaMul);
		static protected LuaCSFunction lua_div = new LuaCSFunction(luaDiv);
		static protected LuaCSFunction lua_unm = new LuaCSFunction(luaUnm);
		static protected LuaCSFunction lua_eq = new LuaCSFunction(luaEq);
        static protected LuaCSFunction lua_lt = new LuaCSFunction(luaLt);
        static protected LuaCSFunction lua_le = new LuaCSFunction(luaLe);
		const string DelgateTable = "__LuaDelegate";

		static protected int newindex_ref = 0;
		static protected int index_ref = 0;

		delegate void PushVarDelegate(IntPtr l, object o);
		static Dictionary<Type, PushVarDelegate> typePushMap = new Dictionary<Type, PushVarDelegate>();

		public static void init(IntPtr l)
		{
			string newindexfun = @"

local getmetatable=getmetatable
local rawget=rawget
local error=error
local type=type
local function newindex(ud,k,v)
    local t=getmetatable(ud)
    repeat
        local h=rawget(t,k)
        if h then
            h[2](ud,v)
            return
        end
        t=rawget(t,'__parent')
    until t==nil
    error('can not find '..k)
end

return newindex
";

			string indexfun = @"
local type=type
local error=error
local rawget=rawget
local sub=string.sub
local function index(ud,k)
    local t=getmetatable(ud)
    repeat
        local fun=rawget(t,k)
        local tp=type(fun)	
        if tp=='function' then 
            return fun 
        elseif tp=='table' then
            return fun[1](ud)
        end
        t = rawget(t,'__parent')
    until t==nil
    error('Can not find '..k)
end

return index
";

			if (LuaDLL.luaL_dostring(l, newindexfun) != 0)
			{
				throwLuaError(l);
				return;
			}
			newindex_ref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);

			if (LuaDLL.luaL_dostring(l, indexfun) != 0)
			{
				throwLuaError(l);
				return;
			}
			index_ref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);

			// object method

			LuaDLL.lua_newtable(l);
			addMember(l, ToString);
			addMember(l, GetHashCode);
			addMember(l, Equals);
			LuaDLL.lua_setfield(l, LuaIndexes.LUA_REGISTRYINDEX, "__luabaseobject");

			LuaVarObject.init(l);

			LuaDLL.lua_newtable(l);
			LuaDLL.lua_setglobal(l, DelgateTable);


			setupPushVar();
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int ToString(IntPtr l)
		{
			object obj = checkObj(l, 1);
			pushValue(l,obj.ToString());
			return 1;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int GetHashCode(IntPtr l)
		{
			object obj = checkObj(l, 1);
			pushValue(l, obj.GetHashCode());
			return 1;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int Equals(IntPtr l)
		{
			object obj = checkObj(l, 1);
			object other = checkObj(l, 2);
			pushValue(l, obj.Equals(other));
			return 1;
		}

		static void setupPushVar()
		{
			typePushMap[typeof(float)] = (IntPtr L, object o) =>
			{
				LuaDLL.lua_pushnumber(L, (float)o);
			};
			typePushMap[typeof(double)] = (IntPtr L, object o) =>
			{
				LuaDLL.lua_pushnumber(L, (double)o);
			};

			typePushMap[typeof(int)] =
				(IntPtr L, object o) =>
				{
					LuaDLL.lua_pushinteger(L, (int)o);
				};

			typePushMap[typeof(uint)] =
				(IntPtr L, object o) =>
				{
					LuaDLL.lua_pushinteger(L, Convert.ToInt32(o));
				};

			typePushMap[typeof(short)] =
				(IntPtr L, object o) =>
				{
					LuaDLL.lua_pushinteger(L, (short)o);
				};

			typePushMap[typeof(ushort)] =
			   (IntPtr L, object o) =>
			   {
				   LuaDLL.lua_pushinteger(L, (ushort)o);
			   };

			typePushMap[typeof(sbyte)] =
			   (IntPtr L, object o) =>
			   {
				   LuaDLL.lua_pushinteger(L, (sbyte)o);
			   };

			typePushMap[typeof(byte)] =
			   (IntPtr L, object o) =>
			   {
				   LuaDLL.lua_pushinteger(L, (byte)o);
			   };


			typePushMap[typeof(Int64)] =
				typePushMap[typeof(UInt64)] =
				(IntPtr L, object o) =>
				{
#if LUA_5_3
					LuaDLL.lua_pushinteger(L, (long)o);
#else
					LuaDLL.lua_pushnumber(L, System.Convert.ToDouble(o));
#endif
				};

			typePushMap[typeof(string)] = (IntPtr L, object o) =>
			{
				LuaDLL.lua_pushstring(L, (string)o);
			};

			typePushMap[typeof(bool)] = (IntPtr L, object o) =>
			{
				LuaDLL.lua_pushboolean(L, (bool)o);
			};

			typePushMap[typeof(LuaTable)] =
				typePushMap[typeof(LuaFunction)] =
				(IntPtr L, object o) =>
				{
					((LuaVar)o).push(L);
				};

			typePushMap[typeof(Vector3)] = (IntPtr L, object o) =>
			{
				pushValue(L, (Vector3)o);
			};

			typePushMap[typeof(Vector2)] = (IntPtr L, object o) =>
			{
				pushValue(L, (Vector2)o);
			};

			typePushMap[typeof(Vector4)] = (IntPtr L, object o) =>
			{
				pushValue(L, (Vector4)o);
			};

			typePushMap[typeof(Quaternion)] = (IntPtr L, object o) =>
			{
				pushValue(L, (Quaternion)o);
			};

			typePushMap[typeof(Color)] = (IntPtr L, object o) =>
			{
				pushValue(L, (Color)o);
			};
		}

		static int getOpFunction(IntPtr l, string f, string tip)
		{
			int err = pushTry(l);
			checkLuaObject(l, 1);

			while (!LuaDLL.lua_isnil(l, -1))
			{
				LuaDLL.lua_getfield(l, -1, f);
				if (!LuaDLL.lua_isnil(l, -1))
				{
					LuaDLL.lua_remove(l, -2);
					break;
				}
				LuaDLL.lua_pop(l, 1); //pop nil
				LuaDLL.lua_getfield(l, -1, "__parent");
				LuaDLL.lua_remove(l, -2); //pop base
			}

			if (LuaDLL.lua_isnil(l, -1))
			{
				LuaDLL.lua_pop(l, 1);
				LuaDLL.luaL_error(l, "No {0} operator", tip);
				return 0;
			}
			return err;
		}

		static int luaOp(IntPtr l, string f, string tip)
		{
			int err = getOpFunction(l, f, tip);
			if (err == 0)
				return 0;

			LuaDLL.lua_pushvalue(l, 1);
			LuaDLL.lua_pushvalue(l, 2);
			if (LuaDLL.lua_pcall(l, 2, 1, err) != 0)
				LuaDLL.lua_pop(l, 1);
			LuaDLL.lua_remove(l, err);
			return 1;
		}


		static int luaUnaryOp(IntPtr l, string f, string tip)
		{
			int err = getOpFunction(l, f, tip);
			if ( err == 0)
				return 0;

			LuaDLL.lua_pushvalue(l, 1);
			if (LuaDLL.lua_pcall(l, 1, 1, err) != 0)
				LuaDLL.lua_pop(l, 1);
			LuaDLL.lua_remove(l, err);
			return 1;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaAdd(IntPtr l)
		{
			return luaOp(l, "op_Addition", "add");
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaSub(IntPtr l)
		{
			return luaOp(l, "op_Subtraction", "sub");
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaMul(IntPtr l)
		{
			return luaOp(l, "op_Multiply", "mul");
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaDiv(IntPtr l)
		{
			return luaOp(l, "op_Division", "div");
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaUnm(IntPtr l)
		{
			return luaUnaryOp(l, "op_UnaryNegation", "unm");
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaEq(IntPtr l)
		{
			return luaOp(l, "op_Equality", "eq");
		}

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int luaLt(IntPtr l)
        {
            return luaOp(l, "op_LessThan", "lt");
        }

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int luaLe(IntPtr l)
        {
            return luaOp(l, "op_LessThanOrEqual", "le");
        }

		public static void getEnumTable(IntPtr l, string t)
		{
			newTypeTable(l, t);
		}

		public static void getTypeTable(IntPtr l, string t)
		{
			newTypeTable(l, t);
			// for static
			LuaDLL.lua_newtable(l);
			// for instance
			LuaDLL.lua_newtable(l);
		}

		public static void newTypeTable(IntPtr l, string t)
		{
			string[] subt = t.Split(new Char[] { '.' });


			LuaDLL.lua_pushglobaltable(l);

			for (int n = 0; n < subt.Length; n++)
			{
				t = subt[n];
				LuaDLL.lua_pushstring(l, t);
				LuaDLL.lua_rawget(l, -2);
				if (LuaDLL.lua_isnil(l, -1))
				{
					LuaDLL.lua_pop(l, 1);
					LuaDLL.lua_createtable(l, 0, 0);
					LuaDLL.lua_pushstring(l, t);
					LuaDLL.lua_pushvalue(l, -2);
					LuaDLL.lua_rawset(l, -4);
				}
				LuaDLL.lua_remove(l, -2);
			}
		}

		public static void createTypeMetatable(IntPtr l, Type self)
		{
			createTypeMetatable(l, null, self, null);
		}

		public static void createTypeMetatable(IntPtr l, LuaCSFunction con, Type self)
		{
			createTypeMetatable(l, con, self, null);
		}

		public static void createTypeMetatable(IntPtr l, LuaCSFunction con, Type self, Type parent)
		{

			// set parent
			if (parent != null && parent != typeof(object))
			{
				LuaDLL.lua_pushstring(l, "__parent");
				LuaDLL.luaL_getmetatable(l, parent.AssemblyQualifiedName);
				LuaDLL.lua_rawset(l, -3);

				LuaDLL.lua_pushstring(l, "__parent");
				LuaDLL.luaL_getmetatable(l, parent.FullName);
				LuaDLL.lua_rawset(l, -4);
			}
			else
			{
				LuaDLL.lua_pushstring(l, "__parent");
				LuaDLL.luaL_getmetatable(l, "__luabaseobject");
				LuaDLL.lua_rawset(l, -3);
			}

			completeInstanceMeta(l, self);
			completeTypeMeta(l, con, self);

			LuaDLL.lua_pop(l, 1); // pop type Table
		}

		static void completeTypeMeta(IntPtr l, LuaCSFunction con, Type self)
		{

			LuaDLL.lua_pushstring(l, ObjectCache.getAQName(self));
			LuaDLL.lua_setfield(l, -3, "__fullname");

			LuaDLL.lua_getref(l, index_ref);
			LuaDLL.lua_setfield(l, -2, "__index");

			LuaDLL.lua_getref(l, newindex_ref);
			LuaDLL.lua_setfield(l, -2, "__newindex");

			if (con == null) con = noConstructor;

			LuaDLL.lua_pushcfunction(l, con);
			LuaDLL.lua_setfield(l, -2, "__call");

			LuaDLL.lua_pushvalue(l, -1);
			LuaDLL.lua_setmetatable(l, -3);

			LuaDLL.lua_setfield(l, LuaIndexes.LUA_REGISTRYINDEX, self.FullName);
		}

		private static void completeInstanceMeta(IntPtr l, Type self)
		{
			LuaDLL.lua_pushstring(l, "__typename");
			LuaDLL.lua_pushstring(l, self.Name);
			LuaDLL.lua_rawset(l, -3);

			// for instance 
			LuaDLL.lua_getref(l, index_ref);
			LuaDLL.lua_setfield(l, -2, "__index");

			LuaDLL.lua_getref(l, newindex_ref);
			LuaDLL.lua_setfield(l, -2, "__newindex");

			LuaDLL.lua_pushcfunction(l, lua_add);
			LuaDLL.lua_setfield(l, -2, "__add");
			LuaDLL.lua_pushcfunction(l, lua_sub);
			LuaDLL.lua_setfield(l, -2, "__sub");
			LuaDLL.lua_pushcfunction(l, lua_mul);
			LuaDLL.lua_setfield(l, -2, "__mul");
			LuaDLL.lua_pushcfunction(l, lua_div);
			LuaDLL.lua_setfield(l, -2, "__div");
			LuaDLL.lua_pushcfunction(l, lua_unm);
			LuaDLL.lua_setfield(l, -2, "__unm");
			LuaDLL.lua_pushcfunction(l, lua_eq);
			LuaDLL.lua_setfield(l, -2, "__eq");
			LuaDLL.lua_pushcfunction(l, lua_gc);
			LuaDLL.lua_setfield(l, -2, "__gc");
            LuaDLL.lua_pushcfunction(l, lua_le);
            LuaDLL.lua_setfield(l, -2, "__le");
            LuaDLL.lua_pushcfunction(l, lua_lt);
            LuaDLL.lua_setfield(l, -2, "__lt");

			if (self.IsValueType)
			{
				LuaDLL.lua_pushvalue(l, -1);
				LuaDLL.lua_setfield(l, LuaIndexes.LUA_REGISTRYINDEX, self.FullName + ".Instance");
			}
			LuaDLL.lua_setfield(l, LuaIndexes.LUA_REGISTRYINDEX, self.AssemblyQualifiedName);
		}

		public static void reg(IntPtr l, LuaCSFunction func, string ns)
		{
			newTypeTable(l, ns);
			LuaDLL.lua_pushcfunction(l, func);
			LuaDLL.lua_setfield(l, -2, func.Method.Name);
			LuaDLL.lua_pop(l, 1);
		}

		protected static void addMember(IntPtr l, LuaCSFunction func)
		{
			LuaDLL.lua_pushcfunction(l, func);
			string name = func.Method.Name;
			if (name.EndsWith("_s"))
			{
				name = name.Substring(0, name.Length - 2);
				LuaDLL.lua_setfield(l, -3, name);
			}
			else
				LuaDLL.lua_setfield(l, -2, func.Method.Name);
		}

		protected static void addMember(IntPtr l, LuaCSFunction func, bool instance)
		{
			LuaDLL.lua_pushcfunction(l, func);
			string name = func.Method.Name;
			LuaDLL.lua_setfield(l, instance ? -2 : -3, name);
		}

		protected static void addMember(IntPtr l, string name, LuaCSFunction get, LuaCSFunction set, bool instance)
		{
			int t = instance ? -2 : -3;

			LuaDLL.lua_newtable(l);
			if (get == null)
				LuaDLL.lua_pushnil(l);
			else
				LuaDLL.lua_pushcfunction(l, get);
			LuaDLL.lua_rawseti(l, -2, 1);

			if (set == null)
				LuaDLL.lua_pushnil(l);
			else
				LuaDLL.lua_pushcfunction(l, set);
			LuaDLL.lua_rawseti(l, -2, 2);

			LuaDLL.lua_setfield(l, t, name);
		}

		protected static void addMember(IntPtr l, int v, string name)
		{
			LuaDLL.lua_pushinteger(l, v);
			LuaDLL.lua_setfield(l, -2, name);
		}

		public static void throwLuaError(IntPtr l)
		{
			string err = LuaDLL.lua_tostring(l, -1);
			LuaDLL.lua_pop(l, 1);

			throw new InvalidProgramException(err);
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int luaGC(IntPtr l)
		{
			int index = LuaDLL.luaS_rawnetobj(l, 1);
			if (index > 0)
			{
				ObjectCache t = ObjectCache.get(l);
				t.gc(index);
			}
			return 0;
		}

		static public void checkLuaObject(IntPtr l, int p)
		{
			LuaDLL.lua_getmetatable(l, p);
			if (LuaDLL.lua_isnil(l, -1))
			{
				LuaDLL.lua_pop(l, 1);
				LuaDLL.luaL_error(l, "expect luaobject as first argument");
			}
		}

		public static void pushObject(IntPtr l, object o)
		{
			ObjectCache oc = ObjectCache.get(l);
			oc.push(l, o);
		}

		public static int pushTry(IntPtr l)
		{
			if (!LuaState.get(l).isMainThread())
			{
				Debug.LogError("Can't call lua function in bg thread");
				return 0;
			}

			LuaDLL.lua_pushcfunction(l, LuaState.errorFunc);
			return LuaDLL.lua_gettop(l);
		}



		public static bool matchType(IntPtr l, int p, LuaTypes lt, Type t)
		{
			if (t == typeof(object))
			{
				return true;
			}
			else if (t == typeof(Type))
			{
				return isTypeTable(l, p);
			}

			switch (lt)
			{
				case LuaTypes.LUA_TNUMBER:
					return t == typeof(Single) || t == typeof(double) || t == typeof(int) || t == typeof(Int16)
						|| t == typeof(UInt16) || t == typeof(UInt32) || t == typeof(byte) || t == typeof(Int64) || t.IsEnum;
				case LuaTypes.LUA_TUSERDATA:
					object o = checkObj(l, p);
					Type ot = o.GetType();
					return ot == t || ot.IsSubclassOf(t);
				case LuaTypes.LUA_TSTRING:
					return t.Name == "String";
				case LuaTypes.LUA_TBOOLEAN:
					return t == typeof(bool);
				case LuaTypes.LUA_TTABLE:
					{
						if (t.IsValueType)
							return luaTypeCheck(l, p, t.Name);
						else if (LuaDLL.luaS_subclassof(l, p, t.Name) == 1)
							return true;
						else
							return t == typeof(LuaTable);
					}
				case LuaTypes.LUA_TFUNCTION:
					return t == typeof(LuaFunction) || t.BaseType == typeof(MulticastDelegate);
			}
			return false;
		}

		static bool isTypeTable(IntPtr l, int p)
		{
			if (LuaDLL.lua_type(l, p) != LuaTypes.LUA_TTABLE)
				return false;
			LuaDLL.lua_pushstring(l, "__fullname");
			LuaDLL.lua_rawget(l, p);
			if (LuaDLL.lua_isnil(l, -1))
			{
				LuaDLL.lua_pop(l, 1);
				return false;
			}
			return true;
		}

		static bool isLuaClass(IntPtr l, int p)
		{
			return LuaDLL.luaS_subclassof(l, p, null) == 1;
		}

		static bool isLuaValueType(IntPtr l, int p)
		{
			return LuaDLL.luaS_checkluatype(l, p, null) == 1;
		}

		public static bool matchType(IntPtr l, int total, int from, params Type[] types)
		{
			if (total - from + 1 != types.Length)
				return false;

			for (int n = 0; n < types.Length; n++)
			{
				int p = n + from;
				LuaTypes t = LuaDLL.lua_type(l, p);
				if (!matchType(l, p, t, types[n]))
					return false;
			}
			return true;
		}

		public static bool matchType(IntPtr l, int total, int from, ParameterInfo[] pars)
		{
			if (total - from + 1 != pars.Length)
				return false;

			for (int n = 0; n < pars.Length; n++)
			{
				int p = n + from;
				LuaTypes t = LuaDLL.lua_type(l, p);
				if (!matchType(l, p, t, pars[n].ParameterType))
					return false;
			}
			return true;
		}



		static public bool checkType(IntPtr l, int p, out float v)
		{
			v = (float)LuaDLL.luaL_checknumber(l, p);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out float[] v)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TTABLE);
			int n = LuaDLL.lua_rawlen(l, p);
			v = new float[n];
			for (int k = 0; k < n; k++)
			{
				LuaDLL.lua_rawgeti(l, p, k + 1);
				float f;
				checkType(l, -1, out f);
				v[k] = f;
				LuaDLL.lua_pop(l, 1);
			}
			return true;
		}

		static public bool checkType(IntPtr l, int p, out string v)
		{
			//LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TSTRING);
			v = LuaDLL.lua_tostring(l, p);
			return true;
		}

		static public bool luaTypeCheck(IntPtr l, int p, string t)
		{
			return LuaDLL.luaS_checkluatype(l, p, t) != 0;
		}

		static public bool checkType(IntPtr l, int p, out int v)
		{
			v = (int)LuaDLL.luaL_checkinteger(l, p);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out short v)
		{
			v = (short)LuaDLL.luaL_checkinteger(l, p);
			return true;
		}
		
		static public bool checkType(IntPtr l, int p, out UInt16 v)
		{
			v = (UInt16)LuaDLL.luaL_checkinteger(l, p);
			return true;
		}
		
		static public bool checkType(IntPtr l, int p, out byte v)
		{
			v = (byte)LuaDLL.luaL_checkinteger(l, p);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out uint v)
		{
			v = (uint)LuaDLL.luaL_checkinteger(l, p);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out Int64 v)
		{
#if LUA_5_3
            v = LuaDLL.luaL_checkinteger(l, p);
#else
			v = (Int64)LuaDLL.luaL_checknumber(l, p);
#endif
			return true;
		}

		static public bool checkType(IntPtr l, int p, out UInt64 v)
		{
#if LUA_5_3
            v = (UInt64)LuaDLL.luaL_checkinteger(l, p);
#else
			v = (UInt64)LuaDLL.luaL_checknumber(l, p);
#endif
			return true;
		}

		static public bool checkType(IntPtr l, int p, out bool v)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TBOOLEAN);
			v = LuaDLL.lua_toboolean(l, p);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out LuaDelegate f)
		{
			LuaState state = LuaState.get(l);

			p = LuaDLL.lua_absindex(l, p);
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);

			LuaDLL.lua_getglobal(l, DelgateTable);
			LuaDLL.lua_pushvalue(l, p);
			LuaDLL.lua_gettable(l, -2); // find function in __LuaDelegate table
			if (LuaDLL.lua_isnil(l, -1))
			{ // not found
				LuaDLL.lua_pop(l, 1); // pop nil
				f = newDelegate(l, p);
			}
			else
			{
				int fref = LuaDLL.lua_tointeger(l, -1);
				LuaDLL.lua_pop(l, 1); // pop ref value;
				f = state.delgateMap[fref];
				if (f == null)
				{
					f = newDelegate(l, p);
				}
			}
			LuaDLL.lua_pop(l, 1); // pop DelgateTable
			return true;
		}

		static LuaDelegate newDelegate(IntPtr l, int p)
		{
			LuaState state = LuaState.get(l);

			LuaDLL.lua_pushvalue(l, p); // push function

			int fref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX); // new ref function
			LuaDelegate f = new LuaDelegate(l, fref);
			LuaDLL.lua_pushvalue(l, p);
			LuaDLL.lua_pushinteger(l, fref);
			LuaDLL.lua_settable(l, -3); // __LuaDelegate[func]= fref
			state.delgateMap[fref] = f;
			return f;
		}

		static public void removeDelgate(IntPtr l, int r)
		{
			LuaDLL.lua_getglobal(l, DelgateTable);
			LuaDLL.lua_getref(l, r); // push key
			LuaDLL.lua_pushnil(l); // push nil value
			LuaDLL.lua_settable(l, -3); // remove function from __LuaDelegate table
			LuaDLL.lua_pop(l, 1); // pop __LuaDelegate
		}

		static public bool checkType(IntPtr l, int p, out LuaFunction f)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDLL.lua_pushvalue(l, p);
			int fref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
			f = new LuaFunction(l, fref);
			return true;
		}

		static public bool checkType(IntPtr l, int p, out LuaTable t)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TTABLE);
			LuaDLL.lua_pushvalue(l, p);
			int fref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
			t = new LuaTable(l, fref);
			return true;
		}

		static Dictionary<string, Type> typeCache = new Dictionary<string, Type>();
		static public bool checkType(IntPtr l, int p, out Type t)
		{
			string tname = null;
			LuaTypes lt = LuaDLL.lua_type(l, p);
			if (lt == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.lua_pushstring(l, "__fullname");
				LuaDLL.lua_rawget(l, p);
				tname = LuaDLL.lua_tostring(l, -1);
				LuaDLL.lua_pop(l, 1);
			}
			else if (lt == LuaTypes.LUA_TSTRING)
				tname = LuaDLL.lua_tostring(l, p);

			if (tname == null)
				LuaDLL.luaL_error(l, "expect string or type table");

			if (typeCache.TryGetValue(tname, out t))
			{
				return true;
			}


			t = Type.GetType(tname);
			if (t != null)
			{
				typeCache[tname] = t;
			}
			return t != null;
		}


		static public bool checkType<T>(IntPtr l, int p, out T o)
		{
			o = (T)checkVar(l, p);
			return true;
		}

		static public object checkObj(IntPtr l, int p)
		{
			if (LuaDLL.lua_istable(l, p))
			{
				LuaDLL.lua_pushvalue(l, p);
				while (LuaDLL.lua_istable(l, -1))
				{
					LuaDLL.lua_pushstring(l, "__base");
					LuaDLL.lua_rawget(l, -2);
					LuaDLL.lua_remove(l, -2);
				}
				if (LuaDLL.lua_isuserdata(l, -1) > 0)
					LuaDLL.lua_replace(l, p);
				else
					LuaDLL.luaL_error(l, "arg {0} expect object, but get a table",p);
			}

			ObjectCache oc = ObjectCache.get(l);
			return oc.get(l, p);
		}

		static public bool checkType(IntPtr l, int p, out object[] t)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TTABLE);
			int n = LuaDLL.lua_rawlen(l, p);
			t = new object[n];
			for (int k = 0; k < n; k++)
			{
				LuaDLL.lua_rawgeti(l, p, k + 1);
				t[k] = checkVar(l, -1);
				LuaDLL.lua_pop(l, 1);
			}
			return true;
		}

		static public bool checkType(IntPtr l, int p, out Type[] t)
		{
			throw new NotSupportedException();
		}

		static public bool checkType(IntPtr l, int p, out Array t)
		{
			throw new NotSupportedException();
		}

		static public bool checkType(IntPtr l, int p, out string[] t)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TTABLE);
			int n = LuaDLL.lua_rawlen(l, p);
			t = new string[n];
			for (int k = 0; k < n; k++)
			{
				LuaDLL.lua_rawgeti(l, p, k + 1);
				string f;
				checkType(l, -1, out f);
				t[k] = f;
				LuaDLL.lua_pop(l, 1);
			}
			return true;
		}

		static public bool checkEnum<T>(IntPtr l, int p, out T o) where T : struct
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TNUMBER);
			int i = LuaDLL.lua_tointeger(l, p);
			o = (T)Enum.ToObject(typeof(T), i);

			return true;
		}

		static public bool checkParams(IntPtr l, int p, out object[] pars)
		{
			int top = LuaDLL.lua_gettop(l);
			if (top - p >= 0)
			{
				pars = new object[top - p + 1];
				for (int n = p, k = 0; n <= top; n++, k++)
				{
					pars[k] = checkVar(l, n);
				}
				return true;
			}
			pars = new object[0];
			return true;
		}

		static public bool checkParams(IntPtr l, int p, out float[] pars)
		{
			int top = LuaDLL.lua_gettop(l);
			if (top - p >= 0)
			{
				pars = new float[top - p + 1];
				for (int n = p, k = 0; n <= top; n++, k++)
				{
					checkType(l, n, out pars[k]);
				}
				return true;
			}
			pars = new float[0];
			return true;
		}

		static public bool checkParams(IntPtr l, int p, out int[] pars)
		{
			int top = LuaDLL.lua_gettop(l);
			if (top - p >= 0)
			{
				pars = new int[top - p + 1];
				for (int n = p, k = 0; n <= top; n++, k++)
				{
					checkType(l, n, out pars[k]);
				}
				return true;
			}
			pars = new int[0];
			return true;
		}



		static public bool checkParams(IntPtr l, int p, out string[] pars)
		{
			int top = LuaDLL.lua_gettop(l);
			if (top - p >= 0)
			{
				pars = new string[top - p + 1];
				for (int n = p, k = 0; n <= top; n++, k++)
				{
					checkType(l, n, out pars[k]);
				}
				return true;
			}
			pars = new string[0];
			return true;
		}

		static public object checkVar(IntPtr l, int p)
		{
			LuaTypes type = LuaDLL.lua_type(l, p);
			switch (type)
			{
				case LuaTypes.LUA_TNUMBER:
					{
						return LuaDLL.lua_tonumber(l, p);
					}
				case LuaTypes.LUA_TSTRING:
					{
						return LuaDLL.lua_tostring(l, p);
					}
				case LuaTypes.LUA_TBOOLEAN:
					{
						return LuaDLL.lua_toboolean(l, p);
					}
				case LuaTypes.LUA_TFUNCTION:
					{
						LuaDLL.lua_pushvalue(l, p);
						int r = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
						LuaFunction v = new LuaFunction(l, r);
						return v;
					}
				case LuaTypes.LUA_TTABLE:
					{
						if (isLuaValueType(l, p))
						{
							if (luaTypeCheck(l, p, "Vector2"))
							{
								Vector2 v;
								checkType(l, p, out v);
								return v;
							}
							else if (luaTypeCheck(l, p, "Vector3"))
							{
								Vector3 v;
								checkType(l, p, out v);
								return v;
							}
							else if (luaTypeCheck(l, p, "Vector4"))
							{
								Vector4 v;
								checkType(l, p, out v);
								return v;
							}
							else if (luaTypeCheck(l, p, "Quaternion"))
							{
								Quaternion v;
								checkType(l, p, out v);
								return v;
							}
							else if (luaTypeCheck(l, p, "Color"))
							{
								Color c;
								checkType(l, p, out c);
								return c;
							}
							LuaDLL.luaL_error(l, "unknown lua value type");
							return null;
						}
						else if (isLuaClass(l, p))
						{
							return checkObj(l, p);
						}
						else
						{
							LuaDLL.lua_pushvalue(l, p);
							int r = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
							LuaTable v = new LuaTable(l, r);
							return v;
						}
					}
				case LuaTypes.LUA_TUSERDATA:
					return LuaObject.checkObj(l, p);
				default:
					return null;
			}
		}


		public static void pushValue(IntPtr l, float o)
		{
			LuaDLL.lua_pushnumber(l, o);
		}

		public static void pushValue(IntPtr l, float[] o)
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

		public static void pushValue(IntPtr l, bool b)
		{
			LuaDLL.lua_pushboolean(l, b);
		}

		public static void pushValue(IntPtr l, bool[] o)
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

		public static void pushValue(IntPtr l, string s)
		{
			LuaDLL.lua_pushstring(l, s);
		}

		public static void pushValue(IntPtr l, string[] o)
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

		public static void pushValue(IntPtr l, int i)
		{
			LuaDLL.lua_pushinteger(l, i);
		}

		public static void pushValue(IntPtr l, short i)
		{
			LuaDLL.lua_pushinteger(l, i);
		}

		public static void pushValue(IntPtr l, byte i)
		{
			LuaDLL.lua_pushinteger(l, i);
		}

		public static void pushValue(IntPtr l, int[] o)
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

		public static void pushValue(IntPtr l, Int64 i)
		{
#if LUA_5_3
            LuaDLL.lua_pushinteger(l,i);
#else
			LuaDLL.lua_pushnumber(l, (double)i);
#endif
		}

		public static void pushValue(IntPtr l, Int64[] o)
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

		public static void pushValue(IntPtr l, double d)
		{
			LuaDLL.lua_pushnumber(l, d);
		}

		public static void pushValue(IntPtr l, double[] o)
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

		public static void pushValue(IntPtr l, object o)
		{
			pushVar(l, o);
		}


		public static void pushValue(IntPtr l, object[] o)
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

		public static void pushValue(IntPtr l, LuaCSFunction f)
		{
			pushObject(l, f);
		}

		public static void pushValue(IntPtr l, LuaTable t)
		{
			if (t == null)
				LuaDLL.lua_pushnil(l);
			else
				t.push(l);
		}

		public static void pushEnum(IntPtr l, int e)
		{
			pushValue(l, e);
		}


		public static void pushVar(IntPtr l, object o)
		{
			if (o == null)
			{
				LuaDLL.lua_pushnil(l);
				return;
			}

			
			Type t = o.GetType();

			
			PushVarDelegate push;
			if (typePushMap.TryGetValue(t, out push))
				push(l, o);
			else if (t.IsEnum)
			{
				pushEnum(l, Convert.ToInt32(o));
			}
			else
				pushObject(l,o);
         
		}



		public static T checkSelf<T>(IntPtr l)
		{
			object o = checkObj(l, 1);
			if (o != null)
			{
				return (T)o;
			}
			LuaDLL.luaL_error(l, "arg 1 expect self, but get null");
			return default(T);
		}

		public static object checkSelf(IntPtr l)
		{
			object o = checkObj(l, 1);
			if (o != null)
				return o;
			LuaDLL.luaL_error(l, "expect self, but get null");
			return null;
		}

		public static void setBack(IntPtr l, object o)
		{
			ObjectCache t = ObjectCache.get(l);
			t.setBack(l, 1, o);
		}

		public static void setBack(IntPtr l, Vector3 v)
		{
			LuaDLL.luaS_setData(l, 1, v.x, v.y, v.z, float.NaN);
		}

		public static void setBack(IntPtr l, Vector2 v)
		{
			LuaDLL.luaS_setData(l, 1, v.x, v.y, float.NaN, float.NaN);
		}

		public static void setBack(IntPtr l, Vector4 v)
		{
			LuaDLL.luaS_setData(l, 1, v.x, v.y, v.z, v.w);
		}

		public static void setBack(IntPtr l, Quaternion v)
		{
			LuaDLL.luaS_setData(l, 1, v.x, v.y, v.z, v.w);
		}

		public static int extractFunction(IntPtr l, int p)
		{
			int op = 0;
			LuaTypes t = LuaDLL.lua_type(l, p);
			if (t == LuaTypes.LUA_TNIL)
			{
				op = 0;
			}
			else if (t == LuaTypes.LUA_TUSERDATA)
			{
				op = 0;
			}
			else if (t == LuaTypes.LUA_TTABLE)
			{

				LuaDLL.lua_rawgeti(l, p, 1);
				LuaDLL.lua_pushstring(l, "+=");
				if (LuaDLL.lua_rawequal(l, -1, -2) == 1)
					op = 1;
				else
					op = 2;

				LuaDLL.lua_pop(l, 2);
				LuaDLL.lua_rawgeti(l, p, 2);
			}
			else if (t == LuaTypes.LUA_TFUNCTION)
			{
				LuaDLL.lua_pushvalue(l, p);
			}
			else
				LuaDLL.luaL_error(l, "expect valid Delegate ");
			return op;
		}


		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static public int noConstructor(IntPtr l)
		{
			LuaDLL.luaL_error(l, "Can't new this object");
			return 0;
		}

	}

}
