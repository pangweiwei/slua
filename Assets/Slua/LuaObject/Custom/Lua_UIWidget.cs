using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIWidget : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIWidget o;
		o=new UIWidget();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDimensions(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetDimensions(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSides(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3[] ret=self.GetSides(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateFinalAlpha(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.CalculateFinalAlpha(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Invalidate(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Invalidate(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateCumulativeAlpha(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.CalculateCumulativeAlpha(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRect(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.SetRect(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResizeCollider(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.ResizeCollider();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateBounds(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UIWidget self=(UIWidget)checkSelf(l);
				UnityEngine.Bounds ret=self.CalculateBounds();
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UIWidget self=(UIWidget)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				UnityEngine.Bounds ret=self.CalculateBounds(a1);
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
	static public int SetDirty(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.SetDirty();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveFromPanel(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.RemoveFromPanel();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkAsChanged(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.MarkAsChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreatePanel(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			UIPanel ret=self.CreatePanel();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckLayer(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.CheckLayer();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParentHasChanged(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.ParentHasChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateVisibility(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.UpdateVisibility(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateTransform(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.UpdateTransform(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateGeometry(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.UpdateGeometry(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WriteToBuffers(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Color32> a3;
			checkType(l,4,out a3);
			BetterList<UnityEngine.Vector3> a4;
			checkType(l,5,out a4);
			BetterList<UnityEngine.Vector4> a5;
			checkType(l,6,out a5);
			self.WriteToBuffers(a1,a2,a3,a4,a5);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MakePixelPerfect(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			self.MakePixelPerfect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnFill(IntPtr l) {
		try{
			UIWidget self=(UIWidget)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Color32> a3;
			checkType(l,4,out a3);
			self.OnFill(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FullCompareFunc_s(IntPtr l) {
		try{
			UIWidget a1;
			checkType(l,1,out a1);
			UIWidget a2;
			checkType(l,2,out a2);
			System.Int32 ret=UIWidget.FullCompareFunc(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PanelCompareFunc_s(IntPtr l) {
		try{
			UIWidget a1;
			checkType(l,1,out a1);
			UIWidget a2;
			checkType(l,2,out a2);
			System.Int32 ret=UIWidget.PanelCompareFunc(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIWidget.OnDimensionsChanged v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onChange=v;
		else if(op==1) o.onChange+=v;
		else if(op==2) o.onChange-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onPostFill(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIWidget.OnPostFillCallback v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onPostFill=v;
		else if(op==1) o.onPostFill+=v;
		else if(op==2) o.onPostFill-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mOnRender(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIDrawCall.OnRenderCallback v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.mOnRender=v;
		else if(op==1) o.mOnRender+=v;
		else if(op==2) o.mOnRender-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoResizeBoxCollider(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.autoResizeBoxCollider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoResizeBoxCollider(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autoResizeBoxCollider=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideIfOffScreen(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.hideIfOffScreen);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideIfOffScreen(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hideIfOffScreen=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepAspectRatio(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushEnum(l,(int)o.keepAspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keepAspectRatio(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIWidget.AspectRatioSource v;
		checkEnum(l,2,out v);
		o.keepAspectRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectRatio(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.aspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectRatio(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.aspectRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hitCheck(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIWidget.HitCheck v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.hitCheck=v;
		else if(op==1) o.hitCheck+=v;
		else if(op==2) o.hitCheck-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_panel(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.panel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_panel(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIPanel v;
		checkType(l,2,out v);
		o.panel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_geometry(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.geometry);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_geometry(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIGeometry v;
		checkType(l,2,out v);
		o.geometry=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillGeometry(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.fillGeometry);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillGeometry(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.fillGeometry=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawCall(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.drawCall);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drawCall(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIDrawCall v;
		checkType(l,2,out v);
		o.drawCall=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRender(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onRender(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawRegion(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.drawRegion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drawRegion(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UnityEngine.Vector4 v;
		checkType(l,2,out v);
		o.drawRegion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotOffset(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.pivotOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.alpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.alpha=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVisible(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.isVisible);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasVertices(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.hasVertices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawPivot(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushEnum(l,(int)o.rawPivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rawPivot(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIWidget.Pivot v;
		checkEnum(l,2,out v);
		o.rawPivot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushEnum(l,(int)o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UIWidget.Pivot v;
		checkEnum(l,2,out v);
		o.pivot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.depth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_raycastDepth(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.raycastDepth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localCorners(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.localCorners);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localSize(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.localSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localCenter(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.localCenter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCorners(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.worldCorners);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCenter(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.worldCenter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawingDimensions(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.drawingDimensions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTexture(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.mainTexture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.shader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UnityEngine.Shader v;
		checkType(l,2,out v);
		o.shader=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBoxCollider(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.hasBoxCollider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showHandlesWithMoveTool(IntPtr l) {
		pushValue(l,UIWidget.showHandlesWithMoveTool);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showHandlesWithMoveTool(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UIWidget.showHandlesWithMoveTool=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showHandles(IntPtr l) {
		pushValue(l,UIWidget.showHandles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		pushValue(l,o.border);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_border(IntPtr l) {
		UIWidget o = (UIWidget)checkSelf(l);
		UnityEngine.Vector4 v;
		checkType(l,2,out v);
		o.border=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIWidget");
		addMember(l,SetDimensions);
		addMember(l,GetSides);
		addMember(l,CalculateFinalAlpha);
		addMember(l,Invalidate);
		addMember(l,CalculateCumulativeAlpha);
		addMember(l,SetRect);
		addMember(l,ResizeCollider);
		addMember(l,CalculateBounds);
		addMember(l,SetDirty);
		addMember(l,RemoveFromPanel);
		addMember(l,MarkAsChanged);
		addMember(l,CreatePanel);
		addMember(l,CheckLayer);
		addMember(l,ParentHasChanged);
		addMember(l,UpdateVisibility);
		addMember(l,UpdateTransform);
		addMember(l,UpdateGeometry);
		addMember(l,WriteToBuffers);
		addMember(l,MakePixelPerfect);
		addMember(l,OnFill);
		addMember(l,FullCompareFunc_s);
		addMember(l,PanelCompareFunc_s);
		addMember(l,"onChange",null,set_onChange,true);
		addMember(l,"onPostFill",null,set_onPostFill,true);
		addMember(l,"mOnRender",null,set_mOnRender,true);
		addMember(l,"autoResizeBoxCollider",get_autoResizeBoxCollider,set_autoResizeBoxCollider,true);
		addMember(l,"hideIfOffScreen",get_hideIfOffScreen,set_hideIfOffScreen,true);
		addMember(l,"keepAspectRatio",get_keepAspectRatio,set_keepAspectRatio,true);
		addMember(l,"aspectRatio",get_aspectRatio,set_aspectRatio,true);
		addMember(l,"hitCheck",null,set_hitCheck,true);
		addMember(l,"panel",get_panel,set_panel,true);
		addMember(l,"geometry",get_geometry,set_geometry,true);
		addMember(l,"fillGeometry",get_fillGeometry,set_fillGeometry,true);
		addMember(l,"drawCall",get_drawCall,set_drawCall,true);
		addMember(l,"onRender",get_onRender,set_onRender,true);
		addMember(l,"drawRegion",get_drawRegion,set_drawRegion,true);
		addMember(l,"pivotOffset",get_pivotOffset,null,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"isVisible",get_isVisible,null,true);
		addMember(l,"hasVertices",get_hasVertices,null,true);
		addMember(l,"rawPivot",get_rawPivot,set_rawPivot,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"raycastDepth",get_raycastDepth,null,true);
		addMember(l,"localCorners",get_localCorners,null,true);
		addMember(l,"localSize",get_localSize,null,true);
		addMember(l,"localCenter",get_localCenter,null,true);
		addMember(l,"worldCorners",get_worldCorners,null,true);
		addMember(l,"worldCenter",get_worldCenter,null,true);
		addMember(l,"drawingDimensions",get_drawingDimensions,null,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"hasBoxCollider",get_hasBoxCollider,null,true);
		addMember(l,"showHandlesWithMoveTool",get_showHandlesWithMoveTool,set_showHandlesWithMoveTool,false);
		addMember(l,"showHandles",get_showHandles,null,false);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"border",get_border,set_border,true);
		createTypeMetatable(l,constructor, typeof(UIWidget),typeof(UIRect));
	}
}
