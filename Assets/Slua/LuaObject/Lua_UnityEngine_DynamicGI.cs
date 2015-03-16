using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DynamicGI : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.DynamicGI o;
		o=new UnityEngine.DynamicGI();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEmissive_s(IntPtr l) {
		try{
			UnityEngine.Renderer a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			UnityEngine.DynamicGI.SetEmissive(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateMaterials_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Renderer))){
				UnityEngine.Renderer a1;
				checkType(l,1,out a1);
				UnityEngine.DynamicGI.UpdateMaterials(a1);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Terrain))){
				UnityEngine.Terrain a1;
				checkType(l,1,out a1);
				UnityEngine.DynamicGI.UpdateMaterials(a1);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Terrain a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.DynamicGI.UpdateMaterials(a1,a2,a3,a4,a5);
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
	static public int UpdateEnvironment_s(IntPtr l) {
		try{
			UnityEngine.DynamicGI.UpdateEnvironment();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indirectScale(IntPtr l) {
		pushValue(l,UnityEngine.DynamicGI.indirectScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_indirectScale(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.DynamicGI.indirectScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateThreshold(IntPtr l) {
		pushValue(l,UnityEngine.DynamicGI.updateThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateThreshold(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.DynamicGI.updateThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_synchronousMode(IntPtr l) {
		pushValue(l,UnityEngine.DynamicGI.synchronousMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_synchronousMode(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.DynamicGI.synchronousMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DynamicGI");
		addMember(l,SetEmissive_s);
		addMember(l,UpdateMaterials_s);
		addMember(l,UpdateEnvironment_s);
		addMember(l,"indirectScale",get_indirectScale,set_indirectScale,false);
		addMember(l,"updateThreshold",get_updateThreshold,set_updateThreshold,false);
		addMember(l,"synchronousMode",get_synchronousMode,set_synchronousMode,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.DynamicGI));
	}
}
