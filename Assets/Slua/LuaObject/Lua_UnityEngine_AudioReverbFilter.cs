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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbPreset(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.reverbPreset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbPreset(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		UnityEngine.AudioReverbPreset v;
		checkEnum(l,2,out v);
		o.reverbPreset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dryLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.dryLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dryLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.dryLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_room(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.room);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_room(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.room=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomHF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.roomHF);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomHF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.roomHF=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomRolloff(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.roomRolloff);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomRolloff(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.roomRolloff=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayTime(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.decayTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayTime(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.decayTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayHFRatio(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.decayHFRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayHFRatio(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.decayHFRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflectionsLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.reflectionsLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflectionsLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.reflectionsLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflectionsDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.reflectionsDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflectionsDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.reflectionsDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.reverbLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbLevel(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.reverbLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.reverbDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbDelay(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.reverbDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_diffusion(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.diffusion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_diffusion(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.diffusion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_density(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.density);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_density(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.density=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hfReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.hfReference);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hfReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.hfReference=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomLF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.roomLF);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomLF(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.roomLF=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lFReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		pushValue(l,o.lFReference);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lFReference(IntPtr l) {
		UnityEngine.AudioReverbFilter o = (UnityEngine.AudioReverbFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lFReference=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioReverbFilter");
		addMember(l,"reverbPreset",get_reverbPreset,set_reverbPreset);
		addMember(l,"dryLevel",get_dryLevel,set_dryLevel);
		addMember(l,"room",get_room,set_room);
		addMember(l,"roomHF",get_roomHF,set_roomHF);
		addMember(l,"roomRolloff",get_roomRolloff,set_roomRolloff);
		addMember(l,"decayTime",get_decayTime,set_decayTime);
		addMember(l,"decayHFRatio",get_decayHFRatio,set_decayHFRatio);
		addMember(l,"reflectionsLevel",get_reflectionsLevel,set_reflectionsLevel);
		addMember(l,"reflectionsDelay",get_reflectionsDelay,set_reflectionsDelay);
		addMember(l,"reverbLevel",get_reverbLevel,set_reverbLevel);
		addMember(l,"reverbDelay",get_reverbDelay,set_reverbDelay);
		addMember(l,"diffusion",get_diffusion,set_diffusion);
		addMember(l,"density",get_density,set_density);
		addMember(l,"hfReference",get_hfReference,set_hfReference);
		addMember(l,"roomLF",get_roomLF,set_roomLF);
		addMember(l,"lFReference",get_lFReference,set_lFReference);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioReverbFilter),typeof(UnityEngine.Behaviour));
	}
}
