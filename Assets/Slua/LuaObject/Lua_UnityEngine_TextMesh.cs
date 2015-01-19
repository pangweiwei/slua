using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextMesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.TextMesh o;
		if(matchType(l,1)){
			o=new UnityEngine.TextMesh();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.String v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetZ(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.offsetZ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetZ(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.Single v;
		checkType(l,2,out v);
		o.offsetZ=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		UnityEngine.TextAlignment v;
		checkEnum(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterSize(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.characterSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterSize(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.Single v;
		checkType(l,2,out v);
		o.characterSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tabSize(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.tabSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tabSize(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.Single v;
		checkType(l,2,out v);
		o.tabSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.richText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.TextMesh o = checkSelf<UnityEngine.TextMesh>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextMesh");
		addMember(l,get_text, "get_text");
		addMember(l,set_text, "set_text");
		addMember(l,get_font, "get_font");
		addMember(l,set_font, "set_font");
		addMember(l,get_fontSize, "get_fontSize");
		addMember(l,set_fontSize, "set_fontSize");
		addMember(l,get_fontStyle, "get_fontStyle");
		addMember(l,set_fontStyle, "set_fontStyle");
		addMember(l,get_offsetZ, "get_offsetZ");
		addMember(l,set_offsetZ, "set_offsetZ");
		addMember(l,get_alignment, "get_alignment");
		addMember(l,set_alignment, "set_alignment");
		addMember(l,get_anchor, "get_anchor");
		addMember(l,set_anchor, "set_anchor");
		addMember(l,get_characterSize, "get_characterSize");
		addMember(l,set_characterSize, "set_characterSize");
		addMember(l,get_lineSpacing, "get_lineSpacing");
		addMember(l,set_lineSpacing, "set_lineSpacing");
		addMember(l,get_tabSize, "get_tabSize");
		addMember(l,set_tabSize, "set_tabSize");
		addMember(l,get_richText, "get_richText");
		addMember(l,set_richText, "set_richText");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.TextMesh),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
