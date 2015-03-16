using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleCollisionEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intersection(IntPtr l) {
		UnityEngine.ParticleCollisionEvent o = (UnityEngine.ParticleCollisionEvent)checkSelf(l);
		pushValue(l,o.intersection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ParticleCollisionEvent o = (UnityEngine.ParticleCollisionEvent)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.ParticleCollisionEvent o = (UnityEngine.ParticleCollisionEvent)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ParticleCollisionEvent o = (UnityEngine.ParticleCollisionEvent)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleCollisionEvent");
		addMember(l,"intersection",get_intersection,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"velocity",get_velocity,null,true);
		addMember(l,"collider",get_collider,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleCollisionEvent));
	}
}
