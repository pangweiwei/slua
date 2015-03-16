using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ShaderVariantCollection_ShaderVariant : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o;
		UnityEngine.Shader a1;
		checkType(l,2,out a1);
		UnityEngine.Rendering.PassType a2;
		checkEnum(l,3,out a2);
		System.String[] a3;
		checkType(l,4,out a3);
		o=new UnityEngine.ShaderVariantCollection.ShaderVariant(a1,a2,a3);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o = (UnityEngine.ShaderVariantCollection.ShaderVariant)checkSelf(l);
		pushValue(l,o.shader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o = (UnityEngine.ShaderVariantCollection.ShaderVariant)checkSelf(l);
		UnityEngine.Shader v;
		checkType(l,2,out v);
		o.shader=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_passType(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o = (UnityEngine.ShaderVariantCollection.ShaderVariant)checkSelf(l);
		pushEnum(l,(int)o.passType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_passType(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o = (UnityEngine.ShaderVariantCollection.ShaderVariant)checkSelf(l);
		UnityEngine.Rendering.PassType v;
		checkEnum(l,2,out v);
		o.passType=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keywords(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o = (UnityEngine.ShaderVariantCollection.ShaderVariant)checkSelf(l);
		pushValue(l,o.keywords);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keywords(IntPtr l) {
		UnityEngine.ShaderVariantCollection.ShaderVariant o = (UnityEngine.ShaderVariantCollection.ShaderVariant)checkSelf(l);
		System.String[] v;
		checkType(l,2,out v);
		o.keywords=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ShaderVariantCollection.ShaderVariant");
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"passType",get_passType,set_passType,true);
		addMember(l,"keywords",get_keywords,set_keywords,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ShaderVariantCollection.ShaderVariant));
	}
}
