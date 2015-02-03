using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragObject o;
		o=new UIDragObject();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CancelMovement(IntPtr l) {
		try{
			UIDragObject self=(UIDragObject)checkSelf(l);
			self.CancelMovement();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CancelSpring(IntPtr l) {
		try{
			UIDragObject self=(UIDragObject)checkSelf(l);
			self.CancelSpring();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollMomentum(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushValue(l,o.scrollMomentum);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollMomentum(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.scrollMomentum=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_restrictWithinPanel(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushValue(l,o.restrictWithinPanel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_restrictWithinPanel(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.restrictWithinPanel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentRect(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushValue(l,o.contentRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contentRect(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		UIRect v;
		checkType(l,2,out v);
		o.contentRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragEffect(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushEnum(l,(int)o.dragEffect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragEffect(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		UIDragObject.DragEffect v;
		checkEnum(l,2,out v);
		o.dragEffect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_momentumAmount(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushValue(l,o.momentumAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_momentumAmount(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.momentumAmount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragMovement(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		pushValue(l,o.dragMovement);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragMovement(IntPtr l) {
		UIDragObject o = (UIDragObject)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.dragMovement=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragObject");
		addMember(l,CancelMovement);
		addMember(l,CancelSpring);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"scrollMomentum",get_scrollMomentum,set_scrollMomentum,true);
		addMember(l,"restrictWithinPanel",get_restrictWithinPanel,set_restrictWithinPanel,true);
		addMember(l,"contentRect",get_contentRect,set_contentRect,true);
		addMember(l,"dragEffect",get_dragEffect,set_dragEffect,true);
		addMember(l,"momentumAmount",get_momentumAmount,set_momentumAmount,true);
		addMember(l,"dragMovement",get_dragMovement,set_dragMovement,true);
		createTypeMetatable(l,constructor, typeof(UIDragObject),typeof(UnityEngine.MonoBehaviour));
	}
}
