using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIBasicSprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.centerType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.centerType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_leftType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.leftType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_leftType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.leftType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rightType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.rightType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rightType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.rightType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottomType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.bottomType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottomType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.bottomType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_topType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.topType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_topType(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.AdvancedType v;
		checkEnum(l,2,out v);
		o.topType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.Type v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flip(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.flip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flip(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.Flip v;
		checkEnum(l,2,out v);
		o.flip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillDirection(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushEnum(l,(int)o.fillDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillDirection(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		UIBasicSprite.FillDirection v;
		checkEnum(l,2,out v);
		o.fillDirection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillAmount(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.fillAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.fillAmount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_invert(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.invert);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_invert(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.invert=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.hasBorder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlpha(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.premultipliedAlpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSize(IntPtr l) {
		UIBasicSprite o = (UIBasicSprite)checkSelf(l);
		pushValue(l,o.pixelSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIBasicSprite");
		addMember(l,"centerType",get_centerType,set_centerType,true);
		addMember(l,"leftType",get_leftType,set_leftType,true);
		addMember(l,"rightType",get_rightType,set_rightType,true);
		addMember(l,"bottomType",get_bottomType,set_bottomType,true);
		addMember(l,"topType",get_topType,set_topType,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"flip",get_flip,set_flip,true);
		addMember(l,"fillDirection",get_fillDirection,set_fillDirection,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"invert",get_invert,set_invert,true);
		addMember(l,"hasBorder",get_hasBorder,null,true);
		addMember(l,"premultipliedAlpha",get_premultipliedAlpha,null,true);
		addMember(l,"pixelSize",get_pixelSize,null,true);
		createTypeMetatable(l,constructor, typeof(UIBasicSprite),typeof(UIWidget));
	}
}
