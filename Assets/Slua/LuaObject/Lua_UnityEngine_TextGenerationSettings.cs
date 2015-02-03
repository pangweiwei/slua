﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextGenerationSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.richText=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushEnum(l,(int)o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textAnchor(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushEnum(l,(int)o.textAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textAnchor(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.textAnchor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextForBestFit(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.resizeTextForBestFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextForBestFit(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.resizeTextForBestFit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMinSize(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.resizeTextMinSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMinSize(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.resizeTextMinSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMaxSize(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.resizeTextMaxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMaxSize(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.resizeTextMaxSize=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateBounds(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.updateBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateBounds(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updateBounds=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushEnum(l,(int)o.verticalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.VerticalWrapMode v;
		checkEnum(l,2,out v);
		o.verticalOverflow=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushEnum(l,(int)o.horizontalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.HorizontalWrapMode v;
		checkEnum(l,2,out v);
		o.horizontalOverflow=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generationExtents(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.generationExtents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generationExtents(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.generationExtents=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pivot=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generateOutOfBounds(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		pushValue(l,o.generateOutOfBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generateOutOfBounds(IntPtr l) {
		UnityEngine.TextGenerationSettings o = (UnityEngine.TextGenerationSettings)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.generateOutOfBounds=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextGenerationSettings");
		addMember(l,"font",get_font,set_font,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing,true);
		addMember(l,"richText",get_richText,set_richText,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"textAnchor",get_textAnchor,set_textAnchor,true);
		addMember(l,"resizeTextForBestFit",get_resizeTextForBestFit,set_resizeTextForBestFit,true);
		addMember(l,"resizeTextMinSize",get_resizeTextMinSize,set_resizeTextMinSize,true);
		addMember(l,"resizeTextMaxSize",get_resizeTextMaxSize,set_resizeTextMaxSize,true);
		addMember(l,"updateBounds",get_updateBounds,set_updateBounds,true);
		addMember(l,"verticalOverflow",get_verticalOverflow,set_verticalOverflow,true);
		addMember(l,"horizontalOverflow",get_horizontalOverflow,set_horizontalOverflow,true);
		addMember(l,"generationExtents",get_generationExtents,set_generationExtents,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"generateOutOfBounds",get_generateOutOfBounds,set_generateOutOfBounds,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TextGenerationSettings));
	}
}
