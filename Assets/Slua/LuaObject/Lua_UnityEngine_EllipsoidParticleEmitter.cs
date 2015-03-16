using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EllipsoidParticleEmitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EllipsoidParticleEmitter");
		createTypeMetatable(l,constructor, typeof(UnityEngine.EllipsoidParticleEmitter),typeof(UnityEngine.ParticleEmitter));
	}
}
