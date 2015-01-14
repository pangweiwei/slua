using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CanvasRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.CanvasRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.CanvasRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColor(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.SetColor(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetColor(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			UnityEngine.Color ret=self.GetColor();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAlpha(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			System.Single ret=self.GetAlpha();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAlpha(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.SetAlpha(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMaterial(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Texture a2;
			checkType(l,3,out a2);
			self.SetMaterial(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMaterial(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			UnityEngine.Material ret=self.GetMaterial();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVertices(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.UIVertex),typeof(System.Int32))){
				UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
				UnityEngine.UIVertex[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetVertices(a1,a2);
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
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.CanvasRenderer self=checkSelf<UnityEngine.CanvasRenderer>(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMask(IntPtr l) {
		UnityEngine.CanvasRenderer o = checkSelf<UnityEngine.CanvasRenderer>(l);
		pushValue(l,o.isMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isMask(IntPtr l) {
		UnityEngine.CanvasRenderer o = checkSelf<UnityEngine.CanvasRenderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeDepth(IntPtr l) {
		UnityEngine.CanvasRenderer o = checkSelf<UnityEngine.CanvasRenderer>(l);
		pushValue(l,o.relativeDepth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_absoluteDepth(IntPtr l) {
		UnityEngine.CanvasRenderer o = checkSelf<UnityEngine.CanvasRenderer>(l);
		pushValue(l,o.absoluteDepth);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CanvasRenderer");
		addMember(l,SetColor, "SetColor");
		addMember(l,GetColor, "GetColor");
		addMember(l,GetAlpha, "GetAlpha");
		addMember(l,SetAlpha, "SetAlpha");
		addMember(l,SetMaterial, "SetMaterial");
		addMember(l,GetMaterial, "GetMaterial");
		addMember(l,SetVertices, "SetVertices");
		addMember(l,Clear, "Clear");
		addMember(l,get_isMask, "get_isMask");
		addMember(l,set_isMask, "set_isMask");
		addMember(l,get_relativeDepth, "get_relativeDepth");
		addMember(l,get_absoluteDepth, "get_absoluteDepth");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.CanvasRenderer),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
