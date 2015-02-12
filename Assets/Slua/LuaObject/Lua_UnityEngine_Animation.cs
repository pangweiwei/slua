﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Animation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Animation o;
		o=new UnityEngine.Animation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				self.Stop();
				return 0;
			}
			else if(argc==2){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Stop(a1);
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
	static public int Rewind(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Rewind(a1);
				return 0;
			}
			else if(argc==1){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				self.Rewind();
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
	static public int Sample(IntPtr l) {
		try{
			UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
			self.Sample();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPlaying(IntPtr l) {
		try{
			UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsPlaying(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.Boolean ret=self.Play();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.PlayMode))){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				UnityEngine.PlayMode a1;
				checkEnum(l,2,out a1);
				System.Boolean ret=self.Play(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.PlayMode a2;
				checkEnum(l,3,out a2);
				System.Boolean ret=self.Play(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.Play(a1);
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
	static public int CrossFade(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.PlayMode a3;
				checkEnum(l,4,out a3);
				self.CrossFade(a1,a2,a3);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.CrossFade(a1,a2);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.CrossFade(a1);
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
	static public int Blend(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Blend(a1,a2,a3);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.Blend(a1,a2);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Blend(a1);
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
	static public int CrossFadeQueued(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.QueueMode a3;
				checkEnum(l,4,out a3);
				UnityEngine.PlayMode a4;
				checkEnum(l,5,out a4);
				UnityEngine.AnimationState ret=self.CrossFadeQueued(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.QueueMode a3;
				checkEnum(l,4,out a3);
				UnityEngine.AnimationState ret=self.CrossFadeQueued(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.AnimationState ret=self.CrossFadeQueued(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.AnimationState ret=self.CrossFadeQueued(a1);
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
	static public int PlayQueued(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.QueueMode a2;
				checkEnum(l,3,out a2);
				UnityEngine.PlayMode a3;
				checkEnum(l,4,out a3);
				UnityEngine.AnimationState ret=self.PlayQueued(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.QueueMode a2;
				checkEnum(l,3,out a2);
				UnityEngine.AnimationState ret=self.PlayQueued(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.AnimationState ret=self.PlayQueued(a1);
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
	static public int AddClip(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				UnityEngine.AnimationClip a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				self.AddClip(a1,a2);
				return 0;
			}
			else if(argc==6){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				UnityEngine.AnimationClip a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Boolean a5;
				checkType(l,6,out a5);
				self.AddClip(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				UnityEngine.AnimationClip a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.AddClip(a1,a2,a3,a4);
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
	static public int RemoveClip(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.AnimationClip))){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				UnityEngine.AnimationClip a1;
				checkType(l,2,out a1);
				self.RemoveClip(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.RemoveClip(a1);
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
	static public int GetClipCount(IntPtr l) {
		try{
			UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
			System.Int32 ret=self.GetClipCount();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SyncLayer(IntPtr l) {
		try{
			UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SyncLayer(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetClip(IntPtr l) {
		try{
			UnityEngine.Animation self=(UnityEngine.Animation)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.AnimationClip ret=self.GetClip(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clip(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		UnityEngine.AnimationClip v;
		checkType(l,2,out v);
		o.clip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playAutomatically(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushValue(l,o.playAutomatically);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playAutomatically(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.playAutomatically=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushEnum(l,(int)o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		UnityEngine.WrapMode v;
		checkEnum(l,2,out v);
		o.wrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animatePhysics(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushValue(l,o.animatePhysics);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animatePhysics(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.animatePhysics=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingType(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushEnum(l,(int)o.cullingType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingType(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		UnityEngine.AnimationCullingType v;
		checkEnum(l,2,out v);
		o.cullingType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localBounds(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		pushValue(l,o.localBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localBounds(IntPtr l) {
		UnityEngine.Animation o = (UnityEngine.Animation)checkSelf(l);
		UnityEngine.Bounds v;
		checkType(l,2,out v);
		o.localBounds=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animation");
		addMember(l,Stop);
		addMember(l,Rewind);
		addMember(l,Sample);
		addMember(l,IsPlaying);
		addMember(l,Play);
		addMember(l,CrossFade);
		addMember(l,Blend);
		addMember(l,CrossFadeQueued);
		addMember(l,PlayQueued);
		addMember(l,AddClip);
		addMember(l,RemoveClip);
		addMember(l,GetClipCount);
		addMember(l,SyncLayer);
		addMember(l,GetClip);
		addMember(l,"clip",get_clip,set_clip,true);
		addMember(l,"playAutomatically",get_playAutomatically,set_playAutomatically,true);
		addMember(l,"wrapMode",get_wrapMode,set_wrapMode,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		addMember(l,"animatePhysics",get_animatePhysics,set_animatePhysics,true);
		addMember(l,"cullingType",get_cullingType,set_cullingType,true);
		addMember(l,"localBounds",get_localBounds,set_localBounds,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Animation),typeof(UnityEngine.Behaviour));
	}
}
