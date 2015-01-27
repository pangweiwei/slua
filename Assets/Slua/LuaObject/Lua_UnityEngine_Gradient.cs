using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Gradient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Gradient o;
		if(matchType(l,1)){
			o=new UnityEngine.Gradient();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Evaluate(IntPtr l) {
		try{
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			UnityEngine.Color ret=self.Evaluate(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetKeys(IntPtr l) {
		try{
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			UnityEngine.GradientColorKey[] a1;
			checkType(l,2,out a1);
			UnityEngine.GradientAlphaKey[] a2;
			checkType(l,3,out a2);
			self.SetKeys(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorKeys(IntPtr l) {
		UnityEngine.Gradient o = (UnityEngine.Gradient)checkSelf(l);
		pushValue(l,o.colorKeys);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorKeys(IntPtr l) {
		UnityEngine.Gradient o = (UnityEngine.Gradient)checkSelf(l);
		UnityEngine.GradientColorKey[] v;
		checkType(l,2,out v);
		o.colorKeys=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alphaKeys(IntPtr l) {
		UnityEngine.Gradient o = (UnityEngine.Gradient)checkSelf(l);
		pushValue(l,o.alphaKeys);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alphaKeys(IntPtr l) {
		UnityEngine.Gradient o = (UnityEngine.Gradient)checkSelf(l);
		UnityEngine.GradientAlphaKey[] v;
		checkType(l,2,out v);
		o.alphaKeys=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Gradient");
		addMember(l,Evaluate);
		addMember(l,SetKeys);
		addMember(l,"colorKeys",get_colorKeys,set_colorKeys,true);
		addMember(l,"alphaKeys",get_alphaKeys,set_alphaKeys,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Gradient));
	}
}
