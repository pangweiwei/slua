using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GraphicRaycaster : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.UI.GraphicRaycaster self=(UnityEngine.UI.GraphicRaycaster)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			List<UnityEngine.EventSystems.RaycastResult> a2;
			checkType(l,3,out a2);
			self.Raycast(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreReversedGraphics(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		pushValue(l,o.ignoreReversedGraphics);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreReversedGraphics(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreReversedGraphics=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blockingObjects(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		pushValue(l,o.blockingObjects);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blockingObjects(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		UnityEngine.UI.GraphicRaycaster.BlockingObjects v;
		checkEnum(l,2,out v);
		o.blockingObjects=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortOrderPriority(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		pushValue(l,o.sortOrderPriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderOrderPriority(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		pushValue(l,o.renderOrderPriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventCamera(IntPtr l) {
		UnityEngine.UI.GraphicRaycaster o = (UnityEngine.UI.GraphicRaycaster)checkSelf(l);
		pushValue(l,o.eventCamera);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.GraphicRaycaster");
		addMember(l,Raycast);
		addMember(l,"ignoreReversedGraphics",get_ignoreReversedGraphics,set_ignoreReversedGraphics,true);
		addMember(l,"blockingObjects",get_blockingObjects,set_blockingObjects,true);
		addMember(l,"sortOrderPriority",get_sortOrderPriority,null,true);
		addMember(l,"renderOrderPriority",get_renderOrderPriority,null,true);
		addMember(l,"eventCamera",get_eventCamera,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.GraphicRaycaster),typeof(UnityEngine.EventSystems.BaseRaycaster));
	}
}
