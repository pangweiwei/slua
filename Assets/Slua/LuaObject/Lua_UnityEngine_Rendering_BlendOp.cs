using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_BlendOp : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.Rendering.BlendOp o = (UnityEngine.Rendering.BlendOp)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.BlendOp");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Add");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Subtract");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "ReverseSubtract");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "Min");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "Max");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "LogicalClear");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "LogicalSet");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "LogicalCopy");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "LogicalCopyInverted");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "LogicalNoop");
		LuaDLL.lua_pushinteger(l, 10);
		LuaDLL.lua_setfield(l, -2, "LogicalInvert");
		LuaDLL.lua_pushinteger(l, 11);
		LuaDLL.lua_setfield(l, -2, "LogicalAnd");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "LogicalNand");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "LogicalOr");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "LogicalNor");
		LuaDLL.lua_pushinteger(l, 15);
		LuaDLL.lua_setfield(l, -2, "LogicalXor");
		LuaDLL.lua_pushinteger(l, 16);
		LuaDLL.lua_setfield(l, -2, "LogicalEquivalence");
		LuaDLL.lua_pushinteger(l, 17);
		LuaDLL.lua_setfield(l, -2, "LogicalAndReverse");
		LuaDLL.lua_pushinteger(l, 18);
		LuaDLL.lua_setfield(l, -2, "LogicalAndInverted");
		LuaDLL.lua_pushinteger(l, 19);
		LuaDLL.lua_setfield(l, -2, "LogicalOrReverse");
		LuaDLL.lua_pushinteger(l, 20);
		LuaDLL.lua_setfield(l, -2, "LogicalOrInverted");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
