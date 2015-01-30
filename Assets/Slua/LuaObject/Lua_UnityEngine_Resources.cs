using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Resources : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Resources o;
		if(matchType(l,1)){
			o=new UnityEngine.Resources();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindObjectsOfTypeAll_s(IntPtr l) {
		try{
			System.Type a1;
			checkType(l,1,out a1);
			UnityEngine.Object[] ret=UnityEngine.Resources.FindObjectsOfTypeAll(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Object ret=UnityEngine.Resources.Load(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(string),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.Object ret=UnityEngine.Resources.Load(a1,a2);
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
	static public int LoadAsync_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.ResourceRequest ret=UnityEngine.Resources.LoadAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(string),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.ResourceRequest ret=UnityEngine.Resources.LoadAsync(a1,a2);
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
	static public int LoadAll_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.Object[] ret=UnityEngine.Resources.LoadAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Object[] ret=UnityEngine.Resources.LoadAll(a1);
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
	static public int GetBuiltinResource_s(IntPtr l) {
		try{
			System.Type a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Object ret=UnityEngine.Resources.GetBuiltinResource(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAssetAtPath_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Type a2;
			checkType(l,2,out a2);
			UnityEngine.Object ret=UnityEngine.Resources.LoadAssetAtPath(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnloadAsset_s(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Resources.UnloadAsset(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnloadUnusedAssets_s(IntPtr l) {
		try{
			UnityEngine.AsyncOperation ret=UnityEngine.Resources.UnloadUnusedAssets();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Resources");
		addMember(l,FindObjectsOfTypeAll_s);
		addMember(l,Load_s);
		addMember(l,LoadAsync_s);
		addMember(l,LoadAll_s);
		addMember(l,GetBuiltinResource_s);
		addMember(l,LoadAssetAtPath_s);
		addMember(l,UnloadAsset_s);
		addMember(l,UnloadUnusedAssets_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Resources));
	}
}
