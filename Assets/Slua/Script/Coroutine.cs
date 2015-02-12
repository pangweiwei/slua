using UnityEngine;
using System.Collections;
using LuaInterface;
using SLua;
using System;

namespace SLua
{
    public class LuaCoroutine : LuaObject
    {

        static MonoBehaviour mb;

        static public void reg(IntPtr l, MonoBehaviour m)
        {
            mb = m;
            LuaObject.reg(l, WaitForSeconds, "UnityEngine");
            LuaObject.reg(l, WaitForEndOfFrame, "UnityEngine");
            LuaObject.reg(l, WaitForFixedUpdate, "UnityEngine");
        }

        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int WaitForSeconds(IntPtr l)
        {
            float sec;
            LuaObject.checkType(l, 1, out sec);

            Action act = () =>
            {
                LuaDLL.lua_resume(l, 0);
            };

            mb.StartCoroutine(waitForSeconds(sec, act));
            return LuaDLL.lua_yield(l, 0);
        }

        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int WaitForEndOfFrame(IntPtr l)
        {
            Action act = () =>
            {
                LuaDLL.lua_resume(l, 0);
            };

            mb.StartCoroutine(waitForEndOfFrame(act));
            return LuaDLL.lua_yield(l, 0);
        }

        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int WaitForFixedUpdate(IntPtr l)
        {
            Action act = () =>
            {
                LuaDLL.lua_resume(l, 0);
            };

            mb.StartCoroutine(waitForFixedUpdate(act));
            return LuaDLL.lua_yield(l, 0);
        }


        static public IEnumerator waitForSeconds(float t, Action act)
        {
            yield return new WaitForSeconds(t);
            act();
        }

        static public IEnumerator waitForEndOfFrame(Action act)
        {
            yield return new WaitForEndOfFrame();
            act();
        }

        static public IEnumerator waitForFixedUpdate(Action act)
        {
            yield return new WaitForFixedUpdate();
            act();
        }
    }
}
