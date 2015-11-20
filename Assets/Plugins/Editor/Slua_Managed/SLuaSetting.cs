﻿// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

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
		public string UnityEngineGeneratePath = "Assets/Plugins/SLua_Managed/Unity/";

		private static SLuaSetting _instance;
		public static SLuaSetting Instance{
			get{
				if(_instance == null){
					string path = "Assets/Slua/setting.asset";
#if UNITY_5
					_instance = AssetDatabase.LoadAssetAtPath<SLuaSetting>(path);
#else
					_instance = (SLuaSetting)AssetDatabase.LoadAssetAtPath(path,typeof(SLuaSetting));
#endif
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
