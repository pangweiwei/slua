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
//             reg(l, WaitForSeconds, "UnityEngine");
//             reg(l, WaitForEndOfFrame, "UnityEngine");
//             reg(l, WaitForFixedUpdate, "UnityEngine");
            reg(l, YieldReturn, "UnityEngine");
        }

        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int YieldReturn(IntPtr l)
        {
            object y = checkObj(l, 1);

            Action act = () =>
            {
                LuaDLL.lua_resume(l, 0);
            };

            mb.StartCoroutine(yieldReturn(y,act));
            return LuaDLL.lua_yield(l, 0);
        }

        static public IEnumerator yieldReturn(object y, Action act)
        {
            yield return y;
            act();
        }


        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int WaitForSeconds(IntPtr l)
        {
            float sec;
            checkType(l, 1, out sec);

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
