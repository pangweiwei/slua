using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralOutputType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralOutputType");
		addMember(l,0,"Unknown");
		addMember(l,1,"Diffuse");
		addMember(l,2,"Normal");
		addMember(l,3,"Height");
		addMember(l,4,"Emissive");
		addMember(l,5,"Specular");
		addMember(l,6,"Opacity");
		addMember(l,7,"Smoothness");
		addMember(l,8,"AmbientOcclusion");
		addMember(l,9,"DetailMask");
		addMember(l,10,"Metallic");
		addMember(l,11,"Roughness");
		LuaDLL.lua_pop(l, 1);
	}
}
