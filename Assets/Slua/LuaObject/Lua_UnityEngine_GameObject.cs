using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GameObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.GameObject o;
		if(argc==2){
			System.String a1;
			checkType(l,2,out a1);
			o=new UnityEngine.GameObject(a1);
			pushObject(l,o);
			return 1;
		}
		else if(argc==1){
			o=new UnityEngine.GameObject();
			pushObject(l,o);
			return 1;
		}
		else if(argc==3){
			System.String a1;
			checkType(l,2,out a1);
			System.Type[] a2;
			checkType(l,3,out a2);
			o=new UnityEngine.GameObject(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SampleAnimation(IntPtr l) {
		try{
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int GetComponent(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.GetComponent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			UnityEngine.Component ret=self.GetComponentInChildren(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInParent(IntPtr l) {
		try{
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			UnityEngine.Component ret=self.GetComponentInParent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponents(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponents(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Collections.Generic.List<UnityEngine.Component> a2;
				checkType(l,3,out a2);
				self.GetComponents(a1,a2);
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
	static public int GetComponentsInChildren(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponentsInChildren(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int GetComponentsInParent(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				UnityEngine.Component[] ret=self.GetComponentsInParent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SetActive(IntPtr l) {
		try{
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessageUpwards(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				return 0;
			}
			else if(argc==2){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessage(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				return 0;
			}
			else if(argc==2){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.BroadcastMessage(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				return 0;
			}
			else if(argc==2){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Component ret=self.AddComponent(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int CreatePrimitive_s(IntPtr l) {
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
	static public int FindGameObjectWithTag_s(IntPtr l) {
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
	static public int FindWithTag_s(IntPtr l) {
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
	static public int FindGameObjectsWithTag_s(IntPtr l) {
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
	static public int Find_s(IntPtr l) {
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
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.isStatic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isStatic(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isStatic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody2D(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.rigidbody2D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_camera(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.camera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_light(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.light);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animation(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.animation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constantForce(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.constantForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderer(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.renderer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audio(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.audio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiText(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.guiText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiTexture(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.guiTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider2D(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.collider2D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hingeJoint(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.hingeJoint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleEmitter(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.particleEmitter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleSystem(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.particleSystem);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layer(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.layer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layer(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.layer=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeSelf(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.activeSelf);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeInHierarchy(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.activeInHierarchy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tag(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.tag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tag(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.tag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.GameObject o = (UnityEngine.GameObject)checkSelf(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GameObject");
		addMember(l,SampleAnimation);
		addMember(l,GetComponent);
		addMember(l,GetComponentInChildren);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponents);
		addMember(l,GetComponentsInChildren);
		addMember(l,GetComponentsInParent);
		addMember(l,SetActive);
		addMember(l,CompareTag);
		addMember(l,SendMessageUpwards);
		addMember(l,SendMessage);
		addMember(l,BroadcastMessage);
		addMember(l,AddComponent);
		addMember(l,CreatePrimitive_s);
		addMember(l,FindGameObjectWithTag_s);
		addMember(l,FindWithTag_s);
		addMember(l,FindGameObjectsWithTag_s);
		addMember(l,Find_s);
		addMember(l,"isStatic",get_isStatic,set_isStatic,true);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"rigidbody",get_rigidbody,null,true);
		addMember(l,"rigidbody2D",get_rigidbody2D,null,true);
		addMember(l,"camera",get_camera,null,true);
		addMember(l,"light",get_light,null,true);
		addMember(l,"animation",get_animation,null,true);
		addMember(l,"constantForce",get_constantForce,null,true);
		addMember(l,"renderer",get_renderer,null,true);
		addMember(l,"audio",get_audio,null,true);
		addMember(l,"guiText",get_guiText,null,true);
		addMember(l,"guiTexture",get_guiTexture,null,true);
		addMember(l,"collider",get_collider,null,true);
		addMember(l,"collider2D",get_collider2D,null,true);
		addMember(l,"hingeJoint",get_hingeJoint,null,true);
		addMember(l,"particleEmitter",get_particleEmitter,null,true);
		addMember(l,"particleSystem",get_particleSystem,null,true);
		addMember(l,"layer",get_layer,set_layer,true);
		addMember(l,"activeSelf",get_activeSelf,null,true);
		addMember(l,"activeInHierarchy",get_activeInHierarchy,null,true);
		addMember(l,"tag",get_tag,set_tag,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GameObject),typeof(UnityEngine.Object));
	}
}
