using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ParticleRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.ParticleRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleRenderMode(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.particleRenderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particleRenderMode(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		UnityEngine.ParticleRenderMode v;
		checkEnum(l,2,out v);
		o.particleRenderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lengthScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.lengthScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lengthScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lengthScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.velocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.velocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.cameraVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.cameraVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.maxParticleSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxParticleSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationXTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.uvAnimationXTile);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationXTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.uvAnimationXTile=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationYTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.uvAnimationYTile);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationYTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.uvAnimationYTile=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationCycles(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.uvAnimationCycles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationCycles(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.uvAnimationCycles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxPartileSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.maxPartileSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxPartileSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxPartileSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTiles(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		pushValue(l,o.uvTiles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvTiles(IntPtr l) {
		UnityEngine.ParticleRenderer o = (UnityEngine.ParticleRenderer)checkSelf(l);
		UnityEngine.Rect[] v;
		checkType(l,2,out v);
		o.uvTiles=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleRenderer");
		addMember(l,"particleRenderMode",get_particleRenderMode,set_particleRenderMode);
		addMember(l,"lengthScale",get_lengthScale,set_lengthScale);
		addMember(l,"velocityScale",get_velocityScale,set_velocityScale);
		addMember(l,"cameraVelocityScale",get_cameraVelocityScale,set_cameraVelocityScale);
		addMember(l,"maxParticleSize",get_maxParticleSize,set_maxParticleSize);
		addMember(l,"uvAnimationXTile",get_uvAnimationXTile,set_uvAnimationXTile);
		addMember(l,"uvAnimationYTile",get_uvAnimationYTile,set_uvAnimationYTile);
		addMember(l,"uvAnimationCycles",get_uvAnimationCycles,set_uvAnimationCycles);
		addMember(l,"maxPartileSize",get_maxPartileSize,set_maxPartileSize);
		addMember(l,"uvTiles",get_uvTiles,set_uvTiles);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleRenderer),typeof(UnityEngine.Renderer));
	}
}
