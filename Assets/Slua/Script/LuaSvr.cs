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

            LuaObject.init(luaState.handle);
            bind("BindUnity");
            bind("BindUnityUI");
            bind("BindCustom");

            
            luaState.doFile(main);

            LuaFunction func = (LuaFunction)luaState["main"];
            Profiler.BeginSample("call main");
            func.call();
            Profiler.EndSample();
        }

        void bind(string name)
        {
            MethodInfo mi = typeof(LuaObject).GetMethod(name,BindingFlags.Public|BindingFlags.Static);
            if (mi != null) mi.Invoke(null, new object[] { luaState.handle });
            else if(name=="BindUnity") Debug.LogError(string.Format("Miss {0}, click SLua=>Make to regenerate them",name));
        }
    }
}
