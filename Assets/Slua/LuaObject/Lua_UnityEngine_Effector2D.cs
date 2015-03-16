using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Effector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Effector2D o;
		o=new UnityEngine.Effector2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colliderMask(IntPtr l) {
		UnityEngine.Effector2D o = (UnityEngine.Effector2D)checkSelf(l);
		pushValue(l,o.colliderMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colliderMask(IntPtr l) {
		UnityEngine.Effector2D o = (UnityEngine.Effector2D)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.colliderMask=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Effector2D");
		addMember(l,"colliderMask",get_colliderMask,set_colliderMask,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Effector2D),typeof(UnityEngine.Behaviour));
	}
}
