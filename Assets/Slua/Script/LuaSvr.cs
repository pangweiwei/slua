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
using UnityEngine;
using LuaInterface;
using System.Reflection;

namespace SLua
{
    class LuaSvr
    {
        public LuaState luaState;

        public LuaSvr(string main)
        {
            luaState = new LuaState();

            LuaObject.init(luaState.L);
            bind("BindUnity");
            bind("BindUnityUI");
            bind("BindCustom");

            GameObject go = new GameObject("LuaSvrProxy");
            LuaSvrGameObject lgo = go.AddComponent<LuaSvrGameObject>();
            GameObject.DontDestroyOnLoad(go);
            lgo.state = luaState;
            lgo.onUpdate = this.tick;

            LuaTimer.init();
            LuaTimer.reg(luaState.L);

            luaState.doFile(main);

            LuaFunction func = (LuaFunction)luaState["main"];
            func.call();

            if (LuaDLL.lua_gettop(luaState.L) != 0)
                Debug.LogError("Some function not remove temp value from lua stack.");
        }

        void bind(string name)
        {
            MethodInfo mi = typeof(LuaObject).GetMethod(name,BindingFlags.Public|BindingFlags.Static);
            if (mi != null) mi.Invoke(null, new object[] { luaState.L });
            else if(name=="BindUnity") Debug.LogError(string.Format("Miss {0}, click SLua=>Make to regenerate them",name));
        }

        void tick()
        {
            luaState.checkRef();
            LuaTimer.tick(Time.deltaTime);
        }
    }
}
