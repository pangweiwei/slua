using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICenterOnChild : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UICenterOnChild o;
		o=new UICenterOnChild();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Recenter(IntPtr l) {
		try{
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			self.Recenter();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CenterOn(IntPtr l) {
		try{
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			self.CenterOn(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_springStrength(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		pushValue(l,o.springStrength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_springStrength(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.springStrength=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextPageThreshold(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		pushValue(l,o.nextPageThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nextPageThreshold(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.nextPageThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		SpringPanel.OnFinished v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onFinished=v;
		else if(op==1) o.onFinished+=v;
		else if(op==2) o.onFinished-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCenter(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		UICenterOnChild.OnCenterCallback v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onCenter=v;
		else if(op==1) o.onCenter+=v;
		else if(op==2) o.onCenter-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centeredObject(IntPtr l) {
		UICenterOnChild o = (UICenterOnChild)checkSelf(l);
		pushValue(l,o.centeredObject);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICenterOnChild");
		addMember(l,Recenter);
		addMember(l,CenterOn);
		addMember(l,"springStrength",get_springStrength,set_springStrength,true);
		addMember(l,"nextPageThreshold",get_nextPageThreshold,set_nextPageThreshold,true);
		addMember(l,"onFinished",null,set_onFinished,true);
		addMember(l,"onCenter",null,set_onCenter,true);
		addMember(l,"centeredObject",get_centeredObject,null,true);
		createTypeMetatable(l,constructor, typeof(UICenterOnChild),typeof(UnityEngine.MonoBehaviour));
	}
}
