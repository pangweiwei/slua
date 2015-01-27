using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GraphicRegistry : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterGraphicForCanvas_s(IntPtr l) {
		try{
			UnityEngine.Canvas a1;
			checkType(l,1,out a1);
			UnityEngine.UI.Graphic a2;
			checkType(l,2,out a2);
			UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnregisterGraphicForCanvas_s(IntPtr l) {
		try{
			UnityEngine.Canvas a1;
			checkType(l,1,out a1);
			UnityEngine.UI.Graphic a2;
			checkType(l,2,out a2);
			UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGraphicsForCanvas_s(IntPtr l) {
		try{
			UnityEngine.Canvas a1;
			checkType(l,1,out a1);
			IList<UnityEngine.UI.Graphic> ret=UnityEngine.UI.GraphicRegistry.GetGraphicsForCanvas(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_instance(IntPtr l) {
		pushValue(l,UnityEngine.UI.GraphicRegistry.instance);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.GraphicRegistry");
		addMember(l,RegisterGraphicForCanvas_s);
		addMember(l,UnregisterGraphicForCanvas_s);
		addMember(l,GetGraphicsForCanvas_s);
		addMember(l,"instance",get_instance,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.GraphicRegistry));
	}
}
