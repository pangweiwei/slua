using System.Collections;
namespace SLua
{
    using UnityEngine;

    // 没搞明白为什么放在 Plugins/Slua_Managed 目录下无法将扩展函数导入到 MonoBehaviour 类中
    // 所以先放在 SLua/Source 目录中
    public static class UnityExtension
    {
        public static void StartCoroutine(this MonoBehaviour mb, LuaFunction func)
        {
            mb.StartCoroutine(LuaCoroutine(func));
        }

        internal static IEnumerator LuaCoroutine(LuaFunction func)
        {
            var thread = new LuaThreadWrapper(func);
            while (true)
            {
                object obj;
                if (!thread.Resume(out obj))
                {
                    yield break;
                }
                yield return obj;
            }
        }
    }
}