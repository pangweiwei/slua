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
using System.Collections;
using UnityEngine;
using LuaInterface;
using System.Reflection;

namespace SLua
{
    class LuaSvr
    {
        public LuaState luaState;
        static LuaSvrGameObject lgo;
        int errorReported = 0;
        

        public LuaSvr():this(null) {

        }

        public LuaSvr(string main)
        {
            luaState = new LuaState();

            LuaObject.init(luaState.L);
            bind("BindUnity");
            bind("BindUnityUI");
            bind("BindDll");
            bind("BindCustom");
            bind("BindExtend"); // if you want to extend slua, can implemented BindExtend function like BindCustom etc.

            GameObject go = new GameObject("LuaSvrProxy");
            lgo = go.AddComponent<LuaSvrGameObject>();
            GameObject.DontDestroyOnLoad(go);
            lgo.state = luaState;
            lgo.onUpdate = this.tick;

            LuaTimer.reg(luaState.L);
            LuaCoroutine.reg(luaState.L, lgo);
            Helper.reg(luaState.L);

            start(main);

            if (LuaDLL.lua_gettop(luaState.L) != errorReported)
            {
                Debug.LogError("Some function not remove temp value from lua stack. You should fix it.");
                errorReported = LuaDLL.lua_gettop(luaState.L);
            }
        }

        public void start(string main)
        {
            if (main != null)
            {
                luaState.doFile(main);
                LuaFunction func = (LuaFunction)luaState["main"];
                func.call();
            }
        }

        void bind(string name)
        {
            MethodInfo mi = typeof(LuaObject).GetMethod(name,BindingFlags.Public|BindingFlags.Static);
            if (mi != null) mi.Invoke(null, new object[] { luaState.L });
            else if(name=="BindUnity") Debug.LogError(string.Format("Miss {0}, click SLua=>Make to regenerate them",name));
        }

        void tick()
        {
            if (LuaDLL.lua_gettop(luaState.L) != errorReported)
            {
                Debug.LogError("Some function not remove temp value from lua stack. You should fix it.");
                errorReported = LuaDLL.lua_gettop(luaState.L);
            }

            luaState.checkRef();
            LuaTimer.tick(Time.deltaTime);
        }
       
    }
}
