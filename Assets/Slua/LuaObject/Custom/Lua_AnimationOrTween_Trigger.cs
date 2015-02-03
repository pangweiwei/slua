using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimationOrTween_Trigger : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"AnimationOrTween.Trigger");
		addMember(l,0,"OnClick");
		addMember(l,1,"OnHover");
		addMember(l,2,"OnPress");
		addMember(l,3,"OnHoverTrue");
		addMember(l,4,"OnHoverFalse");
		addMember(l,5,"OnPressTrue");
		addMember(l,6,"OnPressFalse");
		addMember(l,7,"OnActivate");
		addMember(l,8,"OnActivateTrue");
		addMember(l,9,"OnActivateFalse");
		addMember(l,10,"OnDoubleClick");
		addMember(l,11,"OnSelect");
		addMember(l,12,"OnSelectTrue");
		addMember(l,13,"OnSelectFalse");
		LuaDLL.lua_pop(l, 1);
	}
}
