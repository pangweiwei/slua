using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;
using SLua;

namespace TT{
public class tttt  {

	[DllImport("asd", CallingConvention = CallingConvention.Cdecl),Lua3rdDLL.LualibReg("libluabpack")]
	public static extern int luaopen_libluabpack(IntPtr L);
}
}
