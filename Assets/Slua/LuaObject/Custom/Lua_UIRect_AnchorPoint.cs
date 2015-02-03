using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRect_AnchorPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UIRect.AnchorPoint o;
		if(argc==1){
			o=new UIRect.AnchorPoint();
			pushObject(l,o);
			return 1;
		}
		else if(argc==2){
			System.Single a1;
			checkType(l,2,out a1);
			o=new UIRect.AnchorPoint(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UIRect.AnchorPoint self=(UIRect.AnchorPoint)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.Set(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetToNearest(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UIRect.AnchorPoint self=(UIRect.AnchorPoint)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.SetToNearest(a1,a2,a3);
				return 0;
			}
			else if(argc==6){
				UIRect.AnchorPoint self=(UIRect.AnchorPoint)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				System.Single a6;
				checkType(l,7,out a6);
				self.SetToNearest(a1,a2,a3,a4,a5,a6);
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
	static public int SetHorizontal(IntPtr l) {
		try{
			UIRect.AnchorPoint self=(UIRect.AnchorPoint)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetHorizontal(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVertical(IntPtr l) {
		try{
			UIRect.AnchorPoint self=(UIRect.AnchorPoint)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetVertical(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSides(IntPtr l) {
		try{
			UIRect.AnchorPoint self=(UIRect.AnchorPoint)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3[] ret=self.GetSides(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relative(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		pushValue(l,o.relative);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relative(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.relative=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_absolute(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		pushValue(l,o.absolute);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_absolute(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.absolute=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		pushValue(l,o.rect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rect(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		UIRect v;
		checkType(l,2,out v);
		o.rect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetCam(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		pushValue(l,o.targetCam);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetCam(IntPtr l) {
		UIRect.AnchorPoint o = (UIRect.AnchorPoint)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.targetCam=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIRect.AnchorPoint");
		addMember(l,Set);
		addMember(l,SetToNearest);
		addMember(l,SetHorizontal);
		addMember(l,SetVertical);
		addMember(l,GetSides);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"relative",get_relative,set_relative,true);
		addMember(l,"absolute",get_absolute,set_absolute,true);
		addMember(l,"rect",get_rect,set_rect,true);
		addMember(l,"targetCam",get_targetCam,set_targetCam,true);
		createTypeMetatable(l,constructor, typeof(UIRect.AnchorPoint));
	}
}
