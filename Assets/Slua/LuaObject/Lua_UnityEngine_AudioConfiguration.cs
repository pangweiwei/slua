using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioConfiguration : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speakerMode(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		pushEnum(l,(int)o.speakerMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speakerMode(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		UnityEngine.AudioSpeakerMode v;
		checkEnum(l,2,out v);
		o.speakerMode=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dspBufferSize(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		pushValue(l,o.dspBufferSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dspBufferSize(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.dspBufferSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sampleRate(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		pushValue(l,o.sampleRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sampleRate(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.sampleRate=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numRealVoices(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		pushValue(l,o.numRealVoices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numRealVoices(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.numRealVoices=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numVirtualVoices(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		pushValue(l,o.numVirtualVoices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numVirtualVoices(IntPtr l) {
		UnityEngine.AudioConfiguration o = (UnityEngine.AudioConfiguration)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.numVirtualVoices=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioConfiguration");
		addMember(l,"speakerMode",get_speakerMode,set_speakerMode,true);
		addMember(l,"dspBufferSize",get_dspBufferSize,set_dspBufferSize,true);
		addMember(l,"sampleRate",get_sampleRate,set_sampleRate,true);
		addMember(l,"numRealVoices",get_numRealVoices,set_numRealVoices,true);
		addMember(l,"numVirtualVoices",get_numVirtualVoices,set_numVirtualVoices,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioConfiguration));
	}
}
