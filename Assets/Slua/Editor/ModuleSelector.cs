using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;

namespace SLua
{


#if UNITY_2017_2_OR_NEWER
    public class ModuleSelector : EditorWindow
    {
        Vector2 scrollPosition = Vector2.zero;
        public Action<string[]> onExport;
        void OnGUI()
        {

            List<string> modules = new List<string>();

            scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(Screen.width), GUILayout.ExpandHeight(true));
            foreach (string module in LuaCodeGen.unityModule)
            {
                if (GUILayout.Toggle(true, module, GUILayout.ExpandWidth(false)))
                    modules.Add(module);
            }
            GUILayout.EndScrollView();
            if (GUILayout.Button("Export", GUILayout.ExpandWidth(true)))
            {
                if (onExport != null)
                    onExport(modules.ToArray());
            }
        }
    }
#endif

}

