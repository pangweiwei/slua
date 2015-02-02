using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextMesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.TextMesh o;
		o=new UnityEngine.TextMesh();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushEnum(l,(int)o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetZ(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.offsetZ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetZ(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.offsetZ=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushEnum(l,(int)o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.TextAlignment v;
		checkEnum(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushEnum(l,(int)o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.characterSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.characterSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tabSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.tabSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tabSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.tabSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.richText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextMesh");
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"font",get_font,set_font,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"offsetZ",get_offsetZ,set_offsetZ,true);
		addMember(l,"alignment",get_alignment,set_alignment,true);
		addMember(l,"anchor",get_anchor,set_anchor,true);
		addMember(l,"characterSize",get_characterSize,set_characterSize,true);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing,true);
		addMember(l,"tabSize",get_tabSize,set_tabSize,true);
		addMember(l,"richText",get_richText,set_richText,true);
		addMember(l,"color",get_color,set_color,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TextMesh),typeof(UnityEngine.Component));
	}
}
