using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CombineInstance : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		UnityEngine.CombineInstance o = checkSelf<UnityEngine.CombineInstance>(l);
		pushValue(l,o.mesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		UnityEngine.CombineInstance o = checkSelf<UnityEngine.CombineInstance>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.mesh=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_subMeshIndex(IntPtr l) {
		UnityEngine.CombineInstance o = checkSelf<UnityEngine.CombineInstance>(l);
		pushValue(l,o.subMeshIndex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_subMeshIndex(IntPtr l) {
		UnityEngine.CombineInstance o = checkSelf<UnityEngine.CombineInstance>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.subMeshIndex=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.CombineInstance o = checkSelf<UnityEngine.CombineInstance>(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_transform(IntPtr l) {
		UnityEngine.CombineInstance o = checkSelf<UnityEngine.CombineInstance>(l);
		UnityEngine.Matrix4x4 v;
		checkType(l,2,out v);
		o.transform=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CombineInstance");
		addMember(l,get_mesh, "get_mesh");
		addMember(l,set_mesh, "set_mesh");
		addMember(l,get_subMeshIndex, "get_subMeshIndex");
		addMember(l,set_subMeshIndex, "set_subMeshIndex");
		addMember(l,get_transform, "get_transform");
		addMember(l,set_transform, "set_transform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.CombineInstance));
		LuaDLL.lua_pop(l, 1);
	}
}
