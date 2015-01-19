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
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.particleRenderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particleRenderMode(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		UnityEngine.ParticleRenderMode v;
		checkEnum(l,2,out v);
		o.particleRenderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lengthScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.lengthScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lengthScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lengthScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.velocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.velocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.cameraVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.cameraVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.maxParticleSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxParticleSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationXTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.uvAnimationXTile);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationXTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.uvAnimationXTile=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationYTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.uvAnimationYTile);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationYTile(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.uvAnimationYTile=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationCycles(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.uvAnimationCycles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationCycles(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.uvAnimationCycles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxPartileSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.maxPartileSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxPartileSize(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxPartileSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTiles(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		pushValue(l,o.uvTiles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvTiles(IntPtr l) {
		UnityEngine.ParticleRenderer o = checkSelf<UnityEngine.ParticleRenderer>(l);
		UnityEngine.Rect[] v;
		checkType(l,2,out v);
		o.uvTiles=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleRenderer");
		addMember(l,get_particleRenderMode, "get_particleRenderMode");
		addMember(l,set_particleRenderMode, "set_particleRenderMode");
		addMember(l,get_lengthScale, "get_lengthScale");
		addMember(l,set_lengthScale, "set_lengthScale");
		addMember(l,get_velocityScale, "get_velocityScale");
		addMember(l,set_velocityScale, "set_velocityScale");
		addMember(l,get_cameraVelocityScale, "get_cameraVelocityScale");
		addMember(l,set_cameraVelocityScale, "set_cameraVelocityScale");
		addMember(l,get_maxParticleSize, "get_maxParticleSize");
		addMember(l,set_maxParticleSize, "set_maxParticleSize");
		addMember(l,get_uvAnimationXTile, "get_uvAnimationXTile");
		addMember(l,set_uvAnimationXTile, "set_uvAnimationXTile");
		addMember(l,get_uvAnimationYTile, "get_uvAnimationYTile");
		addMember(l,set_uvAnimationYTile, "set_uvAnimationYTile");
		addMember(l,get_uvAnimationCycles, "get_uvAnimationCycles");
		addMember(l,set_uvAnimationCycles, "set_uvAnimationCycles");
		addMember(l,get_maxPartileSize, "get_maxPartileSize");
		addMember(l,set_maxPartileSize, "set_maxPartileSize");
		addMember(l,get_uvTiles, "get_uvTiles");
		addMember(l,set_uvTiles, "set_uvTiles");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleRenderer),typeof(UnityEngine.Renderer));
		LuaDLL.lua_pop(l, 1);
	}
}
