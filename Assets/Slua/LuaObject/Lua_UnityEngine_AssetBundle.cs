using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AssetBundle o;
		o=new UnityEngine.AssetBundle();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try{
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Contains(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Object ret=self.Load(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				UnityEngine.Object ret=self.Load(a1,a2);
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
	static public int LoadAsync(IntPtr l) {
		try{
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			UnityEngine.AssetBundleRequest ret=self.LoadAsync(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAll(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Object[] ret=self.LoadAll(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				UnityEngine.Object[] ret=self.LoadAll();
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
	static public int Unload(IntPtr l) {
		try{
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Unload(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromMemory_s(IntPtr l) {
		try{
			System.Byte[] a1;
			checkType(l,1,out a1);
			UnityEngine.AssetBundleCreateRequest ret=UnityEngine.AssetBundle.CreateFromMemory(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromMemoryImmediate_s(IntPtr l) {
		try{
			System.Byte[] a1;
			checkType(l,1,out a1);
			UnityEngine.AssetBundle ret=UnityEngine.AssetBundle.CreateFromMemoryImmediate(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromFile_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.AssetBundle ret=UnityEngine.AssetBundle.CreateFromFile(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainAsset(IntPtr l) {
		UnityEngine.AssetBundle o = (UnityEngine.AssetBundle)checkSelf(l);
		pushValue(l,o.mainAsset);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundle");
		addMember(l,Contains);
		addMember(l,Load);
		addMember(l,LoadAsync);
		addMember(l,LoadAll);
		addMember(l,Unload);
		addMember(l,CreateFromMemory_s);
		addMember(l,CreateFromMemoryImmediate_s);
		addMember(l,CreateFromFile_s);
		addMember(l,"mainAsset",get_mainAsset,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundle),typeof(UnityEngine.Object));
	}
}
