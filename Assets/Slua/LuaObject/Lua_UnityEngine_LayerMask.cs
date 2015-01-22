using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LayerMask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LayerToName_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.String ret=UnityEngine.LayerMask.LayerToName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NameToLayer_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.LayerMask.NameToLayer(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMask_s(IntPtr l) {
		try{
			System.String[] a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.LayerMask.GetMask(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UnityEngine.LayerMask o = (UnityEngine.LayerMask)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UnityEngine.LayerMask o = (UnityEngine.LayerMask)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.value=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LayerMask");
		addMember(l,LayerToName_s);
		addMember(l,NameToLayer_s);
		addMember(l,GetMask_s);
		addMember(l,"value",get_value,set_value);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LayerMask));
	}
}
