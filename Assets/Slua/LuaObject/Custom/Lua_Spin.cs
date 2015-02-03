using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Spin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		Spin o;
		o=new Spin();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyDelta(IntPtr l) {
		try{
			Spin self=(Spin)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.ApplyDelta(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationsPerSecond(IntPtr l) {
		Spin o = (Spin)checkSelf(l);
		pushValue(l,o.rotationsPerSecond);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationsPerSecond(IntPtr l) {
		Spin o = (Spin)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.rotationsPerSecond=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreTimeScale(IntPtr l) {
		Spin o = (Spin)checkSelf(l);
		pushValue(l,o.ignoreTimeScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		Spin o = (Spin)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreTimeScale=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Spin");
		addMember(l,ApplyDelta);
		addMember(l,"rotationsPerSecond",get_rotationsPerSecond,set_rotationsPerSecond,true);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		createTypeMetatable(l,constructor, typeof(Spin),typeof(UnityEngine.MonoBehaviour));
	}
}
