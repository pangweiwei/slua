using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ShaderVariantCollection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ShaderVariantCollection o;
		o=new UnityEngine.ShaderVariantCollection();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try{
			UnityEngine.ShaderVariantCollection self=(UnityEngine.ShaderVariantCollection)checkSelf(l);
			UnityEngine.ShaderVariantCollection.ShaderVariant a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Add(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove(IntPtr l) {
		try{
			UnityEngine.ShaderVariantCollection self=(UnityEngine.ShaderVariantCollection)checkSelf(l);
			UnityEngine.ShaderVariantCollection.ShaderVariant a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Remove(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try{
			UnityEngine.ShaderVariantCollection self=(UnityEngine.ShaderVariantCollection)checkSelf(l);
			UnityEngine.ShaderVariantCollection.ShaderVariant a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Contains(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.ShaderVariantCollection self=(UnityEngine.ShaderVariantCollection)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WarmUp(IntPtr l) {
		try{
			UnityEngine.ShaderVariantCollection self=(UnityEngine.ShaderVariantCollection)checkSelf(l);
			self.WarmUp();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shaderCount(IntPtr l) {
		UnityEngine.ShaderVariantCollection o = (UnityEngine.ShaderVariantCollection)checkSelf(l);
		pushValue(l,o.shaderCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_variantCount(IntPtr l) {
		UnityEngine.ShaderVariantCollection o = (UnityEngine.ShaderVariantCollection)checkSelf(l);
		pushValue(l,o.variantCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isWarmedUp(IntPtr l) {
		UnityEngine.ShaderVariantCollection o = (UnityEngine.ShaderVariantCollection)checkSelf(l);
		pushValue(l,o.isWarmedUp);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ShaderVariantCollection");
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,Contains);
		addMember(l,Clear);
		addMember(l,WarmUp);
		addMember(l,"shaderCount",get_shaderCount,null,true);
		addMember(l,"variantCount",get_variantCount,null,true);
		addMember(l,"isWarmedUp",get_isWarmedUp,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ShaderVariantCollection),typeof(UnityEngine.Object));
	}
}
