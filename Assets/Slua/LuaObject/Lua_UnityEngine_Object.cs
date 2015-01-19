using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Object : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Object o;
		if(matchType(l,1)){
			o=new UnityEngine.Object();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstanceID(IntPtr l) {
		try{
			UnityEngine.Object self=checkSelf<UnityEngine.Object>(l);
			System.Int32 ret=self.GetInstanceID();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Instantiate(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Object ret=UnityEngine.Object.Instantiate(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object ret=UnityEngine.Object.Instantiate(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Destroy(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Object),typeof(System.Single))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Object.Destroy(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object.Destroy(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyImmediate(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Object),typeof(System.Boolean))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Object.DestroyImmediate(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object.DestroyImmediate(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindObjectsOfType(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.Object[] ret=UnityEngine.Object.FindObjectsOfType(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindObjectOfType(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.Object ret=UnityEngine.Object.FindObjectOfType(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DontDestroyOnLoad(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object.DontDestroyOnLoad(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyObject(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Object),typeof(System.Single))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Object.DestroyObject(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object.DestroyObject(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.Object o = checkSelf<UnityEngine.Object>(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.Object o = checkSelf<UnityEngine.Object>(l);
		System.String v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideFlags(IntPtr l) {
		UnityEngine.Object o = checkSelf<UnityEngine.Object>(l);
		pushValue(l,o.hideFlags);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideFlags(IntPtr l) {
		UnityEngine.Object o = checkSelf<UnityEngine.Object>(l);
		UnityEngine.HideFlags v;
		checkEnum(l,2,out v);
		o.hideFlags=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Object");
		addMember(l,GetInstanceID, "GetInstanceID");
		addMember(l,Instantiate, "Instantiate");
		addMember(l,Destroy, "Destroy");
		addMember(l,DestroyImmediate, "DestroyImmediate");
		addMember(l,FindObjectsOfType, "FindObjectsOfType");
		addMember(l,FindObjectOfType, "FindObjectOfType");
		addMember(l,DontDestroyOnLoad, "DontDestroyOnLoad");
		addMember(l,DestroyObject, "DestroyObject");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,get_name, "get_name");
		addMember(l,set_name, "set_name");
		addMember(l,get_hideFlags, "get_hideFlags");
		addMember(l,set_hideFlags, "set_hideFlags");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
