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
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bestFit(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.bestFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bestFit(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.bestFit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minSize(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.minSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minSize(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.minSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxSize(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.maxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxSize(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.alignment=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.richText=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.horizontalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		UnityEngine.HorizontalWrapMode v;
		checkEnum(l,2,out v);
		o.horizontalOverflow=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.verticalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		UnityEngine.VerticalWrapMode v;
		checkEnum(l,2,out v);
		o.verticalOverflow=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.UI.FontData o = checkSelf<UnityEngine.UI.FontData>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.FontData");
		addMember(l,get_defaultFontData, "get_defaultFontData");
		addMember(l,get_font, "get_font");
		addMember(l,set_font, "set_font");
		addMember(l,get_fontSize, "get_fontSize");
		addMember(l,set_fontSize, "set_fontSize");
		addMember(l,get_fontStyle, "get_fontStyle");
		addMember(l,set_fontStyle, "set_fontStyle");
		addMember(l,get_bestFit, "get_bestFit");
		addMember(l,set_bestFit, "set_bestFit");
		addMember(l,get_minSize, "get_minSize");
		addMember(l,set_minSize, "set_minSize");
		addMember(l,get_maxSize, "get_maxSize");
		addMember(l,set_maxSize, "set_maxSize");
		addMember(l,get_alignment, "get_alignment");
		addMember(l,set_alignment, "set_alignment");
		addMember(l,get_richText, "get_richText");
		addMember(l,set_richText, "set_richText");
		addMember(l,get_horizontalOverflow, "get_horizontalOverflow");
		addMember(l,set_horizontalOverflow, "set_horizontalOverflow");
		addMember(l,get_verticalOverflow, "get_verticalOverflow");
		addMember(l,set_verticalOverflow, "set_verticalOverflow");
		addMember(l,get_lineSpacing, "get_lineSpacing");
		addMember(l,set_lineSpacing, "set_lineSpacing");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.FontData));
		LuaDLL.lua_pop(l, 1);
	}
}
