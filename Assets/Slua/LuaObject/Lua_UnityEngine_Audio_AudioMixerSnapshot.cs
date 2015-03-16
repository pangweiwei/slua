using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Audio_AudioMixerSnapshot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TransitionTo(IntPtr l) {
		try{
			UnityEngine.Audio.AudioMixerSnapshot self=(UnityEngine.Audio.AudioMixerSnapshot)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.TransitionTo(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioMixer(IntPtr l) {
		UnityEngine.Audio.AudioMixerSnapshot o = (UnityEngine.Audio.AudioMixerSnapshot)checkSelf(l);
		pushValue(l,o.audioMixer);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Audio.AudioMixerSnapshot");
		addMember(l,TransitionTo);
		addMember(l,"audioMixer",get_audioMixer,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Audio.AudioMixerSnapshot),typeof(UnityEngine.Object));
	}
}
