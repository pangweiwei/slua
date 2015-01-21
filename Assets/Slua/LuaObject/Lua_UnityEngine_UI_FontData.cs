using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_FontData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultFontData(IntPtr l) {
		pushValue(l,UnityEngine.UI.FontData.defaultFontData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bestFit(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.bestFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bestFit(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.bestFit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minSize(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.minSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minSize(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.minSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxSize(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.maxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxSize(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.alignment=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.richText=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.horizontalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		UnityEngine.HorizontalWrapMode v;
		checkEnum(l,2,out v);
		o.horizontalOverflow=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.verticalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		UnityEngine.VerticalWrapMode v;
		checkEnum(l,2,out v);
		o.verticalOverflow=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.UI.FontData o = (UnityEngine.UI.FontData)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.FontData");
		addMember(l,"defaultFontData",get_defaultFontData,null);
		addMember(l,"font",get_font,set_font);
		addMember(l,"fontSize",get_fontSize,set_fontSize);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle);
		addMember(l,"bestFit",get_bestFit,set_bestFit);
		addMember(l,"minSize",get_minSize,set_minSize);
		addMember(l,"maxSize",get_maxSize,set_maxSize);
		addMember(l,"alignment",get_alignment,set_alignment);
		addMember(l,"richText",get_richText,set_richText);
		addMember(l,"horizontalOverflow",get_horizontalOverflow,set_horizontalOverflow);
		addMember(l,"verticalOverflow",get_verticalOverflow,set_verticalOverflow);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.FontData));
	}
}
