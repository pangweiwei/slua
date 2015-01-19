using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Transform : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetParent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.SetParent(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Transform),typeof(System.Boolean))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetParent(a1,a2);
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
	static public int Translate(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Translate(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Space a2;
				checkEnum(l,3,out a2);
				self.Translate(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Translate(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Space a4;
				checkEnum(l,5,out a4);
				self.Translate(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				self.Translate(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Transform a4;
				checkType(l,5,out a4);
				self.Translate(a1,a2,a3,a4);
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
	static public int Rotate(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Rotate(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Space a2;
				checkEnum(l,3,out a2);
				self.Rotate(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Rotate(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Space a4;
				checkEnum(l,5,out a4);
				self.Rotate(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.Rotate(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.Space a3;
				checkEnum(l,4,out a3);
				self.Rotate(a1,a2,a3);
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
	static public int RotateAround(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.RotateAround(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.RotateAround(a1,a2);
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
	static public int LookAt(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.LookAt(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Transform),typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.LookAt(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.LookAt(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.LookAt(a1);
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
	static public int TransformDirection(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.TransformDirection(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 ret=self.TransformDirection(a1,a2,a3);
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
	static public int InverseTransformDirection(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.InverseTransformDirection(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 ret=self.InverseTransformDirection(a1,a2,a3);
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
	static public int TransformVector(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.TransformVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 ret=self.TransformVector(a1,a2,a3);
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
	static public int InverseTransformVector(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.InverseTransformVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 ret=self.InverseTransformVector(a1,a2,a3);
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
	static public int TransformPoint(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.TransformPoint(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 ret=self.TransformPoint(a1,a2,a3);
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
	static public int InverseTransformPoint(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.InverseTransformPoint(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 ret=self.InverseTransformPoint(a1,a2,a3);
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
	static public int DetachChildren(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			self.DetachChildren();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAsFirstSibling(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			self.SetAsFirstSibling();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAsLastSibling(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			self.SetAsLastSibling();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSiblingIndex(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetSiblingIndex(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSiblingIndex(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			System.Int32 ret=self.GetSiblingIndex();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Find(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Transform ret=self.Find(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsChildOf(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsChildOf(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindChild(IntPtr l) {
		try{
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Transform ret=self.FindChild(a1);
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
			UnityEngine.Transform self=checkSelf<UnityEngine.Transform>(l);
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
	static public int get_position(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localPosition(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.localPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localPosition(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eulerAngles(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.eulerAngles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eulerAngles(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.eulerAngles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localEulerAngles(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.localEulerAngles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localEulerAngles(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localEulerAngles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.right);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_right(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.right=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_up(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.up);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_up(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.up=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forward(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.forward);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forward(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.forward=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.rotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localRotation(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.localRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localRotation(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.localRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localScale(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.localScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localScale(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parent(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.parent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_parent(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.parent=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldToLocalMatrix(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.worldToLocalMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localToWorldMatrix(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.localToWorldMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.root);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childCount(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.childCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lossyScale(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.lossyScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasChanged(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		pushValue(l,o.hasChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasChanged(IntPtr l) {
		UnityEngine.Transform o = checkSelf<UnityEngine.Transform>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hasChanged=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Transform");
		addMember(l,SetParent, "SetParent");
		addMember(l,Translate, "Translate");
		addMember(l,Rotate, "Rotate");
		addMember(l,RotateAround, "RotateAround");
		addMember(l,LookAt, "LookAt");
		addMember(l,TransformDirection, "TransformDirection");
		addMember(l,InverseTransformDirection, "InverseTransformDirection");
		addMember(l,TransformVector, "TransformVector");
		addMember(l,InverseTransformVector, "InverseTransformVector");
		addMember(l,TransformPoint, "TransformPoint");
		addMember(l,InverseTransformPoint, "InverseTransformPoint");
		addMember(l,DetachChildren, "DetachChildren");
		addMember(l,SetAsFirstSibling, "SetAsFirstSibling");
		addMember(l,SetAsLastSibling, "SetAsLastSibling");
		addMember(l,SetSiblingIndex, "SetSiblingIndex");
		addMember(l,GetSiblingIndex, "GetSiblingIndex");
		addMember(l,Find, "Find");
		addMember(l,IsChildOf, "IsChildOf");
		addMember(l,FindChild, "FindChild");
		addMember(l,GetChild, "GetChild");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_localPosition, "get_localPosition");
		addMember(l,set_localPosition, "set_localPosition");
		addMember(l,get_eulerAngles, "get_eulerAngles");
		addMember(l,set_eulerAngles, "set_eulerAngles");
		addMember(l,get_localEulerAngles, "get_localEulerAngles");
		addMember(l,set_localEulerAngles, "set_localEulerAngles");
		addMember(l,get_right, "get_right");
		addMember(l,set_right, "set_right");
		addMember(l,get_up, "get_up");
		addMember(l,set_up, "set_up");
		addMember(l,get_forward, "get_forward");
		addMember(l,set_forward, "set_forward");
		addMember(l,get_rotation, "get_rotation");
		addMember(l,set_rotation, "set_rotation");
		addMember(l,get_localRotation, "get_localRotation");
		addMember(l,set_localRotation, "set_localRotation");
		addMember(l,get_localScale, "get_localScale");
		addMember(l,set_localScale, "set_localScale");
		addMember(l,get_parent, "get_parent");
		addMember(l,set_parent, "set_parent");
		addMember(l,get_worldToLocalMatrix, "get_worldToLocalMatrix");
		addMember(l,get_localToWorldMatrix, "get_localToWorldMatrix");
		addMember(l,get_root, "get_root");
		addMember(l,get_childCount, "get_childCount");
		addMember(l,get_lossyScale, "get_lossyScale");
		addMember(l,get_hasChanged, "get_hasChanged");
		addMember(l,set_hasChanged, "set_hasChanged");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Transform),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
