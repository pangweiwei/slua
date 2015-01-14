using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CharacterController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.CharacterController o;
		if(matchType(l,1)){
			o=new UnityEngine.CharacterController();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SimpleMove(IntPtr l) {
		try{
			UnityEngine.CharacterController self=checkSelf<UnityEngine.CharacterController>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.SimpleMove(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Move(IntPtr l) {
		try{
			UnityEngine.CharacterController self=checkSelf<UnityEngine.CharacterController>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.CollisionFlags ret=self.Move(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isGrounded(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.isGrounded);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionFlags(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.collisionFlags);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slopeLimit(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.slopeLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slopeLimit(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		System.Single v;
		checkType(l,2,out v);
		o.slopeLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stepOffset(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.stepOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stepOffset(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		System.Single v;
		checkType(l,2,out v);
		o.stepOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_detectCollisions(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		pushValue(l,o.detectCollisions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_detectCollisions(IntPtr l) {
		UnityEngine.CharacterController o = checkSelf<UnityEngine.CharacterController>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.detectCollisions=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterController");
		addMember(l,SimpleMove, "SimpleMove");
		addMember(l,Move, "Move");
		addMember(l,get_isGrounded, "get_isGrounded");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,get_collisionFlags, "get_collisionFlags");
		addMember(l,get_radius, "get_radius");
		addMember(l,set_radius, "set_radius");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_slopeLimit, "get_slopeLimit");
		addMember(l,set_slopeLimit, "set_slopeLimit");
		addMember(l,get_stepOffset, "get_stepOffset");
		addMember(l,set_stepOffset, "set_stepOffset");
		addMember(l,get_detectCollisions, "get_detectCollisions");
		addMember(l,set_detectCollisions, "set_detectCollisions");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.CharacterController),typeof(UnityEngine.Collider));
		LuaDLL.lua_pop(l, 1);
	}
}
