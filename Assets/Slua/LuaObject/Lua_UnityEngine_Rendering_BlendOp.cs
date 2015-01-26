using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_BlendOp : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BlendOp");
		addMember(l,0,"Add");
		addMember(l,1,"Subtract");
		addMember(l,2,"ReverseSubtract");
		addMember(l,3,"Min");
		addMember(l,4,"Max");
		addMember(l,5,"LogicalClear");
		addMember(l,6,"LogicalSet");
		addMember(l,7,"LogicalCopy");
		addMember(l,8,"LogicalCopyInverted");
		addMember(l,9,"LogicalNoop");
		addMember(l,10,"LogicalInvert");
		addMember(l,11,"LogicalAnd");
		addMember(l,12,"LogicalNand");
		addMember(l,13,"LogicalOr");
		addMember(l,14,"LogicalNor");
		addMember(l,15,"LogicalXor");
		addMember(l,16,"LogicalEquivalence");
		addMember(l,17,"LogicalAndReverse");
		addMember(l,18,"LogicalAndInverted");
		addMember(l,19,"LogicalOrReverse");
		addMember(l,20,"LogicalOrInverted");
		LuaDLL.lua_pop(l, 1);
	}
}
