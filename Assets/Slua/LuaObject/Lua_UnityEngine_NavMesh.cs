using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.NavMesh o;
		if(matchType(l,1)){
			o=new UnityEngine.NavMesh();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.NavMeshHit a3;
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Boolean ret=UnityEngine.NavMesh.Raycast(a1,a2,out a3,a4);
			pushValue(l,ret);
			pushValue(l,a3);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculatePath(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.NavMeshPath a4;
			checkType(l,4,out a4);
			System.Boolean ret=UnityEngine.NavMesh.CalculatePath(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindClosestEdge(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.NavMeshHit a2;
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Boolean ret=UnityEngine.NavMesh.FindClosestEdge(a1,out a2,a3);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SamplePosition(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.NavMeshHit a2;
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Boolean ret=UnityEngine.NavMesh.SamplePosition(a1,out a2,a3,a4);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayerCost(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.NavMesh.SetLayerCost(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayerCost(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.NavMesh.GetLayerCost(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNavMeshLayerFromName(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.NavMesh.GetNavMeshLayerFromName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateTriangulation(IntPtr l) {
		try{
			UnityEngine.NavMeshTriangulation ret=UnityEngine.NavMesh.CalculateTriangulation();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddOffMeshLinks(IntPtr l) {
		try{
			UnityEngine.NavMesh.AddOffMeshLinks();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RestoreNavMesh(IntPtr l) {
		try{
			UnityEngine.NavMesh.RestoreNavMesh();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMesh");
		addMember(l,Raycast);
		addMember(l,CalculatePath);
		addMember(l,FindClosestEdge);
		addMember(l,SamplePosition);
		addMember(l,SetLayerCost);
		addMember(l,GetLayerCost);
		addMember(l,GetNavMeshLayerFromName);
		addMember(l,CalculateTriangulation);
		addMember(l,AddOffMeshLinks);
		addMember(l,RestoreNavMesh);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMesh),typeof(UnityEngine.Object));
	}
}
