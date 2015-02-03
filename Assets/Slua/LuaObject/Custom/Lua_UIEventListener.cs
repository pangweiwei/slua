using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIEventListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIEventListener o;
		o=new UIEventListener();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UIEventListener ret=UIEventListener.Get(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parameter(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		pushValue(l,o.parameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_parameter(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		System.Object v;
		checkType(l,2,out v);
		o.parameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.VoidDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onSubmit=v;
		else if(op==1) o.onSubmit+=v;
		else if(op==2) o.onSubmit-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.VoidDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onClick=v;
		else if(op==1) o.onClick+=v;
		else if(op==2) o.onClick-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDoubleClick(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.VoidDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDoubleClick=v;
		else if(op==1) o.onDoubleClick+=v;
		else if(op==2) o.onDoubleClick-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHover(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.BoolDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onHover=v;
		else if(op==1) o.onHover+=v;
		else if(op==2) o.onHover-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onPress(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.BoolDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onPress=v;
		else if(op==1) o.onPress+=v;
		else if(op==2) o.onPress-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.BoolDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onSelect=v;
		else if(op==1) o.onSelect+=v;
		else if(op==2) o.onSelect-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onScroll(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.FloatDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onScroll=v;
		else if(op==1) o.onScroll+=v;
		else if(op==2) o.onScroll-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrag(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.VectorDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDrag=v;
		else if(op==1) o.onDrag+=v;
		else if(op==2) o.onDrag-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrop(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.ObjectDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDrop=v;
		else if(op==1) o.onDrop+=v;
		else if(op==2) o.onDrop-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onKey(IntPtr l) {
		UIEventListener o = (UIEventListener)checkSelf(l);
		UIEventListener.KeyCodeDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onKey=v;
		else if(op==1) o.onKey+=v;
		else if(op==2) o.onKey-=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIEventListener");
		addMember(l,Get_s);
		addMember(l,"parameter",get_parameter,set_parameter,true);
		addMember(l,"onSubmit",null,set_onSubmit,true);
		addMember(l,"onClick",null,set_onClick,true);
		addMember(l,"onDoubleClick",null,set_onDoubleClick,true);
		addMember(l,"onHover",null,set_onHover,true);
		addMember(l,"onPress",null,set_onPress,true);
		addMember(l,"onSelect",null,set_onSelect,true);
		addMember(l,"onScroll",null,set_onScroll,true);
		addMember(l,"onDrag",null,set_onDrag,true);
		addMember(l,"onDrop",null,set_onDrop,true);
		addMember(l,"onKey",null,set_onKey,true);
		createTypeMetatable(l,constructor, typeof(UIEventListener),typeof(UnityEngine.MonoBehaviour));
	}
}
