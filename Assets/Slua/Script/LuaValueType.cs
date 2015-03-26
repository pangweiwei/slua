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
using LuaInterface;
using UnityEngine;
using System.Collections.Generic;

namespace SLua
{
    class LuaValueType
    {
        public static int Vector3Create = 0;
        public static int Vector3Check = 0;

        static int getRefFunction(IntPtr l,string fn)
        {
            LuaDLL.lua_getglobal(l,fn);
            return LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
        }

        static void regValueType(IntPtr l,string type)
        {
            string mod = "valuetype." + type;
            LuaState.get(l).doFile(mod);
        }

        public static void reg(IntPtr l) {
            regValueType(l, "ValueType");
            regValueType(l, "Vector3");

            Vector3Create = getRefFunction(l, "Vector3Create");
            Vector3Check = getRefFunction(l, "Vector3Check");
        }
    }
}
