using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Material : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Material o;
		if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Material(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(UnityEngine.Shader))){
			UnityEngine.Shader a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Material(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(UnityEngine.Material))){
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Material(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColor(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Color))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetColor(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Color))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetColor(a1,a2);
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
	static public int GetColor(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color ret=self.GetColor(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color ret=self.GetColor(a1);
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
	static public int SetVector(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Vector4))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetVector(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Vector4))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetVector(a1,a2);
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
	static public int GetVector(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 ret=self.GetVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 ret=self.GetVector(a1);
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
	static public int SetTexture(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Texture))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.SetTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Texture))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.SetTexture(a1,a2);
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
	static public int GetTexture(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture ret=self.GetTexture(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Texture ret=self.GetTexture(a1);
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
	static public int SetTextureOffset(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			self.SetTextureOffset(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextureOffset(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetTextureOffset(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTextureScale(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			self.SetTextureScale(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextureScale(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetTextureScale(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMatrix(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.SetMatrix(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.SetMatrix(a1,a2);
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
	static public int GetMatrix(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 ret=self.GetMatrix(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 ret=self.GetMatrix(a1);
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
	static public int SetFloat(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Single))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
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
	static public int GetFloat(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
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
	static public int SetInt(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInt(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInt(a1,a2);
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
	static public int GetInt(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.GetInt(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.GetInt(a1);
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
	static public int SetBuffer(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			self.SetBuffer(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasProperty(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.HasProperty(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.HasProperty(a1);
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
	static public int GetTag(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Boolean),typeof(System.String))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.String ret=self.GetTag(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.String),typeof(System.Boolean))){
				UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.String ret=self.GetTag(a1,a2);
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
	static public int Lerp(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Lerp(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPass(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.SetPass(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyPropertiesFromMaterial(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			self.CopyPropertiesFromMaterial(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnableKeyword(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			self.EnableKeyword(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisableKeyword(IntPtr l) {
		try{
			UnityEngine.Material self=checkSelf<UnityEngine.Material>(l);
			System.String a1;
			checkType(l,2,out a1);
			self.DisableKeyword(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.shader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		UnityEngine.Shader v;
		checkType(l,2,out v);
		o.shader=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTexture(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.mainTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTextureOffset(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.mainTextureOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTextureOffset(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.mainTextureOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTextureScale(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.mainTextureScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTextureScale(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.mainTextureScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_passCount(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.passCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderQueue(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.renderQueue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderQueue(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.renderQueue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shaderKeywords(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		pushValue(l,o.shaderKeywords);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shaderKeywords(IntPtr l) {
		UnityEngine.Material o = checkSelf<UnityEngine.Material>(l);
		System.String[] v;
		checkType(l,2,out v);
		o.shaderKeywords=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Material");
		addMember(l,SetColor, "SetColor");
		addMember(l,GetColor, "GetColor");
		addMember(l,SetVector, "SetVector");
		addMember(l,GetVector, "GetVector");
		addMember(l,SetTexture, "SetTexture");
		addMember(l,GetTexture, "GetTexture");
		addMember(l,SetTextureOffset, "SetTextureOffset");
		addMember(l,GetTextureOffset, "GetTextureOffset");
		addMember(l,SetTextureScale, "SetTextureScale");
		addMember(l,GetTextureScale, "GetTextureScale");
		addMember(l,SetMatrix, "SetMatrix");
		addMember(l,GetMatrix, "GetMatrix");
		addMember(l,SetFloat, "SetFloat");
		addMember(l,GetFloat, "GetFloat");
		addMember(l,SetInt, "SetInt");
		addMember(l,GetInt, "GetInt");
		addMember(l,SetBuffer, "SetBuffer");
		addMember(l,HasProperty, "HasProperty");
		addMember(l,GetTag, "GetTag");
		addMember(l,Lerp, "Lerp");
		addMember(l,SetPass, "SetPass");
		addMember(l,CopyPropertiesFromMaterial, "CopyPropertiesFromMaterial");
		addMember(l,EnableKeyword, "EnableKeyword");
		addMember(l,DisableKeyword, "DisableKeyword");
		addMember(l,get_shader, "get_shader");
		addMember(l,set_shader, "set_shader");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_mainTexture, "get_mainTexture");
		addMember(l,set_mainTexture, "set_mainTexture");
		addMember(l,get_mainTextureOffset, "get_mainTextureOffset");
		addMember(l,set_mainTextureOffset, "set_mainTextureOffset");
		addMember(l,get_mainTextureScale, "get_mainTextureScale");
		addMember(l,set_mainTextureScale, "set_mainTextureScale");
		addMember(l,get_passCount, "get_passCount");
		addMember(l,get_renderQueue, "get_renderQueue");
		addMember(l,set_renderQueue, "set_renderQueue");
		addMember(l,get_shaderKeywords, "get_shaderKeywords");
		addMember(l,set_shaderKeywords, "set_shaderKeywords");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Material),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
