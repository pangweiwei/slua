using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLinkData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_valid(IntPtr l) {
		UnityEngine.OffMeshLinkData o = (UnityEngine.OffMeshLinkData)checkSelf(l);
		pushValue(l,o.valid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activated(IntPtr l) {
		UnityEngine.OffMeshLinkData o = (UnityEngine.OffMeshLinkData)checkSelf(l);
		pushValue(l,o.activated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkType(IntPtr l) {
		UnityEngine.OffMeshLinkData o = (UnityEngine.OffMeshLinkData)checkSelf(l);
		pushValue(l,o.linkType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startPos(IntPtr l) {
		UnityEngine.OffMeshLinkData o = (UnityEngine.OffMeshLinkData)checkSelf(l);
		pushValue(l,o.startPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endPos(IntPtr l) {
		UnityEngine.OffMeshLinkData o = (UnityEngine.OffMeshLinkData)checkSelf(l);
		pushValue(l,o.endPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offMeshLink(IntPtr l) {
		UnityEngine.OffMeshLinkData o = (UnityEngine.OffMeshLinkData)checkSelf(l);
		pushValue(l,o.offMeshLink);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLinkData");
		addMember(l,"valid",get_valid,null,true);
		addMember(l,"activated",get_activated,null,true);
		addMember(l,"linkType",get_linkType,null,true);
		addMember(l,"startPos",get_startPos,null,true);
		addMember(l,"endPos",get_endPos,null,true);
		addMember(l,"offMeshLink",get_offMeshLink,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.OffMeshLinkData));
	}
}
