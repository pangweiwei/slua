using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Plane : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Plane o;
		if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Plane(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single))){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Plane(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Plane(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNormalAndPosition(IntPtr l) {
		try{
			UnityEngine.Plane self=(UnityEngine.Plane)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetNormalAndPosition(a1,a2);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set3Points(IntPtr l) {
		try{
			UnityEngine.Plane self=(UnityEngine.Plane)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,4,out a3);
			self.Set3Points(a1,a2,a3);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDistanceToPoint(IntPtr l) {
		try{
			UnityEngine.Plane self=(UnityEngine.Plane)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetDistanceToPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSide(IntPtr l) {
		try{
			UnityEngine.Plane self=(UnityEngine.Plane)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.GetSide(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SameSide(IntPtr l) {
		try{
			UnityEngine.Plane self=(UnityEngine.Plane)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.SameSide(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.Plane self=(UnityEngine.Plane)checkSelf(l);
			UnityEngine.Ray a1;
			checkType(l,2,out a1);
			System.Single a2;
			System.Boolean ret=self.Raycast(a1,out a2);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.Plane o = (UnityEngine.Plane)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.Plane o = (UnityEngine.Plane)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.Plane o = (UnityEngine.Plane)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.Plane o = (UnityEngine.Plane)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Plane");
		addMember(l,SetNormalAndPosition);
		addMember(l,Set3Points);
		addMember(l,GetDistanceToPoint);
		addMember(l,GetSide);
		addMember(l,SameSide);
		addMember(l,Raycast);
		addMember(l,"normal",get_normal,set_normal);
		addMember(l,"distance",get_distance,set_distance);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Plane));
	}
}
