using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using LuaInterface;

public static class LuaSocketDLL{
	#if UNITY_IPHONE && !UNITY_EDITOR
		const string LUADLL = "__Internal";
	#else
		const string LUADLL = "libluasocket";
	#endif

	[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	public static extern int luaopen_socket_core(IntPtr luaState);
	
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
	public static extern int luaopen_mime_core(IntPtr luaState);
	
	public static void Reg(Dictionary<string, LuaCSFunction> preload)
	{
		preload["socket.core"] = luaopen_socket_core;
		preload["mime.core"] = luaopen_mime_core;
	}
}