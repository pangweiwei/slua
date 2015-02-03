using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PropertyBinding_Direction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"PropertyBinding.Direction");
		addMember(l,0,"SourceUpdatesTarget");
		addMember(l,1,"TargetUpdatesSource");
		addMember(l,2,"BiDirectional");
		LuaDLL.lua_pop(l, 1);
	}
}
