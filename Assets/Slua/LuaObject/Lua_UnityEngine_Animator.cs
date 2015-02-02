using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Animator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Animator o;
		if(matchType(l,1)){
			o=new UnityEngine.Animator();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFloat(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single ret=self.GetFloat(a1);
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
	static public int SetFloat(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(string),typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.SetFloat(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.SetFloat(a1,a2,a3,a4);
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
	static public int GetBool(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.GetBool(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.GetBool(a1);
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
	static public int SetBool(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string),typeof(bool))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetBool(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(bool))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetBool(a1,a2);
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
	static public int GetInteger(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.GetInteger(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.GetInteger(a1);
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
	static public int SetInteger(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInteger(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInteger(a1,a2);
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
	static public int SetTrigger(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SetTrigger(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.SetTrigger(a1);
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
	static public int ResetTrigger(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.ResetTrigger(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.ResetTrigger(a1);
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
	static public int IsParameterControlledByCurve(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.IsParameterControlledByCurve(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.IsParameterControlledByCurve(a1);
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
	static public int GetIKPosition(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			UnityEngine.Vector3 ret=self.GetIKPosition(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKPosition(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetIKPosition(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKRotation(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			UnityEngine.Quaternion ret=self.GetIKRotation(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKRotation(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,3,out a2);
			self.SetIKRotation(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKPositionWeight(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			System.Single ret=self.GetIKPositionWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKPositionWeight(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetIKPositionWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKRotationWeight(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			System.Single ret=self.GetIKRotationWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKRotationWeight(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetIKRotationWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLookAtPosition(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.SetLookAtPosition(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLookAtWeight(IntPtr l) {
		try{
			if(matchType(l,2,typeof(float),typeof(float),typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				self.SetLookAtWeight(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(matchType(l,2,typeof(float),typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.SetLookAtWeight(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.SetLookAtWeight(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetLookAtWeight(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.SetLookAtWeight(a1);
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
	static public int GetLayerName(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String ret=self.GetLayerName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayerWeight(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetLayerWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayerWeight(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetLayerWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCurrentAnimatorStateInfo(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo ret=self.GetCurrentAnimatorStateInfo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNextAnimatorStateInfo(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo ret=self.GetNextAnimatorStateInfo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAnimatorTransitionInfo(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorTransitionInfo ret=self.GetAnimatorTransitionInfo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCurrentAnimationClipState(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.AnimationInfo[] ret=self.GetCurrentAnimationClipState(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNextAnimationClipState(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.AnimationInfo[] ret=self.GetNextAnimationClipState(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsInTransition(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsInTransition(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MatchTarget(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.AvatarTarget),typeof(UnityEngine.MatchTargetWeightMask),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Quaternion a2;
				checkType(l,3,out a2);
				UnityEngine.AvatarTarget a3;
				checkEnum(l,4,out a3);
				UnityEngine.MatchTargetWeightMask a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				System.Single a6;
				checkType(l,7,out a6);
				self.MatchTarget(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.AvatarTarget),typeof(UnityEngine.MatchTargetWeightMask),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Quaternion a2;
				checkType(l,3,out a2);
				UnityEngine.AvatarTarget a3;
				checkEnum(l,4,out a3);
				UnityEngine.MatchTargetWeightMask a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				self.MatchTarget(a1,a2,a3,a4,a5);
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
	static public int InterruptMatchTarget(IntPtr l) {
		try{
			if(matchType(l,2,typeof(bool))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.InterruptMatchTarget(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				self.InterruptMatchTarget();
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
	static public int CrossFade(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string),typeof(float),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.CrossFade(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(string),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.CrossFade(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(string),typeof(float),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.CrossFade(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(float),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.CrossFade(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(float),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.CrossFade(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.CrossFade(a1,a2);
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
	static public int Play(IntPtr l) {
		try{
			if(matchType(l,2,typeof(string),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(string),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Play(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Play(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(int),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Play(a1);
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
	static public int SetTarget(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarTarget a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetTarget(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBoneTransform(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.HumanBodyBones a1;
			checkEnum(l,2,out a1);
			UnityEngine.Transform ret=self.GetBoneTransform(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartPlayback(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.StartPlayback();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopPlayback(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.StopPlayback();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartRecording(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.StartRecording(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopRecording(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.StopRecording();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Update(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebind(IntPtr l) {
		try{
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.Rebind();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StringToHash_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.Animator.StringToHash(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOptimizable(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.isOptimizable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHuman(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.isHuman);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasRootMotion(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.hasRootMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_humanScale(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.humanScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.deltaPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaRotation(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.deltaRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.rootPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.rootPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootRotation(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.rootRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootRotation(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.rootRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_applyRootMotion(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.applyRootMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_applyRootMotion(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.applyRootMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateMode(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushEnum(l,(int)o.updateMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateMode(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.AnimatorUpdateMode v;
		checkEnum(l,2,out v);
		o.updateMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasTransformHierarchy(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.hasTransformHierarchy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityWeight(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.gravityWeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bodyPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.bodyPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bodyPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.bodyPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bodyRotation(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.bodyRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bodyRotation(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.bodyRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stabilizeFeet(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.stabilizeFeet);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stabilizeFeet(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.stabilizeFeet=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layerCount(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.layerCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_feetPivotActive(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.feetPivotActive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_feetPivotActive(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.feetPivotActive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotWeight(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.pivotWeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.pivotPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMatchingTarget(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.isMatchingTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetPosition(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.targetPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRotation(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.targetRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMode(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushEnum(l,(int)o.cullingMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMode(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.AnimatorCullingMode v;
		checkEnum(l,2,out v);
		o.cullingMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playbackTime(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.playbackTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playbackTime(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.playbackTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_recorderStartTime(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.recorderStartTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_recorderStartTime(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.recorderStartTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_recorderStopTime(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.recorderStopTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_recorderStopTime(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.recorderStopTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runtimeAnimatorController(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.runtimeAnimatorController);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runtimeAnimatorController(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.RuntimeAnimatorController v;
		checkType(l,2,out v);
		o.runtimeAnimatorController=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_avatar(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.avatar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_avatar(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		UnityEngine.Avatar v;
		checkType(l,2,out v);
		o.avatar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layersAffectMassCenter(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.layersAffectMassCenter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layersAffectMassCenter(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.layersAffectMassCenter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_leftFeetBottomHeight(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.leftFeetBottomHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rightFeetBottomHeight(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.rightFeetBottomHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_logWarnings(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.logWarnings);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_logWarnings(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.logWarnings=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fireEvents(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		pushValue(l,o.fireEvents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fireEvents(IntPtr l) {
		UnityEngine.Animator o = (UnityEngine.Animator)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.fireEvents=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animator");
		addMember(l,GetFloat);
		addMember(l,SetFloat);
		addMember(l,GetBool);
		addMember(l,SetBool);
		addMember(l,GetInteger);
		addMember(l,SetInteger);
		addMember(l,SetTrigger);
		addMember(l,ResetTrigger);
		addMember(l,IsParameterControlledByCurve);
		addMember(l,GetIKPosition);
		addMember(l,SetIKPosition);
		addMember(l,GetIKRotation);
		addMember(l,SetIKRotation);
		addMember(l,GetIKPositionWeight);
		addMember(l,SetIKPositionWeight);
		addMember(l,GetIKRotationWeight);
		addMember(l,SetIKRotationWeight);
		addMember(l,SetLookAtPosition);
		addMember(l,SetLookAtWeight);
		addMember(l,GetLayerName);
		addMember(l,GetLayerWeight);
		addMember(l,SetLayerWeight);
		addMember(l,GetCurrentAnimatorStateInfo);
		addMember(l,GetNextAnimatorStateInfo);
		addMember(l,GetAnimatorTransitionInfo);
		addMember(l,GetCurrentAnimationClipState);
		addMember(l,GetNextAnimationClipState);
		addMember(l,IsInTransition);
		addMember(l,MatchTarget);
		addMember(l,InterruptMatchTarget);
		addMember(l,CrossFade);
		addMember(l,Play);
		addMember(l,SetTarget);
		addMember(l,GetBoneTransform);
		addMember(l,StartPlayback);
		addMember(l,StopPlayback);
		addMember(l,StartRecording);
		addMember(l,StopRecording);
		addMember(l,Update);
		addMember(l,Rebind);
		addMember(l,StringToHash_s);
		addMember(l,"isOptimizable",get_isOptimizable,null,true);
		addMember(l,"isHuman",get_isHuman,null,true);
		addMember(l,"hasRootMotion",get_hasRootMotion,null,true);
		addMember(l,"humanScale",get_humanScale,null,true);
		addMember(l,"deltaPosition",get_deltaPosition,null,true);
		addMember(l,"deltaRotation",get_deltaRotation,null,true);
		addMember(l,"rootPosition",get_rootPosition,set_rootPosition,true);
		addMember(l,"rootRotation",get_rootRotation,set_rootRotation,true);
		addMember(l,"applyRootMotion",get_applyRootMotion,set_applyRootMotion,true);
		addMember(l,"updateMode",get_updateMode,set_updateMode,true);
		addMember(l,"hasTransformHierarchy",get_hasTransformHierarchy,null,true);
		addMember(l,"gravityWeight",get_gravityWeight,null,true);
		addMember(l,"bodyPosition",get_bodyPosition,set_bodyPosition,true);
		addMember(l,"bodyRotation",get_bodyRotation,set_bodyRotation,true);
		addMember(l,"stabilizeFeet",get_stabilizeFeet,set_stabilizeFeet,true);
		addMember(l,"layerCount",get_layerCount,null,true);
		addMember(l,"feetPivotActive",get_feetPivotActive,set_feetPivotActive,true);
		addMember(l,"pivotWeight",get_pivotWeight,null,true);
		addMember(l,"pivotPosition",get_pivotPosition,null,true);
		addMember(l,"isMatchingTarget",get_isMatchingTarget,null,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"targetPosition",get_targetPosition,null,true);
		addMember(l,"targetRotation",get_targetRotation,null,true);
		addMember(l,"cullingMode",get_cullingMode,set_cullingMode,true);
		addMember(l,"playbackTime",get_playbackTime,set_playbackTime,true);
		addMember(l,"recorderStartTime",get_recorderStartTime,set_recorderStartTime,true);
		addMember(l,"recorderStopTime",get_recorderStopTime,set_recorderStopTime,true);
		addMember(l,"runtimeAnimatorController",get_runtimeAnimatorController,set_runtimeAnimatorController,true);
		addMember(l,"avatar",get_avatar,set_avatar,true);
		addMember(l,"layersAffectMassCenter",get_layersAffectMassCenter,set_layersAffectMassCenter,true);
		addMember(l,"leftFeetBottomHeight",get_leftFeetBottomHeight,null,true);
		addMember(l,"rightFeetBottomHeight",get_rightFeetBottomHeight,null,true);
		addMember(l,"logWarnings",get_logWarnings,set_logWarnings,true);
		addMember(l,"fireEvents",get_fireEvents,set_fireEvents,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Animator),typeof(UnityEngine.Behaviour));
	}
}
