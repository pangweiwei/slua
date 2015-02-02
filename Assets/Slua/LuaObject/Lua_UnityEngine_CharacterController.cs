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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SimpleMove(IntPtr l) {
		try{
			UnityEngine.CharacterController self=(UnityEngine.CharacterController)checkSelf(l);
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
			UnityEngine.CharacterController self=(UnityEngine.CharacterController)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.CollisionFlags ret=self.Move(a1);
			pushEnum(l,(int)ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isGrounded(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.isGrounded);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionFlags(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushEnum(l,(int)o.collisionFlags);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slopeLimit(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.slopeLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slopeLimit(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.slopeLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stepOffset(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.stepOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stepOffset(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.stepOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_detectCollisions(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		pushValue(l,o.detectCollisions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_detectCollisions(IntPtr l) {
		UnityEngine.CharacterController o = (UnityEngine.CharacterController)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.detectCollisions=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterController");
		addMember(l,SimpleMove);
		addMember(l,Move);
		addMember(l,"isGrounded",get_isGrounded,null,true);
		addMember(l,"velocity",get_velocity,null,true);
		addMember(l,"collisionFlags",get_collisionFlags,null,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"slopeLimit",get_slopeLimit,set_slopeLimit,true);
		addMember(l,"stepOffset",get_stepOffset,set_stepOffset,true);
		addMember(l,"detectCollisions",get_detectCollisions,set_detectCollisions,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CharacterController),typeof(UnityEngine.Collider));
	}
}
