

using System;

namespace SLua
{

    /// <summary>
    /// A bridge between UnityEngine.Debug.LogXXX and standalone.LogXXX
    /// </summary>
    public class Logger
    {
        private static UnityEngine.Object FindScriptByMsg(string msg)
        {
#if UNITY_EDITOR
            int idx = msg.IndexOf(":");
            if (idx < 0) return null;
            string filename = msg.Substring(0, idx);
            idx = filename.LastIndexOf("/");
            if (idx >= 0) filename = filename.Substring(idx + 1);
            string[] guids = UnityEditor.AssetDatabase.FindAssets(filename);
            filename = filename + ".txt";
            for (int i = 0; i < guids.Length; i++)
            {
                string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guids[i]);
                if(System.IO.Path.GetFileName(path).Equals(filename))
                {
                    return UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
                }
            }
#endif
            return null;
        }

        public static void Log(string msg)
        {
#if !SLUA_STANDALONE
            UnityEngine.Debug.Log(msg);
#else
            Console.WriteLine(msg);
#endif 
        }
        public static void LogError(string msg, bool hasStacktrace = false)
        {
#if !SLUA_STANDALONE
            if(hasStacktrace)
            {
                // Disable Stacktrace so we can jump
                var Type = UnityEngine.Application.GetStackTraceLogType(UnityEngine.LogType.Error);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, UnityEngine.StackTraceLogType.None);
                UnityEngine.Debug.LogError(msg, FindScriptByMsg(msg));
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, Type);
            }
            else
            	UnityEngine.Debug.LogError(msg);
#else
            Console.WriteLine(msg);
#endif
        }

		public static void LogWarning(string msg)
		{
#if !SLUA_STANDALONE
			UnityEngine.Debug.LogWarning(msg);
#else
            Console.WriteLine(msg);
#endif
		}
    }


}