using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Tutorial5 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		Tutorial5 o;
		o=new Tutorial5();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDurationToCurrentProgress(IntPtr l) {
		try{
			Tutorial5 self=(Tutorial5)checkSelf(l);
			self.SetDurationToCurrentProgress();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Tutorial5");
		addMember(l,SetDurationToCurrentProgress);
		createTypeMetatable(l,constructor, typeof(Tutorial5),typeof(UnityEngine.MonoBehaviour));
	}
}
