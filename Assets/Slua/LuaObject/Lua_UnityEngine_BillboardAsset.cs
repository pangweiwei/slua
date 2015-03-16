using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BillboardAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.BillboardAsset o;
		o=new UnityEngine.BillboardAsset();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottom(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.bottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottom(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.bottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imageCount(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.imageCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertexCount(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.vertexCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indexCount(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.indexCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.BillboardAsset o = (UnityEngine.BillboardAsset)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BillboardAsset");
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"bottom",get_bottom,set_bottom,true);
		addMember(l,"imageCount",get_imageCount,null,true);
		addMember(l,"vertexCount",get_vertexCount,null,true);
		addMember(l,"indexCount",get_indexCount,null,true);
		addMember(l,"material",get_material,set_material,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.BillboardAsset),typeof(UnityEngine.Object));
	}
}
