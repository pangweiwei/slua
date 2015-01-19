using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Texture3D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Texture3D o;
		if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Boolean))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.TextureFormat a4;
			checkEnum(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixels(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Texture3D self=checkSelf<UnityEngine.Texture3D>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color[] ret=self.GetPixels(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.Texture3D self=checkSelf<UnityEngine.Texture3D>(l);
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
			if(matchType(l,2,typeof(UnityEngine.Color),typeof(System.Int32))){
				UnityEngine.Texture3D self=checkSelf<UnityEngine.Texture3D>(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetPixels(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Color))){
				UnityEngine.Texture3D self=checkSelf<UnityEngine.Texture3D>(l);
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
			if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.Texture3D self=checkSelf<UnityEngine.Texture3D>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Apply(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.Texture3D self=checkSelf<UnityEngine.Texture3D>(l);
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
		UnityEngine.Texture3D o = checkSelf<UnityEngine.Texture3D>(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		UnityEngine.Texture3D o = checkSelf<UnityEngine.Texture3D>(l);
		pushValue(l,o.format);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture3D");
		addMember(l,GetPixels, "GetPixels");
		addMember(l,SetPixels, "SetPixels");
		addMember(l,Apply, "Apply");
		addMember(l,get_depth, "get_depth");
		addMember(l,get_format, "get_format");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Texture3D),typeof(UnityEngine.Texture));
		LuaDLL.lua_pop(l, 1);
	}
}
