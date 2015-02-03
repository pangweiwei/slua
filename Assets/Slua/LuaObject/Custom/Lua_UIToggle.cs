using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIToggle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIToggle o;
		o=new UIToggle();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UIToggle self=(UIToggle)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Set(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetActiveToggle_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UIToggle ret=UIToggle.GetActiveToggle(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_list(IntPtr l) {
		pushValue(l,UIToggle.list);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_list(IntPtr l) {
		BetterList<UIToggle> v;
		checkType(l,2,out v);
		UIToggle.list=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UIToggle.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIToggle v;
		checkType(l,2,out v);
		UIToggle.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_group(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.group);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_group(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.group=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeSprite(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.activeSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activeSprite(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		UIWidget v;
		checkType(l,2,out v);
		o.activeSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeAnimation(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.activeAnimation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activeAnimation(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		UnityEngine.Animation v;
		checkType(l,2,out v);
		o.activeAnimation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startsActive(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.startsActive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startsActive(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.startsActive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_instantTween(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.instantTween);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_instantTween(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.instantTween=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_optionCanBeNone(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.optionCanBeNone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_optionCanBeNone(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.optionCanBeNone=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChange(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.onChange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onChange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_validator(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		UIToggle.Validate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.validator=v;
		else if(op==1) o.validator+=v;
		else if(op==2) o.validator-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UIToggle o = (UIToggle)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIToggle");
		addMember(l,Set);
		addMember(l,GetActiveToggle_s);
		addMember(l,"list",get_list,set_list,false);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"group",get_group,set_group,true);
		addMember(l,"activeSprite",get_activeSprite,set_activeSprite,true);
		addMember(l,"activeAnimation",get_activeAnimation,set_activeAnimation,true);
		addMember(l,"startsActive",get_startsActive,set_startsActive,true);
		addMember(l,"instantTween",get_instantTween,set_instantTween,true);
		addMember(l,"optionCanBeNone",get_optionCanBeNone,set_optionCanBeNone,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"validator",null,set_validator,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(UIToggle),typeof(UIWidgetContainer));
	}
}
