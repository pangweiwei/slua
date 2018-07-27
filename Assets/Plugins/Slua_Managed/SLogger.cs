

using System;

namespace com.tencent.pandora
{

    /// <summary>
    /// A bridge between UnityEngine.Debug.LogXXX and standalone.LogXXX
    /// </summary>
    internal class SLogger
    {
        public static void Log(string msg)
        {
#if !SLUA_STANDALONE
            Logger.Log(msg);
#else
            Console.WriteLine(msg);
#endif 
        }
        public static void LogError(string msg)
        {
#if !SLUA_STANDALONE
            Logger.LogError(msg);
#else
            Console.WriteLine(msg);
#endif
        }

		public static void LogWarning(string msg)
		{
#if !SLUA_STANDALONE
            Logger.LogWarning(msg);
#else
            Console.WriteLine(msg);
#endif
		}
    }


}