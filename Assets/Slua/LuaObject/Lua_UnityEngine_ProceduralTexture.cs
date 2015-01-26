using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ProceduralTexture o;
		if(matchType(l,1)){
			o=new UnityEngine.ProceduralTexture();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralOutputType(IntPtr l) {
		try{
			UnityEngine.ProceduralTexture self=(UnityEngine.ProceduralTexture)checkSelf(l);
			UnityEngine.ProceduralOutputType ret=self.GetProceduralOutputType();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixels32(IntPtr l) {
		try{
			UnityEngine.ProceduralTexture self=(UnityEngine.ProceduralTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Color32[] ret=self.GetPixels32(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasAlpha(IntPtr l) {
		UnityEngine.ProceduralTexture o = (UnityEngine.ProceduralTexture)checkSelf(l);
		pushValue(l,o.hasAlpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		UnityEngine.ProceduralTexture o = (UnityEngine.ProceduralTexture)checkSelf(l);
		pushValue(l,o.format);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ProceduralTexture");
		addMember(l,GetProceduralOutputType);
		addMember(l,GetPixels32);
		addMember(l,"hasAlpha",get_hasAlpha,null);
		addMember(l,"format",get_format,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ProceduralTexture),typeof(UnityEngine.Texture));
	}
}
