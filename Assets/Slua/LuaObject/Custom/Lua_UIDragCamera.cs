using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragCamera o;
		o=new UIDragCamera();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_draggableCamera(IntPtr l) {
		UIDragCamera o = (UIDragCamera)checkSelf(l);
		pushValue(l,o.draggableCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_draggableCamera(IntPtr l) {
		UIDragCamera o = (UIDragCamera)checkSelf(l);
		UIDraggableCamera v;
		checkType(l,2,out v);
		o.draggableCamera=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragCamera");
		addMember(l,"draggableCamera",get_draggableCamera,set_draggableCamera,true);
		createTypeMetatable(l,constructor, typeof(UIDragCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
