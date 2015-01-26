using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Matrix4x4 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetColumn(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 ret=self.GetColumn(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRow(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 ret=self.GetRow(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColumn(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetColumn(a1,a2);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRow(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetRow(a1,a2);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiplyPoint(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.MultiplyPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiplyPoint3x4(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.MultiplyPoint3x4(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MultiplyVector(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.MultiplyVector(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTRS(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 self=(UnityEngine.Matrix4x4)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,3,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,4,out a3);
			self.SetTRS(a1,a2,a3);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Inverse_s(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 ret=UnityEngine.Matrix4x4.Inverse(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Transpose_s(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 ret=UnityEngine.Matrix4x4.Transpose(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Scale_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 ret=UnityEngine.Matrix4x4.Scale(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TRS_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4 ret=UnityEngine.Matrix4x4.TRS(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Ortho_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			UnityEngine.Matrix4x4 ret=UnityEngine.Matrix4x4.Ortho(a1,a2,a3,a4,a5,a6);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Perspective_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.Matrix4x4 ret=UnityEngine.Matrix4x4.Perspective(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Matrix4x4 a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkType(l,2,out a2);
				UnityEngine.Matrix4x4 ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Matrix4x4),typeof(UnityEngine.Vector4))){
				UnityEngine.Matrix4x4 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector4 ret=a1*a2;
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
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Matrix4x4 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m00(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m00);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m00(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m00=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m10(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m10);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m10(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m10=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m20(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m20);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m20(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m20=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m30(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m30);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m30(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m30=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m01(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m01);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m01(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m01=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m11(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m11);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m11(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m11=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m21(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m21);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m21(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m21=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m31(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m31);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m31(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m31=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m02(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m02);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m02(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m02=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m12(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m12);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m12(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m12=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m22(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m22);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m22(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m22=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m32(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m32);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m32(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m32=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m03(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m03);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m03(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m03=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m13(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m13);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m13(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m13=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m23(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m23);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m23(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m23=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m33(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.m33);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m33(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.m33=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inverse(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.inverse);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transpose(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.transpose);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isIdentity(IntPtr l) {
		UnityEngine.Matrix4x4 o = (UnityEngine.Matrix4x4)checkSelf(l);
		pushValue(l,o.isIdentity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zero(IntPtr l) {
		pushValue(l,UnityEngine.Matrix4x4.zero);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_identity(IntPtr l) {
		pushValue(l,UnityEngine.Matrix4x4.identity);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Matrix4x4");
		addMember(l,GetColumn);
		addMember(l,GetRow);
		addMember(l,SetColumn);
		addMember(l,SetRow);
		addMember(l,MultiplyPoint);
		addMember(l,MultiplyPoint3x4);
		addMember(l,MultiplyVector);
		addMember(l,SetTRS);
		addMember(l,Inverse_s);
		addMember(l,Transpose_s);
		addMember(l,Scale_s);
		addMember(l,TRS_s);
		addMember(l,Ortho_s);
		addMember(l,Perspective_s);
		addMember(l,op_Multiply);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"m00",get_m00,set_m00);
		addMember(l,"m10",get_m10,set_m10);
		addMember(l,"m20",get_m20,set_m20);
		addMember(l,"m30",get_m30,set_m30);
		addMember(l,"m01",get_m01,set_m01);
		addMember(l,"m11",get_m11,set_m11);
		addMember(l,"m21",get_m21,set_m21);
		addMember(l,"m31",get_m31,set_m31);
		addMember(l,"m02",get_m02,set_m02);
		addMember(l,"m12",get_m12,set_m12);
		addMember(l,"m22",get_m22,set_m22);
		addMember(l,"m32",get_m32,set_m32);
		addMember(l,"m03",get_m03,set_m03);
		addMember(l,"m13",get_m13,set_m13);
		addMember(l,"m23",get_m23,set_m23);
		addMember(l,"m33",get_m33,set_m33);
		addMember(l,"inverse",get_inverse,null);
		addMember(l,"transpose",get_transpose,null);
		addMember(l,"isIdentity",get_isIdentity,null);
		addMember(l,"zero",get_zero,null);
		addMember(l,"identity",get_identity,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Matrix4x4));
	}
}
