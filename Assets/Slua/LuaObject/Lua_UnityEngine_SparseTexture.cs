using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SparseTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SparseTexture o;
		if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Int32))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.SparseTexture(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Int32),typeof(System.Boolean))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.SparseTexture(a1,a2,a3,a4,a5);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateTile(IntPtr l) {
		try{
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color32[] a4;
			checkType(l,5,out a4);
			self.UpdateTile(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateTileRaw(IntPtr l) {
		try{
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Byte[] a4;
			checkType(l,5,out a4);
			self.UpdateTileRaw(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnloadTile(IntPtr l) {
		try{
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.UnloadTile(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tileWidth(IntPtr l) {
		UnityEngine.SparseTexture o = (UnityEngine.SparseTexture)checkSelf(l);
		pushValue(l,o.tileWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tileHeight(IntPtr l) {
		UnityEngine.SparseTexture o = (UnityEngine.SparseTexture)checkSelf(l);
		pushValue(l,o.tileHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isCreated(IntPtr l) {
		UnityEngine.SparseTexture o = (UnityEngine.SparseTexture)checkSelf(l);
		pushValue(l,o.isCreated);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SparseTexture");
		addMember(l,UpdateTile);
		addMember(l,UpdateTileRaw);
		addMember(l,UnloadTile);
		addMember(l,"tileWidth",get_tileWidth,null);
		addMember(l,"tileHeight",get_tileHeight,null);
		addMember(l,"isCreated",get_isCreated,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SparseTexture),typeof(UnityEngine.Texture));
	}
}
