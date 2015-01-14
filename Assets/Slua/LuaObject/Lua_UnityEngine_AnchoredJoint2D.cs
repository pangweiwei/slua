using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnchoredJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AnchoredJoint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.AnchoredJoint2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = checkSelf<UnityEngine.AnchoredJoint2D>(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = checkSelf<UnityEngine.AnchoredJoint2D>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedAnchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = checkSelf<UnityEngine.AnchoredJoint2D>(l);
		pushValue(l,o.connectedAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedAnchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = checkSelf<UnityEngine.AnchoredJoint2D>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.connectedAnchor=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnchoredJoint2D");
		addMember(l,get_anchor, "get_anchor");
		addMember(l,set_anchor, "set_anchor");
		addMember(l,get_connectedAnchor, "get_connectedAnchor");
		addMember(l,set_connectedAnchor, "set_connectedAnchor");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnchoredJoint2D),typeof(UnityEngine.Joint2D));
		LuaDLL.lua_pop(l, 1);
	}
}
