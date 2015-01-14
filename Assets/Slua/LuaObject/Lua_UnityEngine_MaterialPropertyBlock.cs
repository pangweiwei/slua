using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MaterialPropertyBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MaterialPropertyBlock o;
		if(matchType(l,1)){
			o=new UnityEngine.MaterialPropertyBlock();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddFloat(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Single))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.AddFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Single))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.AddFloat(a1,a2);
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
	static public int AddVector(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Vector4))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.AddVector(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Vector4))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.AddVector(a1,a2);
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
	static public int AddColor(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Color))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.AddColor(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Color))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.AddColor(a1,a2);
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
	static public int AddMatrix(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.AddMatrix(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.AddMatrix(a1,a2);
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
	static public int AddTexture(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Texture))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.AddTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Texture))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.AddTexture(a1,a2);
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
	static public int GetFloat(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
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
	static public int GetVector(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 ret=self.GetVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 ret=self.GetVector(a1);
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
	static public int GetMatrix(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 ret=self.GetMatrix(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 ret=self.GetMatrix(a1);
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
	static public int GetTexture(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture ret=self.GetTexture(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Texture ret=self.GetTexture(a1);
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
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.MaterialPropertyBlock self=checkSelf<UnityEngine.MaterialPropertyBlock>(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MaterialPropertyBlock");
		addMember(l,AddFloat, "AddFloat");
		addMember(l,AddVector, "AddVector");
		addMember(l,AddColor, "AddColor");
		addMember(l,AddMatrix, "AddMatrix");
		addMember(l,AddTexture, "AddTexture");
		addMember(l,GetFloat, "GetFloat");
		addMember(l,GetVector, "GetVector");
		addMember(l,GetMatrix, "GetMatrix");
		addMember(l,GetTexture, "GetTexture");
		addMember(l,Clear, "Clear");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.MaterialPropertyBlock));
		LuaDLL.lua_pop(l, 1);
	}
}
