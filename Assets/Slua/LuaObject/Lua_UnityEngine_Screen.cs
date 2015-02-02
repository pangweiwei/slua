using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Screen : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Screen o;
		if(matchType(l,1)){
			o=new UnityEngine.Screen();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetResolution_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(int),typeof(int),typeof(bool),typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Screen.SetResolution(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(int),typeof(bool))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Screen.SetResolution(a1,a2,a3);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resolutions(IntPtr l) {
		pushValue(l,UnityEngine.Screen.resolutions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_GetResolution(IntPtr l) {
		pushValue(l,UnityEngine.Screen.GetResolution);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentResolution(IntPtr l) {
		pushValue(l,UnityEngine.Screen.currentResolution);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showCursor(IntPtr l) {
		pushValue(l,UnityEngine.Screen.showCursor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showCursor(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.showCursor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lockCursor(IntPtr l) {
		pushValue(l,UnityEngine.Screen.lockCursor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lockCursor(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.lockCursor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		pushValue(l,UnityEngine.Screen.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		pushValue(l,UnityEngine.Screen.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dpi(IntPtr l) {
		pushValue(l,UnityEngine.Screen.dpi);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fullScreen(IntPtr l) {
		pushValue(l,UnityEngine.Screen.fullScreen);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fullScreen(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.fullScreen=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autorotateToPortrait(IntPtr l) {
		pushValue(l,UnityEngine.Screen.autorotateToPortrait);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autorotateToPortrait(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.autorotateToPortrait=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autorotateToPortraitUpsideDown(IntPtr l) {
		pushValue(l,UnityEngine.Screen.autorotateToPortraitUpsideDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autorotateToPortraitUpsideDown(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.autorotateToPortraitUpsideDown=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autorotateToLandscapeLeft(IntPtr l) {
		pushValue(l,UnityEngine.Screen.autorotateToLandscapeLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autorotateToLandscapeLeft(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.autorotateToLandscapeLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autorotateToLandscapeRight(IntPtr l) {
		pushValue(l,UnityEngine.Screen.autorotateToLandscapeRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autorotateToLandscapeRight(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Screen.autorotateToLandscapeRight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orientation(IntPtr l) {
		pushEnum(l,(int)UnityEngine.Screen.orientation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orientation(IntPtr l) {
		UnityEngine.ScreenOrientation v;
		checkEnum(l,2,out v);
		UnityEngine.Screen.orientation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepTimeout(IntPtr l) {
		pushValue(l,UnityEngine.Screen.sleepTimeout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepTimeout(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Screen.sleepTimeout=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Screen");
		addMember(l,SetResolution_s);
		addMember(l,"resolutions",get_resolutions,null,false);
		addMember(l,"GetResolution",get_GetResolution,null,false);
		addMember(l,"currentResolution",get_currentResolution,null,false);
		addMember(l,"showCursor",get_showCursor,set_showCursor,false);
		addMember(l,"lockCursor",get_lockCursor,set_lockCursor,false);
		addMember(l,"width",get_width,null,false);
		addMember(l,"height",get_height,null,false);
		addMember(l,"dpi",get_dpi,null,false);
		addMember(l,"fullScreen",get_fullScreen,set_fullScreen,false);
		addMember(l,"autorotateToPortrait",get_autorotateToPortrait,set_autorotateToPortrait,false);
		addMember(l,"autorotateToPortraitUpsideDown",get_autorotateToPortraitUpsideDown,set_autorotateToPortraitUpsideDown,false);
		addMember(l,"autorotateToLandscapeLeft",get_autorotateToLandscapeLeft,set_autorotateToLandscapeLeft,false);
		addMember(l,"autorotateToLandscapeRight",get_autorotateToLandscapeRight,set_autorotateToLandscapeRight,false);
		addMember(l,"orientation",get_orientation,set_orientation,false);
		addMember(l,"sleepTimeout",get_sleepTimeout,set_sleepTimeout,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Screen));
	}
}
