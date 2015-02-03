using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Localization : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		Localization o;
		o=new Localization();
		pushObject(l,o);
		return 1;
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
	static public int LoadCSV_s(IntPtr l) {
		try{
			UnityEngine.TextAsset a1;
			checkType(l,1,out a1);
			System.Boolean ret=Localization.LoadCSV(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Collections.Generic.Dictionary<System.String,System.String> a2;
			checkType(l,2,out a2);
			Localization.Set(a1,a2);
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
	static public int get_knownLanguages(IntPtr l) {
		pushValue(l,Localization.knownLanguages);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_knownLanguages(IntPtr l) {
		System.String[] v;
		checkType(l,2,out v);
		Localization.knownLanguages=v;
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
	static public int get_startingLanguage(IntPtr l) {
		Localization o = (Localization)checkSelf(l);
		pushValue(l,o.startingLanguage);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startingLanguage(IntPtr l) {
		Localization o = (Localization)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.startingLanguage=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_languages(IntPtr l) {
		Localization o = (Localization)checkSelf(l);
		pushValue(l,o.languages);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_languages(IntPtr l) {
		Localization o = (Localization)checkSelf(l);
		UnityEngine.TextAsset[] v;
		checkType(l,2,out v);
		o.languages=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dictionary(IntPtr l) {
		pushValue(l,Localization.dictionary);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isActive(IntPtr l) {
		pushValue(l,Localization.isActive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_instance(IntPtr l) {
		pushValue(l,Localization.instance);
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
		addMember(l,LoadCSV_s);
		addMember(l,Set_s);
		addMember(l,Get_s);
		addMember(l,Exists_s);
		addMember(l,"knownLanguages",get_knownLanguages,set_knownLanguages,false);
		addMember(l,"localizationHasBeenSet",get_localizationHasBeenSet,set_localizationHasBeenSet,false);
		addMember(l,"startingLanguage",get_startingLanguage,set_startingLanguage,true);
		addMember(l,"languages",get_languages,set_languages,true);
		addMember(l,"dictionary",get_dictionary,null,false);
		addMember(l,"isActive",get_isActive,null,false);
		addMember(l,"instance",get_instance,null,false);
		addMember(l,"language",get_language,set_language,false);
		createTypeMetatable(l,constructor, typeof(Localization),typeof(UnityEngine.MonoBehaviour));
	}
}
