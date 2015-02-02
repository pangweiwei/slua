using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Event : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.Event o;
		if(argc==1){
			o=new UnityEngine.Event();
			pushObject(l,o);
			return 1;
		}
		else if(argc==2){
			UnityEngine.Event a1;
			checkType(l,2,out a1);
			o=new UnityEngine.Event(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTypeForControl(IntPtr l) {
		try{
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.EventType ret=self.GetTypeForControl(a1);
			pushEnum(l,(int)ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Use(IntPtr l) {
		try{
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			self.Use();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PopEvent_s(IntPtr l) {
		try{
			UnityEngine.Event a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Event.PopEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetEventCount_s(IntPtr l) {
		try{
			System.Int32 ret=UnityEngine.Event.GetEventCount();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int KeyboardEvent_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Event ret=UnityEngine.Event.KeyboardEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawType(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushEnum(l,(int)o.rawType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushEnum(l,(int)o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		UnityEngine.EventType v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePosition(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.mousePosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mousePosition(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.mousePosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.delta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.delta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_button(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.button);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_button(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.button=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifiers(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushEnum(l,(int)o.modifiers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modifiers(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		UnityEngine.EventModifiers v;
		checkEnum(l,2,out v);
		o.modifiers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressure(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.pressure);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressure(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.pressure=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickCount(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.clickCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickCount(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.clickCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_character(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.character);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_character(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		System.Char v;
		checkType(l,2,out v);
		o.character=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_commandName(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.commandName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_commandName(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.commandName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyCode(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushEnum(l,(int)o.keyCode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyCode(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		o.keyCode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shift(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.shift);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shift(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.shift=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_control(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.control);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_control(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.control=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alt(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.alt);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alt(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.alt=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_command(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.command);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_command(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.command=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_capsLock(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.capsLock);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_capsLock(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.capsLock=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numeric(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.numeric);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numeric(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.numeric=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionKey(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.functionKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UnityEngine.Event.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UnityEngine.Event v;
		checkType(l,2,out v);
		UnityEngine.Event.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKey(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.isKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMouse(IntPtr l) {
		UnityEngine.Event o = (UnityEngine.Event)checkSelf(l);
		pushValue(l,o.isMouse);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Event");
		addMember(l,GetTypeForControl);
		addMember(l,Use);
		addMember(l,PopEvent_s);
		addMember(l,GetEventCount_s);
		addMember(l,KeyboardEvent_s);
		addMember(l,"rawType",get_rawType,null,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"mousePosition",get_mousePosition,set_mousePosition,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"button",get_button,set_button,true);
		addMember(l,"modifiers",get_modifiers,set_modifiers,true);
		addMember(l,"pressure",get_pressure,set_pressure,true);
		addMember(l,"clickCount",get_clickCount,set_clickCount,true);
		addMember(l,"character",get_character,set_character,true);
		addMember(l,"commandName",get_commandName,set_commandName,true);
		addMember(l,"keyCode",get_keyCode,set_keyCode,true);
		addMember(l,"shift",get_shift,set_shift,true);
		addMember(l,"control",get_control,set_control,true);
		addMember(l,"alt",get_alt,set_alt,true);
		addMember(l,"command",get_command,set_command,true);
		addMember(l,"capsLock",get_capsLock,set_capsLock,true);
		addMember(l,"numeric",get_numeric,set_numeric,true);
		addMember(l,"functionKey",get_functionKey,null,true);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"isKey",get_isKey,null,true);
		addMember(l,"isMouse",get_isMouse,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Event));
	}
}
