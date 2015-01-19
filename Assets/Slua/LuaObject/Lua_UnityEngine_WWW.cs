using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WWW : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.WWW o;
		if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.WWW(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String),typeof(UnityEngine.WWWForm))){
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.WWWForm a2;
			checkType(l,2,out a2);
			o=new UnityEngine.WWW(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String),typeof(System.Byte))){
			System.String a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkType(l,2,out a2);
			o=new UnityEngine.WWW(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String),typeof(System.Byte),typeof(System.Collections.Hashtable))){
			System.String a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkType(l,2,out a2);
			System.Collections.Hashtable a3;
			checkType(l,3,out a3);
			o=new UnityEngine.WWW(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InitWWW(IntPtr l) {
		try{
			UnityEngine.WWW self=checkSelf<UnityEngine.WWW>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Byte[] a2;
			checkType(l,3,out a2);
			System.String[] a3;
			checkType(l,4,out a3);
			self.InitWWW(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EscapeURL(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.String ret=UnityEngine.WWW.EscapeURL(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Text.Encoding))){
				System.String a1;
				checkType(l,1,out a1);
				System.Text.Encoding a2;
				checkType(l,2,out a2);
				System.String ret=UnityEngine.WWW.EscapeURL(a1,a2);
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
	static public int UnEscapeURL(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.String ret=UnityEngine.WWW.UnEscapeURL(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Text.Encoding))){
				System.String a1;
				checkType(l,1,out a1);
				System.Text.Encoding a2;
				checkType(l,2,out a2);
				System.String ret=UnityEngine.WWW.UnEscapeURL(a1,a2);
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
	static public int GetAudioClip(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.WWW self=checkSelf<UnityEngine.WWW>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				UnityEngine.AudioClip ret=self.GetAudioClip(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.WWW self=checkSelf<UnityEngine.WWW>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.AudioClip ret=self.GetAudioClip(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Boolean),typeof(System.Boolean),typeof(UnityEngine.AudioType))){
				UnityEngine.WWW self=checkSelf<UnityEngine.WWW>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.AudioType a3;
				checkEnum(l,4,out a3);
				UnityEngine.AudioClip ret=self.GetAudioClip(a1,a2,a3);
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
	static public int LoadImageIntoTexture(IntPtr l) {
		try{
			UnityEngine.WWW self=checkSelf<UnityEngine.WWW>(l);
			UnityEngine.Texture2D a1;
			checkType(l,2,out a1);
			self.LoadImageIntoTexture(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadUnityWeb(IntPtr l) {
		try{
			UnityEngine.WWW self=checkSelf<UnityEngine.WWW>(l);
			self.LoadUnityWeb();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadFromCacheOrDownload(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String),typeof(System.Int32))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.WWW ret=UnityEngine.WWW.LoadFromCacheOrDownload(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.UInt32))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.UInt32 a3;
				checkType(l,3,out a3);
				UnityEngine.WWW ret=UnityEngine.WWW.LoadFromCacheOrDownload(a1,a2,a3);
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
	static public int get_responseHeaders(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.responseHeaders);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bytes(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.bytes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_error(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.error);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureNonReadable(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.textureNonReadable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioClip(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.audioClip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDone(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.isDone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_progress(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.progress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uploadProgress(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.uploadProgress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bytesDownloaded(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.bytesDownloaded);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_url(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.url);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_assetBundle(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.assetBundle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_threadPriority(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		pushValue(l,o.threadPriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_threadPriority(IntPtr l) {
		UnityEngine.WWW o = checkSelf<UnityEngine.WWW>(l);
		UnityEngine.ThreadPriority v;
		checkEnum(l,2,out v);
		o.threadPriority=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WWW");
		addMember(l,InitWWW, "InitWWW");
		addMember(l,EscapeURL, "EscapeURL");
		addMember(l,UnEscapeURL, "UnEscapeURL");
		addMember(l,GetAudioClip, "GetAudioClip");
		addMember(l,LoadImageIntoTexture, "LoadImageIntoTexture");
		addMember(l,LoadUnityWeb, "LoadUnityWeb");
		addMember(l,LoadFromCacheOrDownload, "LoadFromCacheOrDownload");
		addMember(l,get_responseHeaders, "get_responseHeaders");
		addMember(l,get_text, "get_text");
		addMember(l,get_bytes, "get_bytes");
		addMember(l,get_size, "get_size");
		addMember(l,get_error, "get_error");
		addMember(l,get_texture, "get_texture");
		addMember(l,get_textureNonReadable, "get_textureNonReadable");
		addMember(l,get_audioClip, "get_audioClip");
		addMember(l,get_isDone, "get_isDone");
		addMember(l,get_progress, "get_progress");
		addMember(l,get_uploadProgress, "get_uploadProgress");
		addMember(l,get_bytesDownloaded, "get_bytesDownloaded");
		addMember(l,get_url, "get_url");
		addMember(l,get_assetBundle, "get_assetBundle");
		addMember(l,get_threadPriority, "get_threadPriority");
		addMember(l,set_threadPriority, "set_threadPriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.WWW));
		LuaDLL.lua_pop(l, 1);
	}
}
