using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIGrid : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIGrid o;
		o=new UIGrid();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildList(IntPtr l) {
		try{
			UIGrid self=(UIGrid)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Transform> ret=self.GetChildList();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChild(IntPtr l) {
		try{
			UIGrid self=(UIGrid)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Transform ret=self.GetChild(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIndex(IntPtr l) {
		try{
			UIGrid self=(UIGrid)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.GetIndex(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddChild(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UIGrid self=(UIGrid)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.AddChild(a1);
				return 0;
			}
			else if(argc==3){
				UIGrid self=(UIGrid)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.AddChild(a1,a2);
				return 0;
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
	static public int RemoveChild(IntPtr l) {
		try{
			UIGrid self=(UIGrid)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.RemoveChild(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reposition(IntPtr l) {
		try{
			UIGrid self=(UIGrid)checkSelf(l);
			self.Reposition();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstrainWithinPanel(IntPtr l) {
		try{
			UIGrid self=(UIGrid)checkSelf(l);
			self.ConstrainWithinPanel();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortByName_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			System.Int32 ret=UIGrid.SortByName(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortHorizontal_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			System.Int32 ret=UIGrid.SortHorizontal(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortVertical_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			System.Int32 ret=UIGrid.SortVertical(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_arrangement(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushEnum(l,(int)o.arrangement);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_arrangement(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		UIGrid.Arrangement v;
		checkEnum(l,2,out v);
		o.arrangement=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sorting(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushEnum(l,(int)o.sorting);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sorting(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		UIGrid.Sorting v;
		checkEnum(l,2,out v);
		o.sorting=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushEnum(l,(int)o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		UIWidget.Pivot v;
		checkEnum(l,2,out v);
		o.pivot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxPerLine(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.maxPerLine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxPerLine(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxPerLine=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cellWidth(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.cellWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cellWidth(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.cellWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cellHeight(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.cellHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cellHeight(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.cellHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animateSmoothly(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.animateSmoothly);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animateSmoothly(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.animateSmoothly=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideInactive(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.hideInactive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideInactive(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hideInactive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepWithinPanel(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.keepWithinPanel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keepWithinPanel(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.keepWithinPanel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onReposition(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		UIGrid.OnReposition v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onReposition=v;
		else if(op==1) o.onReposition+=v;
		else if(op==2) o.onReposition-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCustomSort(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Comparison<UnityEngine.Transform> v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onCustomSort=v;
		else if(op==1) o.onCustomSort+=v;
		else if(op==2) o.onCustomSort-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_repositionNow(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.repositionNow=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIGrid");
		addMember(l,GetChildList);
		addMember(l,GetChild);
		addMember(l,GetIndex);
		addMember(l,AddChild);
		addMember(l,RemoveChild);
		addMember(l,Reposition);
		addMember(l,ConstrainWithinPanel);
		addMember(l,SortByName_s);
		addMember(l,SortHorizontal_s);
		addMember(l,SortVertical_s);
		addMember(l,"arrangement",get_arrangement,set_arrangement,true);
		addMember(l,"sorting",get_sorting,set_sorting,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"maxPerLine",get_maxPerLine,set_maxPerLine,true);
		addMember(l,"cellWidth",get_cellWidth,set_cellWidth,true);
		addMember(l,"cellHeight",get_cellHeight,set_cellHeight,true);
		addMember(l,"animateSmoothly",get_animateSmoothly,set_animateSmoothly,true);
		addMember(l,"hideInactive",get_hideInactive,set_hideInactive,true);
		addMember(l,"keepWithinPanel",get_keepWithinPanel,set_keepWithinPanel,true);
		addMember(l,"onReposition",null,set_onReposition,true);
		addMember(l,"onCustomSort",null,set_onCustomSort,true);
		addMember(l,"repositionNow",null,set_repositionNow,true);
		createTypeMetatable(l,constructor, typeof(UIGrid),typeof(UIWidgetContainer));
	}
}
