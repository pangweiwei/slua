using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanDescription : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_human(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.human);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_human(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		UnityEngine.HumanBone[] v;
		checkType(l,2,out v);
		o.human=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_skeleton(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.skeleton);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_skeleton(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		UnityEngine.SkeletonBone[] v;
		checkType(l,2,out v);
		o.skeleton=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_upperArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.upperArmTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_upperArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.upperArmTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowerArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.lowerArmTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowerArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lowerArmTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_upperLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.upperLegTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_upperLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.upperLegTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowerLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.lowerLegTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowerLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lowerLegTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_armStretch(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.armStretch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_armStretch(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.armStretch=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_legStretch(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.legStretch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_legStretch(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.legStretch=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_feetSpacing(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		pushValue(l,o.feetSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_feetSpacing(IntPtr l) {
		UnityEngine.HumanDescription o = checkSelf<UnityEngine.HumanDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.feetSpacing=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanDescription");
		addMember(l,get_human, "get_human");
		addMember(l,set_human, "set_human");
		addMember(l,get_skeleton, "get_skeleton");
		addMember(l,set_skeleton, "set_skeleton");
		addMember(l,get_upperArmTwist, "get_upperArmTwist");
		addMember(l,set_upperArmTwist, "set_upperArmTwist");
		addMember(l,get_lowerArmTwist, "get_lowerArmTwist");
		addMember(l,set_lowerArmTwist, "set_lowerArmTwist");
		addMember(l,get_upperLegTwist, "get_upperLegTwist");
		addMember(l,set_upperLegTwist, "set_upperLegTwist");
		addMember(l,get_lowerLegTwist, "get_lowerLegTwist");
		addMember(l,set_lowerLegTwist, "set_lowerLegTwist");
		addMember(l,get_armStretch, "get_armStretch");
		addMember(l,set_armStretch, "set_armStretch");
		addMember(l,get_legStretch, "get_legStretch");
		addMember(l,set_legStretch, "set_legStretch");
		addMember(l,get_feetSpacing, "get_feetSpacing");
		addMember(l,set_feetSpacing, "set_feetSpacing");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.HumanDescription));
		LuaDLL.lua_pop(l, 1);
	}
}
