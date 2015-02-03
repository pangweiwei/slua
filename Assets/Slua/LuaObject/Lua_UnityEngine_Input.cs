using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Input : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Input o;
		o=new UnityEngine.Input();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAxis_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Input.GetAxis(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAxisRaw_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Input.GetAxisRaw(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetButton_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetButton(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetButtonDown_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetButtonDown(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetButtonUp_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetButtonUp(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKey_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKey(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.KeyCode))){
				UnityEngine.KeyCode a1;
				checkEnum(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKey(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKeyDown_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyDown(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.KeyCode))){
				UnityEngine.KeyCode a1;
				checkEnum(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyDown(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKeyUp_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyUp(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.KeyCode))){
				UnityEngine.KeyCode a1;
				checkEnum(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyUp(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetJoystickNames_s(IntPtr l) {
		try{
			System.String[] ret=UnityEngine.Input.GetJoystickNames();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouseButton_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetMouseButton(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouseButtonDown_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetMouseButtonDown(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouseButtonUp_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetMouseButtonUp(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetInputAxes_s(IntPtr l) {
		try{
			UnityEngine.Input.ResetInputAxes();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAccelerationEvent_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.AccelerationEvent ret=UnityEngine.Input.GetAccelerationEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTouch_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Touch ret=UnityEngine.Input.GetTouch(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compensateSensors(IntPtr l) {
		pushValue(l,UnityEngine.Input.compensateSensors);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_compensateSensors(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Input.compensateSensors=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gyro(IntPtr l) {
		pushValue(l,UnityEngine.Input.gyro);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePosition(IntPtr l) {
		pushValue(l,UnityEngine.Input.mousePosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mouseScrollDelta(IntPtr l) {
		pushValue(l,UnityEngine.Input.mouseScrollDelta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePresent(IntPtr l) {
		pushValue(l,UnityEngine.Input.mousePresent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulateMouseWithTouches(IntPtr l) {
		pushValue(l,UnityEngine.Input.simulateMouseWithTouches);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulateMouseWithTouches(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Input.simulateMouseWithTouches=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anyKey(IntPtr l) {
		pushValue(l,UnityEngine.Input.anyKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anyKeyDown(IntPtr l) {
		pushValue(l,UnityEngine.Input.anyKeyDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputString(IntPtr l) {
		pushValue(l,UnityEngine.Input.inputString);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		pushValue(l,UnityEngine.Input.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_accelerationEvents(IntPtr l) {
		pushValue(l,UnityEngine.Input.accelerationEvents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_accelerationEventCount(IntPtr l) {
		pushValue(l,UnityEngine.Input.accelerationEventCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touches(IntPtr l) {
		pushValue(l,UnityEngine.Input.touches);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchCount(IntPtr l) {
		pushValue(l,UnityEngine.Input.touchCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchSupported(IntPtr l) {
		pushValue(l,UnityEngine.Input.touchSupported);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_multiTouchEnabled(IntPtr l) {
		pushValue(l,UnityEngine.Input.multiTouchEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_multiTouchEnabled(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Input.multiTouchEnabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_location(IntPtr l) {
		pushValue(l,UnityEngine.Input.location);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compass(IntPtr l) {
		pushValue(l,UnityEngine.Input.compass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceOrientation(IntPtr l) {
		pushEnum(l,(int)UnityEngine.Input.deviceOrientation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imeCompositionMode(IntPtr l) {
		pushEnum(l,(int)UnityEngine.Input.imeCompositionMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_imeCompositionMode(IntPtr l) {
		UnityEngine.IMECompositionMode v;
		checkEnum(l,2,out v);
		UnityEngine.Input.imeCompositionMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compositionString(IntPtr l) {
		pushValue(l,UnityEngine.Input.compositionString);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imeIsSelected(IntPtr l) {
		pushValue(l,UnityEngine.Input.imeIsSelected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compositionCursorPos(IntPtr l) {
		pushValue(l,UnityEngine.Input.compositionCursorPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_compositionCursorPos(IntPtr l) {
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		UnityEngine.Input.compositionCursorPos=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Input");
		addMember(l,GetAxis_s);
		addMember(l,GetAxisRaw_s);
		addMember(l,GetButton_s);
		addMember(l,GetButtonDown_s);
		addMember(l,GetButtonUp_s);
		addMember(l,GetKey_s);
		addMember(l,GetKeyDown_s);
		addMember(l,GetKeyUp_s);
		addMember(l,GetJoystickNames_s);
		addMember(l,GetMouseButton_s);
		addMember(l,GetMouseButtonDown_s);
		addMember(l,GetMouseButtonUp_s);
		addMember(l,ResetInputAxes_s);
		addMember(l,GetAccelerationEvent_s);
		addMember(l,GetTouch_s);
		addMember(l,"compensateSensors",get_compensateSensors,set_compensateSensors,false);
		addMember(l,"gyro",get_gyro,null,false);
		addMember(l,"mousePosition",get_mousePosition,null,false);
		addMember(l,"mouseScrollDelta",get_mouseScrollDelta,null,false);
		addMember(l,"mousePresent",get_mousePresent,null,false);
		addMember(l,"simulateMouseWithTouches",get_simulateMouseWithTouches,set_simulateMouseWithTouches,false);
		addMember(l,"anyKey",get_anyKey,null,false);
		addMember(l,"anyKeyDown",get_anyKeyDown,null,false);
		addMember(l,"inputString",get_inputString,null,false);
		addMember(l,"acceleration",get_acceleration,null,false);
		addMember(l,"accelerationEvents",get_accelerationEvents,null,false);
		addMember(l,"accelerationEventCount",get_accelerationEventCount,null,false);
		addMember(l,"touches",get_touches,null,false);
		addMember(l,"touchCount",get_touchCount,null,false);
		addMember(l,"touchSupported",get_touchSupported,null,false);
		addMember(l,"multiTouchEnabled",get_multiTouchEnabled,set_multiTouchEnabled,false);
		addMember(l,"location",get_location,null,false);
		addMember(l,"compass",get_compass,null,false);
		addMember(l,"deviceOrientation",get_deviceOrientation,null,false);
		addMember(l,"imeCompositionMode",get_imeCompositionMode,set_imeCompositionMode,false);
		addMember(l,"compositionString",get_compositionString,null,false);
		addMember(l,"imeIsSelected",get_imeIsSelected,null,false);
		addMember(l,"compositionCursorPos",get_compositionCursorPos,set_compositionCursorPos,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Input));
	}
}
