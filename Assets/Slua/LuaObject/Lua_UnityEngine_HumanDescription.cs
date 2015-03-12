using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanDescription : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_human(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.human);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_human(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		UnityEngine.HumanBone[] v;
		checkType(l,2,out v);
		o.human=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_skeleton(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.skeleton);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_skeleton(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		UnityEngine.SkeletonBone[] v;
		checkType(l,2,out v);
		o.skeleton=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_upperArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.upperArmTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_upperArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.upperArmTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowerArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.lowerArmTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowerArmTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lowerArmTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_upperLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.upperLegTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_upperLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.upperLegTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowerLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.lowerLegTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowerLegTwist(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lowerLegTwist=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_armStretch(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.armStretch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_armStretch(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.armStretch=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_legStretch(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.legStretch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_legStretch(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.legStretch=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_feetSpacing(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		pushValue(l,o.feetSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_feetSpacing(IntPtr l) {
		UnityEngine.HumanDescription o = (UnityEngine.HumanDescription)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.feetSpacing=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanDescription");
		addMember(l,"human",get_human,set_human,true);
		addMember(l,"skeleton",get_skeleton,set_skeleton,true);
		addMember(l,"upperArmTwist",get_upperArmTwist,set_upperArmTwist,true);
		addMember(l,"lowerArmTwist",get_lowerArmTwist,set_lowerArmTwist,true);
		addMember(l,"upperLegTwist",get_upperLegTwist,set_upperLegTwist,true);
		addMember(l,"lowerLegTwist",get_lowerLegTwist,set_lowerLegTwist,true);
		addMember(l,"armStretch",get_armStretch,set_armStretch,true);
		addMember(l,"legStretch",get_legStretch,set_legStretch,true);
		addMember(l,"feetSpacing",get_feetSpacing,set_feetSpacing,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanDescription));
	}
}
