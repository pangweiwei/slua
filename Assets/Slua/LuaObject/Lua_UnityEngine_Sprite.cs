using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Sprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Sprite o;
		if(matchType(l,1)){
			o=new UnityEngine.Sprite();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(float),typeof(System.UInt32),typeof(UnityEngine.SpriteMeshType),typeof(UnityEngine.Vector4))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.SpriteMeshType a6;
				checkEnum(l,6,out a6);
				UnityEngine.Vector4 a7;
				checkType(l,7,out a7);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(float),typeof(System.UInt32),typeof(UnityEngine.SpriteMeshType))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.SpriteMeshType a6;
				checkEnum(l,6,out a6);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(float),typeof(System.UInt32))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(float))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3);
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
	static public int get_bounds(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.rect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.pixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRect(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.textureRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRectOffset(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.textureRectOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packed(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.packed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packingMode(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushEnum(l,(int)o.packingMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packingRotation(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushEnum(l,(int)o.packingRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		UnityEngine.Sprite o = (UnityEngine.Sprite)checkSelf(l);
		pushValue(l,o.border);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Sprite");
		addMember(l,Create_s);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"rect",get_rect,null,true);
		addMember(l,"pixelsPerUnit",get_pixelsPerUnit,null,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"textureRect",get_textureRect,null,true);
		addMember(l,"textureRectOffset",get_textureRectOffset,null,true);
		addMember(l,"packed",get_packed,null,true);
		addMember(l,"packingMode",get_packingMode,null,true);
		addMember(l,"packingRotation",get_packingRotation,null,true);
		addMember(l,"border",get_border,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Sprite),typeof(UnityEngine.Object));
	}
}
