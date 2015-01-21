using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField_CharacterValidation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.InputField.CharacterValidation o = (UnityEngine.UI.InputField.CharacterValidation)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.InputField.CharacterValidation");
		addMember(l,0,"None");
		addMember(l,1,"Integer");
		addMember(l,2,"Decimal");
		addMember(l,3,"Alphanumeric");
		addMember(l,4,"Name");
		addMember(l,5,"EmailAddress");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
