using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Graphics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Graphics o;
		if(matchType(l,1)){
			o=new UnityEngine.Graphics();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawMesh(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera),typeof(System.Int32),typeof(UnityEngine.MaterialPropertyBlock))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera),typeof(System.Int32),typeof(UnityEngine.MaterialPropertyBlock))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera),typeof(System.Int32),typeof(UnityEngine.MaterialPropertyBlock),typeof(System.Boolean),typeof(System.Boolean))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Material),typeof(System.Int32),typeof(UnityEngine.Camera),typeof(System.Int32),typeof(UnityEngine.MaterialPropertyBlock),typeof(System.Boolean),typeof(System.Boolean))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(System.Int32))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawMesh(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(System.Int32))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawMesh(a1,a2,a3);
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
	static public int DrawMeshNow(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawMeshNow(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Mesh a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawMeshNow(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Mesh),typeof(UnityEngine.Matrix4x4),typeof(System.Int32))){
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
	static public int DrawProcedural(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.MeshTopology),typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.MeshTopology a1;
				checkEnum(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawProcedural(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.MeshTopology),typeof(System.Int32))){
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
	static public int DrawProceduralIndirect(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.MeshTopology),typeof(UnityEngine.ComputeBuffer),typeof(System.Int32))){
				UnityEngine.MeshTopology a1;
				checkEnum(l,1,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawProceduralIndirect(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.MeshTopology),typeof(UnityEngine.ComputeBuffer))){
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
	static public int DrawTexture(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture))){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.DrawTexture(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Material))){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.DrawTexture(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.Material))){
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
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.Material))){
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
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.Color))){
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
			else if(matchType(l,1,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.Rect),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.Color),typeof(UnityEngine.Material))){
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
	static public int Blit(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.Blit(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Material a3;
				checkType(l,3,out a3);
				UnityEngine.Graphics.Blit(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material),typeof(System.Int32))){
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
			else if(matchType(l,1,typeof(UnityEngine.Texture),typeof(UnityEngine.Material))){
				UnityEngine.Texture a1;
				checkType(l,1,out a1);
				UnityEngine.Material a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.Blit(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture),typeof(UnityEngine.Material),typeof(System.Int32))){
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
	static public int BlitMultiTap(IntPtr l) {
		try{
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2[] a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.BlitMultiTap(a1,a2,a3,a4);
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
			if(matchType(l,1,typeof(UnityEngine.RenderTexture))){
				UnityEngine.RenderTexture a1;
				checkType(l,1,out a1);
				UnityEngine.Graphics.SetRenderTarget(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.RenderTexture),typeof(System.Int32))){
				UnityEngine.RenderTexture a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRenderTarget(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.RenderTexture),typeof(System.Int32),typeof(UnityEngine.CubemapFace))){
				UnityEngine.RenderTexture a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,3,out a3);
				UnityEngine.Graphics.SetRenderTarget(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.RenderBuffer a1;
				checkType(l,1,out a1);
				UnityEngine.RenderBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRenderTarget(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer))){
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
	static public int SetRandomWriteTarget(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(UnityEngine.RenderTexture))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,2,out a2);
				UnityEngine.Graphics.SetRandomWriteTarget(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(UnityEngine.ComputeBuffer))){
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
	static public int ClearRandomWriteTargets(IntPtr l) {
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
		addMember(l,DrawMesh);
		addMember(l,DrawMeshNow);
		addMember(l,DrawProcedural);
		addMember(l,DrawProceduralIndirect);
		addMember(l,DrawTexture);
		addMember(l,Blit);
		addMember(l,BlitMultiTap);
		addMember(l,SetRenderTarget);
		addMember(l,SetRandomWriteTarget);
		addMember(l,ClearRandomWriteTargets);
		addMember(l,"activeColorBuffer",get_activeColorBuffer,null);
		addMember(l,"activeDepthBuffer",get_activeDepthBuffer,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Graphics));
	}
}
