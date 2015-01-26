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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Quit_s(IntPtr l) {
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
	static public int CancelQuit_s(IntPtr l) {
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
	static public int LoadLevel_s(IntPtr l) {
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
	static public int LoadLevelAsync_s(IntPtr l) {
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
	static public int LoadLevelAdditiveAsync_s(IntPtr l) {
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
	static public int LoadLevelAdditive_s(IntPtr l) {
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
	static public int GetStreamProgressForLevel_s(IntPtr l) {
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
	static public int CanStreamedLevelBeLoaded_s(IntPtr l) {
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
	static public int CaptureScreenshot_s(IntPtr l) {
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
	static public int HasProLicense_s(IntPtr l) {
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
	static public int ExternalCall_s(IntPtr l) {
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
	static public int ExternalEval_s(IntPtr l) {
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
	static public int OpenURL_s(IntPtr l) {
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
	static public int RegisterLogCallback_s(IntPtr l) {
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
	static public int RegisterLogCallbackThreaded_s(IntPtr l) {
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
	static public int RequestUserAuthorization_s(IntPtr l) {
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
	static public int HasUserAuthorization_s(IntPtr l) {
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
		bool v;
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
		int v;
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
		addMember(l,Quit_s);
		addMember(l,CancelQuit_s);
		addMember(l,LoadLevel_s);
		addMember(l,LoadLevelAsync_s);
		addMember(l,LoadLevelAdditiveAsync_s);
		addMember(l,LoadLevelAdditive_s);
		addMember(l,GetStreamProgressForLevel_s);
		addMember(l,CanStreamedLevelBeLoaded_s);
		addMember(l,CaptureScreenshot_s);
		addMember(l,HasProLicense_s);
		addMember(l,ExternalCall_s);
		addMember(l,ExternalEval_s);
		addMember(l,OpenURL_s);
		addMember(l,RegisterLogCallback_s);
		addMember(l,RegisterLogCallbackThreaded_s);
		addMember(l,RequestUserAuthorization_s);
		addMember(l,HasUserAuthorization_s);
		addMember(l,"loadedLevel",get_loadedLevel,null);
		addMember(l,"loadedLevelName",get_loadedLevelName,null);
		addMember(l,"isLoadingLevel",get_isLoadingLevel,null);
		addMember(l,"levelCount",get_levelCount,null);
		addMember(l,"streamedBytes",get_streamedBytes,null);
		addMember(l,"isPlaying",get_isPlaying,null);
		addMember(l,"isEditor",get_isEditor,null);
		addMember(l,"isWebPlayer",get_isWebPlayer,null);
		addMember(l,"platform",get_platform,null);
		addMember(l,"isMobilePlatform",get_isMobilePlatform,null);
		addMember(l,"isConsolePlatform",get_isConsolePlatform,null);
		addMember(l,"runInBackground",get_runInBackground,set_runInBackground);
		addMember(l,"dataPath",get_dataPath,null);
		addMember(l,"streamingAssetsPath",get_streamingAssetsPath,null);
		addMember(l,"persistentDataPath",get_persistentDataPath,null);
		addMember(l,"temporaryCachePath",get_temporaryCachePath,null);
		addMember(l,"srcValue",get_srcValue,null);
		addMember(l,"absoluteURL",get_absoluteURL,null);
		addMember(l,"unityVersion",get_unityVersion,null);
		addMember(l,"webSecurityEnabled",get_webSecurityEnabled,null);
		addMember(l,"webSecurityHostUrl",get_webSecurityHostUrl,null);
		addMember(l,"targetFrameRate",get_targetFrameRate,set_targetFrameRate);
		addMember(l,"systemLanguage",get_systemLanguage,null);
		addMember(l,"backgroundLoadingPriority",get_backgroundLoadingPriority,set_backgroundLoadingPriority);
		addMember(l,"internetReachability",get_internetReachability,null);
		addMember(l,"genuine",get_genuine,null);
		addMember(l,"genuineCheckAvailable",get_genuineCheckAvailable,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Application));
	}
}
