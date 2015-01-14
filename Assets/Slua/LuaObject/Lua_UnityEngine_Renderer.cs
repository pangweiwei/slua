using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Renderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Renderer o;
		if(matchType(l,1)){
			o=new UnityEngine.Renderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPropertyBlock(IntPtr l) {
		try{
			UnityEngine.Renderer self=checkSelf<UnityEngine.Renderer>(l);
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
			UnityEngine.Renderer self=checkSelf<UnityEngine.Renderer>(l);
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
			UnityEngine.Renderer self=checkSelf<UnityEngine.Renderer>(l);
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
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.isPartOfStaticBatch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldToLocalMatrix(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.worldToLocalMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localToWorldMatrix(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.localToWorldMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_castShadows(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.castShadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_castShadows(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.castShadows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_receiveShadows(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.receiveShadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_receiveShadows(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.receiveShadows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.sharedMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.sharedMaterial=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterials(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.sharedMaterials);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterials(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		UnityEngine.Material[] v;
		checkType(l,2,out v);
		o.sharedMaterials=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materials(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.materials);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_materials(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		UnityEngine.Material[] v;
		checkType(l,2,out v);
		o.materials=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapIndex(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.lightmapIndex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapIndex(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.lightmapIndex=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapTilingOffset(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.lightmapTilingOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapTilingOffset(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		UnityEngine.Vector4 v;
		checkType(l,2,out v);
		o.lightmapTilingOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVisible(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.isVisible);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLightProbes(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.useLightProbes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLightProbes(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useLightProbes=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightProbeAnchor(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.lightProbeAnchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightProbeAnchor(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.lightProbeAnchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerName(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.sortingLayerName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerName(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.String v;
		checkType(l,2,out v);
		o.sortingLayerName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerID(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.sortingLayerID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerID(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.sortingLayerID=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		pushValue(l,o.sortingOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		UnityEngine.Renderer o = checkSelf<UnityEngine.Renderer>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.sortingOrder=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Renderer");
		addMember(l,SetPropertyBlock, "SetPropertyBlock");
		addMember(l,GetPropertyBlock, "GetPropertyBlock");
		addMember(l,Render, "Render");
		addMember(l,get_isPartOfStaticBatch, "get_isPartOfStaticBatch");
		addMember(l,get_worldToLocalMatrix, "get_worldToLocalMatrix");
		addMember(l,get_localToWorldMatrix, "get_localToWorldMatrix");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		addMember(l,get_castShadows, "get_castShadows");
		addMember(l,set_castShadows, "set_castShadows");
		addMember(l,get_receiveShadows, "get_receiveShadows");
		addMember(l,set_receiveShadows, "set_receiveShadows");
		addMember(l,get_material, "get_material");
		addMember(l,set_material, "set_material");
		addMember(l,get_sharedMaterial, "get_sharedMaterial");
		addMember(l,set_sharedMaterial, "set_sharedMaterial");
		addMember(l,get_sharedMaterials, "get_sharedMaterials");
		addMember(l,set_sharedMaterials, "set_sharedMaterials");
		addMember(l,get_materials, "get_materials");
		addMember(l,set_materials, "set_materials");
		addMember(l,get_bounds, "get_bounds");
		addMember(l,get_lightmapIndex, "get_lightmapIndex");
		addMember(l,set_lightmapIndex, "set_lightmapIndex");
		addMember(l,get_lightmapTilingOffset, "get_lightmapTilingOffset");
		addMember(l,set_lightmapTilingOffset, "set_lightmapTilingOffset");
		addMember(l,get_isVisible, "get_isVisible");
		addMember(l,get_useLightProbes, "get_useLightProbes");
		addMember(l,set_useLightProbes, "set_useLightProbes");
		addMember(l,get_lightProbeAnchor, "get_lightProbeAnchor");
		addMember(l,set_lightProbeAnchor, "set_lightProbeAnchor");
		addMember(l,get_sortingLayerName, "get_sortingLayerName");
		addMember(l,set_sortingLayerName, "set_sortingLayerName");
		addMember(l,get_sortingLayerID, "get_sortingLayerID");
		addMember(l,set_sortingLayerID, "set_sortingLayerID");
		addMember(l,get_sortingOrder, "get_sortingOrder");
		addMember(l,set_sortingOrder, "set_sortingOrder");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Renderer),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
