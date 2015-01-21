using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointDrive : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		pushValue(l,o.mode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		UnityEngine.JointDriveMode v;
		checkEnum(l,2,out v);
		o.mode=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionSpring(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		pushValue(l,o.positionSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionSpring(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.positionSpring=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionDamper(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		pushValue(l,o.positionDamper);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionDamper(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.positionDamper=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumForce(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		pushValue(l,o.maximumForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumForce(IntPtr l) {
		UnityEngine.JointDrive o = (UnityEngine.JointDrive)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maximumForce=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointDrive");
		addMember(l,"mode",get_mode,set_mode);
		addMember(l,"positionSpring",get_positionSpring,set_positionSpring);
		addMember(l,"positionDamper",get_positionDamper,set_positionDamper);
		addMember(l,"maximumForce",get_maximumForce,set_maximumForce);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointDrive));
	}
}
