using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Audio_AudioMixer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindMatchingGroups(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixer self=(UnityEngine.Audio.AudioMixer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Audio.AudioMixerGroup[] ret=self.FindMatchingGroups(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSnapshot(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixer self=(UnityEngine.Audio.AudioMixer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Audio.AudioMixerSnapshot ret=self.FindSnapshot(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TransitionToSnapshots(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixer self=(UnityEngine.Audio.AudioMixer)checkSelf(l);
			UnityEngine.Audio.AudioMixerSnapshot[] a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.TransitionToSnapshots(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFloat(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixer self=(UnityEngine.Audio.AudioMixer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.SetFloat(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearFloat(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixer self=(UnityEngine.Audio.AudioMixer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.ClearFloat(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFloat(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixer self=(UnityEngine.Audio.AudioMixer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			System.Boolean ret=self.GetFloat(a1,out a2);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_outputAudioMixerGroup(IntPtr l) {
		UnityEngine.Audio.AudioMixer o = (UnityEngine.Audio.AudioMixer)checkSelf(l);
		pushValue(l,o.outputAudioMixerGroup);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_outputAudioMixerGroup(IntPtr l) {
		UnityEngine.Audio.AudioMixer o = (UnityEngine.Audio.AudioMixer)checkSelf(l);
		UnityEngine.Audio.AudioMixerGroup v;
		checkType(l,2,out v);
		o.outputAudioMixerGroup=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Audio.AudioMixer");
		addMember(l,FindMatchingGroups);
		addMember(l,FindSnapshot);
		addMember(l,TransitionToSnapshots);
		addMember(l,SetFloat);
		addMember(l,ClearFloat);
		addMember(l,GetFloat);
		addMember(l,"outputAudioMixerGroup",get_outputAudioMixerGroup,set_outputAudioMixerGroup,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Audio.AudioMixer),typeof(UnityEngine.Object));
	}
}
