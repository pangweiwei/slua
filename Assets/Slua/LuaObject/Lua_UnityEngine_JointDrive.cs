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
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		pushValue(l,o.mode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		UnityEngine.JointDriveMode v;
		checkEnum(l,2,out v);
		o.mode=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionSpring(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		pushValue(l,o.positionSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionSpring(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		System.Single v;
		checkType(l,2,out v);
		o.positionSpring=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionDamper(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		pushValue(l,o.positionDamper);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionDamper(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		System.Single v;
		checkType(l,2,out v);
		o.positionDamper=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumForce(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		pushValue(l,o.maximumForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumForce(IntPtr l) {
		UnityEngine.JointDrive o = checkSelf<UnityEngine.JointDrive>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maximumForce=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointDrive");
		addMember(l,get_mode, "get_mode");
		addMember(l,set_mode, "set_mode");
		addMember(l,get_positionSpring, "get_positionSpring");
		addMember(l,set_positionSpring, "set_positionSpring");
		addMember(l,get_positionDamper, "get_positionDamper");
		addMember(l,set_positionDamper, "set_positionDamper");
		addMember(l,get_maximumForce, "get_maximumForce");
		addMember(l,set_maximumForce, "set_maximumForce");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.JointDrive));
		LuaDLL.lua_pop(l, 1);
	}
}
