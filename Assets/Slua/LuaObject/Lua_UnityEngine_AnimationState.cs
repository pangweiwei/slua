using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AnimationState o;
		if(matchType(l,1)){
			o=new UnityEngine.AnimationState();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddMixingTransform(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Transform),typeof(System.Boolean))){
				UnityEngine.AnimationState self=checkSelf<UnityEngine.AnimationState>(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.AddMixingTransform(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Transform))){
				UnityEngine.AnimationState self=checkSelf<UnityEngine.AnimationState>(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.AddMixingTransform(a1);
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
	static public int RemoveMixingTransform(IntPtr l) {
		try{
			UnityEngine.AnimationState self=checkSelf<UnityEngine.AnimationState>(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			self.RemoveMixingTransform(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.weight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Single v;
		checkType(l,2,out v);
		o.weight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		UnityEngine.WrapMode v;
		checkEnum(l,2,out v);
		o.wrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.normalizedTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedTime(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Single v;
		checkType(l,2,out v);
		o.normalizedTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Single v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedSpeed(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.normalizedSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedSpeed(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Single v;
		checkType(l,2,out v);
		o.normalizedSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layer(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.layer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layer(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.layer=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		System.String v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendMode(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		pushValue(l,o.blendMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendMode(IntPtr l) {
		UnityEngine.AnimationState o = checkSelf<UnityEngine.AnimationState>(l);
		UnityEngine.AnimationBlendMode v;
		checkEnum(l,2,out v);
		o.blendMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationState");
		addMember(l,AddMixingTransform, "AddMixingTransform");
		addMember(l,RemoveMixingTransform, "RemoveMixingTransform");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		addMember(l,get_weight, "get_weight");
		addMember(l,set_weight, "set_weight");
		addMember(l,get_wrapMode, "get_wrapMode");
		addMember(l,set_wrapMode, "set_wrapMode");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		addMember(l,get_normalizedTime, "get_normalizedTime");
		addMember(l,set_normalizedTime, "set_normalizedTime");
		addMember(l,get_speed, "get_speed");
		addMember(l,set_speed, "set_speed");
		addMember(l,get_normalizedSpeed, "get_normalizedSpeed");
		addMember(l,set_normalizedSpeed, "set_normalizedSpeed");
		addMember(l,get_length, "get_length");
		addMember(l,get_layer, "get_layer");
		addMember(l,set_layer, "set_layer");
		addMember(l,get_clip, "get_clip");
		addMember(l,get_name, "get_name");
		addMember(l,set_name, "set_name");
		addMember(l,get_blendMode, "get_blendMode");
		addMember(l,set_blendMode, "set_blendMode");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnimationState),typeof(UnityEngine.TrackedReference));
		LuaDLL.lua_pop(l, 1);
	}
}
