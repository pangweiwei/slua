using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Camera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Camera o;
		if(matchType(l,1)){
			o=new UnityEngine.Camera();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTargetBuffers(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
				UnityEngine.RenderBuffer a1;
				checkType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkType(l,3,out a2);
				self.SetTargetBuffers(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
				UnityEngine.RenderBuffer[] a1;
				checkType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkType(l,3,out a2);
				self.SetTargetBuffers(a1,a2);
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
	static public int ResetWorldToCameraMatrix(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			self.ResetWorldToCameraMatrix();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetProjectionMatrix(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			self.ResetProjectionMatrix();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetAspect(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			self.ResetAspect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WorldToScreenPoint(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.WorldToScreenPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WorldToViewportPoint(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.WorldToViewportPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ViewportToWorldPoint(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.ViewportToWorldPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToWorldPoint(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.ScreenToWorldPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToViewportPoint(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.ScreenToViewportPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ViewportToScreenPoint(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.ViewportToScreenPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ViewportPointToRay(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Ray ret=self.ViewportPointToRay(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenPointToRay(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Ray ret=self.ScreenPointToRay(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllCameras(IntPtr l) {
		try{
			UnityEngine.Camera[] a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.Camera.GetAllCameras(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Render(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			self.Render();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenderWithShader(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Shader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.RenderWithShader(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetReplacementShader(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Shader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetReplacementShader(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetReplacementShader(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			self.ResetReplacementShader();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenderDontRestore(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			self.RenderDontRestore();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetupCurrent(IntPtr l) {
		try{
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Camera.SetupCurrent(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenderToCubemap(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Cubemap))){
				UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
				UnityEngine.Cubemap a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.RenderToCubemap(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Cubemap),typeof(System.Int32))){
				UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
				UnityEngine.Cubemap a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.RenderToCubemap(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.RenderTexture))){
				UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
				UnityEngine.RenderTexture a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.RenderToCubemap(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.RenderTexture),typeof(System.Int32))){
				UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
				UnityEngine.RenderTexture a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.RenderToCubemap(a1,a2);
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
	static public int CopyFrom(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.CopyFrom(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateObliqueMatrix(IntPtr l) {
		try{
			UnityEngine.Camera self=checkSelf<UnityEngine.Camera>(l);
			UnityEngine.Vector4 a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 ret=self.CalculateObliqueMatrix(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldOfView(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.fieldOfView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldOfView(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.fieldOfView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClipPlane(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.nearClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClipPlane(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.nearClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClipPlane(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.farClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClipPlane(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.farClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingPath(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.renderingPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderingPath(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.RenderingPath v;
		checkEnum(l,2,out v);
		o.renderingPath=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_actualRenderingPath(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.actualRenderingPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hdr(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.hdr);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hdr(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hdr=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographicSize(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.orthographicSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographicSize(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.orthographicSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographic(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.orthographic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographic(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.orthographic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transparencySortMode(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.transparencySortMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_transparencySortMode(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.TransparencySortMode v;
		checkEnum(l,2,out v);
		o.transparencySortMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOrthoGraphic(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.isOrthoGraphic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isOrthoGraphic(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isOrthoGraphic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.depth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspect(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.aspect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspect(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.aspect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMask(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.cullingMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMask(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.cullingMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventMask(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.eventMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventMask(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.eventMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColor(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.backgroundColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColor(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.backgroundColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.rect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rect(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.Rect v;
		checkType(l,2,out v);
		o.rect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelRect(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.pixelRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelRect(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.Rect v;
		checkType(l,2,out v);
		o.pixelRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetTexture(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.targetTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetTexture(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.RenderTexture v;
		checkType(l,2,out v);
		o.targetTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelWidth(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.pixelWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelHeight(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.pixelHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraToWorldMatrix(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.cameraToWorldMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldToCameraMatrix(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.worldToCameraMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldToCameraMatrix(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.Matrix4x4 v;
		checkType(l,2,out v);
		o.worldToCameraMatrix=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionMatrix(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.projectionMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionMatrix(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.Matrix4x4 v;
		checkType(l,2,out v);
		o.projectionMatrix=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clearFlags(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.clearFlags);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clearFlags(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.CameraClearFlags v;
		checkEnum(l,2,out v);
		o.clearFlags=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stereoEnabled(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.stereoEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stereoSeparation(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.stereoSeparation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stereoSeparation(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.stereoSeparation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stereoConvergence(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.stereoConvergence);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stereoConvergence(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single v;
		checkType(l,2,out v);
		o.stereoConvergence=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_main(IntPtr l) {
		pushValue(l,UnityEngine.Camera.main);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UnityEngine.Camera.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allCameras(IntPtr l) {
		pushValue(l,UnityEngine.Camera.allCameras);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allCamerasCount(IntPtr l) {
		pushValue(l,UnityEngine.Camera.allCamerasCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useOcclusionCulling(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.useOcclusionCulling);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useOcclusionCulling(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useOcclusionCulling=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layerCullDistances(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.layerCullDistances);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layerCullDistances(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Single[] v;
		checkType(l,2,out v);
		o.layerCullDistances=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layerCullSpherical(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.layerCullSpherical);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layerCullSpherical(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.layerCullSpherical=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthTextureMode(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.depthTextureMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthTextureMode(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		UnityEngine.DepthTextureMode v;
		checkEnum(l,2,out v);
		o.depthTextureMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clearStencilAfterLightingPass(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		pushValue(l,o.clearStencilAfterLightingPass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clearStencilAfterLightingPass(IntPtr l) {
		UnityEngine.Camera o = checkSelf<UnityEngine.Camera>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.clearStencilAfterLightingPass=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Camera");
		addMember(l,SetTargetBuffers, "SetTargetBuffers");
		addMember(l,ResetWorldToCameraMatrix, "ResetWorldToCameraMatrix");
		addMember(l,ResetProjectionMatrix, "ResetProjectionMatrix");
		addMember(l,ResetAspect, "ResetAspect");
		addMember(l,WorldToScreenPoint, "WorldToScreenPoint");
		addMember(l,WorldToViewportPoint, "WorldToViewportPoint");
		addMember(l,ViewportToWorldPoint, "ViewportToWorldPoint");
		addMember(l,ScreenToWorldPoint, "ScreenToWorldPoint");
		addMember(l,ScreenToViewportPoint, "ScreenToViewportPoint");
		addMember(l,ViewportToScreenPoint, "ViewportToScreenPoint");
		addMember(l,ViewportPointToRay, "ViewportPointToRay");
		addMember(l,ScreenPointToRay, "ScreenPointToRay");
		addMember(l,GetAllCameras, "GetAllCameras");
		addMember(l,Render, "Render");
		addMember(l,RenderWithShader, "RenderWithShader");
		addMember(l,SetReplacementShader, "SetReplacementShader");
		addMember(l,ResetReplacementShader, "ResetReplacementShader");
		addMember(l,RenderDontRestore, "RenderDontRestore");
		addMember(l,SetupCurrent, "SetupCurrent");
		addMember(l,RenderToCubemap, "RenderToCubemap");
		addMember(l,CopyFrom, "CopyFrom");
		addMember(l,CalculateObliqueMatrix, "CalculateObliqueMatrix");
		addMember(l,get_fieldOfView, "get_fieldOfView");
		addMember(l,set_fieldOfView, "set_fieldOfView");
		addMember(l,get_nearClipPlane, "get_nearClipPlane");
		addMember(l,set_nearClipPlane, "set_nearClipPlane");
		addMember(l,get_farClipPlane, "get_farClipPlane");
		addMember(l,set_farClipPlane, "set_farClipPlane");
		addMember(l,get_renderingPath, "get_renderingPath");
		addMember(l,set_renderingPath, "set_renderingPath");
		addMember(l,get_actualRenderingPath, "get_actualRenderingPath");
		addMember(l,get_hdr, "get_hdr");
		addMember(l,set_hdr, "set_hdr");
		addMember(l,get_orthographicSize, "get_orthographicSize");
		addMember(l,set_orthographicSize, "set_orthographicSize");
		addMember(l,get_orthographic, "get_orthographic");
		addMember(l,set_orthographic, "set_orthographic");
		addMember(l,get_transparencySortMode, "get_transparencySortMode");
		addMember(l,set_transparencySortMode, "set_transparencySortMode");
		addMember(l,get_isOrthoGraphic, "get_isOrthoGraphic");
		addMember(l,set_isOrthoGraphic, "set_isOrthoGraphic");
		addMember(l,get_depth, "get_depth");
		addMember(l,set_depth, "set_depth");
		addMember(l,get_aspect, "get_aspect");
		addMember(l,set_aspect, "set_aspect");
		addMember(l,get_cullingMask, "get_cullingMask");
		addMember(l,set_cullingMask, "set_cullingMask");
		addMember(l,get_eventMask, "get_eventMask");
		addMember(l,set_eventMask, "set_eventMask");
		addMember(l,get_backgroundColor, "get_backgroundColor");
		addMember(l,set_backgroundColor, "set_backgroundColor");
		addMember(l,get_rect, "get_rect");
		addMember(l,set_rect, "set_rect");
		addMember(l,get_pixelRect, "get_pixelRect");
		addMember(l,set_pixelRect, "set_pixelRect");
		addMember(l,get_targetTexture, "get_targetTexture");
		addMember(l,set_targetTexture, "set_targetTexture");
		addMember(l,get_pixelWidth, "get_pixelWidth");
		addMember(l,get_pixelHeight, "get_pixelHeight");
		addMember(l,get_cameraToWorldMatrix, "get_cameraToWorldMatrix");
		addMember(l,get_worldToCameraMatrix, "get_worldToCameraMatrix");
		addMember(l,set_worldToCameraMatrix, "set_worldToCameraMatrix");
		addMember(l,get_projectionMatrix, "get_projectionMatrix");
		addMember(l,set_projectionMatrix, "set_projectionMatrix");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,get_clearFlags, "get_clearFlags");
		addMember(l,set_clearFlags, "set_clearFlags");
		addMember(l,get_stereoEnabled, "get_stereoEnabled");
		addMember(l,get_stereoSeparation, "get_stereoSeparation");
		addMember(l,set_stereoSeparation, "set_stereoSeparation");
		addMember(l,get_stereoConvergence, "get_stereoConvergence");
		addMember(l,set_stereoConvergence, "set_stereoConvergence");
		addMember(l,get_main, "get_main");
		addMember(l,get_current, "get_current");
		addMember(l,get_allCameras, "get_allCameras");
		addMember(l,get_allCamerasCount, "get_allCamerasCount");
		addMember(l,get_useOcclusionCulling, "get_useOcclusionCulling");
		addMember(l,set_useOcclusionCulling, "set_useOcclusionCulling");
		addMember(l,get_layerCullDistances, "get_layerCullDistances");
		addMember(l,set_layerCullDistances, "set_layerCullDistances");
		addMember(l,get_layerCullSpherical, "get_layerCullSpherical");
		addMember(l,set_layerCullSpherical, "set_layerCullSpherical");
		addMember(l,get_depthTextureMode, "get_depthTextureMode");
		addMember(l,set_depthTextureMode, "set_depthTextureMode");
		addMember(l,get_clearStencilAfterLightingPass, "get_clearStencilAfterLightingPass");
		addMember(l,set_clearStencilAfterLightingPass, "set_clearStencilAfterLightingPass");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Camera),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
