using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioReverbZone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioReverbZone o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioReverbZone();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minDistance(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.minDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minDistance(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.minDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.maxDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbPreset(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.reverbPreset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbPreset(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		UnityEngine.AudioReverbPreset v;
		checkEnum(l,2,out v);
		o.reverbPreset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_room(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.room);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_room(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.room=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomHF(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.roomHF);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomHF(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.roomHF=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomLF(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.roomLF);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomLF(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.roomLF=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayTime(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.decayTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayTime(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.decayTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayHFRatio(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.decayHFRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayHFRatio(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.decayHFRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflections(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.reflections);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflections(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.reflections=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflectionsDelay(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.reflectionsDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflectionsDelay(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.reflectionsDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverb(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.reverb);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverb(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.reverb=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbDelay(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.reverbDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbDelay(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.reverbDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_HFReference(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.HFReference);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_HFReference(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.HFReference=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LFReference(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.LFReference);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_LFReference(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.LFReference=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomRolloffFactor(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.roomRolloffFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomRolloffFactor(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.roomRolloffFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_diffusion(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.diffusion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_diffusion(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.diffusion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_density(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		pushValue(l,o.density);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_density(IntPtr l) {
		UnityEngine.AudioReverbZone o = (UnityEngine.AudioReverbZone)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.density=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioReverbZone");
		addMember(l,"minDistance",get_minDistance,set_minDistance);
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance);
		addMember(l,"reverbPreset",get_reverbPreset,set_reverbPreset);
		addMember(l,"room",get_room,set_room);
		addMember(l,"roomHF",get_roomHF,set_roomHF);
		addMember(l,"roomLF",get_roomLF,set_roomLF);
		addMember(l,"decayTime",get_decayTime,set_decayTime);
		addMember(l,"decayHFRatio",get_decayHFRatio,set_decayHFRatio);
		addMember(l,"reflections",get_reflections,set_reflections);
		addMember(l,"reflectionsDelay",get_reflectionsDelay,set_reflectionsDelay);
		addMember(l,"reverb",get_reverb,set_reverb);
		addMember(l,"reverbDelay",get_reverbDelay,set_reverbDelay);
		addMember(l,"HFReference",get_HFReference,set_HFReference);
		addMember(l,"LFReference",get_LFReference,set_LFReference);
		addMember(l,"roomRolloffFactor",get_roomRolloffFactor,set_roomRolloffFactor);
		addMember(l,"diffusion",get_diffusion,set_diffusion);
		addMember(l,"density",get_density,set_density);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioReverbZone),typeof(UnityEngine.Behaviour));
	}
}
