using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ReflectionProbe : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ReflectionProbe o;
		o=new UnityEngine.ReflectionProbe();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenderProbe(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				UnityEngine.RenderTexture a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.RenderProbe(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Int32 ret=self.RenderProbe();
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
	static public int IsFinishedRendering(IntPtr l) {
		try{
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsFinishedRendering(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BlendCubemap_s(IntPtr l) {
		try{
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.RenderTexture a4;
			checkType(l,4,out a4);
			System.Boolean ret=UnityEngine.ReflectionProbe.BlendCubemap(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushEnum(l,(int)o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Rendering.ReflectionProbeType v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hdr(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.hdr);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hdr(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.hdr=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClipPlane(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.nearClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClipPlane(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.nearClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClipPlane(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.farClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClipPlane(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.farClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowDistance(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.shadowDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowDistance(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.shadowDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resolution(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.resolution);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resolution(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.resolution=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMask(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.cullingMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMask(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.cullingMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clearFlags(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushEnum(l,(int)o.clearFlags);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clearFlags(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Rendering.ReflectionProbeClearFlags v;
		checkEnum(l,2,out v);
		o.clearFlags=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColor(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.backgroundColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColor(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.backgroundColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intensity(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.intensity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intensity(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.intensity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boxProjection(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.boxProjection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boxProjection(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.boxProjection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushEnum(l,(int)o.mode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Rendering.ReflectionProbeMode v;
		checkEnum(l,2,out v);
		o.mode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_importance(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.importance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_importance(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.importance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_refreshMode(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushEnum(l,(int)o.refreshMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_refreshMode(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Rendering.ReflectionProbeRefreshMode v;
		checkEnum(l,2,out v);
		o.refreshMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeSlicingMode(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushEnum(l,(int)o.timeSlicingMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeSlicingMode(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Rendering.ReflectionProbeTimeSlicingMode v;
		checkEnum(l,2,out v);
		o.timeSlicingMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bakedTexture(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.bakedTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bakedTexture(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.bakedTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customBakedTexture(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.customBakedTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customBakedTexture(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.customBakedTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UnityEngine.ReflectionProbe o = (UnityEngine.ReflectionProbe)checkSelf(l);
		pushValue(l,o.texture);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ReflectionProbe");
		addMember(l,RenderProbe);
		addMember(l,IsFinishedRendering);
		addMember(l,BlendCubemap_s);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"hdr",get_hdr,set_hdr,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"nearClipPlane",get_nearClipPlane,set_nearClipPlane,true);
		addMember(l,"farClipPlane",get_farClipPlane,set_farClipPlane,true);
		addMember(l,"shadowDistance",get_shadowDistance,set_shadowDistance,true);
		addMember(l,"resolution",get_resolution,set_resolution,true);
		addMember(l,"cullingMask",get_cullingMask,set_cullingMask,true);
		addMember(l,"clearFlags",get_clearFlags,set_clearFlags,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"intensity",get_intensity,set_intensity,true);
		addMember(l,"boxProjection",get_boxProjection,set_boxProjection,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"importance",get_importance,set_importance,true);
		addMember(l,"refreshMode",get_refreshMode,set_refreshMode,true);
		addMember(l,"timeSlicingMode",get_timeSlicingMode,set_timeSlicingMode,true);
		addMember(l,"bakedTexture",get_bakedTexture,set_bakedTexture,true);
		addMember(l,"customBakedTexture",get_customBakedTexture,set_customBakedTexture,true);
		addMember(l,"texture",get_texture,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ReflectionProbe),typeof(UnityEngine.Behaviour));
	}
}
