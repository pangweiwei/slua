using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Custom : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getTypeName(IntPtr l) {
		try {
			Custom self=(Custom)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.getTypeName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getItem(IntPtr l) {
		try {
			Custom self=(Custom)checkSelf(l);
			string v;
			checkType(l,2,out v);
			var ret = self[v];
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setItem(IntPtr l) {
		try {
			Custom self=(Custom)checkSelf(l);
			string v;
			checkType(l,2,out v);
			int c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Custom");
		addMember(l,getTypeName);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,Custom.instanceCustom,true);
		addMember(l,Custom.staticCustom,false);
		createTypeMetatable(l,null, typeof(Custom),typeof(UnityEngine.MonoBehaviour));
	}
}
