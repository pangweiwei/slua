using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLink : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.OffMeshLink o;
		if(matchType(l,1)){
			o=new UnityEngine.OffMeshLink();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdatePositions(IntPtr l) {
		try{
			UnityEngine.OffMeshLink self=checkSelf<UnityEngine.OffMeshLink>(l);
			self.UpdatePositions();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activated(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.activated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activated(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.activated=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_occupied(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.occupied);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_costOverride(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.costOverride);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_costOverride(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		System.Single v;
		checkType(l,2,out v);
		o.costOverride=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_biDirectional(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.biDirectional);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_biDirectional(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.biDirectional=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_navMeshLayer(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.navMeshLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_navMeshLayer(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.navMeshLayer=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoUpdatePositions(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.autoUpdatePositions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoUpdatePositions(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoUpdatePositions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.startTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.startTransform=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		pushValue(l,o.endTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = checkSelf<UnityEngine.OffMeshLink>(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.endTransform=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLink");
		addMember(l,UpdatePositions, "UpdatePositions");
		addMember(l,get_activated, "get_activated");
		addMember(l,set_activated, "set_activated");
		addMember(l,get_occupied, "get_occupied");
		addMember(l,get_costOverride, "get_costOverride");
		addMember(l,set_costOverride, "set_costOverride");
		addMember(l,get_biDirectional, "get_biDirectional");
		addMember(l,set_biDirectional, "set_biDirectional");
		addMember(l,get_navMeshLayer, "get_navMeshLayer");
		addMember(l,set_navMeshLayer, "set_navMeshLayer");
		addMember(l,get_autoUpdatePositions, "get_autoUpdatePositions");
		addMember(l,set_autoUpdatePositions, "set_autoUpdatePositions");
		addMember(l,get_startTransform, "get_startTransform");
		addMember(l,set_startTransform, "set_startTransform");
		addMember(l,get_endTransform, "get_endTransform");
		addMember(l,set_endTransform, "set_endTransform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.OffMeshLink),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
