using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LODGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LODGroup o;
		if(matchType(l,1)){
			o=new UnityEngine.LODGroup();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RecalculateBounds(IntPtr l) {
		try{
			UnityEngine.LODGroup self=checkSelf<UnityEngine.LODGroup>(l);
			self.RecalculateBounds();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLODS(IntPtr l) {
		try{
			UnityEngine.LODGroup self=checkSelf<UnityEngine.LODGroup>(l);
			UnityEngine.LOD[] a1;
			checkType(l,2,out a1);
			self.SetLODS(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceLOD(IntPtr l) {
		try{
			UnityEngine.LODGroup self=checkSelf<UnityEngine.LODGroup>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.ForceLOD(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localReferencePoint(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		pushValue(l,o.localReferencePoint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localReferencePoint(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localReferencePoint=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		System.Single v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lodCount(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		pushValue(l,o.lodCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.LODGroup o = checkSelf<UnityEngine.LODGroup>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LODGroup");
		addMember(l,RecalculateBounds, "RecalculateBounds");
		addMember(l,SetLODS, "SetLODS");
		addMember(l,ForceLOD, "ForceLOD");
		addMember(l,get_localReferencePoint, "get_localReferencePoint");
		addMember(l,set_localReferencePoint, "set_localReferencePoint");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		addMember(l,get_lodCount, "get_lodCount");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LODGroup),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
