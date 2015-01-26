using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rigidbody2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Rigidbody2D o;
		if(matchType(l,1)){
			o=new UnityEngine.Rigidbody2D();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MovePosition(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
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
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			System.Single a1;
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
	static public int IsSleeping(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
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
	static public int IsAwake(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			System.Boolean ret=self.IsAwake();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Sleep(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			self.Sleep();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WakeUp(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			self.WakeUp();
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
			if(matchType(l,2,typeof(UnityEngine.Vector2),typeof(UnityEngine.ForceMode2D))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode2D a2;
				checkEnum(l,3,out a2);
				self.AddForce(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector2))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				self.AddForce(a1);
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
			if(matchType(l,2,typeof(UnityEngine.Vector2),typeof(UnityEngine.ForceMode2D))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode2D a2;
				checkEnum(l,3,out a2);
				self.AddRelativeForce(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector2))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				self.AddRelativeForce(a1);
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
			if(matchType(l,2,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.ForceMode2D))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				UnityEngine.ForceMode2D a3;
				checkEnum(l,4,out a3);
				self.AddForceAtPosition(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
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
	static public int AddTorque(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Single),typeof(UnityEngine.ForceMode2D))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode2D a2;
				checkEnum(l,3,out a2);
				self.AddTorque(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Single))){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.AddTorque(a1);
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
	static public int GetPoint(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativePoint(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetRelativePoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetVector(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetVector(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativeVector(IntPtr l) {
		try{
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetRelativeVector(a1);
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
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetPointVelocity(a1);
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
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetRelativePointVelocity(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.rotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mass(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.mass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mass(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.mass=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerOfMass(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.centerOfMass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerOfMass(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.centerOfMass=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCenterOfMass(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.worldCenterOfMass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertia(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.inertia);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertia(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.inertia=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drag(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.drag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drag(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.drag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularDrag(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.angularDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularDrag(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularDrag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityScale(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.gravityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravityScale(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.gravityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKinematic(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.isKinematic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isKinematic(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isKinematic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fixedAngle(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.fixedAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fixedAngle(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.fixedAngle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulated(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.simulated);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulated(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.simulated=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interpolation(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.interpolation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interpolation(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		UnityEngine.RigidbodyInterpolation2D v;
		checkEnum(l,2,out v);
		o.interpolation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepMode(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.sleepMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepMode(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		UnityEngine.RigidbodySleepMode2D v;
		checkEnum(l,2,out v);
		o.sleepMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionDetectionMode(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		pushValue(l,o.collisionDetectionMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionDetectionMode(IntPtr l) {
		UnityEngine.Rigidbody2D o = (UnityEngine.Rigidbody2D)checkSelf(l);
		UnityEngine.CollisionDetectionMode2D v;
		checkEnum(l,2,out v);
		o.collisionDetectionMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rigidbody2D");
		addMember(l,MovePosition);
		addMember(l,MoveRotation);
		addMember(l,IsSleeping);
		addMember(l,IsAwake);
		addMember(l,Sleep);
		addMember(l,WakeUp);
		addMember(l,AddForce);
		addMember(l,AddRelativeForce);
		addMember(l,AddForceAtPosition);
		addMember(l,AddTorque);
		addMember(l,GetPoint);
		addMember(l,GetRelativePoint);
		addMember(l,GetVector);
		addMember(l,GetRelativeVector);
		addMember(l,GetPointVelocity);
		addMember(l,GetRelativePointVelocity);
		addMember(l,"position",get_position,set_position);
		addMember(l,"rotation",get_rotation,set_rotation);
		addMember(l,"velocity",get_velocity,set_velocity);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity);
		addMember(l,"mass",get_mass,set_mass);
		addMember(l,"centerOfMass",get_centerOfMass,set_centerOfMass);
		addMember(l,"worldCenterOfMass",get_worldCenterOfMass,null);
		addMember(l,"inertia",get_inertia,set_inertia);
		addMember(l,"drag",get_drag,set_drag);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag);
		addMember(l,"gravityScale",get_gravityScale,set_gravityScale);
		addMember(l,"isKinematic",get_isKinematic,set_isKinematic);
		addMember(l,"fixedAngle",get_fixedAngle,set_fixedAngle);
		addMember(l,"simulated",get_simulated,set_simulated);
		addMember(l,"interpolation",get_interpolation,set_interpolation);
		addMember(l,"sleepMode",get_sleepMode,set_sleepMode);
		addMember(l,"collisionDetectionMode",get_collisionDetectionMode,set_collisionDetectionMode);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rigidbody2D),typeof(UnityEngine.Component));
	}
}
