using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DistanceJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.DistanceJoint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.DistanceJoint2D();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionForce(IntPtr l) {
		try{
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetReactionForce(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionTorque(IntPtr l) {
		try{
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetReactionTorque(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.DistanceJoint2D o = (UnityEngine.DistanceJoint2D)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.DistanceJoint2D o = (UnityEngine.DistanceJoint2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.distance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistanceOnly(IntPtr l) {
		UnityEngine.DistanceJoint2D o = (UnityEngine.DistanceJoint2D)checkSelf(l);
		pushValue(l,o.maxDistanceOnly);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistanceOnly(IntPtr l) {
		UnityEngine.DistanceJoint2D o = (UnityEngine.DistanceJoint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.maxDistanceOnly=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DistanceJoint2D");
		addMember(l,GetReactionForce);
		addMember(l,GetReactionTorque);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"maxDistanceOnly",get_maxDistanceOnly,set_maxDistanceOnly,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.DistanceJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
