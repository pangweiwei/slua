using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshAgent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.NavMeshAgent o;
		if(matchType(l,1)){
			o=new UnityEngine.NavMeshAgent();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDestination(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.SetDestination(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateCurrentOffMeshLink(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.ActivateCurrentOffMeshLink(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompleteOffMeshLink(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.CompleteOffMeshLink();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Warp(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Warp(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Move(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.Move(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Stop(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
				self.Stop();
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
	static public int Resume(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.Resume();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetPath(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.ResetPath();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPath(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.NavMeshPath a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.SetPath(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindClosestEdge(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.NavMeshHit a1;
			System.Boolean ret=self.FindClosestEdge(out a1);
			pushValue(l,ret);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.NavMeshHit a2;
			System.Boolean ret=self.Raycast(a1,out a2);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculatePath(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.NavMeshPath a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.CalculatePath(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SamplePathPosition(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.NavMeshHit a3;
			System.Boolean ret=self.SamplePathPosition(a1,a2,out a3);
			pushValue(l,ret);
			pushValue(l,a3);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayerCost(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetLayerCost(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayerCost(IntPtr l) {
		try{
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetLayerCost(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_destination(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.destination);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_destination(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.destination=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stoppingDistance(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.stoppingDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stoppingDistance(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.stoppingDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextPosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.nextPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nextPosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.nextPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_steeringTarget(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.steeringTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_desiredVelocity(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.desiredVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_remainingDistance(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.remainingDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseOffset(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.baseOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseOffset(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.baseOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOnOffMeshLink(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.isOnOffMeshLink);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentOffMeshLinkData(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.currentOffMeshLinkData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextOffMeshLinkData(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.nextOffMeshLinkData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoTraverseOffMeshLink(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.autoTraverseOffMeshLink);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoTraverseOffMeshLink(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.autoTraverseOffMeshLink=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoBraking(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.autoBraking);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoBraking(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.autoBraking=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoRepath(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.autoRepath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoRepath(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.autoRepath=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPath(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.hasPath);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathPending(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.pathPending);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPathStale(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.isPathStale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathStatus(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.pathStatus);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathEndPosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.pathEndPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_path(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.path);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_path(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		UnityEngine.NavMeshPath v;
		checkType(l,2,out v);
		o.path=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_walkableMask(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.walkableMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_walkableMask(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.walkableMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularSpeed(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.angularSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularSpeed(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angularSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_acceleration(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.acceleration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updatePosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.updatePosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updatePosition(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.updatePosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateRotation(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.updateRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateRotation(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.updateRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_obstacleAvoidanceType(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.obstacleAvoidanceType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_obstacleAvoidanceType(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		UnityEngine.ObstacleAvoidanceType v;
		checkEnum(l,2,out v);
		o.obstacleAvoidanceType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_avoidancePriority(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		pushValue(l,o.avoidancePriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_avoidancePriority(IntPtr l) {
		UnityEngine.NavMeshAgent o = (UnityEngine.NavMeshAgent)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.avoidancePriority=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshAgent");
		addMember(l,SetDestination);
		addMember(l,ActivateCurrentOffMeshLink);
		addMember(l,CompleteOffMeshLink);
		addMember(l,Warp);
		addMember(l,Move);
		addMember(l,Stop);
		addMember(l,Resume);
		addMember(l,ResetPath);
		addMember(l,SetPath);
		addMember(l,FindClosestEdge);
		addMember(l,Raycast);
		addMember(l,CalculatePath);
		addMember(l,SamplePathPosition);
		addMember(l,SetLayerCost);
		addMember(l,GetLayerCost);
		addMember(l,"destination",get_destination,set_destination,true);
		addMember(l,"stoppingDistance",get_stoppingDistance,set_stoppingDistance,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"nextPosition",get_nextPosition,set_nextPosition,true);
		addMember(l,"steeringTarget",get_steeringTarget,null,true);
		addMember(l,"desiredVelocity",get_desiredVelocity,null,true);
		addMember(l,"remainingDistance",get_remainingDistance,null,true);
		addMember(l,"baseOffset",get_baseOffset,set_baseOffset,true);
		addMember(l,"isOnOffMeshLink",get_isOnOffMeshLink,null,true);
		addMember(l,"currentOffMeshLinkData",get_currentOffMeshLinkData,null,true);
		addMember(l,"nextOffMeshLinkData",get_nextOffMeshLinkData,null,true);
		addMember(l,"autoTraverseOffMeshLink",get_autoTraverseOffMeshLink,set_autoTraverseOffMeshLink,true);
		addMember(l,"autoBraking",get_autoBraking,set_autoBraking,true);
		addMember(l,"autoRepath",get_autoRepath,set_autoRepath,true);
		addMember(l,"hasPath",get_hasPath,null,true);
		addMember(l,"pathPending",get_pathPending,null,true);
		addMember(l,"isPathStale",get_isPathStale,null,true);
		addMember(l,"pathStatus",get_pathStatus,null,true);
		addMember(l,"pathEndPosition",get_pathEndPosition,null,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"walkableMask",get_walkableMask,set_walkableMask,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"angularSpeed",get_angularSpeed,set_angularSpeed,true);
		addMember(l,"acceleration",get_acceleration,set_acceleration,true);
		addMember(l,"updatePosition",get_updatePosition,set_updatePosition,true);
		addMember(l,"updateRotation",get_updateRotation,set_updateRotation,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"obstacleAvoidanceType",get_obstacleAvoidanceType,set_obstacleAvoidanceType,true);
		addMember(l,"avoidancePriority",get_avoidancePriority,set_avoidancePriority,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshAgent),typeof(UnityEngine.Behaviour));
	}
}
