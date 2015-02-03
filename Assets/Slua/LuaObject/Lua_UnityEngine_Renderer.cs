using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Renderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Renderer o;
		o=new UnityEngine.Renderer();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPropertyBlock(IntPtr l) {
		try{
			UnityEngine.Renderer self=(UnityEngine.Renderer)checkSelf(l);
			UnityEngine.MaterialPropertyBlock a1;
			checkType(l,2,out a1);
			self.SetPropertyBlock(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPropertyBlock(IntPtr l) {
		try{
			UnityEngine.Renderer self=(UnityEngine.Renderer)checkSelf(l);
			UnityEngine.MaterialPropertyBlock a1;
			checkType(l,2,out a1);
			self.GetPropertyBlock(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Render(IntPtr l) {
		try{
			UnityEngine.Renderer self=(UnityEngine.Renderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Render(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPartOfStaticBatch(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.isPartOfStaticBatch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldToLocalMatrix(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.worldToLocalMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localToWorldMatrix(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.localToWorldMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_castShadows(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.castShadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_castShadows(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.castShadows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_receiveShadows(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.receiveShadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_receiveShadows(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.receiveShadows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.sharedMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.sharedMaterial=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterials(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.sharedMaterials);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterials(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		UnityEngine.Material[] v;
		checkType(l,2,out v);
		o.sharedMaterials=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materials(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.materials);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_materials(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		UnityEngine.Material[] v;
		checkType(l,2,out v);
		o.materials=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapIndex(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.lightmapIndex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapIndex(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.lightmapIndex=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapTilingOffset(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.lightmapTilingOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapTilingOffset(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		UnityEngine.Vector4 v;
		checkType(l,2,out v);
		o.lightmapTilingOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVisible(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.isVisible);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLightProbes(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.useLightProbes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLightProbes(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useLightProbes=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightProbeAnchor(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.lightProbeAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightProbeAnchor(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.lightProbeAnchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerName(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.sortingLayerName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerName(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.sortingLayerName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerID(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.sortingLayerID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerID(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.sortingLayerID=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		pushValue(l,o.sortingOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		UnityEngine.Renderer o = (UnityEngine.Renderer)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.sortingOrder=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Renderer");
		addMember(l,SetPropertyBlock);
		addMember(l,GetPropertyBlock);
		addMember(l,Render);
		addMember(l,"isPartOfStaticBatch",get_isPartOfStaticBatch,null,true);
		addMember(l,"worldToLocalMatrix",get_worldToLocalMatrix,null,true);
		addMember(l,"localToWorldMatrix",get_localToWorldMatrix,null,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"castShadows",get_castShadows,set_castShadows,true);
		addMember(l,"receiveShadows",get_receiveShadows,set_receiveShadows,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"sharedMaterial",get_sharedMaterial,set_sharedMaterial,true);
		addMember(l,"sharedMaterials",get_sharedMaterials,set_sharedMaterials,true);
		addMember(l,"materials",get_materials,set_materials,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"lightmapIndex",get_lightmapIndex,set_lightmapIndex,true);
		addMember(l,"lightmapTilingOffset",get_lightmapTilingOffset,set_lightmapTilingOffset,true);
		addMember(l,"isVisible",get_isVisible,null,true);
		addMember(l,"useLightProbes",get_useLightProbes,set_useLightProbes,true);
		addMember(l,"lightProbeAnchor",get_lightProbeAnchor,set_lightProbeAnchor,true);
		addMember(l,"sortingLayerName",get_sortingLayerName,set_sortingLayerName,true);
		addMember(l,"sortingLayerID",get_sortingLayerID,set_sortingLayerID,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Renderer),typeof(UnityEngine.Component));
	}
}
