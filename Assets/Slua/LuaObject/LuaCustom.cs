using System;
public static class LuaCustom {
	public static void Bind(IntPtr l) {
		Lua_HelloWorld.reg(l);
	}
}
