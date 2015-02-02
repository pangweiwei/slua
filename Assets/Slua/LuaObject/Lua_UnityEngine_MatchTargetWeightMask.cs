using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MatchTargetWeightMask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o;
		UnityEngine.Vector3 a1;
		checkType(l,2,out a1);
		System.Single a2;
		checkType(l,3,out a2);
		o=new UnityEngine.MatchTargetWeightMask(a1,a2);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionXYZWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = (UnityEngine.MatchTargetWeightMask)checkSelf(l);
		pushValue(l,o.positionXYZWeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionXYZWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = (UnityEngine.MatchTargetWeightMask)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.positionXYZWeight=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = (UnityEngine.MatchTargetWeightMask)checkSelf(l);
		pushValue(l,o.rotationWeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = (UnityEngine.MatchTargetWeightMask)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.rotationWeight=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MatchTargetWeightMask");
		addMember(l,"positionXYZWeight",get_positionXYZWeight,set_positionXYZWeight,true);
		addMember(l,"rotationWeight",get_rotationWeight,set_rotationWeight,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.MatchTargetWeightMask));
	}
}
