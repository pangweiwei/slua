using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o;
		o=new UnityEngine.ParticleSystemRenderer();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		pushEnum(l,(int)o.renderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		UnityEngine.ParticleSystemRenderMode v;
		checkEnum(l,2,out v);
		o.renderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lengthScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		pushValue(l,o.lengthScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lengthScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lengthScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		pushValue(l,o.velocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.velocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		pushValue(l,o.cameraVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.cameraVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		pushValue(l,o.maxParticleSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxParticleSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		pushValue(l,o.mesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = (UnityEngine.ParticleSystemRenderer)checkSelf(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.mesh=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystemRenderer");
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"lengthScale",get_lengthScale,set_lengthScale,true);
		addMember(l,"velocityScale",get_velocityScale,set_velocityScale,true);
		addMember(l,"cameraVelocityScale",get_cameraVelocityScale,set_cameraVelocityScale,true);
		addMember(l,"maxParticleSize",get_maxParticleSize,set_maxParticleSize,true);
		addMember(l,"mesh",get_mesh,set_mesh,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystemRenderer),typeof(UnityEngine.Renderer));
	}
}
