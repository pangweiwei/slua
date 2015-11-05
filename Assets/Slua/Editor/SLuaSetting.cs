using UnityEngine;
using System.Collections;
using UnityEditor;

namespace SLua{
	public enum EOL{
		Native,
		CRLF,
		CR,
		LF,
	}

	public class SLuaSetting : ScriptableObject {

		public EOL eol = EOL.Native;
		public bool exportExtensionMethod = true;

		private static SLuaSetting _instance;
		public static SLuaSetting Instance{
			get{
				if(_instance == null){
					string path = "Assets/Slua/setting.asset";
					_instance = AssetDatabase.LoadAssetAtPath<SLuaSetting>(path);
					if(_instance == null){
						_instance =  SLuaSetting.CreateInstance<SLuaSetting>();
						AssetDatabase.CreateAsset(_instance,path);
					}
				}
				return _instance;
			}
		}


		[MenuItem("SLua/Setting")]
		public static void Open(){
			Selection.activeObject = Instance;
		}


	}

}
