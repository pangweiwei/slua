using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Microphone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Microphone o;
		o=new UnityEngine.Microphone();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Start_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.AudioClip ret=UnityEngine.Microphone.Start(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int End_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Microphone.End(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsRecording_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Microphone.IsRecording(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPosition_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.Microphone.GetPosition(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDeviceCaps_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			System.Int32 a3;
			UnityEngine.Microphone.GetDeviceCaps(a1,out a2,out a3);
			pushValue(l,a2);
			pushValue(l,a3);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_devices(IntPtr l) {
		pushValue(l,UnityEngine.Microphone.devices);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Microphone");
		addMember(l,Start_s);
		addMember(l,End_s);
		addMember(l,IsRecording_s);
		addMember(l,GetPosition_s);
		addMember(l,GetDeviceCaps_s);
		addMember(l,"devices",get_devices,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Microphone));
	}
}
