using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RectTransformUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RectangleContainsScreenPoint(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Camera a3;
			checkType(l,3,out a3);
			System.Boolean ret=UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PixelAdjustPoint(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			UnityEngine.Canvas a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 ret=UnityEngine.RectTransformUtility.PixelAdjustPoint(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PixelAdjustRect(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.Canvas a2;
			checkType(l,2,out a2);
			UnityEngine.Rect ret=UnityEngine.RectTransformUtility.PixelAdjustRect(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenPointToWorldPointInRectangle(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Camera a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			System.Boolean ret=UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(a1,a2,a3,out a4);
			pushValue(l,ret);
			pushValue(l,a4);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenPointToLocalPointInRectangle(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Camera a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 a4;
			System.Boolean ret=UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(a1,a2,a3,out a4);
			pushValue(l,ret);
			pushValue(l,a4);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenPointToRay(IntPtr l) {
		try{
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Ray ret=UnityEngine.RectTransformUtility.ScreenPointToRay(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WorldToScreenPoint(IntPtr l) {
		try{
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.RectTransformUtility.WorldToScreenPoint(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateRelativeRectTransformBounds(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Transform),typeof(UnityEngine.Transform))){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				UnityEngine.Bounds ret=UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Transform))){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Bounds ret=UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(a1);
				pushValue(l,ret);
				return 1;
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
	static public int FlipLayoutOnAxis(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			UnityEngine.RectTransformUtility.FlipLayoutOnAxis(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FlipLayoutAxes(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.RectTransformUtility.FlipLayoutAxes(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RectTransformUtility");
		addMember(l,RectangleContainsScreenPoint);
		addMember(l,PixelAdjustPoint);
		addMember(l,PixelAdjustRect);
		addMember(l,ScreenPointToWorldPointInRectangle);
		addMember(l,ScreenPointToLocalPointInRectangle);
		addMember(l,ScreenPointToRay);
		addMember(l,WorldToScreenPoint);
		addMember(l,CalculateRelativeRectTransformBounds);
		addMember(l,FlipLayoutOnAxis);
		addMember(l,FlipLayoutAxes);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RectTransformUtility));
	}
}
