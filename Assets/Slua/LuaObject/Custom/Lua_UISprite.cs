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
	static public int get_centerType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.centerType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.centerType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_leftType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.leftType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_leftType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.leftType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rightType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.rightType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rightType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.rightType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottomType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.bottomType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottomType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.bottomType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_topType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.topType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_topType(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.topType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.Type v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
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
	static public int get_fillDirection(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushEnum(l,(int)o.fillDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillDirection(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		UISprite.FillDirection v;
		checkEnum(l,2,out v);
		o.fillDirection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillAmount(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.fillAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.fillAmount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_invert(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.invert);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_invert(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.invert=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		UISprite o = (UISprite)checkSelf(l);
		pushValue(l,o.border);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISprite");
		addMember(l,GetAtlasSprite);
		addMember(l,MakePixelPerfect);
		addMember(l,OnFill);
		addMember(l,"centerType",get_centerType,set_centerType,true);
		addMember(l,"leftType",get_leftType,set_leftType,true);
		addMember(l,"rightType",get_rightType,set_rightType,true);
		addMember(l,"bottomType",get_bottomType,set_bottomType,true);
		addMember(l,"topType",get_topType,set_topType,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"material",get_material,null,true);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		addMember(l,"spriteName",get_spriteName,set_spriteName,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"fillDirection",get_fillDirection,set_fillDirection,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"invert",get_invert,set_invert,true);
		addMember(l,"border",get_border,null,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"drawingDimensions",get_drawingDimensions,null,true);
		createTypeMetatable(l,constructor, typeof(UISprite),typeof(UIWidget));
	}
}
