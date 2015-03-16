using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ConstantForce2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ConstantForce2D o;
		o=new UnityEngine.ConstantForce2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.ConstantForce2D o = (UnityEngine.ConstantForce2D)checkSelf(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.ConstantForce2D o = (UnityEngine.ConstantForce2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.force=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeForce(IntPtr l) {
		UnityEngine.ConstantForce2D o = (UnityEngine.ConstantForce2D)checkSelf(l);
		pushValue(l,o.relativeForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeForce(IntPtr l) {
		UnityEngine.ConstantForce2D o = (UnityEngine.ConstantForce2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.relativeForce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_torque(IntPtr l) {
		UnityEngine.ConstantForce2D o = (UnityEngine.ConstantForce2D)checkSelf(l);
		pushValue(l,o.torque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_torque(IntPtr l) {
		UnityEngine.ConstantForce2D o = (UnityEngine.ConstantForce2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.torque=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ConstantForce2D");
		addMember(l,"force",get_force,set_force,true);
		addMember(l,"relativeForce",get_relativeForce,set_relativeForce,true);
		addMember(l,"torque",get_torque,set_torque,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ConstantForce2D),typeof(UnityEngine.PhysicsUpdateBehaviour2D));
	}
}
