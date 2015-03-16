using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Display : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Activate(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
				self.Activate();
				return 0;
			}
			else if(argc==4){
				UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.Activate(a1,a2,a3);
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
	static public int SetParams(IntPtr l) {
		try{
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetParams(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRenderingResolution(IntPtr l) {
		try{
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetRenderingResolution(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiDisplayLicense_s(IntPtr l) {
		try{
			System.Boolean ret=UnityEngine.Display.MultiDisplayLicense();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RelativeMouseAt_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 ret=UnityEngine.Display.RelativeMouseAt(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_displays(IntPtr l) {
		pushValue(l,UnityEngine.Display.displays);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_displays(IntPtr l) {
		UnityEngine.Display[] v;
		checkType(l,2,out v);
		UnityEngine.Display.displays=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingWidth(IntPtr l) {
		UnityEngine.Display o = (UnityEngine.Display)checkSelf(l);
		pushValue(l,o.renderingWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingHeight(IntPtr l) {
		UnityEngine.Display o = (UnityEngine.Display)checkSelf(l);
		pushValue(l,o.renderingHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemWidth(IntPtr l) {
		UnityEngine.Display o = (UnityEngine.Display)checkSelf(l);
		pushValue(l,o.systemWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemHeight(IntPtr l) {
		UnityEngine.Display o = (UnityEngine.Display)checkSelf(l);
		pushValue(l,o.systemHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorBuffer(IntPtr l) {
		UnityEngine.Display o = (UnityEngine.Display)checkSelf(l);
		pushValue(l,o.colorBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthBuffer(IntPtr l) {
		UnityEngine.Display o = (UnityEngine.Display)checkSelf(l);
		pushValue(l,o.depthBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_main(IntPtr l) {
		pushValue(l,UnityEngine.Display.main);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Display");
		addMember(l,Activate);
		addMember(l,SetParams);
		addMember(l,SetRenderingResolution);
		addMember(l,MultiDisplayLicense_s);
		addMember(l,RelativeMouseAt_s);
		addMember(l,"displays",get_displays,set_displays,false);
		addMember(l,"renderingWidth",get_renderingWidth,null,true);
		addMember(l,"renderingHeight",get_renderingHeight,null,true);
		addMember(l,"systemWidth",get_systemWidth,null,true);
		addMember(l,"systemHeight",get_systemHeight,null,true);
		addMember(l,"colorBuffer",get_colorBuffer,null,true);
		addMember(l,"depthBuffer",get_depthBuffer,null,true);
		addMember(l,"main",get_main,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Display));
	}
}
