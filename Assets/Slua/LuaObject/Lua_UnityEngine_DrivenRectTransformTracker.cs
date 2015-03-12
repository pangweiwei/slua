using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DrivenRectTransformTracker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try{
			UnityEngine.DrivenRectTransformTracker self=(UnityEngine.DrivenRectTransformTracker)checkSelf(l);
			UnityEngine.Object a1;
			checkType(l,2,out a1);
			UnityEngine.RectTransform a2;
			checkType(l,3,out a2);
			UnityEngine.DrivenTransformProperties a3;
			checkEnum(l,4,out a3);
			self.Add(a1,a2,a3);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.DrivenRectTransformTracker self=(UnityEngine.DrivenRectTransformTracker)checkSelf(l);
			self.Clear();
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DrivenRectTransformTracker");
		addMember(l,Add);
		addMember(l,Clear);
		createTypeMetatable(l,constructor, typeof(UnityEngine.DrivenRectTransformTracker));
	}
}
