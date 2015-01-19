using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioReverbFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioReverbFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioReverbFilter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbPreset(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.reverbPreset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbPreset(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		UnityEngine.AudioReverbPreset v;
		checkEnum(l,2,out v);
		o.reverbPreset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dryLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.dryLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dryLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.dryLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_room(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.room);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_room(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.room=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomHF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.roomHF);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomHF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.roomHF=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomRolloff(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.roomRolloff);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomRolloff(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.roomRolloff=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayTime(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.decayTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayTime(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.decayTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayHFRatio(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.decayHFRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayHFRatio(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.decayHFRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflectionsLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.reflectionsLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflectionsLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.reflectionsLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflectionsDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.reflectionsDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflectionsDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.reflectionsDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.reverbLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.reverbLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.reverbDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.reverbDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_diffusion(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.diffusion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_diffusion(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.diffusion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_density(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.density);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_density(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.density=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hfReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.hfReference);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hfReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.hfReference=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomLF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.roomLF);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomLF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.roomLF=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lFReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		pushValue(l,o.lFReference);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lFReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = checkSelf<UnityEngine.AudioReverbFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lFReference=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioReverbFilter");
		addMember(l,get_reverbPreset, "get_reverbPreset");
		addMember(l,set_reverbPreset, "set_reverbPreset");
		addMember(l,get_dryLevel, "get_dryLevel");
		addMember(l,set_dryLevel, "set_dryLevel");
		addMember(l,get_room, "get_room");
		addMember(l,set_room, "set_room");
		addMember(l,get_roomHF, "get_roomHF");
		addMember(l,set_roomHF, "set_roomHF");
		addMember(l,get_roomRolloff, "get_roomRolloff");
		addMember(l,set_roomRolloff, "set_roomRolloff");
		addMember(l,get_decayTime, "get_decayTime");
		addMember(l,set_decayTime, "set_decayTime");
		addMember(l,get_decayHFRatio, "get_decayHFRatio");
		addMember(l,set_decayHFRatio, "set_decayHFRatio");
		addMember(l,get_reflectionsLevel, "get_reflectionsLevel");
		addMember(l,set_reflectionsLevel, "set_reflectionsLevel");
		addMember(l,get_reflectionsDelay, "get_reflectionsDelay");
		addMember(l,set_reflectionsDelay, "set_reflectionsDelay");
		addMember(l,get_reverbLevel, "get_reverbLevel");
		addMember(l,set_reverbLevel, "set_reverbLevel");
		addMember(l,get_reverbDelay, "get_reverbDelay");
		addMember(l,set_reverbDelay, "set_reverbDelay");
		addMember(l,get_diffusion, "get_diffusion");
		addMember(l,set_diffusion, "set_diffusion");
		addMember(l,get_density, "get_density");
		addMember(l,set_density, "set_density");
		addMember(l,get_hfReference, "get_hfReference");
		addMember(l,set_hfReference, "set_hfReference");
		addMember(l,get_roomLF, "get_roomLF");
		addMember(l,set_roomLF, "set_roomLF");
		addMember(l,get_lFReference, "get_lFReference");
		addMember(l,set_lFReference, "set_lFReference");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioReverbFilter),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
