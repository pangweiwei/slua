using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ObstacleAvoidanceType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ObstacleAvoidanceType o = (UnityEngine.ObstacleAvoidanceType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ObstacleAvoidanceType");
		addMember(l,0,"NoObstacleAvoidance");
		addMember(l,1,"LowQualityObstacleAvoidance");
		addMember(l,2,"MedQualityObstacleAvoidance");
		addMember(l,3,"GoodQualityObstacleAvoidance");
		addMember(l,4,"HighQualityObstacleAvoidance");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
