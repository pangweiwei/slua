using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField_ContentType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.InputField.ContentType o = (UnityEngine.UI.InputField.ContentType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.InputField.ContentType");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Standard");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Autocorrected");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "IntegerNumber");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "DecimalNumber");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "Alphanumeric");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "Name");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "EmailAddress");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "Password");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "Pin");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "Custom");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
