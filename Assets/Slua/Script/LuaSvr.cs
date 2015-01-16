using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

namespace SLua
{

    class LuaSvr : MonoBehaviour
    {
        LuaState luaState;

        void Start()
        {
            luaState = new LuaState();

            LuaObject.init(luaState.handle);
            LuaUnity.Bind(luaState.handle);
            LuaUnityUI.Bind(luaState.handle);
			LuaCustom.Bind(luaState.handle);

            
            luaState.doFile("main.lua");

            LuaFunction func = (LuaFunction)luaState["main"];
            Profiler.BeginSample("call main");
            func.call();
            Profiler.EndSample();
        }
    }
}
