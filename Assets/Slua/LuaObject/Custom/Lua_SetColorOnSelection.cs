using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SetColorOnSelection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		SetColorOnSelection o;
		o=new SetColorOnSelection();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSpriteBySelection(IntPtr l) {
		try{
			SetColorOnSelection self=(SetColorOnSelection)checkSelf(l);
			self.SetSpriteBySelection();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"SetColorOnSelection");
		addMember(l,SetSpriteBySelection);
		createTypeMetatable(l,constructor, typeof(SetColorOnSelection),typeof(UnityEngine.MonoBehaviour));
	}
}
