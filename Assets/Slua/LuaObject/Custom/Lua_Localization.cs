using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Localization : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load_s(IntPtr l) {
		try{
			UnityEngine.TextAsset a1;
			checkType(l,1,out a1);
			Localization.Load(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string),typeof(System.Byte[]))){
				System.String a1;
				checkType(l,1,out a1);
				System.Byte[] a2;
				checkType(l,2,out a2);
				Localization.Set(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(Dictionary<System.String,System.String>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.Dictionary<System.String,System.String> a2;
				checkType(l,2,out a2);
				Localization.Set(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				Localization.Set(a1,a2);
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
	static public int LoadCSV_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.TextAsset),typeof(bool))){
				UnityEngine.TextAsset a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				System.Boolean ret=Localization.LoadCSV(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(System.Byte[]),typeof(bool))){
				System.Byte[] a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				System.Boolean ret=Localization.LoadCSV(a1,a2);
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
	static public int Get_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.String ret=Localization.Get(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Format_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			System.String ret=Localization.Format(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Exists_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=Localization.Exists(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loadFunction(IntPtr l) {
		Localization.LoadFunction v;
		int op=checkDelegate(l,2,out v);
		if(op==0) Localization.loadFunction=v;
		else if(op==1) Localization.loadFunction+=v;
		else if(op==2) Localization.loadFunction-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onLocalize(IntPtr l) {
		Localization.OnLocalizeNotification v;
		int op=checkDelegate(l,2,out v);
		if(op==0) Localization.onLocalize=v;
		else if(op==1) Localization.onLocalize+=v;
		else if(op==2) Localization.onLocalize-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localizationHasBeenSet(IntPtr l) {
		pushValue(l,Localization.localizationHasBeenSet);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localizationHasBeenSet(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		Localization.localizationHasBeenSet=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dictionary(IntPtr l) {
		pushValue(l,Localization.dictionary);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dictionary(IntPtr l) {
		Dictionary<System.String,System.String[]> v;
		checkType(l,2,out v);
		Localization.dictionary=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_knownLanguages(IntPtr l) {
		pushValue(l,Localization.knownLanguages);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_language(IntPtr l) {
		pushValue(l,Localization.language);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_language(IntPtr l) {
		string v;
		checkType(l,2,out v);
		Localization.language=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Localization");
		addMember(l,Load_s);
		addMember(l,Set_s);
		addMember(l,LoadCSV_s);
		addMember(l,Get_s);
		addMember(l,Format_s);
		addMember(l,Exists_s);
		addMember(l,"loadFunction",null,set_loadFunction,false);
		addMember(l,"onLocalize",null,set_onLocalize,false);
		addMember(l,"localizationHasBeenSet",get_localizationHasBeenSet,set_localizationHasBeenSet,false);
		addMember(l,"dictionary",get_dictionary,set_dictionary,false);
		addMember(l,"knownLanguages",get_knownLanguages,null,false);
		addMember(l,"language",get_language,set_language,false);
		createTypeMetatable(l,constructor, typeof(Localization));
	}
}
