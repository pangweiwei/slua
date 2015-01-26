using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GridLayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.GridLayoutGroup self=(UnityEngine.UI.GridLayoutGroup)checkSelf(l);
			self.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		try{
			UnityEngine.UI.GridLayoutGroup self=(UnityEngine.UI.GridLayoutGroup)checkSelf(l);
			self.CalculateLayoutInputVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.GridLayoutGroup self=(UnityEngine.UI.GridLayoutGroup)checkSelf(l);
			self.SetLayoutHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutVertical(IntPtr l) {
		try{
			UnityEngine.UI.GridLayoutGroup self=(UnityEngine.UI.GridLayoutGroup)checkSelf(l);
			self.SetLayoutVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startCorner(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		pushValue(l,o.startCorner);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startCorner(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		UnityEngine.UI.GridLayoutGroup.Corner v;
		checkEnum(l,2,out v);
		o.startCorner=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startAxis(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		pushValue(l,o.startAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startAxis(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		UnityEngine.UI.GridLayoutGroup.Axis v;
		checkEnum(l,2,out v);
		o.startAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cellSize(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		pushValue(l,o.cellSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cellSize(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.cellSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacing(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		pushValue(l,o.spacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacing(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.spacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraint(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		pushValue(l,o.constraint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraint(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		UnityEngine.UI.GridLayoutGroup.Constraint v;
		checkEnum(l,2,out v);
		o.constraint=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraintCount(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		pushValue(l,o.constraintCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraintCount(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = (UnityEngine.UI.GridLayoutGroup)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.constraintCount=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.GridLayoutGroup");
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		addMember(l,"startCorner",get_startCorner,set_startCorner);
		addMember(l,"startAxis",get_startAxis,set_startAxis);
		addMember(l,"cellSize",get_cellSize,set_cellSize);
		addMember(l,"spacing",get_spacing,set_spacing);
		addMember(l,"constraint",get_constraint,set_constraint);
		addMember(l,"constraintCount",get_constraintCount,set_constraintCount);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.GridLayoutGroup),typeof(UnityEngine.UI.LayoutGroup));
	}
}
