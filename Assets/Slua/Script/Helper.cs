using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using LuaInterface;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SLua
{
    class Helper : LuaObject
    {

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int CreateClass(IntPtr l)
        {
            try
            {
                string cls;
                checkType(l, 1, out cls);
                Type t = Type.GetType(cls);
                if (t == null)
                {
                    LuaDLL.luaL_error(l, "Can't find {0} to create", cls);
                    return 0;
                }

                ConstructorInfo[] cis = t.GetConstructors();
                ConstructorInfo target = null;
                for (int n = 0; n < cis.Length; n++)
                {
                    ConstructorInfo ci = cis[n];
                    if (matchType(l, LuaDLL.lua_gettop(l), 2, ci.GetParameters()))
                    {
                        target = ci;
                        break;
                    }
                }

                if (target != null)
                {
                    ParameterInfo[] pis = target.GetParameters();
                    object[] args = new object[pis.Length];
                    for (int n = 0; n < pis.Length; n++)
                        args[n] = Convert.ChangeType(checkVar(l, n + 2), pis[n].ParameterType);

                    object ret = target.Invoke(args);
                    pushVar(l, ret);
                    return 1;
                }
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }

        static public void reg(IntPtr l)
        {
            reg(l, CreateClass, "Slua");
        }
    }
}
