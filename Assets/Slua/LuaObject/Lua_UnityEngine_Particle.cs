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
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_energy(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.energy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_energy(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.energy=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startEnergy(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.startEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startEnergy(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startEnergy=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.rotation=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Particle o = checkSelf<UnityEngine.Particle>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Particle");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,set_velocity, "set_velocity");
		addMember(l,get_energy, "get_energy");
		addMember(l,set_energy, "set_energy");
		addMember(l,get_startEnergy, "get_startEnergy");
		addMember(l,set_startEnergy, "set_startEnergy");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		addMember(l,get_rotation, "get_rotation");
		addMember(l,set_rotation, "set_rotation");
		addMember(l,get_angularVelocity, "get_angularVelocity");
		addMember(l,set_angularVelocity, "set_angularVelocity");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Particle));
		LuaDLL.lua_pop(l, 1);
	}
}
