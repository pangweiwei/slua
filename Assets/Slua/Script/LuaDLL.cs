using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LuaInterface
{

#pragma warning disable 414
    public class MonoPInvokeCallbackAttribute : System.Attribute
    {
        private Type type;
        public MonoPInvokeCallbackAttribute(Type t) { 
            type = t;
        }
    }
#pragma warning restore 414

    public enum LuaTypes : int
    {
        LUA_TNONE = -1,
        LUA_TNIL = 0,
        LUA_TBOOLEAN = 1,
        LUA_TLIGHTUSERDATA = 2,
        LUA_TNUMBER = 3,
        LUA_TSTRING = 4,
        LUA_TTABLE = 5,
        LUA_TFUNCTION = 6,
        LUA_TUSERDATA = 7,
        LUA_TTHREAD = 8,
    }

    public enum LuaGCOptions
    {
        LUA_GCSTOP = 0,
        LUA_GCRESTART = 1,
        LUA_GCCOLLECT = 2,
        LUA_GCCOUNT = 3,
        LUA_GCCOUNTB = 4,
        LUA_GCSTEP = 5,
        LUA_GCSETPAUSE = 6,
        LUA_GCSETSTEPMUL = 7,
    }

    public enum LuaThreadStatus
    {
        LUA_YIELD = 1,
        LUA_ERRRUN = 2,
        LUA_ERRSYNTAX = 3,
        LUA_ERRMEM = 4,
        LUA_ERRERR = 5,
    }

    sealed class LuaIndexes
    {
#if LUA_5_3
        // for lua5.3
        public static int LUA_REGISTRYINDEX = -1000000 - 1000;
#else
        // for lua5.1 or luajit
        public static int LUA_REGISTRYINDEX = -10000;
        public static int LUA_GLOBALSINDEX = -10002;
#endif
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ReaderInfo
    {
        public String chunkData;
        public bool finished;
    }

    public delegate int LuaCSFunction(IntPtr luaState);
    public delegate string LuaChunkReader(IntPtr luaState, ref ReaderInfo data, ref uint size);

    public delegate int LuaFunctionCallback(IntPtr luaState);
    public class LuaDLL
    {
        public static int LUA_MULTRET = -1;
#if UNITY_IPHONE && !UNITY_EDITOR
		const string LUADLL = "__Internal";
#else

        const string LUADLL = "slua";
#endif

        // Thread Funcs
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_tothread(IntPtr L, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_xmove(IntPtr from, IntPtr to, int n);
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lua_newthread(IntPtr L);
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_status(IntPtr L);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_pushthread(IntPtr L);


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_gc(IntPtr luaState, LuaGCOptions what, int data);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lua_typename(IntPtr luaState, int type);
        public static string lua_typenamestr(IntPtr luaState, LuaTypes type)
        {
            IntPtr p = lua_typename(luaState, (int)type);
            return Marshal.PtrToStringAnsi(p);
        }
        public static string luaL_typename(IntPtr luaState, int stackPos)
        {
            return LuaDLL.lua_typenamestr(luaState, LuaDLL.lua_type(luaState, stackPos));
        }

        public static bool lua_isfunction(IntPtr luaState, int stackPos)
        {
            return lua_type(luaState, stackPos) == LuaTypes.LUA_TFUNCTION;
        }

        public static bool lua_islightuserdata(IntPtr luaState, int stackPos)
        {
            return lua_type(luaState, stackPos) == LuaTypes.LUA_TLIGHTUSERDATA;
        }

        public static bool lua_istable(IntPtr luaState, int stackPos)
        {
            return lua_type(luaState, stackPos) == LuaTypes.LUA_TTABLE;
        }

        public static bool lua_isthread(IntPtr luaState, int stackPos)
        {
            return lua_type(luaState, stackPos) == LuaTypes.LUA_TTHREAD;
        }

        public static void luaL_error(IntPtr luaState, string message)
        {
            LuaDLL.luaL_where(luaState, 1);
            LuaDLL.lua_pushstring(luaState, message);
            LuaDLL.lua_concat(luaState, 2);
            LuaDLL.lua_error(luaState);
        }

        public static void luaL_error(IntPtr luaState, string fmt, params object[] args)
        {
            string str = string.Format(fmt, args);
            luaL_error(luaState, str);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern string luaL_gsub(IntPtr luaState, string str, string pattern, string replacement);
        


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_isuserdata(IntPtr luaState, int stackPos);
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_rawequal(IntPtr luaState, int stackPos1, int stackPos2);
       
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_setfield(IntPtr luaState, int stackPos, string name);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_callmeta(IntPtr luaState, int stackPos, string name);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr luaL_newstate();
        /// <summary>DEPRECATED - use luaL_newstate() instead!</summary>
        public static IntPtr lua_open()
        {
            return LuaDLL.luaL_newstate();
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_close(IntPtr luaState);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void luaL_openlibs(IntPtr luaState);
        


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_loadstring(IntPtr luaState, string chunk);
        public static int luaL_dostring(IntPtr luaState, string chunk)
        {
            int result = LuaDLL.luaL_loadstring(luaState, chunk);
            if (result != 0)
                return result;

            return LuaDLL.lua_pcall(luaState, 0, -1, 0);
        }
        /// <summary>DEPRECATED - use luaL_dostring(IntPtr luaState, string chunk) instead!</summary>
        public static int lua_dostring(IntPtr luaState, string chunk)
        {
            return LuaDLL.luaL_dostring(luaState, chunk);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_createtable(IntPtr luaState, int narr, int nrec);
        public static void lua_newtable(IntPtr luaState)
        {
            LuaDLL.lua_createtable(luaState, 0, 0);
        }

#if LUA_5_3
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_getglobal(IntPtr luaState, string name);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_setglobal(IntPtr luaState, string name);

        public static void lua_insert(IntPtr luaState, int newTop)
        {
            lua_rotate(luaState, newTop, 1);
        }

        public static void lua_pushglobaltable(IntPtr l)
        {
            lua_rawgeti(l, LuaIndexes.LUA_REGISTRYINDEX, 2); 
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_rotate(IntPtr luaState, int index, int n);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_rawlen(IntPtr luaState, int index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_loadbufferx(IntPtr luaState, byte[] buff, int size, string name, IntPtr x);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_callk(IntPtr luaState, int nArgs, int nResults,int ctx,IntPtr k);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_pcallk(IntPtr luaState, int nArgs, int nResults, int errfunc,int ctx,IntPtr k);

		[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
		public static extern int luaS_pcall(IntPtr luaState, int nArgs, int nResults, int errfunc);
		
		public static int lua_call(IntPtr luaState, int nArgs, int nResults)
        {
            return lua_callk(luaState, nArgs, nResults, 0, IntPtr.Zero);
        }

        public static int lua_pcall(IntPtr luaState, int nArgs, int nResults, int errfunc)
        {
			return luaS_pcall(luaState, nArgs, nResults, errfunc);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern double lua_tonumberx(IntPtr luaState, int index, IntPtr x);
        public static double lua_tonumber(IntPtr luaState, int index)
        {
            return lua_tonumberx(luaState, index, IntPtr.Zero);
        }        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int64 lua_tointegerx(IntPtr luaState, int index,IntPtr x);
        public static int lua_tointeger(IntPtr luaState, int index)
        {
            return (int)lua_tointegerx(luaState, index, IntPtr.Zero);
        }


        public static int luaL_loadbuffer(IntPtr luaState, byte[] buff, int size, string name)
        {
            return luaL_loadbufferx(luaState, buff, size, name, IntPtr.Zero);
        }

        public static void lua_remove(IntPtr l, int idx)
        {
            lua_rotate(l, (idx), -1);
            lua_pop(l, 1);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_rawgeti(IntPtr luaState, int tableIndex, Int64 index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_rawseti(IntPtr luaState, int tableIndex, Int64 index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushinteger(IntPtr luaState, Int64 i);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int64 luaL_checkinteger(IntPtr luaState, int stackPos); 

		[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
		public static extern int luaS_yield(IntPtr luaState,int nrets);

		[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_resume(IntPtr L, IntPtr from, int narg);
#else
		[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_resume(IntPtr L, int narg);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_lessthan(IntPtr luaState, int stackPos1, int stackPos2);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_getfenv(IntPtr luaState, int stackPos);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_yield(IntPtr L, int nresults);

        public static void lua_getglobal(IntPtr luaState, string name)
        {
            LuaDLL.lua_pushstring(luaState, name);
            LuaDLL.lua_gettable(luaState, LuaIndexes.LUA_GLOBALSINDEX);
        }

        public static void lua_setglobal(IntPtr luaState, string name)
        {
            LuaDLL.lua_pushstring(luaState, name);
            LuaDLL.lua_insert(luaState, -2);
            LuaDLL.lua_settable(luaState, LuaIndexes.LUA_GLOBALSINDEX);
        }

        public static void lua_pushglobaltable(IntPtr l) {
            LuaDLL.lua_pushvalue(l, LuaIndexes.LUA_GLOBALSINDEX);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_insert(IntPtr luaState, int newTop);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_objlen(IntPtr luaState, int stackPos);

                public static int lua_rawlen(IntPtr luaState, int stackPos)
        {
            return lua_objlen(luaState, stackPos);
        }

        public static int lua_strlen(IntPtr luaState, int stackPos)
        {
            return lua_rawlen(luaState, stackPos);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_call(IntPtr luaState, int nArgs, int nResults);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_pcall(IntPtr luaState, int nArgs, int nResults, int errfunc);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern double lua_tonumber(IntPtr luaState, int index);
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_tointeger(IntPtr luaState, int index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_loadbuffer(IntPtr luaState, byte[] buff, int size, string name);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_remove(IntPtr luaState, int index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_rawgeti(IntPtr luaState, int tableIndex, int index);

         [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_rawseti(IntPtr luaState, int tableIndex, int index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushinteger(IntPtr luaState, int i);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_checkinteger(IntPtr luaState, int stackPos);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_replace(IntPtr luaState, int index);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_setfenv(IntPtr luaState, int stackPos);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_equal(IntPtr luaState, int index1, int index2);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_loadfile(IntPtr luaState, string filename);
#endif


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_settop(IntPtr luaState, int newTop);
        public static void lua_pop(IntPtr luaState, int amount)
        {
            LuaDLL.lua_settop(luaState, -(amount) - 1);
        }
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_gettable(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_rawget(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_settable(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_rawset(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_setmetatable(IntPtr luaState, int objIndex);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_getmetatable(IntPtr luaState, int objIndex);
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushvalue(IntPtr luaState, int index);
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_gettop(IntPtr luaState);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern LuaTypes lua_type(IntPtr luaState, int index);
        public static bool lua_isnil(IntPtr luaState, int index)
        {
            return (LuaDLL.lua_type(luaState, index) == LuaTypes.LUA_TNIL);
        }
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool lua_isnumber(IntPtr luaState, int index);
        public static bool lua_isboolean(IntPtr luaState, int index)
        {
            return LuaDLL.lua_type(luaState, index) == LuaTypes.LUA_TBOOLEAN;
        }
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_ref(IntPtr luaState, int registryIndex);
       

        public static void lua_getref(IntPtr luaState, int reference)
        {
            LuaDLL.lua_rawgeti(luaState,LuaIndexes.LUA_REGISTRYINDEX, reference);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void luaL_unref(IntPtr luaState, int registryIndex, int reference);
        public static void lua_unref(IntPtr luaState, int reference)
        {
            LuaDLL.luaL_unref(luaState, LuaIndexes.LUA_REGISTRYINDEX, reference);
        }
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool lua_isstring(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool lua_iscfunction(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushnil(IntPtr luaState);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushstdcallcfunction(IntPtr luaState, IntPtr wrapper);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void luaL_checktype(IntPtr luaState, int p, LuaTypes t);

        public static void lua_pushstdcallcfunction(IntPtr luaState, LuaCSFunction function)
        {
            IntPtr fn = Marshal.GetFunctionPointerForDelegate(function);
            lua_pushstdcallcfunction(luaState, fn);
        }
    
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lua_tocfunction(IntPtr luaState, int index);
     

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool lua_toboolean(IntPtr luaState, int index);

        

#if UNITY_IPHONE && !UNITY_EDITOR
		[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr luaS_tolstring32(IntPtr luaState, int index, out int strLen);
#else
		[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_tolstring(IntPtr luaState, int index, out int strLen);
#endif

        public static string lua_tostring(IntPtr luaState, int index)
        {
            int strlen;
#if UNITY_IPHONE && !UNITY_EDITOR
			IntPtr str = luaS_tolstring32(luaState, index, out strlen); // fix il2cpp 64 bit
#else
			IntPtr str = lua_tolstring(luaState, index, out strlen);
#endif
            if (str != IntPtr.Zero)
            {
                return Marshal.PtrToStringAnsi(str, strlen);
            }
            return null;
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_atpanic(IntPtr luaState, LuaCSFunction panicf);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushnumber(IntPtr luaState, double number);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushboolean(IntPtr luaState, bool value);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushstring(IntPtr luaState, string str);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushlstring(IntPtr luaState, byte[] str, int size);


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaL_newmetatable(IntPtr luaState, string meta);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_getfield(IntPtr luaState, int stackPos, string meta);
        public static void luaL_getmetatable(IntPtr luaState, string meta)
        {
            LuaDLL.lua_getfield(luaState, LuaIndexes.LUA_REGISTRYINDEX, meta);
        }
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr luaL_checkudata(IntPtr luaState, int stackPos, string meta);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool luaL_getmetafield(IntPtr luaState, int stackPos, string field);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_load(IntPtr luaState, LuaChunkReader chunkReader, ref ReaderInfo data, string chunkName);


        
        
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_error(IntPtr luaState);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool lua_checkstack(IntPtr luaState, int extra);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lua_next(IntPtr luaState, int index);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_pushlightuserdata(IntPtr luaState, IntPtr udata);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void luaL_where(IntPtr luaState, int level);
     
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern double luaL_checknumber(IntPtr luaState, int stackPos);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lua_concat(IntPtr luaState, int n);


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void luaS_newuserdata(IntPtr luaState, int val);
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaS_rawnetobj(IntPtr luaState, int obj);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void luaS_pushcclosure(IntPtr luaState, IntPtr func, int n);

        public static void luaS_pushcclosure(IntPtr luaState, LuaCSFunction func, int n)
        {
            IntPtr p = Marshal.GetFunctionPointerForDelegate(func); 
            luaS_pushcclosure(luaState, p, n);
        }


        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lua_touserdata(IntPtr luaState, int index);

		public static int lua_absindex(IntPtr luaState,int index) {
			return index > 0 ? index : lua_gettop(luaState) + index + 1;
		}

        public static int lua_upvalueindex(int i)
        {
#if LUA_5_3
            return LuaIndexes.LUA_REGISTRYINDEX - i;
#else
            return LuaIndexes.LUA_GLOBALSINDEX - i;
#endif
        }
    }
}