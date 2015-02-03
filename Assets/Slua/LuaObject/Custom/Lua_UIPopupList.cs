using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPopupList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIPopupList o;
		o=new UIPopupList();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UIPopupList.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIPopupList v;
		checkType(l,2,out v);
		UIPopupList.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_atlas(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.atlas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_atlas(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UIAtlas v;
		checkType(l,2,out v);
		o.atlas=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bitmapFont(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.bitmapFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bitmapFont(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UIFont v;
		checkType(l,2,out v);
		o.bitmapFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trueTypeFont(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.trueTypeFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trueTypeFont(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.trueTypeFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushEnum(l,(int)o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundSprite(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.backgroundSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundSprite(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.backgroundSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightSprite(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.highlightSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightSprite(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.highlightSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushEnum(l,(int)o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UIPopupList.Position v;
		checkEnum(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_items(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.items);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_items(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.Collections.Generic.List<System.String> v;
		checkType(l,2,out v);
		o.items=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padding(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.padding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.padding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textColor(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.textColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textColor(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.textColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColor(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.backgroundColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColor(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.backgroundColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightColor(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.highlightColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightColor(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.highlightColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnimated(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.isAnimated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isAnimated(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isAnimated=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLocalized(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.isLocalized);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isLocalized(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isLocalized=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChange(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.onChange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onChange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ambigiousFont(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.ambigiousFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ambigiousFont(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		UnityEngine.Object v;
		checkType(l,2,out v);
		o.ambigiousFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOpen(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.isOpen);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UIPopupList o = (UIPopupList)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPopupList");
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		addMember(l,"bitmapFont",get_bitmapFont,set_bitmapFont,true);
		addMember(l,"trueTypeFont",get_trueTypeFont,set_trueTypeFont,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"backgroundSprite",get_backgroundSprite,set_backgroundSprite,true);
		addMember(l,"highlightSprite",get_highlightSprite,set_highlightSprite,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"items",get_items,set_items,true);
		addMember(l,"padding",get_padding,set_padding,true);
		addMember(l,"textColor",get_textColor,set_textColor,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"highlightColor",get_highlightColor,set_highlightColor,true);
		addMember(l,"isAnimated",get_isAnimated,set_isAnimated,true);
		addMember(l,"isLocalized",get_isLocalized,set_isLocalized,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"ambigiousFont",get_ambigiousFont,set_ambigiousFont,true);
		addMember(l,"isOpen",get_isOpen,null,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(UIPopupList),typeof(UIWidgetContainer));
	}
}
