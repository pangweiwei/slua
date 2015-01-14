using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_RawImage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNativeSize(IntPtr l) {
		try{
			UnityEngine.UI.RawImage self=checkSelf<UnityEngine.UI.RawImage>(l);
			self.SetNativeSize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.RawImage o = checkSelf<UnityEngine.UI.RawImage>(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UnityEngine.UI.RawImage o = checkSelf<UnityEngine.UI.RawImage>(l);
		pushValue(l,o.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_texture(IntPtr l) {
		UnityEngine.UI.RawImage o = checkSelf<UnityEngine.UI.RawImage>(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.texture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		UnityEngine.UI.RawImage o = checkSelf<UnityEngine.UI.RawImage>(l);
		pushValue(l,o.uvRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvRect(IntPtr l) {
		UnityEngine.UI.RawImage o = checkSelf<UnityEngine.UI.RawImage>(l);
		UnityEngine.Rect v;
		checkType(l,2,out v);
		o.uvRect=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.RawImage");
		addMember(l,SetNativeSize, "SetNativeSize");
		addMember(l,get_mainTexture, "get_mainTexture");
		addMember(l,get_texture, "get_texture");
		addMember(l,set_texture, "set_texture");
		addMember(l,get_uvRect, "get_uvRect");
		addMember(l,set_uvRect, "set_uvRect");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.RawImage),typeof(UnityEngine.UI.MaskableGraphic));
		LuaDLL.lua_pop(l, 1);
	}
}
