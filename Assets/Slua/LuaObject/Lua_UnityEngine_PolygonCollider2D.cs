using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PolygonCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.PolygonCollider2D o;
		if(matchType(l,1)){
			o=new UnityEngine.PolygonCollider2D();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPath(IntPtr l) {
		try{
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2[] ret=self.GetPath(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPath(IntPtr l) {
		try{
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2[] a2;
			checkType(l,3,out a2);
			self.SetPath(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTotalPointCount(IntPtr l) {
		try{
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			System.Int32 ret=self.GetTotalPointCount();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreatePrimitive(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,4,out a3);
				self.CreatePrimitive(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Vector2))){
				UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				self.CreatePrimitive(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.CreatePrimitive(a1);
				return 0;
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
	static public int get_points(IntPtr l) {
		UnityEngine.PolygonCollider2D o = (UnityEngine.PolygonCollider2D)checkSelf(l);
		pushValue(l,o.points);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_points(IntPtr l) {
		UnityEngine.PolygonCollider2D o = (UnityEngine.PolygonCollider2D)checkSelf(l);
		UnityEngine.Vector2[] v;
		checkType(l,2,out v);
		o.points=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathCount(IntPtr l) {
		UnityEngine.PolygonCollider2D o = (UnityEngine.PolygonCollider2D)checkSelf(l);
		pushValue(l,o.pathCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pathCount(IntPtr l) {
		UnityEngine.PolygonCollider2D o = (UnityEngine.PolygonCollider2D)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.pathCount=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PolygonCollider2D");
		addMember(l,GetPath);
		addMember(l,SetPath);
		addMember(l,GetTotalPointCount);
		addMember(l,CreatePrimitive);
		addMember(l,"points",get_points,set_points,true);
		addMember(l,"pathCount",get_pathCount,set_pathCount,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PolygonCollider2D),typeof(UnityEngine.Collider2D));
	}
}
