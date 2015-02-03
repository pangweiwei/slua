using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIToggledObjects : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIToggledObjects o;
		o=new UIToggledObjects();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Toggle(IntPtr l) {
		try{
			UIToggledObjects self=(UIToggledObjects)checkSelf(l);
			self.Toggle();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activate(IntPtr l) {
		UIToggledObjects o = (UIToggledObjects)checkSelf(l);
		pushValue(l,o.activate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activate(IntPtr l) {
		UIToggledObjects o = (UIToggledObjects)checkSelf(l);
		System.Collections.Generic.List<UnityEngine.GameObject> v;
		checkType(l,2,out v);
		o.activate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deactivate(IntPtr l) {
		UIToggledObjects o = (UIToggledObjects)checkSelf(l);
		pushValue(l,o.deactivate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_deactivate(IntPtr l) {
		UIToggledObjects o = (UIToggledObjects)checkSelf(l);
		System.Collections.Generic.List<UnityEngine.GameObject> v;
		checkType(l,2,out v);
		o.deactivate=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIToggledObjects");
		addMember(l,Toggle);
		addMember(l,"activate",get_activate,set_activate,true);
		addMember(l,"deactivate",get_deactivate,set_deactivate,true);
		createTypeMetatable(l,constructor, typeof(UIToggledObjects),typeof(UnityEngine.MonoBehaviour));
	}
}
