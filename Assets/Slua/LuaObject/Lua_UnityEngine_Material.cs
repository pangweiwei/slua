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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetColor(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Color))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color ret=self.GetColor(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetVector(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Vector4))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 ret=self.GetVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.SetTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Texture))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture ret=self.GetTexture(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.SetMatrix(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 ret=self.GetMatrix(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInt(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.GetInt(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.HasProperty(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
				UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.shader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		UnityEngine.Shader v;
		checkType(l,2,out v);
		o.shader=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTexture(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.mainTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTextureOffset(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.mainTextureOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTextureOffset(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.mainTextureOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTextureScale(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.mainTextureScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTextureScale(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.mainTextureScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_passCount(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.passCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderQueue(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.renderQueue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderQueue(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.renderQueue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shaderKeywords(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		pushValue(l,o.shaderKeywords);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shaderKeywords(IntPtr l) {
		UnityEngine.Material o = (UnityEngine.Material)checkSelf(l);
		string[] v;
		checkType(l,2,out v);
		o.shaderKeywords=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Material");
		addMember(l,SetColor);
		addMember(l,GetColor);
		addMember(l,SetVector);
		addMember(l,GetVector);
		addMember(l,SetTexture);
		addMember(l,GetTexture);
		addMember(l,SetTextureOffset);
		addMember(l,GetTextureOffset);
		addMember(l,SetTextureScale);
		addMember(l,GetTextureScale);
		addMember(l,SetMatrix);
		addMember(l,GetMatrix);
		addMember(l,SetFloat);
		addMember(l,GetFloat);
		addMember(l,SetInt);
		addMember(l,GetInt);
		addMember(l,SetBuffer);
		addMember(l,HasProperty);
		addMember(l,GetTag);
		addMember(l,Lerp);
		addMember(l,SetPass);
		addMember(l,CopyPropertiesFromMaterial);
		addMember(l,EnableKeyword);
		addMember(l,DisableKeyword);
		addMember(l,"shader",get_shader,set_shader);
		addMember(l,"color",get_color,set_color);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture);
		addMember(l,"mainTextureOffset",get_mainTextureOffset,set_mainTextureOffset);
		addMember(l,"mainTextureScale",get_mainTextureScale,set_mainTextureScale);
		addMember(l,"passCount",get_passCount,null);
		addMember(l,"renderQueue",get_renderQueue,set_renderQueue);
		addMember(l,"shaderKeywords",get_shaderKeywords,set_shaderKeywords);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Material),typeof(UnityEngine.Object));
	}
}
