using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIAtlas : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIAtlas o;
		o=new UIAtlas();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSprite(IntPtr l) {
		try{
			UIAtlas self=(UIAtlas)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UISpriteData ret=self.GetSprite(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortAlphabetically(IntPtr l) {
		try{
			UIAtlas self=(UIAtlas)checkSelf(l);
			self.SortAlphabetically();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetListOfSprites(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				UIAtlas self=(UIAtlas)checkSelf(l);
				BetterList<System.String> ret=self.GetListOfSprites();
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UIAtlas self=(UIAtlas)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				BetterList<System.String> ret=self.GetListOfSprites(a1);
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
	static public int MarkAsChanged(IntPtr l) {
		try{
			UIAtlas self=(UIAtlas)checkSelf(l);
			self.MarkAsChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckIfRelated_s(IntPtr l) {
		try{
			UIAtlas a1;
			checkType(l,1,out a1);
			UIAtlas a2;
			checkType(l,2,out a2);
			System.Boolean ret=UIAtlas.CheckIfRelated(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteMaterial(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		pushValue(l,o.spriteMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteMaterial(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.spriteMaterial=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlpha(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		pushValue(l,o.premultipliedAlpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteList(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		pushValue(l,o.spriteList);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteList(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		List<UISpriteData> v;
		checkType(l,2,out v);
		o.spriteList=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		pushValue(l,o.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSize(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		pushValue(l,o.pixelSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelSize(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.pixelSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_replacement(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		pushValue(l,o.replacement);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_replacement(IntPtr l) {
		UIAtlas o = (UIAtlas)checkSelf(l);
		UIAtlas v;
		checkType(l,2,out v);
		o.replacement=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIAtlas");
		addMember(l,GetSprite);
		addMember(l,SortAlphabetically);
		addMember(l,GetListOfSprites);
		addMember(l,MarkAsChanged);
		addMember(l,CheckIfRelated_s);
		addMember(l,"spriteMaterial",get_spriteMaterial,set_spriteMaterial,true);
		addMember(l,"premultipliedAlpha",get_premultipliedAlpha,null,true);
		addMember(l,"spriteList",get_spriteList,set_spriteList,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"pixelSize",get_pixelSize,set_pixelSize,true);
		addMember(l,"replacement",get_replacement,set_replacement,true);
		createTypeMetatable(l,constructor, typeof(UIAtlas),typeof(UnityEngine.MonoBehaviour));
	}
}
