using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AnimationState o;
		o=new UnityEngine.AnimationState();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddMixingTransform(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AnimationState self=(UnityEngine.AnimationState)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.AddMixingTransform(a1,a2);
				return 0;
			}
			else if(argc==1){
				UnityEngine.AnimationState self=(UnityEngine.AnimationState)checkSelf(l);
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
			UnityEngine.AnimationState self=(UnityEngine.AnimationState)checkSelf(l);
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
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.weight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.weight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushEnum(l,(int)o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		UnityEngine.WrapMode v;
		checkEnum(l,2,out v);
		o.wrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.normalizedTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedTime(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.normalizedTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedSpeed(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.normalizedSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedSpeed(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.normalizedSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layer(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.layer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layer(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.layer=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendMode(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		pushEnum(l,(int)o.blendMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendMode(IntPtr l) {
		UnityEngine.AnimationState o = (UnityEngine.AnimationState)checkSelf(l);
		UnityEngine.AnimationBlendMode v;
		checkEnum(l,2,out v);
		o.blendMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationState");
		addMember(l,AddMixingTransform);
		addMember(l,RemoveMixingTransform);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"weight",get_weight,set_weight,true);
		addMember(l,"wrapMode",get_wrapMode,set_wrapMode,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"normalizedTime",get_normalizedTime,set_normalizedTime,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"normalizedSpeed",get_normalizedSpeed,set_normalizedSpeed,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"layer",get_layer,set_layer,true);
		addMember(l,"clip",get_clip,null,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"blendMode",get_blendMode,set_blendMode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimationState),typeof(UnityEngine.TrackedReference));
	}
}
