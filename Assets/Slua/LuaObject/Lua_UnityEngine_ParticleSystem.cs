using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ParticleSystem o;
		if(matchType(l,1)){
			o=new UnityEngine.ParticleSystem();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetParticles(IntPtr l) {
		try{
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetParticles(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetParticles(IntPtr l) {
		try{
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.GetParticles(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCollisionEvents(IntPtr l) {
		try{
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystem.CollisionEvent[] a2;
			checkType(l,3,out a2);
			System.Int32 ret=self.GetCollisionEvents(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Simulate(IntPtr l) {
		try{
			if(matchType(l,2,typeof(float),typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Simulate(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(float))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Simulate(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(float),typeof(bool),typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.Simulate(a1,a2,a3);
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
	static public int Play(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Play();
				return 0;
			}
			else if(matchType(l,2,typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Play(a1);
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
	static public int Stop(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Stop();
				return 0;
			}
			else if(matchType(l,2,typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Stop(a1);
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
	static public int Pause(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Pause();
				return 0;
			}
			else if(matchType(l,2,typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Pause(a1);
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
	static public int Clear(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Clear();
				return 0;
			}
			else if(matchType(l,2,typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Clear(a1);
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
	static public int IsAlive(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean ret=self.IsAlive();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(bool))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.IsAlive(a1);
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
	static public int Emit(IntPtr l) {
		try{
			if(matchType(l,2,typeof(int))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Emit(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(float),typeof(UnityEngine.Color32))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.Color32 a5;
				checkType(l,6,out a5);
				self.Emit(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.ParticleSystem.Particle))){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				UnityEngine.ParticleSystem.Particle a1;
				checkType(l,2,out a1);
				self.Emit(a1);
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
	static public int get_startDelay(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.startDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startDelay(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isStopped(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.isStopped);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPaused(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.isPaused);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.loop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.loop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playOnAwake(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.playOnAwake);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playOnAwake(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.playOnAwake=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_duration(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.duration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playbackSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.playbackSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playbackSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.playbackSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleCount(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.particleCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_safeCollisionEventSize(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.safeCollisionEventSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableEmission(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.enableEmission);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableEmission(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enableEmission=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emissionRate(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.emissionRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emissionRate(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.emissionRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.startSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startSize(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.startSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startSize(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startColor(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.startColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startColor(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.startColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startRotation(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.startRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startRotation(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startLifetime(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.startLifetime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startLifetime(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startLifetime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityModifier(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.gravityModifier);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravityModifier(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.gravityModifier=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticles(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.maxParticles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticles(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.maxParticles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulationSpace(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushEnum(l,(int)o.simulationSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulationSpace(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		UnityEngine.ParticleSystemSimulationSpace v;
		checkEnum(l,2,out v);
		o.simulationSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_randomSeed(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		pushValue(l,o.randomSeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_randomSeed(IntPtr l) {
		UnityEngine.ParticleSystem o = (UnityEngine.ParticleSystem)checkSelf(l);
		System.UInt32 v;
		checkType(l,2,out v);
		o.randomSeed=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem");
		addMember(l,SetParticles);
		addMember(l,GetParticles);
		addMember(l,GetCollisionEvents);
		addMember(l,Simulate);
		addMember(l,Play);
		addMember(l,Stop);
		addMember(l,Pause);
		addMember(l,Clear);
		addMember(l,IsAlive);
		addMember(l,Emit);
		addMember(l,"startDelay",get_startDelay,set_startDelay,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		addMember(l,"isStopped",get_isStopped,null,true);
		addMember(l,"isPaused",get_isPaused,null,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"playOnAwake",get_playOnAwake,set_playOnAwake,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"duration",get_duration,null,true);
		addMember(l,"playbackSpeed",get_playbackSpeed,set_playbackSpeed,true);
		addMember(l,"particleCount",get_particleCount,null,true);
		addMember(l,"safeCollisionEventSize",get_safeCollisionEventSize,null,true);
		addMember(l,"enableEmission",get_enableEmission,set_enableEmission,true);
		addMember(l,"emissionRate",get_emissionRate,set_emissionRate,true);
		addMember(l,"startSpeed",get_startSpeed,set_startSpeed,true);
		addMember(l,"startSize",get_startSize,set_startSize,true);
		addMember(l,"startColor",get_startColor,set_startColor,true);
		addMember(l,"startRotation",get_startRotation,set_startRotation,true);
		addMember(l,"startLifetime",get_startLifetime,set_startLifetime,true);
		addMember(l,"gravityModifier",get_gravityModifier,set_gravityModifier,true);
		addMember(l,"maxParticles",get_maxParticles,set_maxParticles,true);
		addMember(l,"simulationSpace",get_simulationSpace,set_simulationSpace,true);
		addMember(l,"randomSeed",get_randomSeed,set_randomSeed,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem),typeof(UnityEngine.Component));
	}
}
