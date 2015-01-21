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
		UnityEngine.ParticleSystem.CollisionEvent o = (UnityEngine.ParticleSystem.CollisionEvent)checkSelf(l);
		pushValue(l,o.intersection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = (UnityEngine.ParticleSystem.CollisionEvent)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = (UnityEngine.ParticleSystem.CollisionEvent)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ParticleSystem.CollisionEvent o = (UnityEngine.ParticleSystem.CollisionEvent)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.CollisionEvent");
		addMember(l,"intersection",get_intersection,null);
		addMember(l,"normal",get_normal,null);
		addMember(l,"velocity",get_velocity,null);
		addMember(l,"collider",get_collider,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.CollisionEvent));
	}
}
