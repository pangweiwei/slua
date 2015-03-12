using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ScreenOrientation : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ScreenOrientation");
		addMember(l,0,"Unknown");
		addMember(l,1,"Portrait");
		addMember(l,2,"PortraitUpsideDown");
		addMember(l,3,"LandscapeLeft");
		addMember(l,4,"LandscapeRight");
		addMember(l,5,"AutoRotation");
		addMember(l,3,"Landscape");
		LuaDLL.lua_pop(l, 1);
	}
}
