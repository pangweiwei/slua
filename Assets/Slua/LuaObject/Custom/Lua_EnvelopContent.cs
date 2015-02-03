using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EnvelopContent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		EnvelopContent o;
		o=new EnvelopContent();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Execute(IntPtr l) {
		try{
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			self.Execute();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRoot(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		pushValue(l,o.targetRoot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRoot(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.targetRoot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padLeft(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		pushValue(l,o.padLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padLeft(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.padLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padRight(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		pushValue(l,o.padRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padRight(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.padRight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padBottom(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		pushValue(l,o.padBottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padBottom(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.padBottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padTop(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		pushValue(l,o.padTop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padTop(IntPtr l) {
		EnvelopContent o = (EnvelopContent)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.padTop=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EnvelopContent");
		addMember(l,Execute);
		addMember(l,"targetRoot",get_targetRoot,set_targetRoot,true);
		addMember(l,"padLeft",get_padLeft,set_padLeft,true);
		addMember(l,"padRight",get_padRight,set_padRight,true);
		addMember(l,"padBottom",get_padBottom,set_padBottom,true);
		addMember(l,"padTop",get_padTop,set_padTop,true);
		createTypeMetatable(l,constructor, typeof(EnvelopContent),typeof(UnityEngine.MonoBehaviour));
	}
}
