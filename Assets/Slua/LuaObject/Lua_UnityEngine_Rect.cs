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
	static public int Set(IntPtr l) {
		try{
			UnityEngine.Rect self=(UnityEngine.Rect)checkSelf(l);
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
				UnityEngine.Rect self=(UnityEngine.Rect)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Contains(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rect self=(UnityEngine.Rect)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Contains(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(System.Boolean))){
				UnityEngine.Rect self=(UnityEngine.Rect)checkSelf(l);
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
				UnityEngine.Rect self=(UnityEngine.Rect)checkSelf(l);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Overlaps(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Rect),typeof(System.Boolean))){
				UnityEngine.Rect self=(UnityEngine.Rect)checkSelf(l);
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
	static public int MinMaxRect_s(IntPtr l) {
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
	static public int NormalizedToPoint_s(IntPtr l) {
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
	static public int PointToNormalized_s(IntPtr l) {
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
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.x=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.y=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.center=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.width=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.height=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMin(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.xMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMin(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.xMin=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMin(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.yMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMin(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.yMin=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMax(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.xMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMax(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.xMax=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMax(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		pushValue(l,o.yMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMax(IntPtr l) {
		UnityEngine.Rect o = (UnityEngine.Rect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.yMax=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rect");
		addMember(l,Set);
		addMember(l,Contains);
		addMember(l,Overlaps);
		addMember(l,MinMaxRect_s);
		addMember(l,NormalizedToPoint_s);
		addMember(l,PointToNormalized_s);
		addMember(l,op_Inequality);
		addMember(l,op_Equality);
		addMember(l,"x",get_x,set_x);
		addMember(l,"y",get_y,set_y);
		addMember(l,"position",get_position,set_position);
		addMember(l,"center",get_center,set_center);
		addMember(l,"min",get_min,set_min);
		addMember(l,"max",get_max,set_max);
		addMember(l,"width",get_width,set_width);
		addMember(l,"height",get_height,set_height);
		addMember(l,"size",get_size,set_size);
		addMember(l,"xMin",get_xMin,set_xMin);
		addMember(l,"yMin",get_yMin,set_yMin);
		addMember(l,"xMax",get_xMax,set_xMax);
		addMember(l,"yMax",get_yMax,set_yMax);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rect));
	}
}
