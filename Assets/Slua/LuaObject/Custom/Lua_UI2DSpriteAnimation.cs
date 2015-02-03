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
	static public int Play(IntPtr l) {
		try{
			UI2DSpriteAnimation self=(UI2DSpriteAnimation)checkSelf(l);
			self.Play();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Pause(IntPtr l) {
		try{
			UI2DSpriteAnimation self=(UI2DSpriteAnimation)checkSelf(l);
			self.Pause();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetToBeginning(IntPtr l) {
		try{
			UI2DSpriteAnimation self=(UI2DSpriteAnimation)checkSelf(l);
			self.ResetToBeginning();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
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
	static public int get_loop(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		pushValue(l,o.loop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.loop=v;
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_framesPerSecond(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		pushValue(l,o.framesPerSecond);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_framesPerSecond(IntPtr l) {
		UI2DSpriteAnimation o = (UI2DSpriteAnimation)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.framesPerSecond=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UI2DSpriteAnimation");
		addMember(l,Play);
		addMember(l,Pause);
		addMember(l,ResetToBeginning);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"frames",get_frames,set_frames,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		addMember(l,"framesPerSecond",get_framesPerSecond,set_framesPerSecond,true);
		createTypeMetatable(l,constructor, typeof(UI2DSpriteAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
