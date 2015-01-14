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
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.connectedBody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedBody(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		UnityEngine.Rigidbody v;
		checkType(l,2,out v);
		o.connectedBody=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_axis(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.axis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_axis(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.axis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedAnchor(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.connectedAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedAnchor(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.connectedAnchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoConfigureConnectedAnchor(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.autoConfigureConnectedAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoConfigureConnectedAnchor(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoConfigureConnectedAnchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_breakForce(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.breakForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_breakForce(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		System.Single v;
		checkType(l,2,out v);
		o.breakForce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_breakTorque(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.breakTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_breakTorque(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		System.Single v;
		checkType(l,2,out v);
		o.breakTorque=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableCollision(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		pushValue(l,o.enableCollision);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableCollision(IntPtr l) {
		UnityEngine.Joint o = checkSelf<UnityEngine.Joint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enableCollision=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint");
		addMember(l,get_connectedBody, "get_connectedBody");
		addMember(l,set_connectedBody, "set_connectedBody");
		addMember(l,get_axis, "get_axis");
		addMember(l,set_axis, "set_axis");
		addMember(l,get_anchor, "get_anchor");
		addMember(l,set_anchor, "set_anchor");
		addMember(l,get_connectedAnchor, "get_connectedAnchor");
		addMember(l,set_connectedAnchor, "set_connectedAnchor");
		addMember(l,get_autoConfigureConnectedAnchor, "get_autoConfigureConnectedAnchor");
		addMember(l,set_autoConfigureConnectedAnchor, "set_autoConfigureConnectedAnchor");
		addMember(l,get_breakForce, "get_breakForce");
		addMember(l,set_breakForce, "set_breakForce");
		addMember(l,get_breakTorque, "get_breakTorque");
		addMember(l,set_breakTorque, "set_breakTorque");
		addMember(l,get_enableCollision, "get_enableCollision");
		addMember(l,set_enableCollision, "set_enableCollision");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Joint),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
