using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ByteReader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		ByteReader o;
		if(matchType(l,argc,2,typeof(System.Byte[]))){
			System.Byte[] a1;
			checkType(l,2,out a1);
			o=new ByteReader(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,argc,2,typeof(UnityEngine.TextAsset))){
			UnityEngine.TextAsset a1;
			checkType(l,2,out a1);
			o=new ByteReader(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadLine(IntPtr l) {
		try{
			ByteReader self=(ByteReader)checkSelf(l);
			System.String ret=self.ReadLine();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadDictionary(IntPtr l) {
		try{
			ByteReader self=(ByteReader)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> ret=self.ReadDictionary();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadCSV(IntPtr l) {
		try{
			ByteReader self=(ByteReader)checkSelf(l);
			BetterList<System.String> ret=self.ReadCSV();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canRead(IntPtr l) {
		ByteReader o = (ByteReader)checkSelf(l);
		pushValue(l,o.canRead);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ByteReader");
		addMember(l,ReadLine);
		addMember(l,ReadDictionary);
		addMember(l,ReadCSV);
		addMember(l,"canRead",get_canRead,null,true);
		createTypeMetatable(l,constructor, typeof(ByteReader));
	}
}
