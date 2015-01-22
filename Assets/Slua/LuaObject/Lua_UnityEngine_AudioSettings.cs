using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioSettings o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioSettings();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDSPBufferSize_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.AudioSettings.SetDSPBufferSize(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDSPBufferSize_s(IntPtr l) {
		try{
			System.Int32 a1;
			System.Int32 a2;
			UnityEngine.AudioSettings.GetDSPBufferSize(out a1,out a2);
			pushValue(l,a1);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_driverCaps(IntPtr l) {
		pushValue(l,UnityEngine.AudioSettings.driverCaps);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speakerMode(IntPtr l) {
		pushValue(l,UnityEngine.AudioSettings.speakerMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speakerMode(IntPtr l) {
		UnityEngine.AudioSpeakerMode v;
		checkEnum(l,2,out v);
		UnityEngine.AudioSettings.speakerMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dspTime(IntPtr l) {
		pushValue(l,UnityEngine.AudioSettings.dspTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_outputSampleRate(IntPtr l) {
		pushValue(l,UnityEngine.AudioSettings.outputSampleRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_outputSampleRate(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.AudioSettings.outputSampleRate=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioSettings");
		addMember(l,SetDSPBufferSize_s);
		addMember(l,GetDSPBufferSize_s);
		addMember(l,"driverCaps",get_driverCaps,null);
		addMember(l,"speakerMode",get_speakerMode,set_speakerMode);
		addMember(l,"dspTime",get_dspTime,null);
		addMember(l,"outputSampleRate",get_outputSampleRate,set_outputSampleRate);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioSettings));
	}
}
