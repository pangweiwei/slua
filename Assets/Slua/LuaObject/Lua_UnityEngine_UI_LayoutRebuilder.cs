using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutRebuilder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsDestroyed(IntPtr l) {
		try{
			UnityEngine.UI.LayoutRebuilder self=checkSelf<UnityEngine.UI.LayoutRebuilder>(l);
			System.Boolean ret=self.IsDestroyed();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkLayoutForRebuild(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.UI.LayoutRebuilder o = checkSelf<UnityEngine.UI.LayoutRebuilder>(l);
		pushValue(l,o.transform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutRebuilder");
		addMember(l,IsDestroyed, "IsDestroyed");
		addMember(l,MarkLayoutForRebuild, "MarkLayoutForRebuild");
		addMember(l,get_transform, "get_transform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.LayoutRebuilder));
		LuaDLL.lua_pop(l, 1);
	}
}
