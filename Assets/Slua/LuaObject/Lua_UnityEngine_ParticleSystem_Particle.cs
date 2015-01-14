using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_Particle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lifetime(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.lifetime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lifetime(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lifetime=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startLifetime(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.startLifetime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startLifetime(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startLifetime=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_axisOfRotation(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.axisOfRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_axisOfRotation(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.axisOfRotation=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.rotation=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		UnityEngine.Color32 v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_randomSeed(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		pushValue(l,o.randomSeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_randomSeed(IntPtr l) {
		UnityEngine.ParticleSystem.Particle o = checkSelf<UnityEngine.ParticleSystem.Particle>(l);
		System.UInt32 v;
		checkType(l,2,out v);
		o.randomSeed=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.Particle");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,set_velocity, "set_velocity");
		addMember(l,get_lifetime, "get_lifetime");
		addMember(l,set_lifetime, "set_lifetime");
		addMember(l,get_startLifetime, "get_startLifetime");
		addMember(l,set_startLifetime, "set_startLifetime");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		addMember(l,get_axisOfRotation, "get_axisOfRotation");
		addMember(l,set_axisOfRotation, "set_axisOfRotation");
		addMember(l,get_rotation, "get_rotation");
		addMember(l,set_rotation, "set_rotation");
		addMember(l,get_angularVelocity, "get_angularVelocity");
		addMember(l,set_angularVelocity, "set_angularVelocity");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_randomSeed, "get_randomSeed");
		addMember(l,set_randomSeed, "set_randomSeed");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleSystem.Particle));
		LuaDLL.lua_pop(l, 1);
	}
}
