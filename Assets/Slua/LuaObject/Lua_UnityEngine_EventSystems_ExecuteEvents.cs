using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_ExecuteEvents : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ValidateEventData(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Execute(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExecuteHierarchy(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CanHandleEvent(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetEventHandler(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerEnterHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerExitHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerDownHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerUpHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerClickHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_initializePotentialDrag(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_beginDragHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endDragHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dropHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateSelectedHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deselectHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_submitHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cancelHandler(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.ExecuteEvents");
		addMember(l,ValidateEventData, "ValidateEventData");
		addMember(l,Execute, "Execute");
		addMember(l,ExecuteHierarchy, "ExecuteHierarchy");
		addMember(l,CanHandleEvent, "CanHandleEvent");
		addMember(l,GetEventHandler, "GetEventHandler");
		addMember(l,get_pointerEnterHandler, "get_pointerEnterHandler");
		addMember(l,get_pointerExitHandler, "get_pointerExitHandler");
		addMember(l,get_pointerDownHandler, "get_pointerDownHandler");
		addMember(l,get_pointerUpHandler, "get_pointerUpHandler");
		addMember(l,get_pointerClickHandler, "get_pointerClickHandler");
		addMember(l,get_initializePotentialDrag, "get_initializePotentialDrag");
		addMember(l,get_beginDragHandler, "get_beginDragHandler");
		addMember(l,get_dragHandler, "get_dragHandler");
		addMember(l,get_endDragHandler, "get_endDragHandler");
		addMember(l,get_dropHandler, "get_dropHandler");
		addMember(l,get_scrollHandler, "get_scrollHandler");
		addMember(l,get_updateSelectedHandler, "get_updateSelectedHandler");
		addMember(l,get_selectHandler, "get_selectHandler");
		addMember(l,get_deselectHandler, "get_deselectHandler");
		addMember(l,get_moveHandler, "get_moveHandler");
		addMember(l,get_submitHandler, "get_submitHandler");
		addMember(l,get_cancelHandler, "get_cancelHandler");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.ExecuteEvents));
		LuaDLL.lua_pop(l, 1);
	}
}
