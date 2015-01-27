using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LineRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LineRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.LineRenderer();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetWidth(IntPtr l) {
		try{
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetWidth(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColors(IntPtr l) {
		try{
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetColors(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVertexCount(IntPtr l) {
		try{
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetVertexCount(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPosition(IntPtr l) {
		try{
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetPosition(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useWorldSpace(IntPtr l) {
		UnityEngine.LineRenderer o = (UnityEngine.LineRenderer)checkSelf(l);
		pushValue(l,o.useWorldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useWorldSpace(IntPtr l) {
		UnityEngine.LineRenderer o = (UnityEngine.LineRenderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useWorldSpace=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LineRenderer");
		addMember(l,SetWidth);
		addMember(l,SetColors);
		addMember(l,SetVertexCount);
		addMember(l,SetPosition);
		addMember(l,"useWorldSpace",get_useWorldSpace,set_useWorldSpace,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LineRenderer),typeof(UnityEngine.Renderer));
	}
}
