using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Object : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Object o;
		o=new UnityEngine.Object();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstanceID(IntPtr l) {
		try{
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
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
	static public int Instantiate_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
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
			else if(argc==1){
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
	static public int Destroy_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Object.Destroy(a1,a2);
				return 0;
			}
			else if(argc==1){
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
	static public int DestroyImmediate_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Object.DestroyImmediate(a1,a2);
				return 0;
			}
			else if(argc==1){
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
	static public int FindObjectsOfType_s(IntPtr l) {
		try{
			System.Type a1;
			checkType(l,1,out a1);
			UnityEngine.Object[] ret=UnityEngine.Object.FindObjectsOfType(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindObjectOfType_s(IntPtr l) {
		try{
			System.Type a1;
			checkType(l,1,out a1);
			UnityEngine.Object ret=UnityEngine.Object.FindObjectOfType(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DontDestroyOnLoad_s(IntPtr l) {
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
	static public int DestroyObject_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Object.DestroyObject(a1,a2);
				return 0;
			}
			else if(argc==1){
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
		UnityEngine.Object o = (UnityEngine.Object)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.Object o = (UnityEngine.Object)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideFlags(IntPtr l) {
		UnityEngine.Object o = (UnityEngine.Object)checkSelf(l);
		pushEnum(l,(int)o.hideFlags);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideFlags(IntPtr l) {
		UnityEngine.Object o = (UnityEngine.Object)checkSelf(l);
		UnityEngine.HideFlags v;
		checkEnum(l,2,out v);
		o.hideFlags=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Object");
		addMember(l,GetInstanceID);
		addMember(l,Instantiate_s);
		addMember(l,Destroy_s);
		addMember(l,DestroyImmediate_s);
		addMember(l,FindObjectsOfType_s);
		addMember(l,FindObjectOfType_s);
		addMember(l,DontDestroyOnLoad_s);
		addMember(l,DestroyObject_s);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"hideFlags",get_hideFlags,set_hideFlags,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Object));
	}
}
