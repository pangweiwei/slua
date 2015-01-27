using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Debug : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Debug o;
		if(matchType(l,1)){
			o=new UnityEngine.Debug();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawLine_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Color),typeof(System.Single),typeof(System.Boolean))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				UnityEngine.Debug.DrawLine(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Color),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Debug.DrawLine(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Color))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.Debug.DrawLine(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.DrawLine(a1,a2);
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
	static public int DrawRay_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Color),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Debug.DrawRay(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Color))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.Debug.DrawRay(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.DrawRay(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Color),typeof(System.Single),typeof(System.Boolean))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				UnityEngine.Debug.DrawRay(a1,a2,a3,a4,a5);
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
	static public int Break_s(IntPtr l) {
		try{
			UnityEngine.Debug.Break();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DebugBreak_s(IntPtr l) {
		try{
			UnityEngine.Debug.DebugBreak();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Log_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Object))){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.Log(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Object),typeof(UnityEngine.Object))){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.Log(a1,a2);
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
	static public int LogError_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Object))){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogError(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Object),typeof(UnityEngine.Object))){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogError(a1,a2);
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
	static public int ClearDeveloperConsole_s(IntPtr l) {
		try{
			UnityEngine.Debug.ClearDeveloperConsole();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LogException_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Exception))){
				System.Exception a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogException(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Exception),typeof(UnityEngine.Object))){
				System.Exception a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogException(a1,a2);
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
	static public int LogWarning_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Object))){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogWarning(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Object),typeof(UnityEngine.Object))){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogWarning(a1,a2);
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
	static public int get_developerConsoleVisible(IntPtr l) {
		pushValue(l,UnityEngine.Debug.developerConsoleVisible);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_developerConsoleVisible(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Debug.developerConsoleVisible=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDebugBuild(IntPtr l) {
		pushValue(l,UnityEngine.Debug.isDebugBuild);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Debug");
		addMember(l,DrawLine_s);
		addMember(l,DrawRay_s);
		addMember(l,Break_s);
		addMember(l,DebugBreak_s);
		addMember(l,Log_s);
		addMember(l,LogError_s);
		addMember(l,ClearDeveloperConsole_s);
		addMember(l,LogException_s);
		addMember(l,LogWarning_s);
		addMember(l,"developerConsoleVisible",get_developerConsoleVisible,set_developerConsoleVisible,false);
		addMember(l,"isDebugBuild",get_isDebugBuild,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Debug));
	}
}
