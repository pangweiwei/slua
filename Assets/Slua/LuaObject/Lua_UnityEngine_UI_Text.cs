using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Text : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FontTextureChanged(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
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
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
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
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
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
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
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
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
			self.OnRebuildRequested();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextAnchorPivot_s(IntPtr l) {
		try{
			UnityEngine.TextAnchor a1;
			checkEnum(l,1,out a1);
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
	static public int get_cachedTextGenerator(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.cachedTextGenerator);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTextGeneratorForLayout(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.cachedTextGeneratorForLayout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultMaterial(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.defaultMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportRichText(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.supportRichText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_supportRichText(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.supportRichText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextForBestFit(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.resizeTextForBestFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextForBestFit(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.resizeTextForBestFit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMinSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.resizeTextMinSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMinSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.resizeTextMinSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMaxSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.resizeTextMaxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMaxSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.resizeTextMaxSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.horizontalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.HorizontalWrapMode v;
		checkEnum(l,2,out v);
		o.horizontalOverflow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.verticalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.VerticalWrapMode v;
		checkEnum(l,2,out v);
		o.verticalOverflow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.pixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Text");
		addMember(l,FontTextureChanged);
		addMember(l,GetGenerationSettings);
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,OnRebuildRequested);
		addMember(l,GetTextAnchorPivot_s);
		addMember(l,"cachedTextGenerator",get_cachedTextGenerator,null,true);
		addMember(l,"cachedTextGeneratorForLayout",get_cachedTextGeneratorForLayout,null,true);
		addMember(l,"defaultMaterial",get_defaultMaterial,null,true);
		addMember(l,"mainTexture",get_mainTexture,null,true);
		addMember(l,"font",get_font,set_font,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"supportRichText",get_supportRichText,set_supportRichText,true);
		addMember(l,"resizeTextForBestFit",get_resizeTextForBestFit,set_resizeTextForBestFit,true);
		addMember(l,"resizeTextMinSize",get_resizeTextMinSize,set_resizeTextMinSize,true);
		addMember(l,"resizeTextMaxSize",get_resizeTextMaxSize,set_resizeTextMaxSize,true);
		addMember(l,"alignment",get_alignment,set_alignment,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"horizontalOverflow",get_horizontalOverflow,set_horizontalOverflow,true);
		addMember(l,"verticalOverflow",get_verticalOverflow,set_verticalOverflow,true);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"pixelsPerUnit",get_pixelsPerUnit,null,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"preferredWidth",get_preferredWidth,null,true);
		addMember(l,"flexibleWidth",get_flexibleWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"preferredHeight",get_preferredHeight,null,true);
		addMember(l,"flexibleHeight",get_flexibleHeight,null,true);
		addMember(l,"layoutPriority",get_layoutPriority,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Text),typeof(UnityEngine.UI.MaskableGraphic));
	}
}
