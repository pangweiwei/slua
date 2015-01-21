using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EdgeCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EdgeCollider2D o;
		if(matchType(l,1)){
			o=new UnityEngine.EdgeCollider2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try{
			UnityEngine.EdgeCollider2D self=(UnityEngine.EdgeCollider2D)checkSelf(l);
			self.Reset();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_edgeCount(IntPtr l) {
		UnityEngine.EdgeCollider2D o = (UnityEngine.EdgeCollider2D)checkSelf(l);
		pushValue(l,o.edgeCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointCount(IntPtr l) {
		UnityEngine.EdgeCollider2D o = (UnityEngine.EdgeCollider2D)checkSelf(l);
		pushValue(l,o.pointCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_points(IntPtr l) {
		UnityEngine.EdgeCollider2D o = (UnityEngine.EdgeCollider2D)checkSelf(l);
		pushValue(l,o.points);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_points(IntPtr l) {
		UnityEngine.EdgeCollider2D o = (UnityEngine.EdgeCollider2D)checkSelf(l);
		UnityEngine.Vector2[] v;
		checkType(l,2,out v);
		o.points=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EdgeCollider2D");
		addMember(l,Reset);
		addMember(l,"edgeCount",get_edgeCount,null);
		addMember(l,"pointCount",get_pointCount,null);
		addMember(l,"points",get_points,set_points);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EdgeCollider2D),typeof(UnityEngine.Collider2D));
	}
}
