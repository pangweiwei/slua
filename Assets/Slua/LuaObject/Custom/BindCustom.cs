using System;
namespace SLua {
	public partial class LuaObject {
		public static void BindCustom(IntPtr l) {
			Lua_Custom.reg(l);
			Lua_Deleg.reg(l);
			Lua_HelloWorld.reg(l);
		}
	}
}
