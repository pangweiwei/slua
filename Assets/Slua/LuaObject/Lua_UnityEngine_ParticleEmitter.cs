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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearParticles(IntPtr l) {
		try{
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
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
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
				self.Emit();
				return 0;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Emit(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(float),typeof(UnityEngine.Color))){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
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
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(float),typeof(UnityEngine.Color),typeof(float),typeof(float))){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
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
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
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
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.emit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emit(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.emit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.minSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.maxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxSize(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.minEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minEnergy=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.maxEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxEnergy(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxEnergy=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.minEmission);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minEmission=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.maxEmission);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxEmission(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxEmission=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emitterVelocityScale(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.emitterVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emitterVelocityScale(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.emitterVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.worldVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.localVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.rndVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.rndVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useWorldSpace(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.useWorldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useWorldSpace(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useWorldSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndRotation(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.rndRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndRotation(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.rndRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndAngularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.rndAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndAngularVelocity(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.rndAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particles(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.particles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particles(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		UnityEngine.Particle[] v;
		checkType(l,2,out v);
		o.particles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleCount(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.particleCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.ParticleEmitter o = (UnityEngine.ParticleEmitter)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleEmitter");
		addMember(l,ClearParticles);
		addMember(l,Emit);
		addMember(l,Simulate);
		addMember(l,"emit",get_emit,set_emit,true);
		addMember(l,"minSize",get_minSize,set_minSize,true);
		addMember(l,"maxSize",get_maxSize,set_maxSize,true);
		addMember(l,"minEnergy",get_minEnergy,set_minEnergy,true);
		addMember(l,"maxEnergy",get_maxEnergy,set_maxEnergy,true);
		addMember(l,"minEmission",get_minEmission,set_minEmission,true);
		addMember(l,"maxEmission",get_maxEmission,set_maxEmission,true);
		addMember(l,"emitterVelocityScale",get_emitterVelocityScale,set_emitterVelocityScale,true);
		addMember(l,"worldVelocity",get_worldVelocity,set_worldVelocity,true);
		addMember(l,"localVelocity",get_localVelocity,set_localVelocity,true);
		addMember(l,"rndVelocity",get_rndVelocity,set_rndVelocity,true);
		addMember(l,"useWorldSpace",get_useWorldSpace,set_useWorldSpace,true);
		addMember(l,"rndRotation",get_rndRotation,set_rndRotation,true);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity,true);
		addMember(l,"rndAngularVelocity",get_rndAngularVelocity,set_rndAngularVelocity,true);
		addMember(l,"particles",get_particles,set_particles,true);
		addMember(l,"particleCount",get_particleCount,null,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleEmitter),typeof(UnityEngine.Component));
	}
}
