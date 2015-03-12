﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Graphics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Graphics o;
		o=new UnityEngine.Graphics();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawMesh_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(int),typeof(UnityEngine.Camera),typeof(int))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Material a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.Camera a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(int),typeof(UnityEngine.Camera))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Material a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.Camera a6;
				checkType(l,6,out a6);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Material a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==8){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Material a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.Camera a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.MaterialPropertyBlock a8;
				checkType(l,8,out a8);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(int),typeof(UnityEngine.Camera),typeof(int))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Camera a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(int),typeof(UnityEngine.Camera))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Camera a5;
				checkType(l,5,out a5);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(int),typeof(UnityEngine.Camera),typeof(int),typeof(UnityEngine.MaterialPropertyBlock))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Camera a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.MaterialPropertyBlock a7;
				checkType(l,7,out a7);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7);
				return 0;
			}
			else if(argc==10){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Material a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.Camera a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.MaterialPropertyBlock a8;
				checkType(l,8,out a8);
				System.Boolean a9;
				checkType(l,9,out a9);
				System.Boolean a10;
				checkType(l,10,out a10);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
				return 0;
			}
			else if(argc==9){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Camera a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.MaterialPropertyBlock a7;
				checkType(l,7,out a7);
				System.Boolean a8;
				checkType(l,8,out a8);
				System.Boolean a9;
				checkType(l,9,out a9);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9);
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
	static public int DrawMeshNow_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawMeshNow(a1,a2,a3);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Graphics.DrawMeshNow(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawMeshNow(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(int))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawMeshNow(a1,a2,a3);
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
	static public int DrawProcedural_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.MeshTopology a1;
				checkEnum(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawProcedural(a1,a2,a3);
				return 0;
			}
			else if(argc==2){
				UnityEngine.MeshTopology a1;
				checkEnum(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawProcedural(a1,a2);
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
	static public int DrawProceduralIndirect_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.MeshTopology a1;
				checkEnum(l,1,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawProceduralIndirect(a1,a2,a3);
				return 0;
			}
			else if(argc==2){
				UnityEngine.MeshTopology a1;
				checkEnum(l,1,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawProceduralIndirect(a1,a2);
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
	static public int DrawTexture_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawTexture(a1,a2);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3);
				return 0;
			}
			else if(argc==6){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(int),typeof(int),typeof(int),typeof(int),typeof(UnityEngine.Material))){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.Material a7;
				checkType(l,7,out a7);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(int),typeof(int),typeof(int),typeof(int))){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Rect a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(int),typeof(int),typeof(int),typeof(int),typeof(UnityEngine.Material))){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Rect a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.Material a8;
				checkType(l,8,out a8);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(int),typeof(int),typeof(int),typeof(int),typeof(UnityEngine.Color))){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Rect a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.Color a8;
				checkType(l,8,out a8);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8);
				return 0;
			}
			else if(argc==9){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Rect a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				UnityEngine.Color a8;
				checkType(l,8,out a8);
				UnityEngine.Material a9;
				checkType(l,9,out a9);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9);
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
	static public int Blit_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.Blit(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.Blit(a1,a2,a3);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Graphics.Blit(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Texture),typeof(UnityEngine.Material))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.Material a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.Blit(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Texture),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.Material a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.Blit(a1,a2,a3);
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
	static public int BlitMultiTap_s(IntPtr l) {
		try{
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2[] a4;
			checkParams(l,4,out a4);
			UnityEngine.Graphics.BlitMultiTap(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRenderTarget_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.RenderTexture a1;
				checkType(l,1,out a1);
				UnityEngine.Graphics.SetRenderTarget(a1);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.RenderTexture),typeof(int))){
				UnityEngine.RenderTexture a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRenderTarget(a1,a2);
				return 0;
			}
			else if(argc==3){
				UnityEngine.RenderTexture a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,3,out a3);
				UnityEngine.Graphics.SetRenderTarget(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.RenderBuffer a1;
				checkType(l,1,out a1);
				UnityEngine.RenderBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRenderTarget(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.RenderBuffer[]),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.RenderBuffer[] a1;
				checkType(l,1,out a1);
				UnityEngine.RenderBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRenderTarget(a1,a2);
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
	static public int SetRandomWriteTarget_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.RenderTexture))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRandomWriteTarget(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.ComputeBuffer))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRandomWriteTarget(a1,a2);
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
	static public int ClearRandomWriteTargets_s(IntPtr l) {
		try{
			UnityEngine.Graphics.ClearRandomWriteTargets();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeColorBuffer(IntPtr l) {
		pushValue(l,UnityEngine.Graphics.activeColorBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeDepthBuffer(IntPtr l) {
		pushValue(l,UnityEngine.Graphics.activeDepthBuffer);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Graphics");
		addMember(l,DrawMesh_s);
		addMember(l,DrawMeshNow_s);
		addMember(l,DrawProcedural_s);
		addMember(l,DrawProceduralIndirect_s);
		addMember(l,DrawTexture_s);
		addMember(l,Blit_s);
		addMember(l,BlitMultiTap_s);
		addMember(l,SetRenderTarget_s);
		addMember(l,SetRandomWriteTarget_s);
		addMember(l,ClearRandomWriteTargets_s);
		addMember(l,"activeColorBuffer",get_activeColorBuffer,null,false);
		addMember(l,"activeDepthBuffer",get_activeDepthBuffer,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Graphics));
	}
}
