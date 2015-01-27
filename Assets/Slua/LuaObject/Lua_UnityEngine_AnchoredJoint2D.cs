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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = (UnityEngine.AnchoredJoint2D)checkSelf(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = (UnityEngine.AnchoredJoint2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedAnchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = (UnityEngine.AnchoredJoint2D)checkSelf(l);
		pushValue(l,o.connectedAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedAnchor(IntPtr l) {
		UnityEngine.AnchoredJoint2D o = (UnityEngine.AnchoredJoint2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.connectedAnchor=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnchoredJoint2D");
		addMember(l,"anchor",get_anchor,set_anchor,true);
		addMember(l,"connectedAnchor",get_connectedAnchor,set_connectedAnchor,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnchoredJoint2D),typeof(UnityEngine.Joint2D));
	}
}
