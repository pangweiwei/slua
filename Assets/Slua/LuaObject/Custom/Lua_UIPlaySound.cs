using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPlaySound : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIPlaySound o;
		o=new UIPlaySound();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			UIPlaySound self=(UIPlaySound)checkSelf(l);
			self.Play();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioClip(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		pushValue(l,o.audioClip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_audioClip(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		UnityEngine.AudioClip v;
		checkType(l,2,out v);
		o.audioClip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trigger(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		pushEnum(l,(int)o.trigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trigger(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		UIPlaySound.Trigger v;
		checkEnum(l,2,out v);
		o.trigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_volume(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		pushValue(l,o.volume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_volume(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.volume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pitch(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		pushValue(l,o.pitch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pitch(IntPtr l) {
		UIPlaySound o = (UIPlaySound)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.pitch=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPlaySound");
		addMember(l,Play);
		addMember(l,"audioClip",get_audioClip,set_audioClip,true);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"volume",get_volume,set_volume,true);
		addMember(l,"pitch",get_pitch,set_pitch,true);
		createTypeMetatable(l,constructor, typeof(UIPlaySound),typeof(UnityEngine.MonoBehaviour));
	}
}
