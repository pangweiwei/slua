using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleEmitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ParticleEmitter o;
		if(matchType(l,1)){
			o=new UnityEngine.ParticleEmitter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearParticles(IntPtr l) {
		try{
			UnityEngine.ParticleEmitter self=checkSelf<UnityEngine.ParticleEmitter>(l);
			self.ClearParticles();
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
			if(matchType(l,2)){
				UnityEngine.ParticleEmitter self=checkSelf<UnityEngine.ParticleEmitter>(l);
				self.Emit();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.ParticleEmitter self=checkSelf<UnityEngine.ParticleEmitter>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Emit(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.Color))){
				UnityEngine.ParticleEmitter self=checkSelf<UnityEngine.ParticleEmitter>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.Color a5;
				checkType(l,6,out a5);
				self.Emit(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.Color),typeof(System.Single),typeof(System.Single))){
				UnityEngine.ParticleEmitter self=checkSelf<UnityEngine.ParticleEmitter>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.Color a5;
				checkType(l,6,out a5);
				System.Single a6;
				checkType(l,7,out a6);
				System.Single a7;
				checkType(l,8,out a7);
				self.Emit(a1,a2,a3,a4,a5,a6,a7);
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
	static public int Simulate(IntPtr l) {
		try{
			UnityEngine.ParticleEmitter self=checkSelf<UnityEngine.ParticleEmitter>(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Simulate(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emit(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.emit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emit(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.emit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.minSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.maxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.minEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minEnergy=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.maxEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxEnergy=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.minEmission);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minEmission=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.maxEmission);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxEmission=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emitterVelocityScale(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.emitterVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emitterVelocityScale(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.emitterVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.worldVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.localVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.rndVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.rndVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useWorldSpace(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.useWorldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useWorldSpace(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useWorldSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndRotation(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.rndRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndRotation(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.rndRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndAngularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.rndAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndAngularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.rndAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particles(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.particles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particles(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		UnityEngine.Particle[] v;
		checkType(l,2,out v);
		o.particles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleCount(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.particleCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.ParticleEmitter o = checkSelf<UnityEngine.ParticleEmitter>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleEmitter");
		addMember(l,ClearParticles, "ClearParticles");
		addMember(l,Emit, "Emit");
		addMember(l,Simulate, "Simulate");
		addMember(l,get_emit, "get_emit");
		addMember(l,set_emit, "set_emit");
		addMember(l,get_minSize, "get_minSize");
		addMember(l,set_minSize, "set_minSize");
		addMember(l,get_maxSize, "get_maxSize");
		addMember(l,set_maxSize, "set_maxSize");
		addMember(l,get_minEnergy, "get_minEnergy");
		addMember(l,set_minEnergy, "set_minEnergy");
		addMember(l,get_maxEnergy, "get_maxEnergy");
		addMember(l,set_maxEnergy, "set_maxEnergy");
		addMember(l,get_minEmission, "get_minEmission");
		addMember(l,set_minEmission, "set_minEmission");
		addMember(l,get_maxEmission, "get_maxEmission");
		addMember(l,set_maxEmission, "set_maxEmission");
		addMember(l,get_emitterVelocityScale, "get_emitterVelocityScale");
		addMember(l,set_emitterVelocityScale, "set_emitterVelocityScale");
		addMember(l,get_worldVelocity, "get_worldVelocity");
		addMember(l,set_worldVelocity, "set_worldVelocity");
		addMember(l,get_localVelocity, "get_localVelocity");
		addMember(l,set_localVelocity, "set_localVelocity");
		addMember(l,get_rndVelocity, "get_rndVelocity");
		addMember(l,set_rndVelocity, "set_rndVelocity");
		addMember(l,get_useWorldSpace, "get_useWorldSpace");
		addMember(l,set_useWorldSpace, "set_useWorldSpace");
		addMember(l,get_rndRotation, "get_rndRotation");
		addMember(l,set_rndRotation, "set_rndRotation");
		addMember(l,get_angularVelocity, "get_angularVelocity");
		addMember(l,set_angularVelocity, "set_angularVelocity");
		addMember(l,get_rndAngularVelocity, "get_rndAngularVelocity");
		addMember(l,set_rndAngularVelocity, "set_rndAngularVelocity");
		addMember(l,get_particles, "get_particles");
		addMember(l,set_particles, "set_particles");
		addMember(l,get_particleCount, "get_particleCount");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleEmitter),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
