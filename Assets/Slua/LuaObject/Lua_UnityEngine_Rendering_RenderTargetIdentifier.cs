using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_RenderTargetIdentifier : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.Rendering.RenderTargetIdentifier o;
		if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType))){
			UnityEngine.Rendering.BuiltinRenderTextureType a1;
			checkEnum(l,2,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,argc,2,typeof(string))){
			System.String a1;
			checkType(l,2,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,argc,2,typeof(int))){
			System.Int32 a1;
			checkType(l,2,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,argc,2,typeof(UnityEngine.RenderTexture))){
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderTargetIdentifier");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
	}
}
