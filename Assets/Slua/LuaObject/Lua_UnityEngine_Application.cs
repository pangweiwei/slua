using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Application : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Application o;
		o=new UnityEngine.Application();
		pushObject(l,o);
		return 1;
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Application.LoadLevel(a1);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(string))){
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.AsyncOperation ret=UnityEngine.Application.LoadLevelAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string))){
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.AsyncOperation ret=UnityEngine.Application.LoadLevelAdditiveAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string))){
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Application.LoadLevelAdditive(a1);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(string))){
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Single ret=UnityEngine.Application.GetStreamProgressForLevel(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string))){
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Application.CanStreamedLevelBeLoaded(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string))){
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Application.CaptureScreenshot(a1,a2);
				return 0;
			}
			else if(argc==1){
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
			checkParams(l,2,out a2);
			UnityEngine.Application.ExternalCall(a1,a2);
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
		pushEnum(l,(int)UnityEngine.Application.platform);
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
		pushEnum(l,(int)UnityEngine.Application.systemLanguage);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundLoadingPriority(IntPtr l) {
		pushEnum(l,(int)UnityEngine.Application.backgroundLoadingPriority);
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
		pushEnum(l,(int)UnityEngine.Application.internetReachability);
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
		addMember(l,OpenURL_s);
		addMember(l,RegisterLogCallback_s);
		addMember(l,RegisterLogCallbackThreaded_s);
		addMember(l,RequestUserAuthorization_s);
		addMember(l,HasUserAuthorization_s);
		addMember(l,"loadedLevel",get_loadedLevel,null,false);
		addMember(l,"loadedLevelName",get_loadedLevelName,null,false);
		addMember(l,"isLoadingLevel",get_isLoadingLevel,null,false);
		addMember(l,"levelCount",get_levelCount,null,false);
		addMember(l,"streamedBytes",get_streamedBytes,null,false);
		addMember(l,"isPlaying",get_isPlaying,null,false);
		addMember(l,"isEditor",get_isEditor,null,false);
		addMember(l,"isWebPlayer",get_isWebPlayer,null,false);
		addMember(l,"platform",get_platform,null,false);
		addMember(l,"isMobilePlatform",get_isMobilePlatform,null,false);
		addMember(l,"isConsolePlatform",get_isConsolePlatform,null,false);
		addMember(l,"runInBackground",get_runInBackground,set_runInBackground,false);
		addMember(l,"dataPath",get_dataPath,null,false);
		addMember(l,"streamingAssetsPath",get_streamingAssetsPath,null,false);
		addMember(l,"persistentDataPath",get_persistentDataPath,null,false);
		addMember(l,"temporaryCachePath",get_temporaryCachePath,null,false);
		addMember(l,"srcValue",get_srcValue,null,false);
		addMember(l,"absoluteURL",get_absoluteURL,null,false);
		addMember(l,"unityVersion",get_unityVersion,null,false);
		addMember(l,"webSecurityEnabled",get_webSecurityEnabled,null,false);
		addMember(l,"webSecurityHostUrl",get_webSecurityHostUrl,null,false);
		addMember(l,"targetFrameRate",get_targetFrameRate,set_targetFrameRate,false);
		addMember(l,"systemLanguage",get_systemLanguage,null,false);
		addMember(l,"backgroundLoadingPriority",get_backgroundLoadingPriority,set_backgroundLoadingPriority,false);
		addMember(l,"internetReachability",get_internetReachability,null,false);
		addMember(l,"genuine",get_genuine,null,false);
		addMember(l,"genuineCheckAvailable",get_genuineCheckAvailable,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Application));
	}
}
