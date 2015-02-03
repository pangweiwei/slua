using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TypewriterEffect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		TypewriterEffect o;
		o=new TypewriterEffect();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_charsPerSecond(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.charsPerSecond);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_charsPerSecond(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.charsPerSecond=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"TypewriterEffect");
		addMember(l,"charsPerSecond",get_charsPerSecond,set_charsPerSecond,true);
		createTypeMetatable(l,constructor, typeof(TypewriterEffect),typeof(UnityEngine.MonoBehaviour));
	}
}
