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
            reg(l, Yield, "UnityEngine");
            reg(l, create, "coroutine");
        }

        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int create(IntPtr l)
        {
            LuaDLL.luaL_checktype(l, 1, LuaTypes.LUA_TFUNCTION);
            IntPtr nl = LuaDLL.lua_newthread(l);
            LuaDLL.lua_pushvalue(l, 1);  /* move function to top */
            LuaDLL.lua_xmove(l, nl, 1);  /* move function from L to NL */
            return 1;
        }


        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int Yield(IntPtr l)
        {
			try {
	           	object y = checkObj(l, 1);

	            Action act = () =>
	            {
	                LuaDLL.lua_resume(l, 0);
	            };

	            mb.StartCoroutine(yieldReturn(y,act));
	            return LuaDLL.lua_yield(l, 0);
			}
			catch(Exception e) {
				LuaDLL.luaL_error(l,e.ToString());
				return 0;
			}
        }

        static public IEnumerator yieldReturn(object y, Action act)
        {
            yield return y;
            act();
        }

    }
}
