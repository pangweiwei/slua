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
	static public int UpdateGeometry(IntPtr l) {
		try{
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.UpdateGeometry(a1);
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
	static public int get_widgetCount(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.widgetCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_widgetCount(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.widgetCount=v;
		return 0;
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
	static public int get_clipTexture(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.clipTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipTexture(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UnityEngine.Texture2D v;
		checkType(l,2,out v);
		o.clipTexture=v;
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
	static public int get_verts(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.verts);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verts(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		BetterList<UnityEngine.Vector3> v;
		checkType(l,2,out v);
		o.verts=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_norms(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.norms);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_norms(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		BetterList<UnityEngine.Vector3> v;
		checkType(l,2,out v);
		o.norms=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tans(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.tans);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tans(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		BetterList<UnityEngine.Vector4> v;
		checkType(l,2,out v);
		o.tans=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvs(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.uvs);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvs(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		BetterList<UnityEngine.Vector2> v;
		checkType(l,2,out v);
		o.uvs=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cols(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.cols);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cols(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		BetterList<UnityEngine.Color32> v;
		checkType(l,2,out v);
		o.cols=v;
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
	static public int set_onRender(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		UIDrawCall.OnRenderCallback v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onRender=v;
		else if(op==1) o.onRender+=v;
		else if(op==2) o.onRender-=v;
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
	static public int get_sortingOrder(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		pushValue(l,o.sortingOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		UIDrawCall o = (UIDrawCall)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.sortingOrder=v;
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDrawCall");
		addMember(l,UpdateGeometry);
		addMember(l,Create_s);
		addMember(l,ClearAll_s);
		addMember(l,ReleaseAll_s);
		addMember(l,ReleaseInactive_s);
		addMember(l,Count_s);
		addMember(l,Destroy_s);
		addMember(l,"widgetCount",get_widgetCount,set_widgetCount,true);
		addMember(l,"depthStart",get_depthStart,set_depthStart,true);
		addMember(l,"depthEnd",get_depthEnd,set_depthEnd,true);
		addMember(l,"manager",get_manager,set_manager,true);
		addMember(l,"panel",get_panel,set_panel,true);
		addMember(l,"clipTexture",get_clipTexture,set_clipTexture,true);
		addMember(l,"alwaysOnScreen",get_alwaysOnScreen,set_alwaysOnScreen,true);
		addMember(l,"verts",get_verts,set_verts,true);
		addMember(l,"norms",get_norms,set_norms,true);
		addMember(l,"tans",get_tans,set_tans,true);
		addMember(l,"uvs",get_uvs,set_uvs,true);
		addMember(l,"cols",get_cols,set_cols,true);
		addMember(l,"isDirty",get_isDirty,set_isDirty,true);
		addMember(l,"onRender",null,set_onRender,true);
		addMember(l,"activeList",get_activeList,null,false);
		addMember(l,"inactiveList",get_inactiveList,null,false);
		addMember(l,"renderQueue",get_renderQueue,set_renderQueue,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"finalRenderQueue",get_finalRenderQueue,null,true);
		addMember(l,"isActive",get_isActive,set_isActive,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"baseMaterial",get_baseMaterial,set_baseMaterial,true);
		addMember(l,"dynamicMaterial",get_dynamicMaterial,null,true);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"triangles",get_triangles,null,true);
		addMember(l,"isClipped",get_isClipped,null,true);
		createTypeMetatable(l,constructor, typeof(UIDrawCall),typeof(UnityEngine.MonoBehaviour));
	}
}
