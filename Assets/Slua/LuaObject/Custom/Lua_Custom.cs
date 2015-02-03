using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Custom : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		Custom o;
		o=new Custom();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getTypeName(IntPtr l) {
		try{
			Custom self=(Custom)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.String ret=self.getTypeName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Custom");
		addMember(l,getTypeName);
		addMember(l,Custom.instanceCustom,true);
		addMember(l,Custom.staticCustom,false);
		createTypeMetatable(l,constructor, typeof(Custom),typeof(UnityEngine.MonoBehaviour));
	}
}
