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
			UnityEngine.OffMeshLink self=(UnityEngine.OffMeshLink)checkSelf(l);
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
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.activated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activated(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.activated=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_occupied(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.occupied);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_costOverride(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.costOverride);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_costOverride(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.costOverride=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_biDirectional(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.biDirectional);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_biDirectional(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.biDirectional=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_navMeshLayer(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.navMeshLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_navMeshLayer(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.navMeshLayer=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoUpdatePositions(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.autoUpdatePositions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoUpdatePositions(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoUpdatePositions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.startTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.startTransform=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		pushValue(l,o.endTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endTransform(IntPtr l) {
		UnityEngine.OffMeshLink o = (UnityEngine.OffMeshLink)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.endTransform=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLink");
		addMember(l,UpdatePositions);
		addMember(l,"activated",get_activated,set_activated);
		addMember(l,"occupied",get_occupied,null);
		addMember(l,"costOverride",get_costOverride,set_costOverride);
		addMember(l,"biDirectional",get_biDirectional,set_biDirectional);
		addMember(l,"navMeshLayer",get_navMeshLayer,set_navMeshLayer);
		addMember(l,"autoUpdatePositions",get_autoUpdatePositions,set_autoUpdatePositions);
		addMember(l,"startTransform",get_startTransform,set_startTransform);
		addMember(l,"endTransform",get_endTransform,set_endTransform);
		createTypeMetatable(l,constructor, typeof(UnityEngine.OffMeshLink),typeof(UnityEngine.Component));
	}
}
