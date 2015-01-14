using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BoneWeight : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.BoneWeight a1;
			checkType(l,1,out a1);
			UnityEngine.BoneWeight a2;
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
			UnityEngine.BoneWeight a1;
			checkType(l,1,out a1);
			UnityEngine.BoneWeight a2;
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
	static public int get_weight0(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.weight0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight0(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Single v;
		checkType(l,2,out v);
		o.weight0=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight1(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.weight1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight1(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Single v;
		checkType(l,2,out v);
		o.weight1=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight2(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.weight2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight2(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Single v;
		checkType(l,2,out v);
		o.weight2=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight3(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.weight3);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight3(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Single v;
		checkType(l,2,out v);
		o.weight3=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex0(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.boneIndex0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex0(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.boneIndex0=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex1(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.boneIndex1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex1(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.boneIndex1=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex2(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.boneIndex2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex2(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.boneIndex2=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex3(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		pushValue(l,o.boneIndex3);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex3(IntPtr l) {
		UnityEngine.BoneWeight o = checkSelf<UnityEngine.BoneWeight>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.boneIndex3=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BoneWeight");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,get_weight0, "get_weight0");
		addMember(l,set_weight0, "set_weight0");
		addMember(l,get_weight1, "get_weight1");
		addMember(l,set_weight1, "set_weight1");
		addMember(l,get_weight2, "get_weight2");
		addMember(l,set_weight2, "set_weight2");
		addMember(l,get_weight3, "get_weight3");
		addMember(l,set_weight3, "set_weight3");
		addMember(l,get_boneIndex0, "get_boneIndex0");
		addMember(l,set_boneIndex0, "set_boneIndex0");
		addMember(l,get_boneIndex1, "get_boneIndex1");
		addMember(l,set_boneIndex1, "set_boneIndex1");
		addMember(l,get_boneIndex2, "get_boneIndex2");
		addMember(l,set_boneIndex2, "set_boneIndex2");
		addMember(l,get_boneIndex3, "get_boneIndex3");
		addMember(l,set_boneIndex3, "set_boneIndex3");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.BoneWeight));
		LuaDLL.lua_pop(l, 1);
	}
}
