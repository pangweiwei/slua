using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUITools : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlaySound_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				UnityEngine.AudioSource ret=NGUITools.PlaySound(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.AudioSource ret=NGUITools.PlaySound(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.AudioSource ret=NGUITools.PlaySound(a1,a2,a3);
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
	static public int RandomRange_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 ret=NGUITools.RandomRange(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetHierarchy_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.String ret=NGUITools.GetHierarchy(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindCameraForLayer_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Camera ret=NGUITools.FindCameraForLayer(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddWidgetCollider_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				NGUITools.AddWidgetCollider(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				NGUITools.AddWidgetCollider(a1,a2);
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
	static public int UpdateWidgetCollider_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				NGUITools.UpdateWidgetCollider(a1);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(bool))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				NGUITools.UpdateWidgetCollider(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.BoxCollider),typeof(bool))){
				UnityEngine.BoxCollider a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				NGUITools.UpdateWidgetCollider(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.BoxCollider2D),typeof(bool))){
				UnityEngine.BoxCollider2D a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				NGUITools.UpdateWidgetCollider(a1,a2);
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
	static public int GetTypeName_s(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.String ret=NGUITools.GetTypeName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterUndo_s(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			NGUITools.RegisterUndo(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDirty_s(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			NGUITools.SetDirty(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddChild_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				UnityEngine.GameObject ret=NGUITools.AddChild(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(bool))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.GameObject ret=NGUITools.AddChild(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				UnityEngine.GameObject a2;
				checkType(l,2,out a2);
				UnityEngine.GameObject ret=NGUITools.AddChild(a1,a2);
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
	static public int CalculateRaycastDepth_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Int32 ret=NGUITools.CalculateRaycastDepth(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateNextDepth_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Int32 ret=NGUITools.CalculateNextDepth(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				System.Int32 ret=NGUITools.CalculateNextDepth(a1,a2);
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
	static public int AdjustDepth_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 ret=NGUITools.AdjustDepth(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BringForward_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			NGUITools.BringForward(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PushBack_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			NGUITools.PushBack(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NormalizeDepths_s(IntPtr l) {
		try{
			NGUITools.NormalizeDepths();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NormalizeWidgetDepths_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				NGUITools.NormalizeWidgetDepths();
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				NGUITools.NormalizeWidgetDepths(a1);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(UIWidget[]))){
				UIWidget[] a1;
				checkType(l,1,out a1);
				NGUITools.NormalizeWidgetDepths(a1);
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
	static public int NormalizePanelDepths_s(IntPtr l) {
		try{
			NGUITools.NormalizePanelDepths();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateUI_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Boolean a1;
				checkType(l,1,out a1);
				UIPanel ret=NGUITools.CreateUI(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UIPanel ret=NGUITools.CreateUI(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UIPanel ret=NGUITools.CreateUI(a1,a2,a3);
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
	static public int SetChildLayer_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			NGUITools.SetChildLayer(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddSprite_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UIAtlas a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UISprite ret=NGUITools.AddSprite(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRoot_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject ret=NGUITools.GetRoot(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Destroy_s(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			NGUITools.Destroy(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyImmediate_s(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			NGUITools.DestroyImmediate(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Broadcast_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				NGUITools.Broadcast(a1);
				return 0;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.Object a2;
				checkType(l,2,out a2);
				NGUITools.Broadcast(a1,a2);
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
	static public int IsChild_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			System.Boolean ret=NGUITools.IsChild(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetActive_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				NGUITools.SetActive(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				NGUITools.SetActive(a1,a2,a3);
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
	static public int SetActiveChildren_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			NGUITools.SetActiveChildren(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetActive_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Behaviour))){
				UnityEngine.Behaviour a1;
				checkType(l,1,out a1);
				System.Boolean ret=NGUITools.GetActive(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Boolean ret=NGUITools.GetActive(a1);
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
	static public int SetActiveSelf_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			NGUITools.SetActiveSelf(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayer_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			NGUITools.SetLayer(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Round_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 ret=NGUITools.Round(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MakePixelPerfect_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			NGUITools.MakePixelPerfect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Save_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkType(l,2,out a2);
			System.Boolean ret=NGUITools.Save(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Byte[] ret=NGUITools.Load(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyPMA_s(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color ret=NGUITools.ApplyPMA(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkParentAsChanged_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			NGUITools.MarkParentAsChanged(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSides_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3[] ret=NGUITools.GetSides(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Camera),typeof(float))){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3[] ret=NGUITools.GetSides(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Camera),typeof(UnityEngine.Transform))){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3[] ret=NGUITools.GetSides(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3[] ret=NGUITools.GetSides(a1,a2,a3);
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
	static public int GetWorldCorners_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3[] ret=NGUITools.GetWorldCorners(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Camera),typeof(float))){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3[] ret=NGUITools.GetWorldCorners(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Camera),typeof(UnityEngine.Transform))){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3[] ret=NGUITools.GetWorldCorners(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3[] ret=NGUITools.GetWorldCorners(a1,a2,a3);
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
	static public int GetFuncName_s(IntPtr l) {
		try{
			System.Object a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String ret=NGUITools.GetFuncName(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ImmediatelyCreateDrawCalls_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			NGUITools.ImmediatelyCreateDrawCalls(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_soundVolume(IntPtr l) {
		pushValue(l,NGUITools.soundVolume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_soundVolume(IntPtr l) {
		float v;
		checkType(l,2,out v);
		NGUITools.soundVolume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fileAccess(IntPtr l) {
		pushValue(l,NGUITools.fileAccess);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipboard(IntPtr l) {
		pushValue(l,NGUITools.clipboard);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipboard(IntPtr l) {
		string v;
		checkType(l,2,out v);
		NGUITools.clipboard=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenSize(IntPtr l) {
		pushValue(l,NGUITools.screenSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NGUITools");
		addMember(l,PlaySound_s);
		addMember(l,RandomRange_s);
		addMember(l,GetHierarchy_s);
		addMember(l,FindCameraForLayer_s);
		addMember(l,AddWidgetCollider_s);
		addMember(l,UpdateWidgetCollider_s);
		addMember(l,GetTypeName_s);
		addMember(l,RegisterUndo_s);
		addMember(l,SetDirty_s);
		addMember(l,AddChild_s);
		addMember(l,CalculateRaycastDepth_s);
		addMember(l,CalculateNextDepth_s);
		addMember(l,AdjustDepth_s);
		addMember(l,BringForward_s);
		addMember(l,PushBack_s);
		addMember(l,NormalizeDepths_s);
		addMember(l,NormalizeWidgetDepths_s);
		addMember(l,NormalizePanelDepths_s);
		addMember(l,CreateUI_s);
		addMember(l,SetChildLayer_s);
		addMember(l,AddSprite_s);
		addMember(l,GetRoot_s);
		addMember(l,Destroy_s);
		addMember(l,DestroyImmediate_s);
		addMember(l,Broadcast_s);
		addMember(l,IsChild_s);
		addMember(l,SetActive_s);
		addMember(l,SetActiveChildren_s);
		addMember(l,GetActive_s);
		addMember(l,SetActiveSelf_s);
		addMember(l,SetLayer_s);
		addMember(l,Round_s);
		addMember(l,MakePixelPerfect_s);
		addMember(l,Save_s);
		addMember(l,Load_s);
		addMember(l,ApplyPMA_s);
		addMember(l,MarkParentAsChanged_s);
		addMember(l,GetSides_s);
		addMember(l,GetWorldCorners_s);
		addMember(l,GetFuncName_s);
		addMember(l,ImmediatelyCreateDrawCalls_s);
		addMember(l,"soundVolume",get_soundVolume,set_soundVolume,false);
		addMember(l,"fileAccess",get_fileAccess,null,false);
		addMember(l,"clipboard",get_clipboard,set_clipboard,false);
		addMember(l,"screenSize",get_screenSize,null,false);
		createTypeMetatable(l,constructor, typeof(NGUITools));
	}
}
