using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_CommandBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Rendering.CommandBuffer o;
		o=new UnityEngine.Rendering.CommandBuffer();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Release(IntPtr l) {
		try{
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Release();
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
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawMesh(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				UnityEngine.MaterialPropertyBlock a6;
				checkType(l,7,out a6);
				self.DrawMesh(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				self.DrawMesh(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.DrawMesh(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.DrawMesh(a1,a2,a3);
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
	static public int DrawRenderer(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,2,out a1);
				UnityEngine.Material a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.DrawRenderer(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,2,out a1);
				UnityEngine.Material a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.DrawRenderer(a1,a2,a3);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,2,out a1);
				UnityEngine.Material a2;
				checkType(l,3,out a2);
				self.DrawRenderer(a1,a2);
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
	static public int SetRenderTarget(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkType(l,2,out a1);
				self.SetRenderTarget(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				self.SetRenderTarget(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier[]),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier[] a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				self.SetRenderTarget(a1,a2);
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
	static public int Blit(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				self.Blit(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.Blit(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.Blit(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				self.Blit(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.Blit(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.Blit(a1,a2,a3,a4);
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
	static public int GetTemporaryRT(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,6,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,7,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,8,out a7);
				System.Int32 a8;
				checkType(l,9,out a8);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8);
				return 0;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,6,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,7,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,8,out a7);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7);
				return 0;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,6,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,7,out a6);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,6,out a5);
				self.GetTemporaryRT(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.GetTemporaryRT(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.GetTemporaryRT(a1,a2,a3);
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
	static public int ReleaseTemporaryRT(IntPtr l) {
		try{
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.ReleaseTemporaryRT(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearRenderTarget(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Color a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.ClearRenderTarget(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Color a3;
				checkType(l,4,out a3);
				self.ClearRenderTarget(a1,a2,a3);
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
	static public int SetGlobalFloat(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(float))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetGlobalFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(float))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetGlobalFloat(a1,a2);
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
	static public int SetGlobalVector(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Vector4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetGlobalVector(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Vector4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetGlobalVector(a1,a2);
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
	static public int SetGlobalColor(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Color))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetGlobalColor(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Color))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetGlobalColor(a1,a2);
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
	static public int SetGlobalMatrix(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.SetGlobalMatrix(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,3,out a2);
				self.SetGlobalMatrix(a1,a2);
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
	static public int SetGlobalTexture(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				self.SetGlobalTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkType(l,3,out a2);
				self.SetGlobalTexture(a1,a2);
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
	static public int get_name(IntPtr l) {
		UnityEngine.Rendering.CommandBuffer o = (UnityEngine.Rendering.CommandBuffer)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.Rendering.CommandBuffer o = (UnityEngine.Rendering.CommandBuffer)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sizeInBytes(IntPtr l) {
		UnityEngine.Rendering.CommandBuffer o = (UnityEngine.Rendering.CommandBuffer)checkSelf(l);
		pushValue(l,o.sizeInBytes);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.CommandBuffer");
		addMember(l,Release);
		addMember(l,Clear);
		addMember(l,DrawMesh);
		addMember(l,DrawRenderer);
		addMember(l,SetRenderTarget);
		addMember(l,Blit);
		addMember(l,GetTemporaryRT);
		addMember(l,ReleaseTemporaryRT);
		addMember(l,ClearRenderTarget);
		addMember(l,SetGlobalFloat);
		addMember(l,SetGlobalVector);
		addMember(l,SetGlobalColor);
		addMember(l,SetGlobalMatrix);
		addMember(l,SetGlobalTexture);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"sizeInBytes",get_sizeInBytes,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.CommandBuffer));
	}
}
