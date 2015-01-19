using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GameObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.GameObject o;
		if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.GameObject(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1)){
			o=new UnityEngine.GameObject();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String),typeof(System.Type))){
			System.String a1;
			checkType(l,1,out a1);
			System.Type[] a2;
			checkType(l,2,out a2);
			o=new UnityEngine.GameObject(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SampleAnimation(IntPtr l) {
		try{
			UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
			UnityEngine.AnimationClip a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SampleAnimation(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreatePrimitive(IntPtr l) {
		try{
			UnityEngine.PrimitiveType a1;
			checkEnum(l,1,out a1);
			UnityEngine.GameObject ret=UnityEngine.GameObject.CreatePrimitive(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.GetComponent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
	static public int GetComponentInParent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponentsInParent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Type),typeof(System.Boolean))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
	static public int GetComponentsInChildren(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Type))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponentsInChildren(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Type),typeof(System.Boolean))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
	static public int SetActive(IntPtr l) {
		try{
			UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetActive(a1);
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
			UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
	static public int FindGameObjectWithTag(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject ret=UnityEngine.GameObject.FindGameObjectWithTag(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindWithTag(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject ret=UnityEngine.GameObject.FindWithTag(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindGameObjectsWithTag(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject[] ret=UnityEngine.GameObject.FindGameObjectsWithTag(a1);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.String),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
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
	static public int AddComponent(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.String))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.AddComponent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Type))){
				UnityEngine.GameObject self=checkSelf<UnityEngine.GameObject>(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.AddComponent(a1);
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
	static public int Find(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject ret=UnityEngine.GameObject.Find(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isStatic(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.isStatic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isStatic(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isStatic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody2D(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.rigidbody2D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_camera(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.camera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_light(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.light);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animation(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.animation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constantForce(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.constantForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderer(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.renderer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audio(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.audio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiText(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.guiText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_networkView(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.networkView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiTexture(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.guiTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider2D(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.collider2D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hingeJoint(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.hingeJoint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleEmitter(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.particleEmitter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleSystem(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.particleSystem);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layer(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.layer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layer(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.layer=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeSelf(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.activeSelf);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeInHierarchy(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.activeInHierarchy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tag(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.tag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tag(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		System.String v;
		checkType(l,2,out v);
		o.tag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.GameObject o = checkSelf<UnityEngine.GameObject>(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GameObject");
		addMember(l,SampleAnimation, "SampleAnimation");
		addMember(l,CreatePrimitive, "CreatePrimitive");
		addMember(l,GetComponent, "GetComponent");
		addMember(l,GetComponentInChildren, "GetComponentInChildren");
		addMember(l,GetComponentInParent, "GetComponentInParent");
		addMember(l,GetComponentsInParent, "GetComponentsInParent");
		addMember(l,GetComponents, "GetComponents");
		addMember(l,GetComponentsInChildren, "GetComponentsInChildren");
		addMember(l,SetActive, "SetActive");
		addMember(l,CompareTag, "CompareTag");
		addMember(l,FindGameObjectWithTag, "FindGameObjectWithTag");
		addMember(l,FindWithTag, "FindWithTag");
		addMember(l,FindGameObjectsWithTag, "FindGameObjectsWithTag");
		addMember(l,SendMessageUpwards, "SendMessageUpwards");
		addMember(l,SendMessage, "SendMessage");
		addMember(l,BroadcastMessage, "BroadcastMessage");
		addMember(l,AddComponent, "AddComponent");
		addMember(l,Find, "Find");
		addMember(l,get_isStatic, "get_isStatic");
		addMember(l,set_isStatic, "set_isStatic");
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
		addMember(l,get_layer, "get_layer");
		addMember(l,set_layer, "set_layer");
		addMember(l,get_activeSelf, "get_activeSelf");
		addMember(l,get_activeInHierarchy, "get_activeInHierarchy");
		addMember(l,get_tag, "get_tag");
		addMember(l,set_tag, "set_tag");
		addMember(l,get_gameObject, "get_gameObject");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.GameObject),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
