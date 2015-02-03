using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ExampleDragDropSurface : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		ExampleDragDropSurface o;
		o=new ExampleDragDropSurface();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotatePlacedObject(IntPtr l) {
		ExampleDragDropSurface o = (ExampleDragDropSurface)checkSelf(l);
		pushValue(l,o.rotatePlacedObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotatePlacedObject(IntPtr l) {
		ExampleDragDropSurface o = (ExampleDragDropSurface)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.rotatePlacedObject=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ExampleDragDropSurface");
		addMember(l,"rotatePlacedObject",get_rotatePlacedObject,set_rotatePlacedObject,true);
		createTypeMetatable(l,constructor, typeof(ExampleDragDropSurface),typeof(UnityEngine.MonoBehaviour));
	}
}
