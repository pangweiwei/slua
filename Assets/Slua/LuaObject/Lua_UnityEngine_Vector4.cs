using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Vector4 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Vector4 o;
		if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Vector4(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Vector4(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Vector4(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UnityEngine.Vector4 self=checkSelf<UnityEngine.Vector4>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.Set(a1,a2,a3,a4);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector4 ret=UnityEngine.Vector4.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTowards(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector4 ret=UnityEngine.Vector4.MoveTowards(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Scale(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector4),typeof(UnityEngine.Vector4))){
				UnityEngine.Vector4 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector4 ret=UnityEngine.Vector4.Scale(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector4))){
				UnityEngine.Vector4 self=checkSelf<UnityEngine.Vector4>(l);
				UnityEngine.Vector4 a1;
				checkType(l,2,out a1);
				self.Scale(a1);
				setBack(l,self);
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
	static public int Normalize(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector4))){
				UnityEngine.Vector4 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 ret=UnityEngine.Vector4.Normalize(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.Vector4 self=checkSelf<UnityEngine.Vector4>(l);
				self.Normalize();
				setBack(l,self);
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
	static public int Dot(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector4.Dot(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Project(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector4 ret=UnityEngine.Vector4.Project(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Distance(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector4.Distance(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Magnitude(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Vector4.Magnitude(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SqrMagnitude(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector4))){
				UnityEngine.Vector4 a1;
				checkType(l,1,out a1);
				System.Single ret=UnityEngine.Vector4.SqrMagnitude(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.Vector4 self=checkSelf<UnityEngine.Vector4>(l);
				System.Single ret=self.SqrMagnitude();
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
	static public int Min(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector4 ret=UnityEngine.Vector4.Min(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Max(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector4 ret=UnityEngine.Vector4.Max(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Addition(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector4 ret=a1+a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Subtraction(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector4 ret=a1-a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_UnaryNegation(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=-a1;
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
			if(matchType(l,1,typeof(UnityEngine.Vector4),typeof(System.Single))){
				UnityEngine.Vector4 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector4 ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Single),typeof(UnityEngine.Vector4))){
				System.Single a1;
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
	static public int op_Division(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector4 ret=a1/a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
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
			UnityEngine.Vector4 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
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
	static public int get_kEpsilon(IntPtr l) {
		pushValue(l,UnityEngine.Vector4.kEpsilon);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		System.Single v;
		checkType(l,2,out v);
		o.x=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		System.Single v;
		checkType(l,2,out v);
		o.y=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_z(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.z);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_z(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		System.Single v;
		checkType(l,2,out v);
		o.z=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_w(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.w);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_w(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		System.Single v;
		checkType(l,2,out v);
		o.w=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalized(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.normalized);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magnitude(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.magnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sqrMagnitude(IntPtr l) {
		UnityEngine.Vector4 o = checkSelf<UnityEngine.Vector4>(l);
		pushValue(l,o.sqrMagnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zero(IntPtr l) {
		pushValue(l,UnityEngine.Vector4.zero);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_one(IntPtr l) {
		pushValue(l,UnityEngine.Vector4.one);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Vector4");
		addMember(l,Set, "Set");
		addMember(l,Lerp, "Lerp");
		addMember(l,MoveTowards, "MoveTowards");
		addMember(l,Scale, "Scale");
		addMember(l,Normalize, "Normalize");
		addMember(l,Dot, "Dot");
		addMember(l,Project, "Project");
		addMember(l,Distance, "Distance");
		addMember(l,Magnitude, "Magnitude");
		addMember(l,SqrMagnitude, "SqrMagnitude");
		addMember(l,Min, "Min");
		addMember(l,Max, "Max");
		addMember(l,op_Addition, "op_Addition");
		addMember(l,op_Subtraction, "op_Subtraction");
		addMember(l,op_UnaryNegation, "op_UnaryNegation");
		addMember(l,op_Multiply, "op_Multiply");
		addMember(l,op_Division, "op_Division");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,get_kEpsilon, "get_kEpsilon");
		addMember(l,get_x, "get_x");
		addMember(l,set_x, "set_x");
		addMember(l,get_y, "get_y");
		addMember(l,set_y, "set_y");
		addMember(l,get_z, "get_z");
		addMember(l,set_z, "set_z");
		addMember(l,get_w, "get_w");
		addMember(l,set_w, "set_w");
		addMember(l,get_normalized, "get_normalized");
		addMember(l,get_magnitude, "get_magnitude");
		addMember(l,get_sqrMagnitude, "get_sqrMagnitude");
		addMember(l,get_zero, "get_zero");
		addMember(l,get_one, "get_one");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Vector4));
		LuaDLL.lua_pop(l, 1);
	}
}
