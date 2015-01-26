using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_AxisEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EventSystems.AxisEventData o;
		if(matchType(l,1,typeof(UnityEngine.EventSystems.EventSystem))){
			UnityEngine.EventSystems.EventSystem a1;
			checkType(l,1,out a1);
			o=new UnityEngine.EventSystems.AxisEventData(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
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
		pushValue(l,o.moveDir);
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
		addMember(l,"moveVector",get_moveVector,set_moveVector);
		addMember(l,"moveDir",get_moveDir,set_moveDir);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.AxisEventData),typeof(UnityEngine.EventSystems.BaseEventData));
	}
}
