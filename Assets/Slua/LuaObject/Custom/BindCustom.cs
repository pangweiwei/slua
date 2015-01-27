using System;
namespace SLua {
	public partial class LuaObject {
		public static void BindCustom(IntPtr l) {
			Lua_HelloWorld.reg(l);
			Lua_Custom.reg(l);
		}
	}
}
