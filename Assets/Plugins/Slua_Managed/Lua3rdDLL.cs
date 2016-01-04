using System.Collections.Generic;
using LuaInterface;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using System.IO;

namespace SLua{
	public static class Lua3rdDLL{
		static Dictionary<string, LuaCSFunction> DLLRegFuncs = new Dictionary<string, LuaCSFunction>();
		
		static Lua3rdDLL(){
			// LuaSocketDLL.Reg(DLLRegFuncs);
		}
		
		public static void open(IntPtr L){
			var typenames = Lua3rdMeta.Instance.typesWithAttribtues;
			var assemblys = AppDomain.CurrentDomain.GetAssemblies();
			Assembly assembly = null;
			foreach(var ass in assemblys){
				if(ass.GetName().Name == "Assembly-CSharp"){
					assembly = ass;
					break;
				}
			}
			if(assembly != null){
				foreach(var typename in typenames){
					var type = assembly.GetType(typename);
					var methods = type.GetMethods(BindingFlags.Static|BindingFlags.Public);
					foreach(var method in methods){
						var attr = System.Attribute.GetCustomAttribute(method,typeof(LualibRegAttribute)) as LualibRegAttribute;
						if(attr != null){
							var csfunc = Delegate.CreateDelegate(typeof(LuaCSFunction),method) as LuaCSFunction;
							DLLRegFuncs.Add(attr.luaName,csfunc);
						}
					}
				}
			}
			
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


	public class Lua3rdMeta:ScriptableObject{
		/// <summary>
		///Cache class types here those contain 3rd dll attribute.
		/// </summary>
		public List<string> typesWithAttribtues = new List<string>();

		void OnEnable(){
			this.hideFlags = HideFlags.NotEditable;
		}
#if UNITY_EDITOR

		public void ReBuildTypes(){
			typesWithAttribtues.Clear();
			Assembly assembly = null;
			foreach(var assem in AppDomain.CurrentDomain.GetAssemblies()){
				if(assem.GetName().Name == "Assembly-CSharp"){
					assembly = assem;
					break;
				}
			}
			if(assembly != null){
				var types = assembly.GetExportedTypes();
				foreach(var type in types){
					var methods = type.GetMethods(BindingFlags.Public|BindingFlags.Static);
					foreach(var method in methods){
						if(method.IsDefined(typeof(Lua3rdDLL.LualibRegAttribute),false)){
							typesWithAttribtues.Add(type.FullName);
							break;
						}
					} 
				}
			}
		}

#endif
		private static Lua3rdMeta _instance;
		public static Lua3rdMeta Instance{
			get{
				if(_instance == null){
					_instance = Resources.Load<Lua3rdMeta>("lua3rdmeta");
				}
#if UNITY_EDITOR
				if(_instance == null){
					_instance = ScriptableObject.CreateInstance<Lua3rdMeta>();
					string path = "Assets/Slua/Meta/Resources";
					if(!Directory.Exists(path)){
						Directory.CreateDirectory(path);
					}
					UnityEditor.AssetDatabase.CreateAsset(_instance,Path.Combine(path,"lua3rdmeta.asset"));
				}

#endif
				return _instance;
			}
		}
	}

}