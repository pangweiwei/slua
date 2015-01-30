using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Shader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Shader o;
		if(matchType(l,1)){
			o=new UnityEngine.Shader();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Find_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Shader ret=UnityEngine.Shader.Find(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnableKeyword_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Shader.EnableKeyword(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisableKeyword_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Shader.DisableKeyword(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetGlobalColor_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(UnityEngine.Color))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Color a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalColor(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(UnityEngine.Color))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Color a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalColor(a1,a2);
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
	static public int SetGlobalVector_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(UnityEngine.Vector4))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalVector(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(UnityEngine.Vector4))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalVector(a1,a2);
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
	static public int SetGlobalFloat_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(float))){
				System.String a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(float))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloat(a1,a2);
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
	static public int SetGlobalInt_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalInt(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalInt(a1,a2);
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
	static public int SetGlobalTexture_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(UnityEngine.Texture))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(UnityEngine.Texture))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalTexture(a1,a2);
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
	static public int SetGlobalMatrix_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(string),typeof(UnityEngine.Matrix4x4))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrix(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int),typeof(UnityEngine.Matrix4x4))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrix(a1,a2);
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
	static public int SetGlobalTexGenMode_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.TexGenMode a2;
			checkEnum(l,2,out a2);
			UnityEngine.Shader.SetGlobalTexGenMode(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetGlobalTextureMatrixName_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalTextureMatrixName(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetGlobalBuffer_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalBuffer(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PropertyToID_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.Shader.PropertyToID(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WarmupAllShaders_s(IntPtr l) {
		try{
			UnityEngine.Shader.WarmupAllShaders();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isSupported(IntPtr l) {
		UnityEngine.Shader o = (UnityEngine.Shader)checkSelf(l);
		pushValue(l,o.isSupported);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumLOD(IntPtr l) {
		UnityEngine.Shader o = (UnityEngine.Shader)checkSelf(l);
		pushValue(l,o.maximumLOD);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumLOD(IntPtr l) {
		UnityEngine.Shader o = (UnityEngine.Shader)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.maximumLOD=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_globalMaximumLOD(IntPtr l) {
		pushValue(l,UnityEngine.Shader.globalMaximumLOD);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_globalMaximumLOD(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Shader.globalMaximumLOD=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderQueue(IntPtr l) {
		UnityEngine.Shader o = (UnityEngine.Shader)checkSelf(l);
		pushValue(l,o.renderQueue);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Shader");
		addMember(l,Find_s);
		addMember(l,EnableKeyword_s);
		addMember(l,DisableKeyword_s);
		addMember(l,SetGlobalColor_s);
		addMember(l,SetGlobalVector_s);
		addMember(l,SetGlobalFloat_s);
		addMember(l,SetGlobalInt_s);
		addMember(l,SetGlobalTexture_s);
		addMember(l,SetGlobalMatrix_s);
		addMember(l,SetGlobalTexGenMode_s);
		addMember(l,SetGlobalTextureMatrixName_s);
		addMember(l,SetGlobalBuffer_s);
		addMember(l,PropertyToID_s);
		addMember(l,WarmupAllShaders_s);
		addMember(l,"isSupported",get_isSupported,null,true);
		addMember(l,"maximumLOD",get_maximumLOD,set_maximumLOD,true);
		addMember(l,"globalMaximumLOD",get_globalMaximumLOD,set_globalMaximumLOD,false);
		addMember(l,"renderQueue",get_renderQueue,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Shader),typeof(UnityEngine.Object));
	}
}
