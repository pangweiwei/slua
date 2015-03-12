using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WWWForm : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.WWWForm o;
		o=new UnityEngine.WWWForm();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddField(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(string))){
				UnityEngine.WWWForm self=(UnityEngine.WWWForm)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				self.AddField(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.WWWForm self=(UnityEngine.WWWForm)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Text.Encoding a3;
				checkType(l,4,out a3);
				self.AddField(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int))){
				UnityEngine.WWWForm self=(UnityEngine.WWWForm)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.AddField(a1,a2);
				return 0;
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
	static public int AddBinaryData(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.WWWForm self=(UnityEngine.WWWForm)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Byte[] a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				self.AddBinaryData(a1,a2,a3);
				return 0;
			}
			else if(argc==3){
				UnityEngine.WWWForm self=(UnityEngine.WWWForm)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Byte[] a2;
				checkType(l,3,out a2);
				self.AddBinaryData(a1,a2);
				return 0;
			}
			else if(argc==5){
				UnityEngine.WWWForm self=(UnityEngine.WWWForm)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Byte[] a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				self.AddBinaryData(a1,a2,a3,a4);
				return 0;
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
	static public int get_headers(IntPtr l) {
		UnityEngine.WWWForm o = (UnityEngine.WWWForm)checkSelf(l);
		pushValue(l,o.headers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_data(IntPtr l) {
		UnityEngine.WWWForm o = (UnityEngine.WWWForm)checkSelf(l);
		pushValue(l,o.data);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WWWForm");
		addMember(l,AddField);
		addMember(l,AddBinaryData);
		addMember(l,"headers",get_headers,null,true);
		addMember(l,"data",get_data,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WWWForm));
	}
}
