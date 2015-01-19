using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ParticleSystemRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.ParticleSystemRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		pushValue(l,o.renderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		UnityEngine.ParticleSystemRenderMode v;
		checkEnum(l,2,out v);
		o.renderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lengthScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		pushValue(l,o.lengthScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lengthScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lengthScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		pushValue(l,o.velocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.velocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		pushValue(l,o.cameraVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraVelocityScale(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.cameraVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		pushValue(l,o.maxParticleSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticleSize(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxParticleSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		pushValue(l,o.mesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		UnityEngine.ParticleSystemRenderer o = checkSelf<UnityEngine.ParticleSystemRenderer>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.mesh=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystemRenderer");
		addMember(l,get_renderMode, "get_renderMode");
		addMember(l,set_renderMode, "set_renderMode");
		addMember(l,get_lengthScale, "get_lengthScale");
		addMember(l,set_lengthScale, "set_lengthScale");
		addMember(l,get_velocityScale, "get_velocityScale");
		addMember(l,set_velocityScale, "set_velocityScale");
		addMember(l,get_cameraVelocityScale, "get_cameraVelocityScale");
		addMember(l,set_cameraVelocityScale, "set_cameraVelocityScale");
		addMember(l,get_maxParticleSize, "get_maxParticleSize");
		addMember(l,set_maxParticleSize, "set_maxParticleSize");
		addMember(l,get_mesh, "get_mesh");
		addMember(l,set_mesh, "set_mesh");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleSystemRenderer),typeof(UnityEngine.Renderer));
		LuaDLL.lua_pop(l, 1);
	}
}
