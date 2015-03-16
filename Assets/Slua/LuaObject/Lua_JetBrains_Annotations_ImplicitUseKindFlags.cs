using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_JetBrains_Annotations_ImplicitUseKindFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"JetBrains.Annotations.ImplicitUseKindFlags");
		addMember(l,7,"Default");
		addMember(l,1,"Access");
		addMember(l,2,"Assign");
		addMember(l,4,"InstantiatedWithFixedConstructorSignature");
		addMember(l,8,"InstantiatedNoFixedConstructorSignature");
		LuaDLL.lua_pop(l, 1);
	}
}
