using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ObstacleAvoidanceType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ObstacleAvoidanceType");
		addMember(l,0,"NoObstacleAvoidance");
		addMember(l,1,"LowQualityObstacleAvoidance");
		addMember(l,2,"MedQualityObstacleAvoidance");
		addMember(l,3,"GoodQualityObstacleAvoidance");
		addMember(l,4,"HighQualityObstacleAvoidance");
		LuaDLL.lua_pop(l, 1);
	}
}
