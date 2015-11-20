using System.Collections.Generic;
using LuaInterface;
using System;
using System.Linq;
using System.Reflection;

namespace SLua{
	public static class Lua3rdDLL{
		static Dictionary<string, LuaCSFunction> DLLRegFuncs = new Dictionary<string, LuaCSFunction>();
		
		static Lua3rdDLL(){
			// LuaSocketDLL.Reg(DLLRegFuncs);
		}
		
		public static void open(IntPtr L){
			
			var now = System.DateTime.Now;
			Assembly assembly = null;
			foreach(var assem in AppDomain.CurrentDomain.GetAssemblies()){
				if(assem.GetName().Name == "Assembly-CSharp"){
					assembly = assem;
				}
			}
			if(assembly != null){
				var csfunctions = assembly.GetExportedTypes()
					.SelectMany(x => x.GetMethods())
						.Where(y => y.GetCustomAttributes(typeof(LualibRegAttribute),false).Any())
						.ToList();
				foreach(MethodInfo func in csfunctions){
					var attr = System.Attribute.GetCustomAttribute(func,typeof(LualibRegAttribute)) as LualibRegAttribute;
					var csfunc = Delegate.CreateDelegate(typeof(LuaCSFunction),func) as LuaCSFunction;
					DLLRegFuncs.Add(attr.luaName,csfunc);
					//	UnityEngine.Debug.Log(attr.luaName);
				}
			}
			//	UnityEngine.Debug.Log("find all methods marked by [Lua3rdRegAttribute] cost :"+(System.DateTime.Now - now).TotalSeconds);
			
			if(DLLRegFuncs.Count == 0){
				return;
			}
			
			LuaDLL.lua_getglobal(L, "package");
			LuaDLL.lua_getfield(L, -1, "preload");
			foreach (KeyValuePair<string, LuaCSFunction> pair in DLLRegFuncs) {
				LuaDLL.lua_pushcfunction (L, pair.Value);
				LuaDLL.lua_setfield(L, -2, pair.Key);
			}
			
			LuaDLL.lua_settop(L, 0);
		}


		[AttributeUsage(AttributeTargets.Method)]
		public class LualibRegAttribute:System.Attribute{

			public string luaName;
			public LualibRegAttribute(string luaName){
				this.luaName = luaName;
			}
		}
	}
}