using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GraphicRebuildTracker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TrackGraphic_s(IntPtr l) {
		try{
			UnityEngine.UI.Graphic a1;
			checkType(l,1,out a1);
			UnityEngine.UI.GraphicRebuildTracker.TrackGraphic(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnTrackGraphic_s(IntPtr l) {
		try{
			UnityEngine.UI.Graphic a1;
			checkType(l,1,out a1);
			UnityEngine.UI.GraphicRebuildTracker.UnTrackGraphic(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.GraphicRebuildTracker");
		addMember(l,TrackGraphic_s);
		addMember(l,UnTrackGraphic_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.GraphicRebuildTracker));
	}
}
