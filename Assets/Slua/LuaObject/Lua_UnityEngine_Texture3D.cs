using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Texture3D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Texture3D o;
		System.Int32 a1;
		checkType(l,2,out a1);
		System.Int32 a2;
		checkType(l,3,out a2);
		System.Int32 a3;
		checkType(l,4,out a3);
		UnityEngine.TextureFormat a4;
		checkEnum(l,5,out a4);
		System.Boolean a5;
		checkType(l,6,out a5);
		o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixels(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color[] ret=self.GetPixels(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color[] ret=self.GetPixels();
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
	static public int SetPixels(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetPixels(a1,a2);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				self.SetPixels(a1);
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
	static public int Apply(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Apply(a1);
				return 0;
			}
			else if(argc==1){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				self.Apply();
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
	static public int get_depth(IntPtr l) {
		UnityEngine.Texture3D o = (UnityEngine.Texture3D)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		UnityEngine.Texture3D o = (UnityEngine.Texture3D)checkSelf(l);
		pushEnum(l,(int)o.format);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture3D");
		addMember(l,GetPixels);
		addMember(l,SetPixels);
		addMember(l,Apply);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"format",get_format,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Texture3D),typeof(UnityEngine.Texture));
	}
}
