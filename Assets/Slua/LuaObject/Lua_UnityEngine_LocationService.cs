using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LocationService : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LocationService o;
		if(matchType(l,1)){
			o=new UnityEngine.LocationService();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Start(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Single),typeof(System.Single))){
				UnityEngine.LocationService self=(UnityEngine.LocationService)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.Start(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single))){
				UnityEngine.LocationService self=(UnityEngine.LocationService)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Start(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.LocationService self=(UnityEngine.LocationService)checkSelf(l);
				self.Start();
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			UnityEngine.LocationService self=(UnityEngine.LocationService)checkSelf(l);
			self.Stop();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEnabledByUser(IntPtr l) {
		UnityEngine.LocationService o = (UnityEngine.LocationService)checkSelf(l);
		pushValue(l,o.isEnabledByUser);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_status(IntPtr l) {
		UnityEngine.LocationService o = (UnityEngine.LocationService)checkSelf(l);
		pushValue(l,o.status);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastData(IntPtr l) {
		UnityEngine.LocationService o = (UnityEngine.LocationService)checkSelf(l);
		pushValue(l,o.lastData);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LocationService");
		addMember(l,Start);
		addMember(l,Stop);
		addMember(l,"isEnabledByUser",get_isEnabledByUser,null,true);
		addMember(l,"status",get_status,null,true);
		addMember(l,"lastData",get_lastData,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LocationService));
	}
}
