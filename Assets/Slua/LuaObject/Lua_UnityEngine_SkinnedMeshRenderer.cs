using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SkinnedMeshRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SkinnedMeshRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.SkinnedMeshRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BakeMesh(IntPtr l) {
		try{
			UnityEngine.SkinnedMeshRenderer self=checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			self.BakeMesh(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBlendShapeWeight(IntPtr l) {
		try{
			UnityEngine.SkinnedMeshRenderer self=checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetBlendShapeWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBlendShapeWeight(IntPtr l) {
		try{
			UnityEngine.SkinnedMeshRenderer self=checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetBlendShapeWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bones(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		pushValue(l,o.bones);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bones(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		UnityEngine.Transform[] v;
		checkType(l,2,out v);
		o.bones=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootBone(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		pushValue(l,o.rootBone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootBone(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.rootBone=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_quality(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		pushValue(l,o.quality);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_quality(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		UnityEngine.SkinQuality v;
		checkEnum(l,2,out v);
		o.quality=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		pushValue(l,o.sharedMesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.sharedMesh=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateWhenOffscreen(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		pushValue(l,o.updateWhenOffscreen);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateWhenOffscreen(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updateWhenOffscreen=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localBounds(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		pushValue(l,o.localBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localBounds(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = checkSelf<UnityEngine.SkinnedMeshRenderer>(l);
		UnityEngine.Bounds v;
		checkType(l,2,out v);
		o.localBounds=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkinnedMeshRenderer");
		addMember(l,BakeMesh, "BakeMesh");
		addMember(l,GetBlendShapeWeight, "GetBlendShapeWeight");
		addMember(l,SetBlendShapeWeight, "SetBlendShapeWeight");
		addMember(l,get_bones, "get_bones");
		addMember(l,set_bones, "set_bones");
		addMember(l,get_rootBone, "get_rootBone");
		addMember(l,set_rootBone, "set_rootBone");
		addMember(l,get_quality, "get_quality");
		addMember(l,set_quality, "set_quality");
		addMember(l,get_sharedMesh, "get_sharedMesh");
		addMember(l,set_sharedMesh, "set_sharedMesh");
		addMember(l,get_updateWhenOffscreen, "get_updateWhenOffscreen");
		addMember(l,set_updateWhenOffscreen, "set_updateWhenOffscreen");
		addMember(l,get_localBounds, "get_localBounds");
		addMember(l,set_localBounds, "set_localBounds");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SkinnedMeshRenderer),typeof(UnityEngine.Renderer));
		LuaDLL.lua_pop(l, 1);
	}
}
