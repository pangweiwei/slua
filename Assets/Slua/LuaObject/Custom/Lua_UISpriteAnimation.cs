using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISpriteAnimation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISpriteAnimation o;
		o=new UISpriteAnimation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildSpriteList(IntPtr l) {
		try{
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			self.RebuildSpriteList();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
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
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
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
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			self.ResetToBeginning();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frames(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		pushValue(l,o.frames);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_framesPerSecond(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		pushValue(l,o.framesPerSecond);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_framesPerSecond(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.framesPerSecond=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_namePrefix(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		pushValue(l,o.namePrefix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_namePrefix(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.namePrefix=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		pushValue(l,o.loop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.loop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UISpriteAnimation o = (UISpriteAnimation)checkSelf(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISpriteAnimation");
		addMember(l,RebuildSpriteList);
		addMember(l,Play);
		addMember(l,Pause);
		addMember(l,ResetToBeginning);
		addMember(l,"frames",get_frames,null,true);
		addMember(l,"framesPerSecond",get_framesPerSecond,set_framesPerSecond,true);
		addMember(l,"namePrefix",get_namePrefix,set_namePrefix,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		createTypeMetatable(l,constructor, typeof(UISpriteAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
