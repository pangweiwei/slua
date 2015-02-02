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

    public partial class LuaObject
    {

        static protected LuaCSFunction lua_gc = new LuaCSFunction(luaGC);
        static protected LuaCSFunction lua_add = new LuaCSFunction(luaAdd);
        static protected LuaCSFunction lua_sub = new LuaCSFunction(luaSub);
        static protected LuaCSFunction lua_mul = new LuaCSFunction(luaMul);
        static protected LuaCSFunction lua_div = new LuaCSFunction(luaDiv);
        static protected LuaCSFunction lua_eq = new LuaCSFunction(luaEq);

        static protected int newindex_ref = 0;
        static protected int index_ref = 0;

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

            LuaVarObject.init(l);
            //LuaValueType.init(l);
        }

        static int luaOp(IntPtr l,string f, string tip)
        {
            int err = pushTry(l);
            checkLuaObject(l, 1);

            while (!LuaDLL.lua_isnil(l, -1))
            {
                LuaDLL.lua_getfield(l, -1, f);
                if(!LuaDLL.lua_isnil(l,-1)) {
                    LuaDLL.lua_remove(l, -2);
                    break;
                }
                LuaDLL.lua_pop(l,1); //pop nil
                LuaDLL.lua_getfield(l, -1, "__parent");
                LuaDLL.lua_remove(l, -2); //pop base
            }

            if (LuaDLL.lua_isnil(l, -1))
            {
                LuaDLL.lua_pop(l, 1);
                LuaDLL.luaL_error(l, "No {0} operator",tip);
                return 0;
            }
            

            LuaDLL.lua_pushvalue(l, 1);
            LuaDLL.lua_pushvalue(l, 2);
            if (LuaDLL.lua_pcall(l, 2, 1, err) != 0)
                LuaDLL.lua_pop(l, 1);
            LuaDLL.lua_remove(l, err);
            return 1;
        }

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int luaAdd(IntPtr l)
        {
            return luaOp(l,"op_Addition","add");
        }

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int luaSub(IntPtr l)
        {
            return luaOp(l,"op_Subtraction","sub");
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
        static public int luaEq(IntPtr l)
        {
            return luaOp(l, "op_Equality", "eq");
        }

        internal static void getEnumTable(IntPtr l, string t)
        {
            newTypeTable(l, t);
        }

        internal static void getTypeTable(IntPtr l, string t)
        {
            newTypeTable(l,t);
            // for static
            LuaDLL.lua_newtable(l);
            // for instance
            LuaDLL.lua_newtable(l);
        }

        static void newTypeTable(IntPtr l, string t) {
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

        internal static void createTypeMetatable(IntPtr l,Type self)
        {
            createTypeMetatable(l, null, self, null);
        }

        internal static void createTypeMetatable(IntPtr l,LuaCSFunction con, Type self)
        {
            createTypeMetatable(l, con, self, null);
        }

        internal static void createTypeMetatable(IntPtr l, LuaCSFunction con, Type self, Type parent)
        {

            // set parent
            if (parent != null && parent != typeof(object))
            {
                LuaDLL.lua_pushstring(l, "__parent");
                LuaDLL.luaL_getmetatable(l, parent.AssemblyQualifiedName);
                LuaDLL.lua_rawset(l, -3);
            }

            if (parent != null && parent != typeof(object))
            {
                LuaDLL.lua_pushstring(l, "__parent");
                LuaDLL.luaL_getmetatable(l, parent.FullName);
                LuaDLL.lua_rawset(l, -4);
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

            if (con != null)
            {
                LuaDLL.lua_pushstdcallcfunction(l, con);
                LuaDLL.lua_setfield(l, -2, "__call");
            }
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

            LuaDLL.lua_pushstdcallcfunction(l, lua_add);
            LuaDLL.lua_setfield(l, -2, "__add");
            LuaDLL.lua_pushstdcallcfunction(l, lua_sub);
            LuaDLL.lua_setfield(l, -2, "__sub");
            LuaDLL.lua_pushstdcallcfunction(l, lua_mul);
            LuaDLL.lua_setfield(l, -2, "__mul");
            LuaDLL.lua_pushstdcallcfunction(l, lua_div);
            LuaDLL.lua_setfield(l, -2, "__div");
            LuaDLL.lua_pushstdcallcfunction(l, lua_eq);
            LuaDLL.lua_setfield(l, -2, "__eq");
            LuaDLL.lua_pushstdcallcfunction(l, lua_gc);
            LuaDLL.lua_setfield(l, -2, "__gc");

            LuaDLL.lua_setfield(l, LuaIndexes.LUA_REGISTRYINDEX, self.AssemblyQualifiedName);
        }

        public static void addMember(IntPtr l, ref List<LuaCSFunction> list, LuaCSFunction func, string name)
        {
            list.Add(func);
            LuaDLL.lua_pushstdcallcfunction(l, func);
            LuaDLL.lua_setfield(l, -2, name);
        }

        public static void addMember(IntPtr l, LuaCSFunction func, string name)
        {
            LuaDLL.lua_pushstdcallcfunction(l, func);
            LuaDLL.lua_setfield(l, -2, name);
        }

        public static void addMember(IntPtr l, LuaCSFunction func)
        {
            LuaDLL.lua_pushstdcallcfunction(l, func);
            string name = func.Method.Name;
            if(name.EndsWith("_s"))
            {
                name = name.Substring(0, name.Length - 2);
                LuaDLL.lua_setfield(l, -3, name);
            }
            else
                LuaDLL.lua_setfield(l, -2,func.Method.Name);
        }

        public static void addMember(IntPtr l, LuaCSFunction func, bool instance)
        {
            LuaDLL.lua_pushstdcallcfunction(l, func);
            string name = func.Method.Name;
            LuaDLL.lua_setfield(l, instance?-2:-3, name);
        }

        public static void addMember(IntPtr l, string name, LuaCSFunction get, LuaCSFunction set, bool instance=true)
        {
            int t = instance ? -2 : -3;

            LuaDLL.lua_newtable(l);
            if (get == null)
                LuaDLL.lua_pushnil(l);
            else
                LuaDLL.lua_pushstdcallcfunction(l, get);
            LuaDLL.lua_rawseti(l, -2, 1);

            if (set == null)
                LuaDLL.lua_pushnil(l);
            else
                LuaDLL.lua_pushstdcallcfunction(l, set);
            LuaDLL.lua_rawseti(l, -2, 2);

            LuaDLL.lua_setfield(l, t, name);
        }

        public static void addMember(IntPtr l, int v, string name)
        {
            LuaDLL.lua_pushinteger(l, v);
            LuaDLL.lua_setfield(l, -2, name);
        }

        static void throwLuaError(IntPtr l)
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
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TUSERDATA);
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
            LuaDLL.lua_pushstdcallcfunction(l, LuaState.errorReport);
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
                return lt == LuaTypes.LUA_TTABLE;
            }

            switch (lt)
            {
                case LuaTypes.LUA_TNUMBER:
                    return t == typeof(Single) || t == typeof(double) || t == typeof(int) || t == typeof(Int16)
                        || t == typeof(UInt16) || t == typeof(UInt32) || t == typeof(byte) || t == typeof(Int64) || t.IsEnum;
                case LuaTypes.LUA_TUSERDATA:
                    return true;
                case LuaTypes.LUA_TSTRING:
                    return t.Name == "String";
                case LuaTypes.LUA_TBOOLEAN:
                    return t == typeof(bool);
                case LuaTypes.LUA_TTABLE:
                    {
                        if (t.IsValueType)
                            return luaTypeCheck(l, p, t.Name);
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

        public static bool matchType(IntPtr l, int from, params Type[] types)
        {
            if (LuaDLL.lua_gettop(l) - from + 1 != types.Length)
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



        static internal bool checkType(IntPtr l, int p, out float v)
        {
            v = (float)LuaDLL.luaL_checknumber(l, p);
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out float[] v)
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

        static internal bool checkType(IntPtr l, int p, out string v)
        {
            //LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TSTRING);
            v = LuaDLL.lua_tostring(l, p);
            return true;
        }

        static internal bool luaTypeCheck(IntPtr l, int p, string t)
        {
            if (LuaDLL.lua_type(l, p) != LuaTypes.LUA_TTABLE)
                return false;

            LuaDLL.lua_pushstring(l, "__typename");
            LuaDLL.lua_rawget(l, p);
            if (LuaDLL.lua_isnil(l, -1))
            {
                LuaDLL.lua_pop(l, 1);
                return false;
            }

            LuaDLL.lua_pushstring(l, t);
            int equal = LuaDLL.lua_rawequal(l, -1, -2);
            LuaDLL.lua_pop(l, 2);

            if (equal == 0)
                return false;

            return true;
        }

//         static internal bool checkType(IntPtr l, int p, out Vector4 v)
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

        
//         static internal bool checkType(IntPtr l, int p, out Vector3 v)
//         {
//             if (LuaDLL.lua_type(l, p) == LuaTypes.LUA_TUSERDATA)
//                 return checkType<Vector3>(l, p, out v);
// 
//             v = Vector3.zero;
//             if (!luaTypeCheck(l, p, "Vector3"))
//                 return false;
// 
//             LuaDLL.lua_getfield(l, p, "x");
//             v.x = (float)LuaDLL.lua_tonumber(l, -1);
//             LuaDLL.lua_getfield(l, p, "y");
//             v.y = (float)LuaDLL.lua_tonumber(l, -1);
//             LuaDLL.lua_getfield(l, p, "z");
//             v.z = (float)LuaDLL.lua_tonumber(l, -1);
//             LuaDLL.lua_pop(l, 3);
//             return true;
//         }

//         static internal bool checkType(IntPtr l, int p, out Vector2 v)
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
//         static internal bool checkType(IntPtr l, int p, out Quaternion q)
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
        

        static internal bool checkType(IntPtr l, int p, out int v)
        {
            v = (int) LuaDLL.luaL_checkinteger(l, p);
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out uint v)
        {
            v = (uint)LuaDLL.luaL_checkinteger(l, p);
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out Int64 v)
        {
#if LUA_5_3
            v = LuaDLL.luaL_checkinteger(l, p);
#else
            v = (Int64)LuaDLL.luaL_checknumber(l,p);
#endif
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out UInt64 v)
        {
#if LUA_5_3
            v = LuaDLL.luaL_checkinteger(l, p);
#else
            v = (UInt64)LuaDLL.luaL_checknumber(l, p);
#endif
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out bool v)
        {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TBOOLEAN);
            v = LuaDLL.lua_toboolean(l, p);
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out LuaFunction f)
        {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            LuaDLL.lua_pushvalue(l, p);
            int fref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
            f = new LuaFunction(l, fref);
            return true;
        }

        static internal bool checkType(IntPtr l, int p, out LuaTable t)
        {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TTABLE);
            LuaDLL.lua_pushvalue(l, p);
            int fref = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
            t = new LuaTable(l, fref);
            return true;
        }

        static Dictionary<string, Type> typeCache = new Dictionary<string, Type>();
        static internal bool checkType(IntPtr l, int p, out Type t)
        {
            string tname=null;
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
            
            if(tname==null)
                LuaDLL.luaL_error(l, "expect string or type table");

            if (typeCache.TryGetValue(tname, out t))
            {
                return true;
            }


            t = Type.GetType(tname);
            if (t!=null)
            {
                typeCache[tname] = t;
            }
            return t != null;
        }

        static internal bool checkType<T>(IntPtr l, int p, out T o) {
            o = (T)checkVar(l, p);
            return true;
        }

        static internal object checkObj(IntPtr l, int p)
        {
            ObjectCache oc = ObjectCache.get(l);
            return oc.get(l, p);
        }

        static internal bool checkType(IntPtr l, int p, out object[] o)
        {
            throw new NotSupportedException();
        }

        static internal bool checkType(IntPtr l, int p, out Type[] t)
        {
            throw new NotSupportedException();
        }

        static internal bool checkType(IntPtr l, int p, out Array t)
        {
            throw new NotSupportedException();
        }

        static internal bool checkType(IntPtr l, int p, out string[] t)
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

        static internal bool checkEnum<T>(IntPtr l, int p, out T o) where T:struct
        {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TNUMBER);
            int i = LuaDLL.lua_tointeger(l, p);
            o = (T)Enum.ToObject(typeof(T), i);
            return true;
        }

        static internal bool checkParams(IntPtr l, int p, out object[] pars)
        {
            int top = LuaDLL.lua_gettop(l);
            if (top - p >= 0)
            {
                pars = new object[top-p+1];
                for (int n = p,k=0; n <= top; n++,k++)
                {
                    pars[k] = checkVar(l, n);
                }
                return true;
            }
            pars = new object[0];
            return true;
        }

        static internal bool checkParams(IntPtr l, int p, out float[] pars)
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

        static internal bool checkParams(IntPtr l, int p, out int[] pars)
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

        static internal bool checkParams(IntPtr l, int p, out string[] pars)
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

		static internal object checkVar(IntPtr l,int p) {
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
				LuaDLL.lua_pushvalue(l, p);
				int r = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
				LuaTable v = new LuaTable(l, r);
				return v;
			}
			case LuaTypes.LUA_TUSERDATA:
				return LuaObject.checkObj(l, p);
			default:
				return null;
			}
		}


        internal static void pushValue(IntPtr l, float o)
        {
            LuaDLL.lua_pushnumber(l, o);
        }

        internal static void pushValue(IntPtr l, float[] o)
        {
            LuaDLL.lua_newtable(l);
            for (int n = 0; n < o.Length; n++)
            {
                pushValue(l, o[n]);
                LuaDLL.lua_rawseti(l, -2, n+1);
            }
        }

        // i don't know why c# find a wrong generic function
        // push T will push object not a real push<T>

