using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Mesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Mesh o;
		if(matchType(l,1)){
			o=new UnityEngine.Mesh();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			if(matchType(l,2,typeof(bool))){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Clear(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				self.Clear();
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
	static public int RecalculateBounds(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateBounds();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RecalculateNormals(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateNormals();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Optimize(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.Optimize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTriangles(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32[] ret=self.GetTriangles(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTriangles(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetTriangles(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIndices(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32[] ret=self.GetIndices(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIndices(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkType(l,2,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetIndices(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTopology(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.MeshTopology ret=self.GetTopology(a1);
			pushEnum(l,(int)ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CombineMeshes(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.CombineInstance[]),typeof(bool),typeof(bool))){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				UnityEngine.CombineInstance[] a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.CombineMeshes(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.CombineInstance[]),typeof(bool))){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				UnityEngine.CombineInstance[] a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.CombineMeshes(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.CombineInstance[]))){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				UnityEngine.CombineInstance[] a1;
				checkType(l,2,out a1);
				self.CombineMeshes(a1);
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
	static public int MarkDynamic(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.MarkDynamic();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UploadMeshData(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.UploadMeshData(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBlendShapeName(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String ret=self.GetBlendShapeName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBlendShapeIndex(IntPtr l) {
		try{
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.GetBlendShapeIndex(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isReadable(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.isReadable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.vertices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertices(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Vector3[] v;
		checkType(l,2,out v);
		o.vertices=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normals(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.normals);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normals(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Vector3[] v;
		checkType(l,2,out v);
		o.normals=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tangents(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.tangents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tangents(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Vector4[] v;
		checkType(l,2,out v);
		o.tangents=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.uv);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Vector2[] v;
		checkType(l,2,out v);
		o.uv=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv2(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.uv2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv2(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Vector2[] v;
		checkType(l,2,out v);
		o.uv2=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv1(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.uv1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv1(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Vector2[] v;
		checkType(l,2,out v);
		o.uv1=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounds(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Bounds v;
		checkType(l,2,out v);
		o.bounds=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.colors);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Color[] v;
		checkType(l,2,out v);
		o.colors=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors32(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.colors32);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors32(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Color32[] v;
		checkType(l,2,out v);
		o.colors32=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangles(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.triangles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_triangles(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		System.Int32[] v;
		checkType(l,2,out v);
		o.triangles=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertexCount(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.vertexCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_subMeshCount(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.subMeshCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_subMeshCount(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.subMeshCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneWeights(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.boneWeights);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneWeights(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.BoneWeight[] v;
		checkType(l,2,out v);
		o.boneWeights=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bindposes(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.bindposes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bindposes(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		UnityEngine.Matrix4x4[] v;
		checkType(l,2,out v);
		o.bindposes=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendShapeCount(IntPtr l) {
		UnityEngine.Mesh o = (UnityEngine.Mesh)checkSelf(l);
		pushValue(l,o.blendShapeCount);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Mesh");
		addMember(l,Clear);
		addMember(l,RecalculateBounds);
		addMember(l,RecalculateNormals);
		addMember(l,Optimize);
		addMember(l,GetTriangles);
		addMember(l,SetTriangles);
		addMember(l,GetIndices);
		addMember(l,SetIndices);
		addMember(l,GetTopology);
		addMember(l,CombineMeshes);
		addMember(l,MarkDynamic);
		addMember(l,UploadMeshData);
		addMember(l,GetBlendShapeName);
		addMember(l,GetBlendShapeIndex);
		addMember(l,"isReadable",get_isReadable,null,true);
		addMember(l,"vertices",get_vertices,set_vertices,true);
		addMember(l,"normals",get_normals,set_normals,true);
		addMember(l,"tangents",get_tangents,set_tangents,true);
		addMember(l,"uv",get_uv,set_uv,true);
		addMember(l,"uv2",get_uv2,set_uv2,true);
		addMember(l,"uv1",get_uv1,set_uv1,true);
		addMember(l,"bounds",get_bounds,set_bounds,true);
		addMember(l,"colors",get_colors,set_colors,true);
		addMember(l,"colors32",get_colors32,set_colors32,true);
		addMember(l,"triangles",get_triangles,set_triangles,true);
		addMember(l,"vertexCount",get_vertexCount,null,true);
		addMember(l,"subMeshCount",get_subMeshCount,set_subMeshCount,true);
		addMember(l,"boneWeights",get_boneWeights,set_boneWeights,true);
		addMember(l,"bindposes",get_bindposes,set_bindposes,true);
		addMember(l,"blendShapeCount",get_blendShapeCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Mesh),typeof(UnityEngine.Object));
	}
}
