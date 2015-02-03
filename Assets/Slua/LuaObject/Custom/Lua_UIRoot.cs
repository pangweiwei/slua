using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRoot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIRoot o;
		o=new UIRoot();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixelSizeAdjustment(IntPtr l) {
		try{
			UIRoot self=(UIRoot)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetPixelSizeAdjustment(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixelSizeAdjustment_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Single ret=UIRoot.GetPixelSizeAdjustment(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Broadcast_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				UIRoot.Broadcast(a1);
				return 0;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Object a2;
				checkType(l,2,out a2);
				UIRoot.Broadcast(a1,a2);
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
	static public int get_list(IntPtr l) {
		pushValue(l,UIRoot.list);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_list(IntPtr l) {
		System.Collections.Generic.List<UIRoot> v;
		checkType(l,2,out v);
		UIRoot.list=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scalingStyle(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		pushEnum(l,(int)o.scalingStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scalingStyle(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		UIRoot.Scaling v;
		checkEnum(l,2,out v);
		o.scalingStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_manualHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		pushValue(l,o.manualHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_manualHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.manualHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minimumHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		pushValue(l,o.minimumHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minimumHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.minimumHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		pushValue(l,o.maximumHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maximumHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeHeight(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		pushValue(l,o.activeHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSizeAdjustment(IntPtr l) {
		UIRoot o = (UIRoot)checkSelf(l);
		pushValue(l,o.pixelSizeAdjustment);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIRoot");
		addMember(l,GetPixelSizeAdjustment);
		addMember(l,GetPixelSizeAdjustment_s);
		addMember(l,Broadcast_s);
		addMember(l,"list",get_list,set_list,false);
		addMember(l,"scalingStyle",get_scalingStyle,set_scalingStyle,true);
		addMember(l,"manualHeight",get_manualHeight,set_manualHeight,true);
		addMember(l,"minimumHeight",get_minimumHeight,set_minimumHeight,true);
		addMember(l,"maximumHeight",get_maximumHeight,set_maximumHeight,true);
		addMember(l,"activeHeight",get_activeHeight,null,true);
		addMember(l,"pixelSizeAdjustment",get_pixelSizeAdjustment,null,true);
		createTypeMetatable(l,constructor, typeof(UIRoot),typeof(UnityEngine.MonoBehaviour));
	}
}
