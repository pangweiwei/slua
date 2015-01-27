using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshPath : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.NavMeshPath o;
		if(matchType(l,1)){
			o=new UnityEngine.NavMeshPath();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearCorners(IntPtr l) {
		try{
			UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
			self.ClearCorners();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_corners(IntPtr l) {
		UnityEngine.NavMeshPath o = (UnityEngine.NavMeshPath)checkSelf(l);
		pushValue(l,o.corners);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_status(IntPtr l) {
		UnityEngine.NavMeshPath o = (UnityEngine.NavMeshPath)checkSelf(l);
		pushValue(l,o.status);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshPath");
		addMember(l,ClearCorners);
		addMember(l,"corners",get_corners,null,true);
		addMember(l,"status",get_status,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshPath));
	}
}
