// The MIT License (MIT)

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

using System;

namespace SLua
{

    /// <summary>
    /// A bridge between UnityEngine.Debug.LogXXX and standalone.LogXXX
    /// </summary>
    public class Logger
    {
        public enum Level
        {
            Debug,
            Warning,
            Error
        }
        public static Action<Level, string> LogAction;
#if !SLUA_STANDALONE
        private static UnityEngine.Object FindScriptByMsg(string msg)
        {
#if UNITY_EDITOR
            string[] lines = msg.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 2; i < lines.Length; i++)
            {
                int idx = lines[i].IndexOf(":");
                if (idx < 0) continue;
                string filename = lines[i].Substring(0, idx);
                idx = filename.LastIndexOf("/");
                if (idx >= 0) filename = filename.Substring(idx + 1);
                filename = filename.Trim();
                string[] guids = UnityEditor.AssetDatabase.FindAssets(filename);
                filename = filename + ".txt";
                for (int j = 0; j < guids.Length; j++)
                {
                    string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guids[j]);
                    if (System.IO.Path.GetFileName(path).Equals(filename))
                    {
                        return UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
                    }
                }
            }
#endif
            return null;
        }
#endif

        public static void Log(string msg, bool hasStacktrace = false)
        {
            if (LogAction != null)
            {
                LogAction(Level.Debug, msg);
                return;
            }

#if !SLUA_STANDALONE
            var Type = UnityEngine.Application.GetStackTraceLogType(UnityEngine.LogType.Log);
            UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Log, UnityEngine.StackTraceLogType.None);
            UnityEngine.Debug.Log(msg, hasStacktrace ? FindScriptByMsg(msg) : null);
            UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Log, Type);
#else
            Console.WriteLine(msg);
#endif 
        }
        public static void LogError(string msg, bool hasStacktrace = false)
        {
            if (LogAction != null)
            {
                LogAction(Level.Error, msg);
                return;
            }

#if !SLUA_STANDALONE
            var Type = UnityEngine.Application.GetStackTraceLogType(UnityEngine.LogType.Error);
            UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, UnityEngine.StackTraceLogType.None);
            UnityEngine.Debug.LogError(msg, hasStacktrace ? FindScriptByMsg(msg) : null);
            UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, Type);
#else
            Console.WriteLine(msg);
#endif
        }

		public static void LogWarning(string msg)
		{
            if (LogAction != null)
            {
                LogAction(Level.Warning, msg);
                return;
            }

#if !SLUA_STANDALONE
			UnityEngine.Debug.LogWarning(msg);
#else
            Console.WriteLine(msg);
#endif
		}
    }


}