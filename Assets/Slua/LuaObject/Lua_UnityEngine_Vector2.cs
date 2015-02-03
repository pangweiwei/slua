using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Vector2 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Vector2 o;
		System.Single a1;
		checkType(l,2,out a1);
		System.Single a2;
		checkType(l,3,out a2);
		o=new UnityEngine.Vector2(a1,a2);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UnityEngine.Vector2 self=(UnityEngine.Vector2)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.Set(a1,a2);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Scale(IntPtr l) {
		try{
			UnityEngine.Vector2 self=(UnityEngine.Vector2)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.Scale(a1);
			setBack(l,self);
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
			UnityEngine.Vector2 self=(UnityEngine.Vector2)checkSelf(l);
			self.Normalize();
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SqrMagnitude(IntPtr l) {
		try{
			UnityEngine.Vector2 self=(UnityEngine.Vector2)checkSelf(l);
			System.Single ret=self.SqrMagnitude();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 ret=UnityEngine.Vector2.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTowards_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 ret=UnityEngine.Vector2.MoveTowards(a1,a2,a3);
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Vector2.Scale(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dot_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector2.Dot(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Angle_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector2.Angle(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Distance_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector2.Distance(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClampMagnitude_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Vector2.ClampMagnitude(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SqrMagnitude_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Vector2.SqrMagnitude(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Min_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Vector2.Min(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Max_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=UnityEngine.Vector2.Max(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SmoothDamp_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Vector2 ret=UnityEngine.Vector2.SmoothDamp(a1,a2,ref a3,a4,a5);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Vector2 ret=UnityEngine.Vector2.SmoothDamp(a1,a2,ref a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.Vector2 ret=UnityEngine.Vector2.SmoothDamp(a1,a2,ref a3,a4,a5,a6);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
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
	static public int op_Addition(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=a1+a2;
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=a1-a2;
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 ret=-a1;
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Vector2),typeof(float))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(UnityEngine.Vector2))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 ret=a1*a2;
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=a1/a2;
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
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
		pushValue(l,UnityEngine.Vector2.kEpsilon);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.x=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.y=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalized(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		pushValue(l,o.normalized);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magnitude(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		pushValue(l,o.magnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sqrMagnitude(IntPtr l) {
		UnityEngine.Vector2 o = (UnityEngine.Vector2)checkSelf(l);
		pushValue(l,o.sqrMagnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zero(IntPtr l) {
		pushValue(l,UnityEngine.Vector2.zero);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_one(IntPtr l) {
		pushValue(l,UnityEngine.Vector2.one);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_up(IntPtr l) {
		pushValue(l,UnityEngine.Vector2.up);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		pushValue(l,UnityEngine.Vector2.right);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Vector2");
		addMember(l,Set);
		addMember(l,Scale);
		addMember(l,Normalize);
		addMember(l,SqrMagnitude);
		addMember(l,Lerp_s);
		addMember(l,MoveTowards_s);
		addMember(l,Scale_s);
		addMember(l,Dot_s);
		addMember(l,Angle_s);
		addMember(l,Distance_s);
		addMember(l,ClampMagnitude_s);
		addMember(l,SqrMagnitude_s);
		addMember(l,Min_s);
		addMember(l,Max_s);
		addMember(l,SmoothDamp_s);
		addMember(l,op_Addition);
		addMember(l,op_Subtraction);
		addMember(l,op_UnaryNegation);
		addMember(l,op_Multiply);
		addMember(l,op_Division);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"kEpsilon",get_kEpsilon,null,false);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"normalized",get_normalized,null,true);
		addMember(l,"magnitude",get_magnitude,null,true);
		addMember(l,"sqrMagnitude",get_sqrMagnitude,null,true);
		addMember(l,"zero",get_zero,null,false);
		addMember(l,"one",get_one,null,false);
		addMember(l,"up",get_up,null,false);
		addMember(l,"right",get_right,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Vector2));
	}
}
