using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanTrait : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.HumanTrait o;
		if(matchType(l,1)){
			o=new UnityEngine.HumanTrait();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MuscleFromBone(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 ret=UnityEngine.HumanTrait.MuscleFromBone(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BoneFromMuscle(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.HumanTrait.BoneFromMuscle(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RequiredBone(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.HumanTrait.RequiredBone(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMuscleDefaultMin(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.HumanTrait.GetMuscleDefaultMin(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMuscleDefaultMax(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.HumanTrait.GetMuscleDefaultMax(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_MuscleCount(IntPtr l) {
		pushValue(l,UnityEngine.HumanTrait.MuscleCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_MuscleName(IntPtr l) {
		pushValue(l,UnityEngine.HumanTrait.MuscleName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_BoneCount(IntPtr l) {
		pushValue(l,UnityEngine.HumanTrait.BoneCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_BoneName(IntPtr l) {
		pushValue(l,UnityEngine.HumanTrait.BoneName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_RequiredBoneCount(IntPtr l) {
		pushValue(l,UnityEngine.HumanTrait.RequiredBoneCount);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanTrait");
		addMember(l,MuscleFromBone, "MuscleFromBone");
		addMember(l,BoneFromMuscle, "BoneFromMuscle");
		addMember(l,RequiredBone, "RequiredBone");
		addMember(l,GetMuscleDefaultMin, "GetMuscleDefaultMin");
		addMember(l,GetMuscleDefaultMax, "GetMuscleDefaultMax");
		addMember(l,get_MuscleCount, "get_MuscleCount");
		addMember(l,get_MuscleName, "get_MuscleName");
		addMember(l,get_BoneCount, "get_BoneCount");
		addMember(l,get_BoneName, "get_BoneName");
		addMember(l,get_RequiredBoneCount, "get_RequiredBoneCount");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.HumanTrait),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
