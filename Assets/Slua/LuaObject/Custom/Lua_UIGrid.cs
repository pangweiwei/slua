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
	static public int get_sorted(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		pushValue(l,o.sorted);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sorted(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.sorted=v;
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
	static public int set_repositionNow(IntPtr l) {
		UIGrid o = (UIGrid)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.repositionNow=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIGrid");
		addMember(l,Reposition);
		addMember(l,"arrangement",get_arrangement,set_arrangement,true);
		addMember(l,"maxPerLine",get_maxPerLine,set_maxPerLine,true);
		addMember(l,"cellWidth",get_cellWidth,set_cellWidth,true);
		addMember(l,"cellHeight",get_cellHeight,set_cellHeight,true);
		addMember(l,"animateSmoothly",get_animateSmoothly,set_animateSmoothly,true);
		addMember(l,"sorted",get_sorted,set_sorted,true);
		addMember(l,"hideInactive",get_hideInactive,set_hideInactive,true);
		addMember(l,"keepWithinPanel",get_keepWithinPanel,set_keepWithinPanel,true);
		addMember(l,"onReposition",null,set_onReposition,true);
		addMember(l,"repositionNow",null,set_repositionNow,true);
		createTypeMetatable(l,constructor, typeof(UIGrid),typeof(UIWidgetContainer));
	}
}
