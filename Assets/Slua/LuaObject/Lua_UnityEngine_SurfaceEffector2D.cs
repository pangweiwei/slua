using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SurfaceEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.SurfaceEffector2D o;
		o=new UnityEngine.SurfaceEffector2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		UnityEngine.SurfaceEffector2D o = (UnityEngine.SurfaceEffector2D)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		UnityEngine.SurfaceEffector2D o = (UnityEngine.SurfaceEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speedVariation(IntPtr l) {
		UnityEngine.SurfaceEffector2D o = (UnityEngine.SurfaceEffector2D)checkSelf(l);
		pushValue(l,o.speedVariation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speedVariation(IntPtr l) {
		UnityEngine.SurfaceEffector2D o = (UnityEngine.SurfaceEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.speedVariation=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SurfaceEffector2D");
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"speedVariation",get_speedVariation,set_speedVariation,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SurfaceEffector2D),typeof(UnityEngine.Effector2D));
	}
}
