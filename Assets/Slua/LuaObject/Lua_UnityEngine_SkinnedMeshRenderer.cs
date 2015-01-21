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
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
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
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
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
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
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
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		pushValue(l,o.bones);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bones(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		UnityEngine.Transform[] v;
		checkType(l,2,out v);
		o.bones=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootBone(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		pushValue(l,o.rootBone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootBone(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.rootBone=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_quality(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		pushValue(l,o.quality);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_quality(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		UnityEngine.SkinQuality v;
		checkEnum(l,2,out v);
		o.quality=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		pushValue(l,o.sharedMesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.sharedMesh=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateWhenOffscreen(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		pushValue(l,o.updateWhenOffscreen);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateWhenOffscreen(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updateWhenOffscreen=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localBounds(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		pushValue(l,o.localBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localBounds(IntPtr l) {
		UnityEngine.SkinnedMeshRenderer o = (UnityEngine.SkinnedMeshRenderer)checkSelf(l);
		UnityEngine.Bounds v;
		checkType(l,2,out v);
		o.localBounds=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkinnedMeshRenderer");
		addMember(l,BakeMesh);
		addMember(l,GetBlendShapeWeight);
		addMember(l,SetBlendShapeWeight);
		addMember(l,"bones",get_bones,set_bones);
		addMember(l,"rootBone",get_rootBone,set_rootBone);
		addMember(l,"quality",get_quality,set_quality);
		addMember(l,"sharedMesh",get_sharedMesh,set_sharedMesh);
		addMember(l,"updateWhenOffscreen",get_updateWhenOffscreen,set_updateWhenOffscreen);
		addMember(l,"localBounds",get_localBounds,set_localBounds);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SkinnedMeshRenderer),typeof(UnityEngine.Renderer));
	}
}
