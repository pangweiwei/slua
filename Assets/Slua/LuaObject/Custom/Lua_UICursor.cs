using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICursor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UICursor o;
		o=new UICursor();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear_s(IntPtr l) {
		try{
			UICursor.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set_s(IntPtr l) {
		try{
			UIAtlas a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UICursor.Set(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_instance(IntPtr l) {
		pushValue(l,UICursor.instance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_instance(IntPtr l) {
		UICursor v;
		checkType(l,2,out v);
		UICursor.instance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		UICursor o = (UICursor)checkSelf(l);
		pushValue(l,o.uiCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiCamera(IntPtr l) {
		UICursor o = (UICursor)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.uiCamera=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICursor");
		addMember(l,Clear_s);
		addMember(l,Set_s);
		addMember(l,"instance",get_instance,set_instance,false);
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		createTypeMetatable(l,constructor, typeof(UICursor),typeof(UnityEngine.MonoBehaviour));
	}
}
