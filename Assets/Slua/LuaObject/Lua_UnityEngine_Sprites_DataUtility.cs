using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Sprites_DataUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Sprites.DataUtility o;
		o=new UnityEngine.Sprites.DataUtility();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInnerUV_s(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=UnityEngine.Sprites.DataUtility.GetInnerUV(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOuterUV_s(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=UnityEngine.Sprites.DataUtility.GetOuterUV(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPadding_s(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=UnityEngine.Sprites.DataUtility.GetPadding(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMinSize_s(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 ret=UnityEngine.Sprites.DataUtility.GetMinSize(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Sprites.DataUtility");
		addMember(l,GetInnerUV_s);
		addMember(l,GetOuterUV_s);
		addMember(l,GetPadding_s);
		addMember(l,GetMinSize_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Sprites.DataUtility));
	}
}
