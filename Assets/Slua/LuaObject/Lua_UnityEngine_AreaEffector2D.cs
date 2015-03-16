using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AreaEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AreaEffector2D o;
		o=new UnityEngine.AreaEffector2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forceDirection(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		pushValue(l,o.forceDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forceDirection(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.forceDirection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forceMagnitude(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		pushValue(l,o.forceMagnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forceMagnitude(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.forceMagnitude=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forceVariation(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		pushValue(l,o.forceVariation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forceVariation(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.forceVariation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drag(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		pushValue(l,o.drag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drag(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.drag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularDrag(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		pushValue(l,o.angularDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularDrag(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularDrag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forceTarget(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		pushEnum(l,(int)o.forceTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forceTarget(IntPtr l) {
		UnityEngine.AreaEffector2D o = (UnityEngine.AreaEffector2D)checkSelf(l);
		UnityEngine.EffectorSelection2D v;
		checkEnum(l,2,out v);
		o.forceTarget=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AreaEffector2D");
		addMember(l,"forceDirection",get_forceDirection,set_forceDirection,true);
		addMember(l,"forceMagnitude",get_forceMagnitude,set_forceMagnitude,true);
		addMember(l,"forceVariation",get_forceVariation,set_forceVariation,true);
		addMember(l,"drag",get_drag,set_drag,true);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag,true);
		addMember(l,"forceTarget",get_forceTarget,set_forceTarget,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AreaEffector2D),typeof(UnityEngine.Effector2D));
	}
}
