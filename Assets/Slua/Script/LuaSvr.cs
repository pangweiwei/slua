using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

namespace SLua
{

    class LuaSvr
    {
        public LuaState luaState;

        public LuaSvr(string main)
        {
            luaState = new LuaState();

            LuaObject.init(luaState.handle);
            // if compiler report can't find these symbols, 
            // you should click SLua=>Make, Make UI, Make custom to regenrate them.
            LuaUnity.Bind(luaState.handle);
            LuaUnityUI.Bind(luaState.handle);
			LuaCustom.Bind(luaState.handle);

            
            luaState.doFile(main);

            LuaFunction func = (LuaFunction)luaState["main"];
            Profiler.BeginSample("call main");
            func.call();
            Profiler.EndSample();
        }
    }
}
