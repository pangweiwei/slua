using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ChatInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		ChatInput o;
		o=new ChatInput();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSubmit(IntPtr l) {
		try{
			ChatInput self=(ChatInput)checkSelf(l);
			self.OnSubmit();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textList(IntPtr l) {
		ChatInput o = (ChatInput)checkSelf(l);
		pushValue(l,o.textList);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textList(IntPtr l) {
		ChatInput o = (ChatInput)checkSelf(l);
		UITextList v;
		checkType(l,2,out v);
		o.textList=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillWithDummyData(IntPtr l) {
		ChatInput o = (ChatInput)checkSelf(l);
		pushValue(l,o.fillWithDummyData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillWithDummyData(IntPtr l) {
		ChatInput o = (ChatInput)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.fillWithDummyData=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ChatInput");
		addMember(l,OnSubmit);
		addMember(l,"textList",get_textList,set_textList,true);
		addMember(l,"fillWithDummyData",get_fillWithDummyData,set_fillWithDummyData,true);
		createTypeMetatable(l,constructor, typeof(ChatInput),typeof(UnityEngine.MonoBehaviour));
	}
}
