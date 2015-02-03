using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITextList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UITextList o;
		o=new UITextList();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UITextList self=(UITextList)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnScroll(IntPtr l) {
		try{
			UITextList self=(UITextList)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.OnScroll(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try{
			UITextList self=(UITextList)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try{
			UITextList self=(UITextList)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.Add(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textLabel(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		pushValue(l,o.textLabel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textLabel(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		UILabel v;
		checkType(l,2,out v);
		o.textLabel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollBar(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		pushValue(l,o.scrollBar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollBar(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		UIProgressBar v;
		checkType(l,2,out v);
		o.scrollBar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_style(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		pushEnum(l,(int)o.style);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_style(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		UITextList.Style v;
		checkEnum(l,2,out v);
		o.style=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paragraphHistory(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		pushValue(l,o.paragraphHistory);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paragraphHistory(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.paragraphHistory=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollValue(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		pushValue(l,o.scrollValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollValue(IntPtr l) {
		UITextList o = (UITextList)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.scrollValue=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UITextList");
		addMember(l,Clear);
		addMember(l,OnScroll);
		addMember(l,OnDrag);
		addMember(l,Add);
		addMember(l,"textLabel",get_textLabel,set_textLabel,true);
		addMember(l,"scrollBar",get_scrollBar,set_scrollBar,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"paragraphHistory",get_paragraphHistory,set_paragraphHistory,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"scrollValue",get_scrollValue,set_scrollValue,true);
		createTypeMetatable(l,constructor, typeof(UITextList),typeof(UnityEngine.MonoBehaviour));
	}
}
