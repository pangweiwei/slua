using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralOutputType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ProceduralOutputType o = (UnityEngine.ProceduralOutputType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralOutputType");
		addMember(l,0,"Unknown");
		addMember(l,1,"Diffuse");
		addMember(l,2,"Normal");
		addMember(l,3,"Height");
		addMember(l,4,"Emissive");
		addMember(l,5,"Specular");
		addMember(l,6,"Opacity");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
