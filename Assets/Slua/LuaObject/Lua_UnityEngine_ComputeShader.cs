using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ComputeShader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ComputeShader o;
		if(matchType(l,1)){
			o=new UnityEngine.ComputeShader();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindKernel(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.FindKernel(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFloat(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetFloat(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInt(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInt(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVector(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetVector(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFloats(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkType(l,3,out a2);
			self.SetFloats(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInts(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32[] a2;
			checkType(l,3,out a2);
			self.SetInts(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTexture(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Texture a3;
			checkType(l,4,out a3);
			self.SetTexture(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBuffer(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			self.SetBuffer(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispatch(IntPtr l) {
		try{
			UnityEngine.ComputeShader self=checkSelf<UnityEngine.ComputeShader>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.Dispatch(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ComputeShader");
		addMember(l,FindKernel, "FindKernel");
		addMember(l,SetFloat, "SetFloat");
		addMember(l,SetInt, "SetInt");
		addMember(l,SetVector, "SetVector");
		addMember(l,SetFloats, "SetFloats");
		addMember(l,SetInts, "SetInts");
		addMember(l,SetTexture, "SetTexture");
		addMember(l,SetBuffer, "SetBuffer");
		addMember(l,Dispatch, "Dispatch");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ComputeShader),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
