using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UI2DSpriteAnimation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UI2DSpriteAnimation o;
		o=new UI2DSpriteAnimation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_framerate(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		pushValue(l,o.framerate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_framerate(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.framerate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreTimeScale(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		pushValue(l,o.ignoreTimeScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreTimeScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frames(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		pushValue(l,o.frames);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frames(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		UnityEngine.Sprite[] v;
		checkType(l,2,out v);
		o.frames=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UI2DSpriteAnimation");
		addMember(l,"framerate",get_framerate,set_framerate,true);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		addMember(l,"frames",get_frames,set_frames,true);
		createTypeMetatable(l,constructor, typeof(UI2DSpriteAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
