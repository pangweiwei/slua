using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Rect o;
		if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rect(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(UnityEngine.Rect))){
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Rect(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MinMaxRect(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.Rect ret=UnityEngine.Rect.MinMaxRect(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UnityEngine.Rect self=checkSelf<UnityEngine.Rect>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.Set(a1,a2,a3,a4);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector2))){
				UnityEngine.Rect self=checkSelf<UnityEngine.Rect>(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Contains(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rect self=checkSelf<UnityEngine.Rect>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Contains(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(System.Boolean))){
				UnityEngine.Rect self=checkSelf<UnityEngine.Rect>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.Contains(a1,a2);
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
	static public int Overlaps(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Rect))){
				UnityEngine.Rect self=checkSelf<UnityEngine.Rect>(l);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Overlaps(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Rect),typeof(System.Boolean))){
				UnityEngine.Rect self=checkSelf<UnityEngine.Rect>(l);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.Overlaps(a1,a2);
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
	static public int NormalizedToPoint(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Rect.NormalizedToPoint(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PointToNormalized(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Rect.PointToNormalized(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.x=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.y=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.center=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.width=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMin(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.xMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMin(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.xMin=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMin(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.yMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMin(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.yMin=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMax(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.xMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMax(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.xMax=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMax(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		pushValue(l,o.yMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMax(IntPtr l) {
		UnityEngine.Rect o = checkSelf<UnityEngine.Rect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.yMax=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rect");
		addMember(l,MinMaxRect, "MinMaxRect");
		addMember(l,Set, "Set");
		addMember(l,Contains, "Contains");
		addMember(l,Overlaps, "Overlaps");
		addMember(l,NormalizedToPoint, "NormalizedToPoint");
		addMember(l,PointToNormalized, "PointToNormalized");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,get_x, "get_x");
		addMember(l,set_x, "set_x");
		addMember(l,get_y, "get_y");
		addMember(l,set_y, "set_y");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_min, "get_min");
		addMember(l,set_min, "set_min");
		addMember(l,get_max, "get_max");
		addMember(l,set_max, "set_max");
		addMember(l,get_width, "get_width");
		addMember(l,set_width, "set_width");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		addMember(l,get_xMin, "get_xMin");
		addMember(l,set_xMin, "set_xMin");
		addMember(l,get_yMin, "get_yMin");
		addMember(l,set_yMin, "set_yMin");
		addMember(l,get_xMax, "get_xMax");
		addMember(l,set_xMax, "set_xMax");
		addMember(l,get_yMax, "get_yMax");
		addMember(l,set_yMax, "set_yMax");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Rect));
		LuaDLL.lua_pop(l, 1);
	}
}
