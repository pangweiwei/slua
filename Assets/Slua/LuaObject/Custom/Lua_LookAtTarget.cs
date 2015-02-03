using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LookAtTarget : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LookAtTarget o;
		o=new LookAtTarget();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_level(IntPtr l) {
		LookAtTarget o = (LookAtTarget)checkSelf(l);
		pushValue(l,o.level);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_level(IntPtr l) {
		LookAtTarget o = (LookAtTarget)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.level=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		LookAtTarget o = (LookAtTarget)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		LookAtTarget o = (LookAtTarget)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		LookAtTarget o = (LookAtTarget)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		LookAtTarget o = (LookAtTarget)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LookAtTarget");
		addMember(l,"level",get_level,set_level,true);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"speed",get_speed,set_speed,true);
		createTypeMetatable(l,constructor, typeof(LookAtTarget),typeof(UnityEngine.MonoBehaviour));
	}
}
