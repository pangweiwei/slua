using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Joint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Joint o;
		if(matchType(l,1)){
			o=new UnityEngine.Joint();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedBody(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.connectedBody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedBody(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		UnityEngine.Rigidbody v;
		checkType(l,2,out v);
		o.connectedBody=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_axis(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.axis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_axis(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.axis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedAnchor(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.connectedAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedAnchor(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.connectedAnchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoConfigureConnectedAnchor(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.autoConfigureConnectedAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoConfigureConnectedAnchor(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.autoConfigureConnectedAnchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_breakForce(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.breakForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_breakForce(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.breakForce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_breakTorque(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.breakTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_breakTorque(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.breakTorque=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableCollision(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		pushValue(l,o.enableCollision);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableCollision(IntPtr l) {
		UnityEngine.Joint o = (UnityEngine.Joint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enableCollision=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint");
		addMember(l,"connectedBody",get_connectedBody,set_connectedBody);
		addMember(l,"axis",get_axis,set_axis);
		addMember(l,"anchor",get_anchor,set_anchor);
		addMember(l,"connectedAnchor",get_connectedAnchor,set_connectedAnchor);
		addMember(l,"autoConfigureConnectedAnchor",get_autoConfigureConnectedAnchor,set_autoConfigureConnectedAnchor);
		addMember(l,"breakForce",get_breakForce,set_breakForce);
		addMember(l,"breakTorque",get_breakTorque,set_breakTorque);
		addMember(l,"enableCollision",get_enableCollision,set_enableCollision);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Joint),typeof(UnityEngine.Component));
	}
}
