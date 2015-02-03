using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIProgressBar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIProgressBar o;
		o=new UIProgressBar();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceUpdate(IntPtr l) {
		try{
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			self.ForceUpdate();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UIProgressBar.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIProgressBar v;
		checkType(l,2,out v);
		UIProgressBar.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragFinished(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		UIProgressBar.OnDragFinished v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDragFinished=v;
		else if(op==1) o.onDragFinished+=v;
		else if(op==2) o.onDragFinished-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thumb(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.thumb);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thumb(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.thumb=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numberOfSteps(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.numberOfSteps);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numberOfSteps(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.numberOfSteps=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChange(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.onChange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onChange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.cachedTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedCamera(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.cachedCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_foregroundWidget(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.foregroundWidget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_foregroundWidget(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		UIWidget v;
		checkType(l,2,out v);
		o.foregroundWidget=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundWidget(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.backgroundWidget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundWidget(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		UIWidget v;
		checkType(l,2,out v);
		o.backgroundWidget=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillDirection(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushEnum(l,(int)o.fillDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillDirection(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		UIProgressBar.FillDirection v;
		checkEnum(l,2,out v);
		o.fillDirection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		pushValue(l,o.alpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		UIProgressBar o = (UIProgressBar)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.alpha=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIProgressBar");
		addMember(l,ForceUpdate);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"onDragFinished",null,set_onDragFinished,true);
		addMember(l,"thumb",get_thumb,set_thumb,true);
		addMember(l,"numberOfSteps",get_numberOfSteps,set_numberOfSteps,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"cachedCamera",get_cachedCamera,null,true);
		addMember(l,"foregroundWidget",get_foregroundWidget,set_foregroundWidget,true);
		addMember(l,"backgroundWidget",get_backgroundWidget,set_backgroundWidget,true);
		addMember(l,"fillDirection",get_fillDirection,set_fillDirection,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		createTypeMetatable(l,constructor, typeof(UIProgressBar),typeof(UIWidgetContainer));
	}
}
