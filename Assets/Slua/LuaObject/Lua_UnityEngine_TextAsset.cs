using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.TextAsset o;
		o=new UnityEngine.TextAsset();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.TextAsset o = (UnityEngine.TextAsset)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bytes(IntPtr l) {
		UnityEngine.TextAsset o = (UnityEngine.TextAsset)checkSelf(l);
		pushValue(l,o.bytes);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextAsset");
		addMember(l,"text",get_text,null,true);
		addMember(l,"bytes",get_bytes,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TextAsset),typeof(UnityEngine.Object));
	}
}
