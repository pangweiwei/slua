using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLinkData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_valid(IntPtr l) {
		UnityEngine.OffMeshLinkData o = checkSelf<UnityEngine.OffMeshLinkData>(l);
		pushValue(l,o.valid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activated(IntPtr l) {
		UnityEngine.OffMeshLinkData o = checkSelf<UnityEngine.OffMeshLinkData>(l);
		pushValue(l,o.activated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkType(IntPtr l) {
		UnityEngine.OffMeshLinkData o = checkSelf<UnityEngine.OffMeshLinkData>(l);
		pushValue(l,o.linkType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startPos(IntPtr l) {
		UnityEngine.OffMeshLinkData o = checkSelf<UnityEngine.OffMeshLinkData>(l);
		pushValue(l,o.startPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endPos(IntPtr l) {
		UnityEngine.OffMeshLinkData o = checkSelf<UnityEngine.OffMeshLinkData>(l);
		pushValue(l,o.endPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offMeshLink(IntPtr l) {
		UnityEngine.OffMeshLinkData o = checkSelf<UnityEngine.OffMeshLinkData>(l);
		pushValue(l,o.offMeshLink);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLinkData");
		addMember(l,get_valid, "get_valid");
		addMember(l,get_activated, "get_activated");
		addMember(l,get_linkType, "get_linkType");
		addMember(l,get_startPos, "get_startPos");
		addMember(l,get_endPos, "get_endPos");
		addMember(l,get_offMeshLink, "get_offMeshLink");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.OffMeshLinkData));
		LuaDLL.lua_pop(l, 1);
	}
}
