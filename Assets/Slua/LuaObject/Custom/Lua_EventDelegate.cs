using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EventDelegate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		EventDelegate o;
		if(argc==1){
			o=new EventDelegate();
			pushObject(l,o);
			return 1;
		}
		else if(argc==2){
			EventDelegate.Callback a1;
			checkDelegate(l,2,out a1);
			o=new EventDelegate(a1);
			pushObject(l,o);
			return 1;
		}
		else if(argc==3){
			UnityEngine.MonoBehaviour a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new EventDelegate(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			EventDelegate self=(EventDelegate)checkSelf(l);
			UnityEngine.MonoBehaviour a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.Set(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Execute(IntPtr l) {
		try{
			EventDelegate self=(EventDelegate)checkSelf(l);
			System.Boolean ret=self.Execute();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			EventDelegate self=(EventDelegate)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Execute_s(IntPtr l) {
		try{
			System.Collections.Generic.List<EventDelegate> a1;
			checkType(l,1,out a1);
			EventDelegate.Execute(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsValid_s(IntPtr l) {
		try{
			System.Collections.Generic.List<EventDelegate> a1;
			checkType(l,1,out a1);
			System.Boolean ret=EventDelegate.IsValid(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove_s(IntPtr l) {
		try{
			System.Collections.Generic.List<EventDelegate> a1;
			checkType(l,1,out a1);
			EventDelegate.Callback a2;
			checkDelegate(l,2,out a2);
			System.Boolean ret=EventDelegate.Remove(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_oneShot(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		pushValue(l,o.oneShot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_oneShot(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.oneShot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		UnityEngine.MonoBehaviour v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_methodName(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		pushValue(l,o.methodName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_methodName(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.methodName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEnabled(IntPtr l) {
		EventDelegate o = (EventDelegate)checkSelf(l);
		pushValue(l,o.isEnabled);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EventDelegate");
		addMember(l,Set);
		addMember(l,Execute);
		addMember(l,Clear);
		addMember(l,Execute_s);
		addMember(l,IsValid_s);
		addMember(l,Set_s);
		addMember(l,Add_s);
		addMember(l,Remove_s);
		addMember(l,"oneShot",get_oneShot,set_oneShot,true);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"methodName",get_methodName,set_methodName,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"isEnabled",get_isEnabled,null,true);
		createTypeMetatable(l,constructor, typeof(EventDelegate));
	}
}
