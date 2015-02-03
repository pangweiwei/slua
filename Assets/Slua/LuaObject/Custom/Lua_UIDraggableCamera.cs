using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDraggableCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDraggableCamera o;
		o=new UIDraggableCamera();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstrainToBounds(IntPtr l) {
		try{
			UIDraggableCamera self=(UIDraggableCamera)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.ConstrainToBounds(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Press(IntPtr l) {
		try{
			UIDraggableCamera self=(UIDraggableCamera)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Press(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Drag(IntPtr l) {
		try{
			UIDraggableCamera self=(UIDraggableCamera)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.Drag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Scroll(IntPtr l) {
		try{
			UIDraggableCamera self=(UIDraggableCamera)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Scroll(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootForBounds(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushValue(l,o.rootForBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootForBounds(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.rootForBounds=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scale(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushValue(l,o.scale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scale(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.scale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollWheelFactor(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushValue(l,o.scrollWheelFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollWheelFactor(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.scrollWheelFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragEffect(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushEnum(l,(int)o.dragEffect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragEffect(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		UIDragObject.DragEffect v;
		checkEnum(l,2,out v);
		o.dragEffect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_smoothDragStart(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushValue(l,o.smoothDragStart);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_smoothDragStart(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.smoothDragStart=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_momentumAmount(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushValue(l,o.momentumAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_momentumAmount(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.momentumAmount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentMomentum(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		pushValue(l,o.currentMomentum);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentMomentum(IntPtr l) {
		UIDraggableCamera o = (UIDraggableCamera)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.currentMomentum=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDraggableCamera");
		addMember(l,ConstrainToBounds);
		addMember(l,Press);
		addMember(l,Drag);
		addMember(l,Scroll);
		addMember(l,"rootForBounds",get_rootForBounds,set_rootForBounds,true);
		addMember(l,"scale",get_scale,set_scale,true);
		addMember(l,"scrollWheelFactor",get_scrollWheelFactor,set_scrollWheelFactor,true);
		addMember(l,"dragEffect",get_dragEffect,set_dragEffect,true);
		addMember(l,"smoothDragStart",get_smoothDragStart,set_smoothDragStart,true);
		addMember(l,"momentumAmount",get_momentumAmount,set_momentumAmount,true);
		addMember(l,"currentMomentum",get_currentMomentum,set_currentMomentum,true);
		createTypeMetatable(l,constructor, typeof(UIDraggableCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
