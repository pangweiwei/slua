using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Bounds : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Bounds o;
		if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Bounds(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMinMax(IntPtr l) {
		try{
			UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetMinMax(a1,a2);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Encapsulate(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Encapsulate(a1);
				setBack(l,self);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Bounds))){
				UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
				UnityEngine.Bounds a1;
				checkType(l,2,out a1);
				self.Encapsulate(a1);
				setBack(l,self);
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
	static public int Expand(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Single))){
				UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Expand(a1);
				setBack(l,self);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Expand(a1);
				setBack(l,self);
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
	static public int Intersects(IntPtr l) {
		try{
			UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
			UnityEngine.Bounds a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Intersects(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try{
			UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Contains(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SqrDistance(IntPtr l) {
		try{
			UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Single ret=self.SqrDistance(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IntersectRay(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Ray))){
				UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
				UnityEngine.Ray a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.IntersectRay(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Bounds self=(UnityEngine.Bounds)checkSelf(l);
				UnityEngine.Ray a1;
				checkType(l,2,out a1);
				System.Single a2;
				System.Boolean ret=self.IntersectRay(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
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
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Bounds a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
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
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Bounds a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
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
	static public int get_center(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_extents(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		pushValue(l,o.extents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_extents(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.extents=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.Bounds o = (UnityEngine.Bounds)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Bounds");
		addMember(l,SetMinMax);
		addMember(l,Encapsulate);
		addMember(l,Expand);
		addMember(l,Intersects);
		addMember(l,Contains);
		addMember(l,SqrDistance);
		addMember(l,IntersectRay);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"center",get_center,set_center);
		addMember(l,"size",get_size,set_size);
		addMember(l,"extents",get_extents,set_extents);
		addMember(l,"min",get_min,set_min);
		addMember(l,"max",get_max,set_max);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Bounds));
	}
}
