using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Transform : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetParent(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.SetParent(a1);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Translate(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Space a2;
				checkEnum(l,3,out a2);
				self.Translate(a1,a2);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Translate(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(float),typeof(float),typeof(float),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				self.Translate(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(float),typeof(float),typeof(float),typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Rotate(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Space a2;
				checkEnum(l,3,out a2);
				self.Rotate(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(float),typeof(float),typeof(float))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Rotate(a1,a2,a3);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.Rotate(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Space))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.RotateAround(a1,a2,a3);
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Transform))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.LookAt(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Transform),typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.LookAt(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.LookAt(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.TransformDirection(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.InverseTransformDirection(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.TransformVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.InverseTransformVector(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.TransformPoint(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 ret=self.InverseTransformPoint(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
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
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localPosition(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.localPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localPosition(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eulerAngles(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.eulerAngles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eulerAngles(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.eulerAngles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localEulerAngles(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.localEulerAngles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localEulerAngles(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localEulerAngles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.right);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_right(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.right=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_up(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.up);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_up(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.up=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forward(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.forward);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forward(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.forward=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.rotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localRotation(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.localRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localRotation(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.localRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localScale(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.localScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localScale(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parent(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.parent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_parent(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.parent=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldToLocalMatrix(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.worldToLocalMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localToWorldMatrix(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.localToWorldMatrix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.root);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childCount(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.childCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lossyScale(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.lossyScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasChanged(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		pushValue(l,o.hasChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasChanged(IntPtr l) {
		UnityEngine.Transform o = (UnityEngine.Transform)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.hasChanged=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Transform");
		addMember(l,SetParent);
		addMember(l,Translate);
		addMember(l,Rotate);
		addMember(l,RotateAround);
		addMember(l,LookAt);
		addMember(l,TransformDirection);
		addMember(l,InverseTransformDirection);
		addMember(l,TransformVector);
		addMember(l,InverseTransformVector);
		addMember(l,TransformPoint);
		addMember(l,InverseTransformPoint);
		addMember(l,DetachChildren);
		addMember(l,SetAsFirstSibling);
		addMember(l,SetAsLastSibling);
		addMember(l,SetSiblingIndex);
		addMember(l,GetSiblingIndex);
		addMember(l,Find);
		addMember(l,IsChildOf);
		addMember(l,FindChild);
		addMember(l,GetChild);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"localPosition",get_localPosition,set_localPosition,true);
		addMember(l,"eulerAngles",get_eulerAngles,set_eulerAngles,true);
		addMember(l,"localEulerAngles",get_localEulerAngles,set_localEulerAngles,true);
		addMember(l,"right",get_right,set_right,true);
		addMember(l,"up",get_up,set_up,true);
		addMember(l,"forward",get_forward,set_forward,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"localRotation",get_localRotation,set_localRotation,true);
		addMember(l,"localScale",get_localScale,set_localScale,true);
		addMember(l,"parent",get_parent,set_parent,true);
		addMember(l,"worldToLocalMatrix",get_worldToLocalMatrix,null,true);
		addMember(l,"localToWorldMatrix",get_localToWorldMatrix,null,true);
		addMember(l,"root",get_root,null,true);
		addMember(l,"childCount",get_childCount,null,true);
		addMember(l,"lossyScale",get_lossyScale,null,true);
		addMember(l,"hasChanged",get_hasChanged,set_hasChanged,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Transform),typeof(UnityEngine.Component));
	}
}
