using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Display : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Activate(IntPtr l) {
		try{
			UnityEngine.Display self=checkSelf<UnityEngine.Display>(l);
			self.Activate();
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
			UnityEngine.Display self=checkSelf<UnityEngine.Display>(l);
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
		UnityEngine.Display o = checkSelf<UnityEngine.Display>(l);
		pushValue(l,o.renderingWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingHeight(IntPtr l) {
		UnityEngine.Display o = checkSelf<UnityEngine.Display>(l);
		pushValue(l,o.renderingHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemWidth(IntPtr l) {
		UnityEngine.Display o = checkSelf<UnityEngine.Display>(l);
		pushValue(l,o.systemWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemHeight(IntPtr l) {
		UnityEngine.Display o = checkSelf<UnityEngine.Display>(l);
		pushValue(l,o.systemHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorBuffer(IntPtr l) {
		UnityEngine.Display o = checkSelf<UnityEngine.Display>(l);
		pushValue(l,o.colorBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthBuffer(IntPtr l) {
		UnityEngine.Display o = checkSelf<UnityEngine.Display>(l);
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
		addMember(l,Activate, "Activate");
		addMember(l,SetRenderingResolution, "SetRenderingResolution");
		addMember(l,get_displays, "get_displays");
		addMember(l,set_displays, "set_displays");
		addMember(l,get_renderingWidth, "get_renderingWidth");
		addMember(l,get_renderingHeight, "get_renderingHeight");
		addMember(l,get_systemWidth, "get_systemWidth");
		addMember(l,get_systemHeight, "get_systemHeight");
		addMember(l,get_colorBuffer, "get_colorBuffer");
		addMember(l,get_depthBuffer, "get_depthBuffer");
		addMember(l,get_main, "get_main");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Display));
		LuaDLL.lua_pop(l, 1);
	}
}
