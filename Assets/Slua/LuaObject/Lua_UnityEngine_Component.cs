using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Component : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Component o;
		if(matchType(l,1)){
			o=new UnityEngine.Component();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.GetComponent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.GetComponent(a1);
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
	static public int GetComponentInChildren(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.GetComponentInChildren(a1);
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
	static public int GetComponentsInChildren(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponentsInChildren(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Type),typeof(System.Boolean))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Component[] ret=self.GetComponentsInChildren(a1,a2);
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
	static public int GetComponentInParent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.GetComponentInParent(a1);
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
	static public int GetComponentsInParent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponentsInParent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Type),typeof(System.Boolean))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Component[] ret=self.GetComponentsInParent(a1,a2);
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
	static public int GetComponents(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponents(a1);
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
	static public int CompareTag(IntPtr l) {
		try{
			UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.CompareTag(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessageUpwards(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Object),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessageUpwards(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(System.Object))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
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
	static public int SendMessage(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Object),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessage(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(System.Object))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessage(a1,a2);
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
	static public int BroadcastMessage(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String),typeof(System.Object),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.BroadcastMessage(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(System.Object))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=checkSelf<UnityEngine.Component>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.BroadcastMessage(a1,a2);
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
	static public int get_transform(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody2D(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.rigidbody2D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_camera(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.camera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_light(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.light);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animation(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.animation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constantForce(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.constantForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderer(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.renderer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audio(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.audio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiText(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.guiText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_networkView(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.networkView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiTexture(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.guiTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider2D(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.collider2D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hingeJoint(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.hingeJoint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleEmitter(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.particleEmitter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleSystem(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.particleSystem);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tag(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		pushValue(l,o.tag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tag(IntPtr l) {
		UnityEngine.Component o = checkSelf<UnityEngine.Component>(l);
		System.String v;
		checkType(l,2,out v);
		o.tag=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Component");
		addMember(l,GetComponent, "GetComponent");
		addMember(l,GetComponentInChildren, "GetComponentInChildren");
		addMember(l,GetComponentsInChildren, "GetComponentsInChildren");
		addMember(l,GetComponentInParent, "GetComponentInParent");
		addMember(l,GetComponentsInParent, "GetComponentsInParent");
		addMember(l,GetComponents, "GetComponents");
		addMember(l,CompareTag, "CompareTag");
		addMember(l,SendMessageUpwards, "SendMessageUpwards");
		addMember(l,SendMessage, "SendMessage");
		addMember(l,BroadcastMessage, "BroadcastMessage");
		addMember(l,get_transform, "get_transform");
		addMember(l,get_rigidbody, "get_rigidbody");
		addMember(l,get_rigidbody2D, "get_rigidbody2D");
		addMember(l,get_camera, "get_camera");
		addMember(l,get_light, "get_light");
		addMember(l,get_animation, "get_animation");
		addMember(l,get_constantForce, "get_constantForce");
		addMember(l,get_renderer, "get_renderer");
		addMember(l,get_audio, "get_audio");
		addMember(l,get_guiText, "get_guiText");
		addMember(l,get_networkView, "get_networkView");
		addMember(l,get_guiTexture, "get_guiTexture");
		addMember(l,get_collider, "get_collider");
		addMember(l,get_collider2D, "get_collider2D");
		addMember(l,get_hingeJoint, "get_hingeJoint");
		addMember(l,get_particleEmitter, "get_particleEmitter");
		addMember(l,get_particleSystem, "get_particleSystem");
		addMember(l,get_gameObject, "get_gameObject");
		addMember(l,get_tag, "get_tag");
		addMember(l,set_tag, "set_tag");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Component),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
