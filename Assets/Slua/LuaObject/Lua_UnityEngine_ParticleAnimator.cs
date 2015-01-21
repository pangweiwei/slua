using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleAnimator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ParticleAnimator o;
		if(matchType(l,1)){
			o=new UnityEngine.ParticleAnimator();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_doesAnimateColor(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.doesAnimateColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_doesAnimateColor(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.doesAnimateColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.worldRotationAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldRotationAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.localRotationAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localRotationAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sizeGrow(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.sizeGrow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sizeGrow(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.sizeGrow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndForce(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.rndForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndForce(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.rndForce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.force=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damping(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.damping);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damping(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.damping=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autodestruct(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.autodestruct);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autodestruct(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.autodestruct=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorAnimation(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		pushValue(l,o.colorAnimation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorAnimation(IntPtr l) {
		UnityEngine.ParticleAnimator o = (UnityEngine.ParticleAnimator)checkSelf(l);
		UnityEngine.Color[] v;
		checkType(l,2,out v);
		o.colorAnimation=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleAnimator");
		addMember(l,"doesAnimateColor",get_doesAnimateColor,set_doesAnimateColor);
		addMember(l,"worldRotationAxis",get_worldRotationAxis,set_worldRotationAxis);
		addMember(l,"localRotationAxis",get_localRotationAxis,set_localRotationAxis);
		addMember(l,"sizeGrow",get_sizeGrow,set_sizeGrow);
		addMember(l,"rndForce",get_rndForce,set_rndForce);
		addMember(l,"force",get_force,set_force);
		addMember(l,"damping",get_damping,set_damping);
		addMember(l,"autodestruct",get_autodestruct,set_autodestruct);
		addMember(l,"colorAnimation",get_colorAnimation,set_colorAnimation);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleAnimator),typeof(UnityEngine.Component));
	}
}
