using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SpringPanel : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		SpringPanel o;
		o=new SpringPanel();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			SpringPanel ret=SpringPanel.Begin(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,SpringPanel.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		SpringPanel v;
		checkType(l,2,out v);
		SpringPanel.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		SpringPanel o = (SpringPanel)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		SpringPanel o = (SpringPanel)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_strength(IntPtr l) {
		SpringPanel o = (SpringPanel)checkSelf(l);
		pushValue(l,o.strength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_strength(IntPtr l) {
		SpringPanel o = (SpringPanel)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.strength=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		SpringPanel o = (SpringPanel)checkSelf(l);
		SpringPanel.OnFinished v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onFinished=v;
		else if(op==1) o.onFinished+=v;
		else if(op==2) o.onFinished-=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"SpringPanel");
		addMember(l,Begin_s);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"strength",get_strength,set_strength,true);
		addMember(l,"onFinished",null,set_onFinished,true);
		createTypeMetatable(l,constructor, typeof(SpringPanel),typeof(UnityEngine.MonoBehaviour));
	}
}
