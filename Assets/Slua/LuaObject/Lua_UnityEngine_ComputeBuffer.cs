using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ComputeBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ComputeBuffer o;
		if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.ComputeBuffer(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.ComputeBufferType))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.ComputeBufferType a3;
			checkEnum(l,3,out a3);
			o=new UnityEngine.ComputeBuffer(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Release(IntPtr l) {
		try{
			UnityEngine.ComputeBuffer self=(UnityEngine.ComputeBuffer)checkSelf(l);
			self.Release();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetData(IntPtr l) {
		try{
			UnityEngine.ComputeBuffer self=(UnityEngine.ComputeBuffer)checkSelf(l);
			System.Array a1;
			checkType(l,2,out a1);
			self.SetData(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetData(IntPtr l) {
		try{
			UnityEngine.ComputeBuffer self=(UnityEngine.ComputeBuffer)checkSelf(l);
			System.Array a1;
			checkType(l,2,out a1);
			self.GetData(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyCount_s(IntPtr l) {
		try{
			UnityEngine.ComputeBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.ComputeBuffer.CopyCount(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_count(IntPtr l) {
		UnityEngine.ComputeBuffer o = (UnityEngine.ComputeBuffer)checkSelf(l);
		pushValue(l,o.count);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stride(IntPtr l) {
		UnityEngine.ComputeBuffer o = (UnityEngine.ComputeBuffer)checkSelf(l);
		pushValue(l,o.stride);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ComputeBuffer");
		addMember(l,Release);
		addMember(l,SetData);
		addMember(l,GetData);
		addMember(l,CopyCount_s);
		addMember(l,"count",get_count,null,true);
		addMember(l,"stride",get_stride,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ComputeBuffer));
	}
}
