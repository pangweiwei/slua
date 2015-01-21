using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralPropertyType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ProceduralPropertyType o = (UnityEngine.ProceduralPropertyType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralPropertyType");
		addMember(l,0,"Boolean");
		addMember(l,1,"Float");
		addMember(l,2,"Vector2");
		addMember(l,3,"Vector3");
		addMember(l,4,"Vector4");
		addMember(l,5,"Color3");
		addMember(l,6,"Color4");
		addMember(l,7,"Enum");
		addMember(l,8,"Texture");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
