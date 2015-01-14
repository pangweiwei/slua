using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_CollisionEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intersection(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = checkSelf<UnityEngine.ParticleSystem.CollisionEvent>(l);
		pushValue(l,o.intersection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = checkSelf<UnityEngine.ParticleSystem.CollisionEvent>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = checkSelf<UnityEngine.ParticleSystem.CollisionEvent>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = checkSelf<UnityEngine.ParticleSystem.CollisionEvent>(l);
		pushValue(l,o.collider);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.CollisionEvent");
		addMember(l,get_intersection, "get_intersection");
		addMember(l,get_normal, "get_normal");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,get_collider, "get_collider");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleSystem.CollisionEvent));
		LuaDLL.lua_pop(l, 1);
	}
}