//         internal static void pushValue<T>(IntPtr l, List<T> list)
//         {
//             LuaDLL.lua_newtable(l);
//             for (int n = 0; n < list.Count; n++)
//             {
//                 pushValue(l, (T)list[n]);
//                 LuaDLL.lua_rawseti(l, -2, n + 1);
//             }
//         }
// 
//         internal static void pushValue<K,V>(IntPtr l, Dictionary<K,V> dict)
//         {
//             LuaDLL.lua_newtable(l);
//             foreach (K k in dict.Keys)
//             {
//                 pushValue(l, (K)k);
//                 pushValue(l, (V)dict[k]);
//                 LuaDLL.lua_rawset(l, -3);
//             }
//         }

        internal static void pushValue(IntPtr l, bool b)
        {
            LuaDLL.lua_pushboolean(l, b);
        }

        internal static void pushValue(IntPtr l, string s)
        {
            LuaDLL.lua_pushstring(l, s);
        }

        internal static void pushValue(IntPtr l, int i)
        {
            LuaDLL.lua_pushinteger(l, i);
        }

        public static void pushValue(IntPtr l, Int64 i)
        {
#if LUA_5_3
            LuaDLL.lua_pushinteger(l,i);
#else
            LuaDLL.lua_pushnumber(l, (double)i);
#endif
        }

        internal static void pushValue(IntPtr l, double d)
        {
            LuaDLL.lua_pushnumber(l, d);
        }

        internal static void pushValue(IntPtr l, UnityEngine.Object o)
        {
            pushObject(l, o);
        }

        internal static void pushValue(IntPtr l, object o)
        {
            pushObject(l, o);
        }

        internal static void pushValue(IntPtr l, object[] o)
        {
            LuaDLL.lua_newtable(l);
            for (int n = 0; n < o.Length; n++)
            {
                pushValue(l, o[n]);
                LuaDLL.lua_rawseti(l, -2, n + 1);
            }
        }

        internal static void pushValue(IntPtr l, LuaCSFunction f)
        {
            pushObject(l, f);
        }

        internal static void pushValue(IntPtr l, LuaTable t)
        {
            t.push(l);
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
//        internal static void pushValue(IntPtr l, Vector2 o)
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



//        internal static void pushValue(IntPtr l, Vector3 o)
//        {
//            LuaDLL.lua_newtable(l);
//            LuaDLL.lua_pushnumber(l, o.x);
//            LuaDLL.lua_setfield(l, -2, "x");
//            LuaDLL.lua_pushnumber(l, o.y);
//            LuaDLL.lua_setfield(l, -2, "y");
//            LuaDLL.lua_pushnumber(l, o.z);
//            LuaDLL.lua_setfield(l, -2, "z");
//            LuaDLL.lua_pushstring(l, "Vector3");
//            LuaDLL.lua_setfield(l, -2, "__typename");
// 
//            LuaDLL.lua_getglobal(l, "Vector3_mt");
//            LuaDLL.lua_setmetatable(l, -2);
//        }



//        internal static void pushValue(IntPtr l, Vector4 o)
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


        internal static void pushEnum(IntPtr l, int e)
        {
            pushValue(l, e);
        }


        internal static void pushVar(IntPtr l, object o)
        {
            if(o==null)
            {
                LuaDLL.lua_pushnil(l);
                return;
            }

            string t = o.GetType().Name;
            switch (t)
            {
                case "Single":
                    LuaDLL.lua_pushnumber(l, (float)o);
                    break;
                case "Double":
                    LuaDLL.lua_pushnumber(l, (double)o);
                    break;
                case "Int32":
                case "Uint32":
                    LuaDLL.lua_pushinteger(l, (int)o);
                    break;

                case "Int64":
                case "UInt64":
#if LUA_5_3
                    LuaDLL.lua_pushinteger(l, (long)o);
#else
                    LuaDLL.lua_pushnumber(l, (double)o);
#endif
                    break;

                case "String":
                    LuaDLL.lua_pushstring(l, (string)o);
                    break;
                case "Boolean":
                    LuaDLL.lua_pushboolean(l, (bool)o);
                    break;
                case "LuaTable":
                case "LuaFunction":
                    ((LuaVar)o).push(l);
                    break;
                default:
                    LuaObject.pushObject(l, o);
                    break;
            }
        }



        internal static T checkSelf<T>(IntPtr l)
        {
            object o = checkObj(l, 1);
            if (o!=null)
            {
                return (T)o;
            }
            LuaDLL.luaL_error(l, "expect self, but get null");
            return default(T);
        }

        internal static object checkSelf(IntPtr l) {
            object o = checkObj(l, 1);
            if (o != null)
                return o;
            LuaDLL.luaL_error(l, "expect self, but get null");
            return null;
        }

        internal static void setBack(IntPtr l, object o)
        {
            ObjectCache t = ObjectCache.get(l);
            t.setBack(l, 1, o);
        }

		internal static int extractFunction(IntPtr l,int p) {
			int op=0;
			LuaTypes t = LuaDLL.lua_type(l,p);
			if(t==LuaTypes.LUA_TNIL)
			{
				op=0;
			} else if(t==LuaTypes.LUA_TTABLE) {
				
				LuaDLL.lua_rawgeti(l,p,1);
				LuaDLL.lua_pushstring(l,"+=");
				if(LuaDLL.lua_rawequal(l,-1,-2)==1) 
					op=1;
				else
					op=2;
				
				LuaDLL.lua_pop(l,2);
				LuaDLL.lua_rawgeti(l,p,2);
			} 
			else if(t==LuaTypes.LUA_TFUNCTION) {
				LuaDLL.lua_pushvalue(l,p);
			} else 
				LuaDLL.luaL_error(l,"expect valid Delegate ");
			return op;
		}

		static Dictionary<int ,object> delegateCache = new Dictionary<int, object>();
		static internal bool getCacheDelegate<T>(int r,out T ua) {
			object o;
			if(delegateCache.TryGetValue(r,out o)) {
				ua=(T)o;
				return true;
			}
			ua=default(T);
			return false;
		}

		static internal void cacheDelegate(int r,object o) {
			delegateCache[r]=o;
		}
    }

}