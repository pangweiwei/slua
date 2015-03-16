using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_PassType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.PassType");
		addMember(l,0,"Normal");
		addMember(l,1,"Vertex");
		addMember(l,2,"VertexLM");
		addMember(l,3,"VertexLMRGBM");
		addMember(l,4,"ForwardBase");
		addMember(l,5,"ForwardAdd");
		addMember(l,6,"LightPrePassBase");
		addMember(l,7,"LightPrePassFinal");
		addMember(l,8,"ShadowCaster");
		addMember(l,10,"Deferred");
		addMember(l,11,"Meta");
		LuaDLL.lua_pop(l, 1);
	}
}
