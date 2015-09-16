using System.Collections.Generic;
using LuaInterface;
using System;

namespace SLua{
public static class Lua3rdDLL{
	static Dictionary<string, LuaCSFunction> DLLRegFuncs = new Dictionary<string, LuaCSFunction>();
	
	static Lua3rdDLL(){
		// LuaSocketDLL.Reg(DLLRegFuncs);
	}
	
	public static void open(IntPtr L){
		if(DLLRegFuncs.Count == 0){
			return;
		}
		
		LuaDLL.lua_getglobal(L, "package");
		LuaDLL.lua_getfield(L, -1, "preload");
		foreach (KeyValuePair<string, LuaCSFunction> pair in DLLRegFuncs) {
			LuaDLL.lua_pushcfunction (L, pair.Value);
			LuaDLL.lua_setfield(L, -2, pair.Key);
		}
		LuaDLL.lua_settop(L, 0);
	}
}
}