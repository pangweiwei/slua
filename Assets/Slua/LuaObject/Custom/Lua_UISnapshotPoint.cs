using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISnapshotPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISnapshotPoint o;
		o=new UISnapshotPoint();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOrthographic(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		pushValue(l,o.isOrthographic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isOrthographic(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isOrthographic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClip(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		pushValue(l,o.nearClip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClip(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.nearClip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClip(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		pushValue(l,o.farClip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClip(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.farClip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldOfView(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		pushValue(l,o.fieldOfView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldOfView(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fieldOfView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthoSize(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		pushValue(l,o.orthoSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthoSize(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.orthoSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thumbnail(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		pushValue(l,o.thumbnail);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thumbnail(IntPtr l) {
		UISnapshotPoint o = (UISnapshotPoint)checkSelf(l);
		UnityEngine.Texture2D v;
		checkType(l,2,out v);
		o.thumbnail=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISnapshotPoint");
		addMember(l,"isOrthographic",get_isOrthographic,set_isOrthographic,true);
		addMember(l,"nearClip",get_nearClip,set_nearClip,true);
		addMember(l,"farClip",get_farClip,set_farClip,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"orthoSize",get_orthoSize,set_orthoSize,true);
		addMember(l,"thumbnail",get_thumbnail,set_thumbnail,true);
		createTypeMetatable(l,constructor, typeof(UISnapshotPoint),typeof(UnityEngine.MonoBehaviour));
	}
}
