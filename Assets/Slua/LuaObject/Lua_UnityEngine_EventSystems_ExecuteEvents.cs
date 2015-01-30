using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_ExecuteEvents : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
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
		addMember(l,"pointerEnterHandler",get_pointerEnterHandler,null,true);
		addMember(l,"pointerExitHandler",get_pointerExitHandler,null,true);
		addMember(l,"pointerDownHandler",get_pointerDownHandler,null,true);
		addMember(l,"pointerUpHandler",get_pointerUpHandler,null,true);
		addMember(l,"pointerClickHandler",get_pointerClickHandler,null,true);
		addMember(l,"initializePotentialDrag",get_initializePotentialDrag,null,true);
		addMember(l,"beginDragHandler",get_beginDragHandler,null,true);
		addMember(l,"dragHandler",get_dragHandler,null,true);
		addMember(l,"endDragHandler",get_endDragHandler,null,true);
		addMember(l,"dropHandler",get_dropHandler,null,true);
		addMember(l,"scrollHandler",get_scrollHandler,null,true);
		addMember(l,"updateSelectedHandler",get_updateSelectedHandler,null,true);
		addMember(l,"selectHandler",get_selectHandler,null,true);
		addMember(l,"deselectHandler",get_deselectHandler,null,true);
		addMember(l,"moveHandler",get_moveHandler,null,true);
		addMember(l,"submitHandler",get_submitHandler,null,true);
		addMember(l,"cancelHandler",get_cancelHandler,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.ExecuteEvents));
	}
}
