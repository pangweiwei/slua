using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AnimatorUtility o;
		o=new UnityEngine.AnimatorUtility();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OptimizeTransformHierarchy_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.String[] a2;
			checkType(l,2,out a2);
			UnityEngine.AnimatorUtility.OptimizeTransformHierarchy(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeoptimizeTransformHierarchy_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.AnimatorUtility.DeoptimizeTransformHierarchy(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorUtility");
		addMember(l,OptimizeTransformHierarchy_s);
		addMember(l,DeoptimizeTransformHierarchy_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorUtility));
	}
}
