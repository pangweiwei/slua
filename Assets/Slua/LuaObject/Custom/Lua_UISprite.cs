using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISprite o;
		o=new UISprite();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAtlasSprite(IntPtr l) {
		try{
			UISprite self=(UISprite)checkSelf(l);
			UISpriteData ret=self.GetAtlasSprite();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MakePixelPerfect(IntPtr l) {
		try{
			UISprite self=(UISprite)checkSelf(l);
			self.MakePixelPerfect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnFill(IntPtr l) {
		try{
			UISprite self=(UISprite)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Color32> a3;
			checkType(l,4,out a3);
			self.OnFill(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_atlas(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.atlas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_atlas(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UIAtlas v;
		checkType(l,2,out v);
		o.atlas=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteName(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.spriteName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteName(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.spriteName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.border);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSize(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.pixelSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawingDimensions(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.drawingDimensions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlpha(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.premultipliedAlpha);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISprite");
		addMember(l,GetAtlasSprite);
		addMember(l,MakePixelPerfect);
		addMember(l,OnFill);
		addMember(l,"material",get_material,null,true);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		addMember(l,"spriteName",get_spriteName,set_spriteName,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"border",get_border,null,true);
		addMember(l,"pixelSize",get_pixelSize,null,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"drawingDimensions",get_drawingDimensions,null,true);
		addMember(l,"premultipliedAlpha",get_premultipliedAlpha,null,true);
		createTypeMetatable(l,constructor, typeof(UISprite),typeof(UIBasicSprite));
	}
}
