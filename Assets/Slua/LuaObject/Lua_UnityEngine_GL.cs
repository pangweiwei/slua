using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GL : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.GL o;
		o=new UnityEngine.GL();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Vertex3_s(IntPtr l) {
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
	static public int Vertex_s(IntPtr l) {
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
	static public int Color_s(IntPtr l) {
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
	static public int TexCoord_s(IntPtr l) {
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
	static public int TexCoord2_s(IntPtr l) {
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
	static public int TexCoord3_s(IntPtr l) {
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
	static public int MultiTexCoord2_s(IntPtr l) {
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
	static public int MultiTexCoord3_s(IntPtr l) {
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
	static public int MultiTexCoord_s(IntPtr l) {
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
	static public int Begin_s(IntPtr l) {
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
	static public int End_s(IntPtr l) {
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
	static public int LoadOrtho_s(IntPtr l) {
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
	static public int LoadPixelMatrix_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.GL.LoadPixelMatrix();
				return 0;
			}
			else if(argc==5){
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
	static public int Viewport_s(IntPtr l) {
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
	static public int LoadProjectionMatrix_s(IntPtr l) {
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
	static public int LoadIdentity_s(IntPtr l) {
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
	static public int MultMatrix_s(IntPtr l) {
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
	static public int PushMatrix_s(IntPtr l) {
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
	static public int PopMatrix_s(IntPtr l) {
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
	static public int GetGPUProjectionMatrix_s(IntPtr l) {
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
	static public int SetRevertBackfacing_s(IntPtr l) {
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
	static public int Clear_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.GL.Clear(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
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
	static public int ClearWithSkybox_s(IntPtr l) {
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
	static public int InvalidateState_s(IntPtr l) {
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
	static public int IssuePluginEvent_s(IntPtr l) {
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
		bool v;
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
		bool v;
		checkType(l,2,out v);
		UnityEngine.GL.sRGBWrite=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GL");
		addMember(l,Vertex3_s);
		addMember(l,Vertex_s);
		addMember(l,Color_s);
		addMember(l,TexCoord_s);
		addMember(l,TexCoord2_s);
		addMember(l,TexCoord3_s);
		addMember(l,MultiTexCoord2_s);
		addMember(l,MultiTexCoord3_s);
		addMember(l,MultiTexCoord_s);
		addMember(l,Begin_s);
		addMember(l,End_s);
		addMember(l,LoadOrtho_s);
		addMember(l,LoadPixelMatrix_s);
		addMember(l,Viewport_s);
		addMember(l,LoadProjectionMatrix_s);
		addMember(l,LoadIdentity_s);
		addMember(l,MultMatrix_s);
		addMember(l,PushMatrix_s);
		addMember(l,PopMatrix_s);
		addMember(l,GetGPUProjectionMatrix_s);
		addMember(l,SetRevertBackfacing_s);
		addMember(l,Clear_s);
		addMember(l,ClearWithSkybox_s);
		addMember(l,InvalidateState_s);
		addMember(l,IssuePluginEvent_s);
		addMember(l,"TRIANGLES",get_TRIANGLES,null,false);
		addMember(l,"TRIANGLE_STRIP",get_TRIANGLE_STRIP,null,false);
		addMember(l,"QUADS",get_QUADS,null,false);
		addMember(l,"LINES",get_LINES,null,false);
		addMember(l,"modelview",get_modelview,set_modelview,false);
		addMember(l,"wireframe",get_wireframe,set_wireframe,false);
		addMember(l,"sRGBWrite",get_sRGBWrite,set_sRGBWrite,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GL));
	}
}
