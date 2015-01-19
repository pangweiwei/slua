using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GridLayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.GridLayoutGroup self=checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
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
			UnityEngine.UI.GridLayoutGroup self=checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
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
			UnityEngine.UI.GridLayoutGroup self=checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
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
			UnityEngine.UI.GridLayoutGroup self=checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
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
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		pushValue(l,o.startCorner);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startCorner(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		UnityEngine.UI.GridLayoutGroup.Corner v;
		checkEnum(l,2,out v);
		o.startCorner=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startAxis(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		pushValue(l,o.startAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startAxis(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		UnityEngine.UI.GridLayoutGroup.Axis v;
		checkEnum(l,2,out v);
		o.startAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cellSize(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		pushValue(l,o.cellSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cellSize(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.cellSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacing(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		pushValue(l,o.spacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacing(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.spacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraint(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		pushValue(l,o.constraint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraint(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		UnityEngine.UI.GridLayoutGroup.Constraint v;
		checkEnum(l,2,out v);
		o.constraint=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraintCount(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		pushValue(l,o.constraintCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraintCount(IntPtr l) {
		UnityEngine.UI.GridLayoutGroup o = checkSelf<UnityEngine.UI.GridLayoutGroup>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.constraintCount=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.GridLayoutGroup");
		addMember(l,CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal");
		addMember(l,CalculateLayoutInputVertical, "CalculateLayoutInputVertical");
		addMember(l,SetLayoutHorizontal, "SetLayoutHorizontal");
		addMember(l,SetLayoutVertical, "SetLayoutVertical");
		addMember(l,get_startCorner, "get_startCorner");
		addMember(l,set_startCorner, "set_startCorner");
		addMember(l,get_startAxis, "get_startAxis");
		addMember(l,set_startAxis, "set_startAxis");
		addMember(l,get_cellSize, "get_cellSize");
		addMember(l,set_cellSize, "set_cellSize");
		addMember(l,get_spacing, "get_spacing");
		addMember(l,set_spacing, "set_spacing");
		addMember(l,get_constraint, "get_constraint");
		addMember(l,set_constraint, "set_constraint");
		addMember(l,get_constraintCount, "get_constraintCount");
		addMember(l,set_constraintCount, "set_constraintCount");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.GridLayoutGroup),typeof(UnityEngine.UI.LayoutGroup));
		LuaDLL.lua_pop(l, 1);
	}
}
