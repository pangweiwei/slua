using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AssetBundleManifest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AssetBundleManifest o;
		o=new UnityEngine.AssetBundleManifest();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllAssetBundles(IntPtr l) {
		try{
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String[] ret=self.GetAllAssetBundles();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllAssetBundlesWithVariant(IntPtr l) {
		try{
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String[] ret=self.GetAllAssetBundlesWithVariant();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAssetBundleHash(IntPtr l) {
		try{
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Hash128 ret=self.GetAssetBundleHash(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDirectDependencies(IntPtr l) {
		try{
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String[] ret=self.GetDirectDependencies(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllDependencies(IntPtr l) {
		try{
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String[] ret=self.GetAllDependencies(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundleManifest");
		addMember(l,GetAllAssetBundles);
		addMember(l,GetAllAssetBundlesWithVariant);
		addMember(l,GetAssetBundleHash);
		addMember(l,GetDirectDependencies);
		addMember(l,GetAllDependencies);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundleManifest),typeof(UnityEngine.Object));
	}
}
