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
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
//     public class LuaUnityEvent_Vector2 : LuaObject
//     {
// 
//         [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
//         static public int AddListener(IntPtr l)
//         {
//             try
//             {
//                 UnityEngine.Events.UnityEvent<Vector2> self = checkSelf<UnityEngine.Events.UnityEvent<Vector2>>(l);
//                 UnityEngine.Events.UnityAction<Vector2> a1;
//                 checkType(l, 2, out a1);
//                 self.AddListener(a1);
//                 return 0;
//             }
//             catch (Exception e)
//             {
//                 LuaDLL.luaL_error(l, e.ToString());
//                 return 0;
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
//         static public int RemoveListener(IntPtr l)
//         {
//             try
//             {
//                 UnityEngine.Events.UnityEvent<Vector2> self = checkSelf<UnityEngine.Events.UnityEvent<Vector2>>(l);
//                 UnityEngine.Events.UnityAction<Vector2> a1;
//                 checkType(l, 2, out a1);
//                 self.RemoveListener(a1);
//                 return 0;
//             }
//             catch (Exception e)
//             {
//                 LuaDLL.luaL_error(l, e.ToString());
//                 return 0;
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
//         static public int Invoke(IntPtr l)
//         {
//             try
//             {
//                 UnityEngine.Events.UnityEvent<Vector2> self = checkSelf<UnityEngine.Events.UnityEvent<Vector2>>(l);
//                 Vector2 o;
//                 checkType(l,2,out o);
//                 self.Invoke(o);
//                 return 0;
//             }
//             catch (Exception e)
//             {
//                 LuaDLL.luaL_error(l, e.ToString());
//                 return 0;
//             }
//         }
//         static public void reg(IntPtr l)
//         {
//             getTypeTable(l, typeof(LuaUnityEvent_Vector2).FullName);
//             addMember(l, AddListener, "AddListener");
//             addMember(l, RemoveListener, "RemoveListener");
//             addMember(l, Invoke, "Invoke");
//             createTypeMetatable(l, typeof(LuaUnityEvent_Vector2));
//             LuaDLL.lua_pop(l, 1);
//         }
// 
//         static bool checkType(IntPtr l,int p,out UnityEngine.Events.UnityAction<Vector2> ua) {
//             LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
//             int r = LuaDLL.luaS_checkcallback(l, p);
//             ua = (Vector2 v) =>
//             {
//                 int error = pushTry(l);
//                 LuaDLL.lua_getref(l, r);
//                 pushValue(l, v);
//                 if (LuaDLL.lua_pcall(l, 1, 0, error) != 0)
//                 {
//                     LuaDLL.lua_pop(l, 1); // pop error msg
//                 }
//                 LuaDLL.lua_pop(l, 1); // pop error function
//             };
//             return true;
//         }
//     }
}
