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
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetWidth(IntPtr l) {
		try{
			UnityEngine.LineRenderer self=checkSelf<UnityEngine.LineRenderer>(l);
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
			UnityEngine.LineRenderer self=checkSelf<UnityEngine.LineRenderer>(l);
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
			UnityEngine.LineRenderer self=checkSelf<UnityEngine.LineRenderer>(l);
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
			UnityEngine.LineRenderer self=checkSelf<UnityEngine.LineRenderer>(l);
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
		UnityEngine.LineRenderer o = checkSelf<UnityEngine.LineRenderer>(l);
		pushValue(l,o.useWorldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useWorldSpace(IntPtr l) {
		UnityEngine.LineRenderer o = checkSelf<UnityEngine.LineRenderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useWorldSpace=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LineRenderer");
		addMember(l,SetWidth, "SetWidth");
		addMember(l,SetColors, "SetColors");
		addMember(l,SetVertexCount, "SetVertexCount");
		addMember(l,SetPosition, "SetPosition");
		addMember(l,get_useWorldSpace, "get_useWorldSpace");
		addMember(l,set_useWorldSpace, "set_useWorldSpace");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LineRenderer),typeof(UnityEngine.Renderer));
		LuaDLL.lua_pop(l, 1);
	}
}
