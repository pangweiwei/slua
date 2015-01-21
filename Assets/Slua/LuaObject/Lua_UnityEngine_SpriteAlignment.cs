using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SpriteAlignment : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.SpriteAlignment o = (UnityEngine.SpriteAlignment)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.SpriteAlignment");
		addMember(l,0,"Center");
		addMember(l,1,"TopLeft");
		addMember(l,2,"TopCenter");
		addMember(l,3,"TopRight");
		addMember(l,4,"LeftCenter");
		addMember(l,5,"RightCenter");
		addMember(l,6,"BottomLeft");
		addMember(l,7,"BottomCenter");
		addMember(l,8,"BottomRight");
		addMember(l,9,"Custom");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
