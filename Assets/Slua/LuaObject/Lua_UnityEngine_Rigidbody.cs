using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rigidbody : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Rigidbody o;
		if(matchType(l,1)){
			o=new UnityEngine.Rigidbody();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDensity(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.SetDensity(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddForce(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddForce(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddForce(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddForce(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddForce(a1,a2,a3,a4);
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
	static public int AddRelativeForce(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddRelativeForce(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddRelativeForce(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddRelativeForce(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddRelativeForce(a1,a2,a3,a4);
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
	static public int AddTorque(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddTorque(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddTorque(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddTorque(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddTorque(a1,a2,a3,a4);
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
	static public int AddRelativeTorque(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddRelativeTorque(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddRelativeTorque(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddRelativeTorque(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddRelativeTorque(a1,a2,a3,a4);
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
	static public int AddForceAtPosition(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.ForceMode a3;
				checkEnum(l,4,out a3);
				self.AddForceAtPosition(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.AddForceAtPosition(a1,a2);
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
	static public int AddExplosionForce(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single),typeof(UnityEngine.ForceMode))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.ForceMode a5;
				checkEnum(l,6,out a5);
				self.AddExplosionForce(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.AddExplosionForce(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddExplosionForce(a1,a2,a3);
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
	static public int ClosestPointOnBounds(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.ClosestPointOnBounds(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativePointVelocity(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.GetRelativePointVelocity(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPointVelocity(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.GetPointVelocity(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MovePosition(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.MovePosition(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveRotation(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Quaternion a1;
			checkType(l,2,out a1);
			self.MoveRotation(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Sleep(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			self.Sleep();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsSleeping(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			System.Boolean ret=self.IsSleeping();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WakeUp(IntPtr l) {
		try{
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			self.WakeUp();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SweepTest(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,4,out a3);
				System.Boolean ret=self.SweepTest(a1,out a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.RaycastHit a2;
				System.Boolean ret=self.SweepTest(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
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
	static public int SweepTestAll(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.RaycastHit[] ret=self.SweepTestAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.RaycastHit[] ret=self.SweepTestAll(a1);
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
	static public int get_velocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drag(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.drag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drag(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.drag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularDrag(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.angularDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularDrag(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularDrag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mass(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.mass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mass(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.mass=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGravity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.useGravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGravity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useGravity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKinematic(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.isKinematic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isKinematic(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isKinematic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_freezeRotation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.freezeRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_freezeRotation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.freezeRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraints(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.constraints);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraints(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.RigidbodyConstraints v;
		checkEnum(l,2,out v);
		o.constraints=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionDetectionMode(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.collisionDetectionMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionDetectionMode(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.CollisionDetectionMode v;
		checkEnum(l,2,out v);
		o.collisionDetectionMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerOfMass(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.centerOfMass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerOfMass(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.centerOfMass=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCenterOfMass(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.worldCenterOfMass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertiaTensorRotation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.inertiaTensorRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertiaTensorRotation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.inertiaTensorRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertiaTensor(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.inertiaTensor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertiaTensor(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.inertiaTensor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_detectCollisions(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.detectCollisions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_detectCollisions(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.detectCollisions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useConeFriction(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.useConeFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useConeFriction(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useConeFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.rotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interpolation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.interpolation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interpolation(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		UnityEngine.RigidbodyInterpolation v;
		checkEnum(l,2,out v);
		o.interpolation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_solverIterationCount(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.solverIterationCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_solverIterationCount(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.solverIterationCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.sleepVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.sleepVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepAngularVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.sleepAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepAngularVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.sleepAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxAngularVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		pushValue(l,o.maxAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxAngularVelocity(IntPtr l) {
		UnityEngine.Rigidbody o = (UnityEngine.Rigidbody)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxAngularVelocity=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rigidbody");
		addMember(l,SetDensity);
		addMember(l,AddForce);
		addMember(l,AddRelativeForce);
		addMember(l,AddTorque);
		addMember(l,AddRelativeTorque);
		addMember(l,AddForceAtPosition);
		addMember(l,AddExplosionForce);
		addMember(l,ClosestPointOnBounds);
		addMember(l,GetRelativePointVelocity);
		addMember(l,GetPointVelocity);
		addMember(l,MovePosition);
		addMember(l,MoveRotation);
		addMember(l,Sleep);
		addMember(l,IsSleeping);
		addMember(l,WakeUp);
		addMember(l,SweepTest);
		addMember(l,SweepTestAll);
		addMember(l,"velocity",get_velocity,set_velocity);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity);
		addMember(l,"drag",get_drag,set_drag);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag);
		addMember(l,"mass",get_mass,set_mass);
		addMember(l,"useGravity",get_useGravity,set_useGravity);
		addMember(l,"isKinematic",get_isKinematic,set_isKinematic);
		addMember(l,"freezeRotation",get_freezeRotation,set_freezeRotation);
		addMember(l,"constraints",get_constraints,set_constraints);
		addMember(l,"collisionDetectionMode",get_collisionDetectionMode,set_collisionDetectionMode);
		addMember(l,"centerOfMass",get_centerOfMass,set_centerOfMass);
		addMember(l,"worldCenterOfMass",get_worldCenterOfMass,null);
		addMember(l,"inertiaTensorRotation",get_inertiaTensorRotation,set_inertiaTensorRotation);
		addMember(l,"inertiaTensor",get_inertiaTensor,set_inertiaTensor);
		addMember(l,"detectCollisions",get_detectCollisions,set_detectCollisions);
		addMember(l,"useConeFriction",get_useConeFriction,set_useConeFriction);
		addMember(l,"position",get_position,set_position);
		addMember(l,"rotation",get_rotation,set_rotation);
		addMember(l,"interpolation",get_interpolation,set_interpolation);
		addMember(l,"solverIterationCount",get_solverIterationCount,set_solverIterationCount);
		addMember(l,"sleepVelocity",get_sleepVelocity,set_sleepVelocity);
		addMember(l,"sleepAngularVelocity",get_sleepAngularVelocity,set_sleepAngularVelocity);
		addMember(l,"maxAngularVelocity",get_maxAngularVelocity,set_maxAngularVelocity);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rigidbody),typeof(UnityEngine.Component));
	}
}
