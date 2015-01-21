using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WheelHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collider(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		UnityEngine.Collider v;
		checkType(l,2,out v);
		o.collider=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_point(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.point=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forwardDir(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.forwardDir);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forwardDir(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.forwardDir=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sidewaysDir(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.sidewaysDir);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sidewaysDir(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.sidewaysDir=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.force=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forwardSlip(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.forwardSlip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forwardSlip(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.forwardSlip=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sidewaysSlip(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		pushValue(l,o.sidewaysSlip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sidewaysSlip(IntPtr l) {
		UnityEngine.WheelHit o = (UnityEngine.WheelHit)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.sidewaysSlip=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelHit");
		addMember(l,"collider",get_collider,set_collider);
		addMember(l,"point",get_point,set_point);
		addMember(l,"normal",get_normal,set_normal);
		addMember(l,"forwardDir",get_forwardDir,set_forwardDir);
		addMember(l,"sidewaysDir",get_sidewaysDir,set_sidewaysDir);
		addMember(l,"force",get_force,set_force);
		addMember(l,"forwardSlip",get_forwardSlip,set_forwardSlip);
		addMember(l,"sidewaysSlip",get_sidewaysSlip,set_sidewaysSlip);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WheelHit));
	}
}
