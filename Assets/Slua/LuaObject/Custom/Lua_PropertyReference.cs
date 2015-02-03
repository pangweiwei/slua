using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PropertyReference : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		PropertyReference o;
		if(argc==1){
			o=new PropertyReference();
			pushObject(l,o);
			return 1;
		}
		else if(argc==3){
			UnityEngine.Component a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new PropertyReference(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPropertyType(IntPtr l) {
		try{
			PropertyReference self=(PropertyReference)checkSelf(l);
			System.Type ret=self.GetPropertyType();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				PropertyReference self=(PropertyReference)checkSelf(l);
				UnityEngine.Component a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				self.Set(a1,a2);
				return 0;
			}
			else if(argc==1){
				PropertyReference self=(PropertyReference)checkSelf(l);
				System.Object a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Set(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			PropertyReference self=(PropertyReference)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try{
			PropertyReference self=(PropertyReference)checkSelf(l);
			self.Reset();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get(IntPtr l) {
		try{
			PropertyReference self=(PropertyReference)checkSelf(l);
			System.Object ret=self.Get();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Convert_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(System.Type),typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				System.Boolean ret=PropertyReference.Convert(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(System.Object),typeof(System.Type))){
				System.Object a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				System.Boolean ret=PropertyReference.Convert(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				System.Object a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				System.Type a3;
				checkType(l,3,out a3);
				System.Boolean ret=PropertyReference.Convert(ref a1,a2,a3);
				pushValue(l,ret);
				pushValue(l,a1);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		PropertyReference o = (PropertyReference)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		PropertyReference o = (PropertyReference)checkSelf(l);
		UnityEngine.Component v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		PropertyReference o = (PropertyReference)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		PropertyReference o = (PropertyReference)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		PropertyReference o = (PropertyReference)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEnabled(IntPtr l) {
		PropertyReference o = (PropertyReference)checkSelf(l);
		pushValue(l,o.isEnabled);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"PropertyReference");
		addMember(l,GetPropertyType);
		addMember(l,Set);
		addMember(l,Clear);
		addMember(l,Reset);
		addMember(l,Get);
		addMember(l,Convert_s);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"isEnabled",get_isEnabled,null,true);
		createTypeMetatable(l,constructor, typeof(PropertyReference));
	}
}
