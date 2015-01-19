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
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetParticles(IntPtr l) {
		try{
			UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
			UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
			UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
			if(matchType(l,2,typeof(System.Single),typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Simulate(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Simulate(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				self.Play();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				self.Stop();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				self.Pause();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				self.Clear();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				System.Boolean ret=self.IsAlive();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
			if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Emit(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.Color32))){
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
				UnityEngine.ParticleSystem self=checkSelf<UnityEngine.ParticleSystem>(l);
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
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.startDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startDelay(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isStopped(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.isStopped);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPaused(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.isPaused);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.loop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.loop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playOnAwake(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.playOnAwake);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playOnAwake(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.playOnAwake=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_duration(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.duration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playbackSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.playbackSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playbackSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.playbackSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleCount(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.particleCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_safeCollisionEventSize(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.safeCollisionEventSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableEmission(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.enableEmission);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableEmission(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enableEmission=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emissionRate(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.emissionRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emissionRate(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.emissionRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.startSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startSpeed(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startSize(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.startSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startSize(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startColor(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.startColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startColor(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.startColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startRotation(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.startRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startRotation(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startLifetime(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.startLifetime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startLifetime(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startLifetime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityModifier(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.gravityModifier);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravityModifier(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Single v;
		checkType(l,2,out v);
		o.gravityModifier=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticles(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.maxParticles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticles(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxParticles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulationSpace(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.simulationSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulationSpace(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		UnityEngine.ParticleSystemSimulationSpace v;
		checkEnum(l,2,out v);
		o.simulationSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_randomSeed(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		pushValue(l,o.randomSeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_randomSeed(IntPtr l) {
		UnityEngine.ParticleSystem o = checkSelf<UnityEngine.ParticleSystem>(l);
		System.UInt32 v;
		checkType(l,2,out v);
		o.randomSeed=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem");
		addMember(l,SetParticles, "SetParticles");
		addMember(l,GetParticles, "GetParticles");
		addMember(l,GetCollisionEvents, "GetCollisionEvents");
		addMember(l,Simulate, "Simulate");
		addMember(l,Play, "Play");
		addMember(l,Stop, "Stop");
		addMember(l,Pause, "Pause");
		addMember(l,Clear, "Clear");
		addMember(l,IsAlive, "IsAlive");
		addMember(l,Emit, "Emit");
		addMember(l,get_startDelay, "get_startDelay");
		addMember(l,set_startDelay, "set_startDelay");
		addMember(l,get_isPlaying, "get_isPlaying");
		addMember(l,get_isStopped, "get_isStopped");
		addMember(l,get_isPaused, "get_isPaused");
		addMember(l,get_loop, "get_loop");
		addMember(l,set_loop, "set_loop");
		addMember(l,get_playOnAwake, "get_playOnAwake");
		addMember(l,set_playOnAwake, "set_playOnAwake");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		addMember(l,get_duration, "get_duration");
		addMember(l,get_playbackSpeed, "get_playbackSpeed");
		addMember(l,set_playbackSpeed, "set_playbackSpeed");
		addMember(l,get_particleCount, "get_particleCount");
		addMember(l,get_safeCollisionEventSize, "get_safeCollisionEventSize");
		addMember(l,get_enableEmission, "get_enableEmission");
		addMember(l,set_enableEmission, "set_enableEmission");
		addMember(l,get_emissionRate, "get_emissionRate");
		addMember(l,set_emissionRate, "set_emissionRate");
		addMember(l,get_startSpeed, "get_startSpeed");
		addMember(l,set_startSpeed, "set_startSpeed");
		addMember(l,get_startSize, "get_startSize");
		addMember(l,set_startSize, "set_startSize");
		addMember(l,get_startColor, "get_startColor");
		addMember(l,set_startColor, "set_startColor");
		addMember(l,get_startRotation, "get_startRotation");
		addMember(l,set_startRotation, "set_startRotation");
		addMember(l,get_startLifetime, "get_startLifetime");
		addMember(l,set_startLifetime, "set_startLifetime");
		addMember(l,get_gravityModifier, "get_gravityModifier");
		addMember(l,set_gravityModifier, "set_gravityModifier");
		addMember(l,get_maxParticles, "get_maxParticles");
		addMember(l,set_maxParticles, "set_maxParticles");
		addMember(l,get_simulationSpace, "get_simulationSpace");
		addMember(l,set_simulationSpace, "set_simulationSpace");
		addMember(l,get_randomSeed, "get_randomSeed");
		addMember(l,set_randomSeed, "set_randomSeed");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleSystem),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
