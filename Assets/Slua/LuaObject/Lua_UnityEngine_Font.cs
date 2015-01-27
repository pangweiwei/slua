using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Font : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Font o;
		if(matchType(l,1)){
			o=new UnityEngine.Font();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Font(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasCharacter(IntPtr l) {
		try{
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.HasCharacter(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RequestCharactersInTexture(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Int32),typeof(UnityEngine.FontStyle))){
				UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.FontStyle a3;
				checkEnum(l,4,out a3);
				self.RequestCharactersInTexture(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(System.Int32))){
				UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.RequestCharactersInTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.RequestCharactersInTexture(a1);
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
	static public int GetCharacterInfo(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Char),typeof(UnityEngine.CharacterInfo),typeof(System.Int32),typeof(UnityEngine.FontStyle))){
				UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
				System.Char a1;
				checkType(l,2,out a1);
				UnityEngine.CharacterInfo a2;
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.FontStyle a4;
				checkEnum(l,5,out a4);
				System.Boolean ret=self.GetCharacterInfo(a1,out a2,a3,a4);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,2,typeof(System.Char),typeof(UnityEngine.CharacterInfo),typeof(System.Int32))){
				UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
				System.Char a1;
				checkType(l,2,out a1);
				UnityEngine.CharacterInfo a2;
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Boolean ret=self.GetCharacterInfo(a1,out a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,2,typeof(System.Char),typeof(UnityEngine.CharacterInfo))){
				UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
				System.Char a1;
				checkType(l,2,out a1);
				UnityEngine.CharacterInfo a2;
				System.Boolean ret=self.GetCharacterInfo(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
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
	static public int GetMaxVertsForString_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.Font.GetMaxVertsForString(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontNames(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		pushValue(l,o.fontNames);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontNames(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		string[] v;
		checkType(l,2,out v);
		o.fontNames=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterInfo(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		pushValue(l,o.characterInfo);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterInfo(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		UnityEngine.CharacterInfo[] v;
		checkType(l,2,out v);
		o.characterInfo=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRebuildCallback(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textureRebuildCallback(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamic(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		pushValue(l,o.dynamic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.Font o = (UnityEngine.Font)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Font");
		addMember(l,HasCharacter);
		addMember(l,RequestCharactersInTexture);
		addMember(l,GetCharacterInfo);
		addMember(l,GetMaxVertsForString_s);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"fontNames",get_fontNames,set_fontNames,true);
		addMember(l,"characterInfo",get_characterInfo,set_characterInfo,true);
		addMember(l,"textureRebuildCallback",get_textureRebuildCallback,set_textureRebuildCallback,true);
		addMember(l,"dynamic",get_dynamic,null,true);
		addMember(l,"fontSize",get_fontSize,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Font),typeof(UnityEngine.Object));
	}
}
