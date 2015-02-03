using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDrawCall : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDrawCall o;
		o=new UIDrawCall();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector3> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Vector4> a3;
			checkType(l,4,out a3);
			BetterList<UnityEngine.Vector2> a4;
			checkType(l,5,out a4);
			BetterList<UnityEngine.Color32> a5;
			checkType(l,6,out a5);
			self.Set(a1,a2,a3,a4,a5);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create_s(IntPtr l) {
		try{
			UIPanel a1;
			checkType(l,1,out a1);
			UnityEngine.Material a2;
			checkType(l,2,out a2);
			UnityEngine.Texture a3;
			checkType(l,3,out a3);
			UnityEngine.Shader a4;
			checkType(l,4,out a4);
			UIDrawCall ret=UIDrawCall.Create(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearAll_s(IntPtr l) {
		try{
			UIDrawCall.ClearAll();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReleaseAll_s(IntPtr l) {
		try{
			UIDrawCall.ReleaseAll();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReleaseInactive_s(IntPtr l) {
		try{
			UIDrawCall.ReleaseInactive();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Count_s(IntPtr l) {
		try{
			UIPanel a1;
			checkType(l,1,out a1);
			System.Int32 ret=UIDrawCall.Count(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Destroy_s(IntPtr l) {
		try{
			UIDrawCall a1;
			checkType(l,1,out a1);
			UIDrawCall.Destroy(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthStart(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.depthStart);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthStart(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.depthStart=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthEnd(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.depthEnd);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthEnd(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.depthEnd=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_manager(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.manager);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_manager(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UIPanel v;
		checkType(l,2,out v);
		o.manager=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_panel(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.panel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_panel(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UIPanel v;
		checkType(l,2,out v);
		o.panel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alwaysOnScreen(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.alwaysOnScreen);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alwaysOnScreen(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.alwaysOnScreen=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDirty(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.isDirty);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isDirty(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isDirty=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeList(IntPtr l) {
		pushValue(l,UIDrawCall.activeList);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inactiveList(IntPtr l) {
		pushValue(l,UIDrawCall.inactiveList);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderQueue(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.renderQueue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderQueue(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.renderQueue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalRenderQueue(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.finalRenderQueue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isActive(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.isActive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isActive(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isActive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.cachedTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseMaterial(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.baseMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseMaterial(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.baseMaterial=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicMaterial(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.dynamicMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTexture(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.mainTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.shader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UnityEngine.Shader v;
		checkType(l,2,out v);
		o.shader=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangles(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.triangles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isClipped(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.isClipped);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipping(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushEnum(l,(int)o.clipping);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipping(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UIDrawCall.Clipping v;
		checkEnum(l,2,out v);
		o.clipping=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipRange(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.clipRange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipRange(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UnityEngine.Vector4 v;
		checkType(l,2,out v);
		o.clipRange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipSoftness(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.clipSoftness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipSoftness(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.clipSoftness=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDrawCall");
		addMember(l,Set);
		addMember(l,Create_s);
		addMember(l,ClearAll_s);
		addMember(l,ReleaseAll_s);
		addMember(l,ReleaseInactive_s);
		addMember(l,Count_s);
		addMember(l,Destroy_s);
		addMember(l,"depthStart",get_depthStart,set_depthStart,true);
		addMember(l,"depthEnd",get_depthEnd,set_depthEnd,true);
		addMember(l,"manager",get_manager,set_manager,true);
		addMember(l,"panel",get_panel,set_panel,true);
		addMember(l,"alwaysOnScreen",get_alwaysOnScreen,set_alwaysOnScreen,true);
		addMember(l,"isDirty",get_isDirty,set_isDirty,true);
		addMember(l,"activeList",get_activeList,null,false);
		addMember(l,"inactiveList",get_inactiveList,null,false);
		addMember(l,"renderQueue",get_renderQueue,set_renderQueue,true);
		addMember(l,"finalRenderQueue",get_finalRenderQueue,null,true);
		addMember(l,"isActive",get_isActive,set_isActive,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"baseMaterial",get_baseMaterial,set_baseMaterial,true);
		addMember(l,"dynamicMaterial",get_dynamicMaterial,null,true);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"triangles",get_triangles,null,true);
		addMember(l,"isClipped",get_isClipped,null,true);
		addMember(l,"clipping",get_clipping,set_clipping,true);
		addMember(l,"clipRange",get_clipRange,set_clipRange,true);
		addMember(l,"clipSoftness",get_clipSoftness,set_clipSoftness,true);
		createTypeMetatable(l,constructor, typeof(UIDrawCall),typeof(UnityEngine.MonoBehaviour));
	}
}
