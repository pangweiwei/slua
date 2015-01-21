using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GL : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.GL o;
		if(matchType(l,1)){
			o=new UnityEngine.GL();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Vertex3(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.GL.Vertex3(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Vertex(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Vertex(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Color(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Color(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TexCoord(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.TexCoord(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TexCoord2(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.GL.TexCoord2(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TexCoord3(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.GL.TexCoord3(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiTexCoord2(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.GL.MultiTexCoord2(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiTexCoord3(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.GL.MultiTexCoord3(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiTexCoord(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.GL.MultiTexCoord(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Begin(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int End(IntPtr l) {
		try{
			UnityEngine.GL.End();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadOrtho(IntPtr l) {
		try{
			UnityEngine.GL.LoadOrtho();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadPixelMatrix(IntPtr l) {
		try{
			if(matchType(l,1)){
				UnityEngine.GL.LoadPixelMatrix();
				return 0;
			}
			else if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GL.LoadPixelMatrix(a1,a2,a3,a4);
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
	static public int Viewport(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			UnityEngine.GL.Viewport(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadProjectionMatrix(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.LoadProjectionMatrix(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadIdentity(IntPtr l) {
		try{
			UnityEngine.GL.LoadIdentity();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultMatrix(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.MultMatrix(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PushMatrix(IntPtr l) {
		try{
			UnityEngine.GL.PushMatrix();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PopMatrix(IntPtr l) {
		try{
			UnityEngine.GL.PopMatrix();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGPUProjectionMatrix(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			UnityEngine.Matrix4x4 ret=UnityEngine.GL.GetGPUProjectionMatrix(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRevertBackfacing(IntPtr l) {
		try{
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.GL.SetRevertBackfacing(a1);
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
			if(matchType(l,1,typeof(System.Boolean),typeof(System.Boolean),typeof(UnityEngine.Color))){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.GL.Clear(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Boolean),typeof(System.Boolean),typeof(UnityEngine.Color),typeof(System.Single))){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GL.Clear(a1,a2,a3,a4);
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
	static public int ClearWithSkybox(IntPtr l) {
		try{
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Camera a2;
			checkType(l,2,out a2);
			UnityEngine.GL.ClearWithSkybox(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvalidateState(IntPtr l) {
		try{
			UnityEngine.GL.InvalidateState();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IssuePluginEvent(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GL.IssuePluginEvent(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLES(IntPtr l) {
		pushValue(l,UnityEngine.GL.TRIANGLES);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLE_STRIP(IntPtr l) {
		pushValue(l,UnityEngine.GL.TRIANGLE_STRIP);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_QUADS(IntPtr l) {
		pushValue(l,UnityEngine.GL.QUADS);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LINES(IntPtr l) {
		pushValue(l,UnityEngine.GL.LINES);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modelview(IntPtr l) {
		pushValue(l,UnityEngine.GL.modelview);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modelview(IntPtr l) {
		UnityEngine.Matrix4x4 v;
		checkType(l,2,out v);
		UnityEngine.GL.modelview=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wireframe(IntPtr l) {
		pushValue(l,UnityEngine.GL.wireframe);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wireframe(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.GL.wireframe=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sRGBWrite(IntPtr l) {
		pushValue(l,UnityEngine.GL.sRGBWrite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sRGBWrite(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.GL.sRGBWrite=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GL");
		addMember(l,Vertex3);
		addMember(l,Vertex);
		addMember(l,Color);
		addMember(l,TexCoord);
		addMember(l,TexCoord2);
		addMember(l,TexCoord3);
		addMember(l,MultiTexCoord2);
		addMember(l,MultiTexCoord3);
		addMember(l,MultiTexCoord);
		addMember(l,Begin);
		addMember(l,End);
		addMember(l,LoadOrtho);
		addMember(l,LoadPixelMatrix);
		addMember(l,Viewport);
		addMember(l,LoadProjectionMatrix);
		addMember(l,LoadIdentity);
		addMember(l,MultMatrix);
		addMember(l,PushMatrix);
		addMember(l,PopMatrix);
		addMember(l,GetGPUProjectionMatrix);
		addMember(l,SetRevertBackfacing);
		addMember(l,Clear);
		addMember(l,ClearWithSkybox);
		addMember(l,InvalidateState);
		addMember(l,IssuePluginEvent);
		addMember(l,"TRIANGLES",get_TRIANGLES,null);
		addMember(l,"TRIANGLE_STRIP",get_TRIANGLE_STRIP,null);
		addMember(l,"QUADS",get_QUADS,null);
		addMember(l,"LINES",get_LINES,null);
		addMember(l,"modelview",get_modelview,set_modelview);
		addMember(l,"wireframe",get_wireframe,set_wireframe);
		addMember(l,"sRGBWrite",get_sRGBWrite,set_sRGBWrite);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GL));
	}
}
