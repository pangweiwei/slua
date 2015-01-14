using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioReverbPreset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.AudioReverbPreset o = (UnityEngine.AudioReverbPreset)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioReverbPreset");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Off");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Generic");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "PaddedCell");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "Room");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "Bathroom");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "Livingroom");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "Stoneroom");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "Auditorium");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "Concerthall");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "Cave");
		LuaDLL.lua_pushinteger(l, 10);
		LuaDLL.lua_setfield(l, -2, "Arena");
		LuaDLL.lua_pushinteger(l, 11);
		LuaDLL.lua_setfield(l, -2, "Hangar");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "CarpetedHallway");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "Hallway");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "StoneCorridor");
		LuaDLL.lua_pushinteger(l, 15);
		LuaDLL.lua_setfield(l, -2, "Alley");
		LuaDLL.lua_pushinteger(l, 16);
		LuaDLL.lua_setfield(l, -2, "Forest");
		LuaDLL.lua_pushinteger(l, 17);
		LuaDLL.lua_setfield(l, -2, "City");
		LuaDLL.lua_pushinteger(l, 18);
		LuaDLL.lua_setfield(l, -2, "Mountains");
		LuaDLL.lua_pushinteger(l, 19);
		LuaDLL.lua_setfield(l, -2, "Quarry");
		LuaDLL.lua_pushinteger(l, 20);
		LuaDLL.lua_setfield(l, -2, "Plain");
		LuaDLL.lua_pushinteger(l, 21);
		LuaDLL.lua_setfield(l, -2, "ParkingLot");
		LuaDLL.lua_pushinteger(l, 22);
		LuaDLL.lua_setfield(l, -2, "SewerPipe");
		LuaDLL.lua_pushinteger(l, 23);
		LuaDLL.lua_setfield(l, -2, "Underwater");
		LuaDLL.lua_pushinteger(l, 24);
		LuaDLL.lua_setfield(l, -2, "Drugged");
		LuaDLL.lua_pushinteger(l, 25);
		LuaDLL.lua_setfield(l, -2, "Dizzy");
		LuaDLL.lua_pushinteger(l, 26);
		LuaDLL.lua_setfield(l, -2, "Psychotic");
		LuaDLL.lua_pushinteger(l, 27);
		LuaDLL.lua_setfield(l, -2, "User");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
