using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Particle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_energy(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.energy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_energy(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.energy=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startEnergy(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.startEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startEnergy(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startEnergy=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.rotation=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Particle o = (UnityEngine.Particle)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Particle");
		addMember(l,"position",get_position,set_position);
		addMember(l,"velocity",get_velocity,set_velocity);
		addMember(l,"energy",get_energy,set_energy);
		addMember(l,"startEnergy",get_startEnergy,set_startEnergy);
		addMember(l,"size",get_size,set_size);
		addMember(l,"rotation",get_rotation,set_rotation);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity);
		addMember(l,"color",get_color,set_color);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Particle));
	}
}
