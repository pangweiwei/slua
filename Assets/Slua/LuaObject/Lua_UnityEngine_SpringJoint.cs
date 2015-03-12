﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SpringJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.SpringJoint o;
		o=new UnityEngine.SpringJoint();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spring(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		pushValue(l,o.spring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spring(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.spring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damper(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		pushValue(l,o.damper);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damper(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.damper=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minDistance(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		pushValue(l,o.minDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minDistance(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		pushValue(l,o.maxDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		UnityEngine.SpringJoint o = (UnityEngine.SpringJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxDistance=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SpringJoint");
		addMember(l,"spring",get_spring,set_spring,true);
		addMember(l,"damper",get_damper,set_damper,true);
		addMember(l,"minDistance",get_minDistance,set_minDistance,true);
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SpringJoint),typeof(UnityEngine.Joint));
	}
}
