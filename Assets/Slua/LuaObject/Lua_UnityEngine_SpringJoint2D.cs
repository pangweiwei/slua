using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SpringJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SpringJoint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.SpringJoint2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionForce(IntPtr l) {
		try{
			UnityEngine.SpringJoint2D self=(UnityEngine.SpringJoint2D)checkSelf(l);
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
			UnityEngine.SpringJoint2D self=(UnityEngine.SpringJoint2D)checkSelf(l);
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
		UnityEngine.SpringJoint2D o = (UnityEngine.SpringJoint2D)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.SpringJoint2D o = (UnityEngine.SpringJoint2D)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.distance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dampingRatio(IntPtr l) {
		UnityEngine.SpringJoint2D o = (UnityEngine.SpringJoint2D)checkSelf(l);
		pushValue(l,o.dampingRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dampingRatio(IntPtr l) {
		UnityEngine.SpringJoint2D o = (UnityEngine.SpringJoint2D)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.dampingRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frequency(IntPtr l) {
		UnityEngine.SpringJoint2D o = (UnityEngine.SpringJoint2D)checkSelf(l);
		pushValue(l,o.frequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frequency(IntPtr l) {
		UnityEngine.SpringJoint2D o = (UnityEngine.SpringJoint2D)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.frequency=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SpringJoint2D");
		addMember(l,GetReactionForce);
		addMember(l,GetReactionTorque);
		addMember(l,"distance",get_distance,set_distance);
		addMember(l,"dampingRatio",get_dampingRatio,set_dampingRatio);
		addMember(l,"frequency",get_frequency,set_frequency);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SpringJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
