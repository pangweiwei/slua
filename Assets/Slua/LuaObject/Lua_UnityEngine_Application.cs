using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Application : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Application o;
		if(matchType(l,1)){
			o=new UnityEngine.Application();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Quit(IntPtr l) {
		try{
			UnityEngine.Application.Quit();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CancelQuit(IntPtr l) {
		try{
			UnityEngine.Application.CancelQuit();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadLevel(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Application.LoadLevel(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Application.LoadLevel(a1);
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
	static public int LoadLevelAsync(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.AsyncOperation ret=UnityEngine.Application.LoadLevelAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.AsyncOperation ret=UnityEngine.Application.LoadLevelAsync(a1);
				pushValue(l,ret);
				return 1;
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
	static public int LoadLevelAdditiveAsync(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.AsyncOperation ret=UnityEngine.Application.LoadLevelAdditiveAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.AsyncOperation ret=UnityEngine.Application.LoadLevelAdditiveAsync(a1);
				pushValue(l,ret);
				return 1;
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
	static public int LoadLevelAdditive(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Application.LoadLevelAdditive(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Application.LoadLevelAdditive(a1);
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
	static public int GetStreamProgressForLevel(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Single ret=UnityEngine.Application.GetStreamProgressForLevel(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.Single ret=UnityEngine.Application.GetStreamProgressForLevel(a1);
				pushValue(l,ret);
				return 1;
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
	static public int CanStreamedLevelBeLoaded(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Application.CanStreamedLevelBeLoaded(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Application.CanStreamedLevelBeLoaded(a1);
				pushValue(l,ret);
				return 1;
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
	static public int CaptureScreenshot(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String),typeof(System.Int32))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Application.CaptureScreenshot(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Application.CaptureScreenshot(a1);
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
	static public int HasProLicense(IntPtr l) {
		try{
			System.Boolean ret=UnityEngine.Application.HasProLicense();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExternalCall(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkType(l,2,out a2);
			UnityEngine.Application.ExternalCall(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExternalEval(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Application.ExternalEval(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OpenURL(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Application.OpenURL(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterLogCallback(IntPtr l) {
		try{
			UnityEngine.Application.LogCallback a1;
			checkDelegate(l,1,out a1);
			UnityEngine.Application.RegisterLogCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterLogCallbackThreaded(IntPtr l) {
		try{
			UnityEngine.Application.LogCallback a1;
			checkDelegate(l,1,out a1);
			UnityEngine.Application.RegisterLogCallbackThreaded(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RequestUserAuthorization(IntPtr l) {
		try{
			UnityEngine.UserAuthorization a1;
			checkEnum(l,1,out a1);
			UnityEngine.AsyncOperation ret=UnityEngine.Application.RequestUserAuthorization(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasUserAuthorization(IntPtr l) {
		try{
			UnityEngine.UserAuthorization a1;
			checkEnum(l,1,out a1);
			System.Boolean ret=UnityEngine.Application.HasUserAuthorization(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loadedLevel(IntPtr l) {
		pushValue(l,UnityEngine.Application.loadedLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loadedLevelName(IntPtr l) {
		pushValue(l,UnityEngine.Application.loadedLevelName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLoadingLevel(IntPtr l) {
		pushValue(l,UnityEngine.Application.isLoadingLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_levelCount(IntPtr l) {
		pushValue(l,UnityEngine.Application.levelCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_streamedBytes(IntPtr l) {
		pushValue(l,UnityEngine.Application.streamedBytes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		pushValue(l,UnityEngine.Application.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEditor(IntPtr l) {
		pushValue(l,UnityEngine.Application.isEditor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isWebPlayer(IntPtr l) {
		pushValue(l,UnityEngine.Application.isWebPlayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_platform(IntPtr l) {
		pushValue(l,UnityEngine.Application.platform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMobilePlatform(IntPtr l) {
		pushValue(l,UnityEngine.Application.isMobilePlatform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isConsolePlatform(IntPtr l) {
		pushValue(l,UnityEngine.Application.isConsolePlatform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runInBackground(IntPtr l) {
		pushValue(l,UnityEngine.Application.runInBackground);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runInBackground(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Application.runInBackground=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dataPath(IntPtr l) {
		pushValue(l,UnityEngine.Application.dataPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_streamingAssetsPath(IntPtr l) {
		pushValue(l,UnityEngine.Application.streamingAssetsPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_persistentDataPath(IntPtr l) {
		pushValue(l,UnityEngine.Application.persistentDataPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_temporaryCachePath(IntPtr l) {
		pushValue(l,UnityEngine.Application.temporaryCachePath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_srcValue(IntPtr l) {
		pushValue(l,UnityEngine.Application.srcValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_absoluteURL(IntPtr l) {
		pushValue(l,UnityEngine.Application.absoluteURL);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_unityVersion(IntPtr l) {
		pushValue(l,UnityEngine.Application.unityVersion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_webSecurityEnabled(IntPtr l) {
		pushValue(l,UnityEngine.Application.webSecurityEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_webSecurityHostUrl(IntPtr l) {
		pushValue(l,UnityEngine.Application.webSecurityHostUrl);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetFrameRate(IntPtr l) {
		pushValue(l,UnityEngine.Application.targetFrameRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetFrameRate(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.Application.targetFrameRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemLanguage(IntPtr l) {
		pushValue(l,UnityEngine.Application.systemLanguage);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundLoadingPriority(IntPtr l) {
		pushValue(l,UnityEngine.Application.backgroundLoadingPriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundLoadingPriority(IntPtr l) {
		UnityEngine.ThreadPriority v;
		checkEnum(l,2,out v);
		UnityEngine.Application.backgroundLoadingPriority=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_internetReachability(IntPtr l) {
		pushValue(l,UnityEngine.Application.internetReachability);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_genuine(IntPtr l) {
		pushValue(l,UnityEngine.Application.genuine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_genuineCheckAvailable(IntPtr l) {
		pushValue(l,UnityEngine.Application.genuineCheckAvailable);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Application");
		addMember(l,Quit, "Quit");
		addMember(l,CancelQuit, "CancelQuit");
		addMember(l,LoadLevel, "LoadLevel");
		addMember(l,LoadLevelAsync, "LoadLevelAsync");
		addMember(l,LoadLevelAdditiveAsync, "LoadLevelAdditiveAsync");
		addMember(l,LoadLevelAdditive, "LoadLevelAdditive");
		addMember(l,GetStreamProgressForLevel, "GetStreamProgressForLevel");
		addMember(l,CanStreamedLevelBeLoaded, "CanStreamedLevelBeLoaded");
		addMember(l,CaptureScreenshot, "CaptureScreenshot");
		addMember(l,HasProLicense, "HasProLicense");
		addMember(l,ExternalCall, "ExternalCall");
		addMember(l,ExternalEval, "ExternalEval");
		addMember(l,OpenURL, "OpenURL");
		addMember(l,RegisterLogCallback, "RegisterLogCallback");
		addMember(l,RegisterLogCallbackThreaded, "RegisterLogCallbackThreaded");
		addMember(l,RequestUserAuthorization, "RequestUserAuthorization");
		addMember(l,HasUserAuthorization, "HasUserAuthorization");
		addMember(l,get_loadedLevel, "get_loadedLevel");
		addMember(l,get_loadedLevelName, "get_loadedLevelName");
		addMember(l,get_isLoadingLevel, "get_isLoadingLevel");
		addMember(l,get_levelCount, "get_levelCount");
		addMember(l,get_streamedBytes, "get_streamedBytes");
		addMember(l,get_isPlaying, "get_isPlaying");
		addMember(l,get_isEditor, "get_isEditor");
		addMember(l,get_isWebPlayer, "get_isWebPlayer");
		addMember(l,get_platform, "get_platform");
		addMember(l,get_isMobilePlatform, "get_isMobilePlatform");
		addMember(l,get_isConsolePlatform, "get_isConsolePlatform");
		addMember(l,get_runInBackground, "get_runInBackground");
		addMember(l,set_runInBackground, "set_runInBackground");
		addMember(l,get_dataPath, "get_dataPath");
		addMember(l,get_streamingAssetsPath, "get_streamingAssetsPath");
		addMember(l,get_persistentDataPath, "get_persistentDataPath");
		addMember(l,get_temporaryCachePath, "get_temporaryCachePath");
		addMember(l,get_srcValue, "get_srcValue");
		addMember(l,get_absoluteURL, "get_absoluteURL");
		addMember(l,get_unityVersion, "get_unityVersion");
		addMember(l,get_webSecurityEnabled, "get_webSecurityEnabled");
		addMember(l,get_webSecurityHostUrl, "get_webSecurityHostUrl");
		addMember(l,get_targetFrameRate, "get_targetFrameRate");
		addMember(l,set_targetFrameRate, "set_targetFrameRate");
		addMember(l,get_systemLanguage, "get_systemLanguage");
		addMember(l,get_backgroundLoadingPriority, "get_backgroundLoadingPriority");
		addMember(l,set_backgroundLoadingPriority, "set_backgroundLoadingPriority");
		addMember(l,get_internetReachability, "get_internetReachability");
		addMember(l,get_genuine, "get_genuine");
		addMember(l,get_genuineCheckAvailable, "get_genuineCheckAvailable");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Application));
		LuaDLL.lua_pop(l, 1);
	}
}
