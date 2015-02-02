using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_AxisEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.EventSystems.AxisEventData o;
		UnityEngine.EventSystems.EventSystem a1;
		checkType(l,2,out a1);
		o=new UnityEngine.EventSystems.AxisEventData(a1);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveVector(IntPtr l) {
		UnityEngine.EventSystems.AxisEventData o = (UnityEngine.EventSystems.AxisEventData)checkSelf(l);
		pushValue(l,o.moveVector);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_moveVector(IntPtr l) {
		UnityEngine.EventSystems.AxisEventData o = (UnityEngine.EventSystems.AxisEventData)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.moveVector=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveDir(IntPtr l) {
		UnityEngine.EventSystems.AxisEventData o = (UnityEngine.EventSystems.AxisEventData)checkSelf(l);
		pushEnum(l,(int)o.moveDir);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_moveDir(IntPtr l) {
		UnityEngine.EventSystems.AxisEventData o = (UnityEngine.EventSystems.AxisEventData)checkSelf(l);
		UnityEngine.EventSystems.MoveDirection v;
		checkEnum(l,2,out v);
		o.moveDir=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.AxisEventData");
		addMember(l,"moveVector",get_moveVector,set_moveVector,true);
		addMember(l,"moveDir",get_moveDir,set_moveDir,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.AxisEventData),typeof(UnityEngine.EventSystems.BaseEventData));
	}
}
