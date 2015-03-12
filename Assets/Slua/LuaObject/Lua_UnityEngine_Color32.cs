using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Color32 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Color32 o;
		System.Byte a1;
		checkType(l,2,out a1);
		System.Byte a2;
		checkType(l,3,out a2);
		System.Byte a3;
		checkType(l,4,out a3);
		System.Byte a4;
		checkType(l,5,out a4);
		o=new UnityEngine.Color32(a1,a2,a3,a4);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp_s(IntPtr l) {
		try{
			UnityEngine.Color32 a1;
			checkType(l,1,out a1);
			UnityEngine.Color32 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Color32 ret=UnityEngine.Color32.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_r(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		pushValue(l,o.r);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_r(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		System.Byte v;
		checkType(l,2,out v);
		o.r=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_g(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		pushValue(l,o.g);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_g(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		System.Byte v;
		checkType(l,2,out v);
		o.g=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_b(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		pushValue(l,o.b);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_b(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		System.Byte v;
		checkType(l,2,out v);
		o.b=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_a(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		pushValue(l,o.a);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_a(IntPtr l) {
		UnityEngine.Color32 o = (UnityEngine.Color32)checkSelf(l);
		System.Byte v;
		checkType(l,2,out v);
		o.a=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Color32");
		addMember(l,Lerp_s);
		addMember(l,"r",get_r,set_r,true);
		addMember(l,"g",get_g,set_g,true);
		addMember(l,"b",get_b,set_b,true);
		addMember(l,"a",get_a,set_a,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Color32));
	}
}
