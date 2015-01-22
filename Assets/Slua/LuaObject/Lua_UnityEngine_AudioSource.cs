using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioSource : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioSource o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioSource();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.UInt64))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				System.UInt64 a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				self.Play();
				return 0;
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
	static public int PlayDelayed(IntPtr l) {
		try{
			UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.PlayDelayed(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayScheduled(IntPtr l) {
		try{
			UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.PlayScheduled(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetScheduledStartTime(IntPtr l) {
		try{
			UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.SetScheduledStartTime(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetScheduledEndTime(IntPtr l) {
		try{
			UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.SetScheduledEndTime(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
			self.Stop();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Pause(IntPtr l) {
		try{
			UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
			self.Pause();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayOneShot(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.AudioClip),typeof(System.Single))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.PlayOneShot(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.AudioClip))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				self.PlayOneShot(a1);
				return 0;
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
	static public int GetOutputData(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single[] ret=self.GetOutputData(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Int32))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				System.Single[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.GetOutputData(a1,a2);
				return 0;
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
	static public int GetSpectrumData(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.FFTWindow))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.FFTWindow a3;
				checkEnum(l,4,out a3);
				System.Single[] ret=self.GetSpectrumData(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Int32),typeof(UnityEngine.FFTWindow))){
				UnityEngine.AudioSource self=(UnityEngine.AudioSource)checkSelf(l);
				System.Single[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.FFTWindow a3;
				checkEnum(l,4,out a3);
				self.GetSpectrumData(a1,a2,a3);
				return 0;
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
	static public int PlayClipAtPoint_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.AudioClip),typeof(UnityEngine.Vector3))){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.AudioSource.PlayClipAtPoint(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.AudioClip),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.AudioSource.PlayClipAtPoint(a1,a2,a3);
				return 0;
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
	static public int get_volume(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.volume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_volume(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.volume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pitch(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.pitch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pitch(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.pitch=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeSamples(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.timeSamples);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeSamples(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.timeSamples=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clip(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		UnityEngine.AudioClip v;
		checkType(l,2,out v);
		o.clip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.loop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.loop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreListenerVolume(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.ignoreListenerVolume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreListenerVolume(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.ignoreListenerVolume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playOnAwake(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.playOnAwake);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playOnAwake(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.playOnAwake=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreListenerPause(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.ignoreListenerPause);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreListenerPause(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.ignoreListenerPause=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.velocityUpdateMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		UnityEngine.AudioVelocityUpdateMode v;
		checkEnum(l,2,out v);
		o.velocityUpdateMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_panLevel(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.panLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_panLevel(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.panLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bypassEffects(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.bypassEffects);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bypassEffects(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.bypassEffects=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bypassListenerEffects(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.bypassListenerEffects);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bypassListenerEffects(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.bypassListenerEffects=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bypassReverbZones(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.bypassReverbZones);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bypassReverbZones(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.bypassReverbZones=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dopplerLevel(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.dopplerLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dopplerLevel(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.dopplerLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spread(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.spread);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spread(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.spread=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_priority(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.priority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_priority(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.priority=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mute(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.mute);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mute(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.mute=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minDistance(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.minDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minDistance(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.maxDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pan(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.pan);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pan(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.pan=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rolloffMode(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		pushValue(l,o.rolloffMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rolloffMode(IntPtr l) {
		UnityEngine.AudioSource o = (UnityEngine.AudioSource)checkSelf(l);
		UnityEngine.AudioRolloffMode v;
		checkEnum(l,2,out v);
		o.rolloffMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioSource");
		addMember(l,Play);
		addMember(l,PlayDelayed);
		addMember(l,PlayScheduled);
		addMember(l,SetScheduledStartTime);
		addMember(l,SetScheduledEndTime);
		addMember(l,Stop);
		addMember(l,Pause);
		addMember(l,PlayOneShot);
		addMember(l,GetOutputData);
		addMember(l,GetSpectrumData);
		addMember(l,PlayClipAtPoint_s);
		addMember(l,"volume",get_volume,set_volume);
		addMember(l,"pitch",get_pitch,set_pitch);
		addMember(l,"time",get_time,set_time);
		addMember(l,"timeSamples",get_timeSamples,set_timeSamples);
		addMember(l,"clip",get_clip,set_clip);
		addMember(l,"isPlaying",get_isPlaying,null);
		addMember(l,"loop",get_loop,set_loop);
		addMember(l,"ignoreListenerVolume",get_ignoreListenerVolume,set_ignoreListenerVolume);
		addMember(l,"playOnAwake",get_playOnAwake,set_playOnAwake);
		addMember(l,"ignoreListenerPause",get_ignoreListenerPause,set_ignoreListenerPause);
		addMember(l,"velocityUpdateMode",get_velocityUpdateMode,set_velocityUpdateMode);
		addMember(l,"panLevel",get_panLevel,set_panLevel);
		addMember(l,"bypassEffects",get_bypassEffects,set_bypassEffects);
		addMember(l,"bypassListenerEffects",get_bypassListenerEffects,set_bypassListenerEffects);
		addMember(l,"bypassReverbZones",get_bypassReverbZones,set_bypassReverbZones);
		addMember(l,"dopplerLevel",get_dopplerLevel,set_dopplerLevel);
		addMember(l,"spread",get_spread,set_spread);
		addMember(l,"priority",get_priority,set_priority);
		addMember(l,"mute",get_mute,set_mute);
		addMember(l,"minDistance",get_minDistance,set_minDistance);
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance);
		addMember(l,"pan",get_pan,set_pan);
		addMember(l,"rolloffMode",get_rolloffMode,set_rolloffMode);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioSource),typeof(UnityEngine.Behaviour));
	}
}
