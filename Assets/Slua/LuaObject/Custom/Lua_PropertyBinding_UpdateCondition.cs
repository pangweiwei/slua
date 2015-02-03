using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PropertyBinding_UpdateCondition : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"PropertyBinding.UpdateCondition");
		addMember(l,0,"OnStart");
		addMember(l,1,"OnUpdate");
		addMember(l,2,"OnLateUpdate");
		addMember(l,3,"OnFixedUpdate");
		LuaDLL.lua_pop(l, 1);
	}
}
