using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Text : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FontTextureChanged(IntPtr l) {
		try{
			UnityEngine.UI.Text self=checkSelf<UnityEngine.UI.Text>(l);
			self.FontTextureChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGenerationSettings(IntPtr l) {
		try{
			UnityEngine.UI.Text self=checkSelf<UnityEngine.UI.Text>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.TextGenerationSettings ret=self.GetGenerationSettings(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextAnchorPivot(IntPtr l) {
		try{
			UnityEngine.TextAnchor a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 ret=UnityEngine.UI.Text.GetTextAnchorPivot(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.Text self=checkSelf<UnityEngine.UI.Text>(l);
			self.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		try{
			UnityEngine.UI.Text self=checkSelf<UnityEngine.UI.Text>(l);
			self.CalculateLayoutInputVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnRebuildRequested(IntPtr l) {
		try{
			UnityEngine.UI.Text self=checkSelf<UnityEngine.UI.Text>(l);
			self.OnRebuildRequested();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTextGenerator(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.cachedTextGenerator);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTextGeneratorForLayout(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.cachedTextGeneratorForLayout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultMaterial(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.defaultMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.String v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportRichText(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.supportRichText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_supportRichText(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.supportRichText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextForBestFit(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.resizeTextForBestFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextForBestFit(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.resizeTextForBestFit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMinSize(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.resizeTextMinSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMinSize(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.resizeTextMinSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMaxSize(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.resizeTextMaxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMaxSize(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.resizeTextMaxSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		UnityEngine.TextAnchor v;
		checkType(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.horizontalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		UnityEngine.HorizontalWrapMode v;
		checkType(l,2,out v);
		o.horizontalOverflow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.verticalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		UnityEngine.VerticalWrapMode v;
		checkType(l,2,out v);
		o.verticalOverflow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		UnityEngine.FontStyle v;
		checkType(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.pixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.Text o = checkSelf<UnityEngine.UI.Text>(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Text");
		addMember(l,FontTextureChanged, "FontTextureChanged");
		addMember(l,GetGenerationSettings, "GetGenerationSettings");
		addMember(l,GetTextAnchorPivot, "GetTextAnchorPivot");
		addMember(l,CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal");
		addMember(l,CalculateLayoutInputVertical, "CalculateLayoutInputVertical");
		addMember(l,OnRebuildRequested, "OnRebuildRequested");
		addMember(l,get_cachedTextGenerator, "get_cachedTextGenerator");
		addMember(l,get_cachedTextGeneratorForLayout, "get_cachedTextGeneratorForLayout");
		addMember(l,get_defaultMaterial, "get_defaultMaterial");
		addMember(l,get_mainTexture, "get_mainTexture");
		addMember(l,get_font, "get_font");
		addMember(l,set_font, "set_font");
		addMember(l,get_text, "get_text");
		addMember(l,set_text, "set_text");
		addMember(l,get_supportRichText, "get_supportRichText");
		addMember(l,set_supportRichText, "set_supportRichText");
		addMember(l,get_resizeTextForBestFit, "get_resizeTextForBestFit");
		addMember(l,set_resizeTextForBestFit, "set_resizeTextForBestFit");
		addMember(l,get_resizeTextMinSize, "get_resizeTextMinSize");
		addMember(l,set_resizeTextMinSize, "set_resizeTextMinSize");
		addMember(l,get_resizeTextMaxSize, "get_resizeTextMaxSize");
		addMember(l,set_resizeTextMaxSize, "set_resizeTextMaxSize");
		addMember(l,get_alignment, "get_alignment");
		addMember(l,set_alignment, "set_alignment");
		addMember(l,get_fontSize, "get_fontSize");
		addMember(l,set_fontSize, "set_fontSize");
		addMember(l,get_horizontalOverflow, "get_horizontalOverflow");
		addMember(l,set_horizontalOverflow, "set_horizontalOverflow");
		addMember(l,get_verticalOverflow, "get_verticalOverflow");
		addMember(l,set_verticalOverflow, "set_verticalOverflow");
		addMember(l,get_lineSpacing, "get_lineSpacing");
		addMember(l,set_lineSpacing, "set_lineSpacing");
		addMember(l,get_fontStyle, "get_fontStyle");
		addMember(l,set_fontStyle, "set_fontStyle");
		addMember(l,get_pixelsPerUnit, "get_pixelsPerUnit");
		addMember(l,get_minWidth, "get_minWidth");
		addMember(l,get_preferredWidth, "get_preferredWidth");
		addMember(l,get_flexibleWidth, "get_flexibleWidth");
		addMember(l,get_minHeight, "get_minHeight");
		addMember(l,get_preferredHeight, "get_preferredHeight");
		addMember(l,get_flexibleHeight, "get_flexibleHeight");
		addMember(l,get_layoutPriority, "get_layoutPriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Text),typeof(UnityEngine.UI.MaskableGraphic));
		LuaDLL.lua_pop(l, 1);
	}
}
