
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLua
{
    public class LuaUnityEvent_UnityEngine_EventSystems_BaseEventData : LuaObject
    {

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int AddListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData> self = checkSelf<UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>>(l);
                UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> a1;
                checkType(l, 2, out a1);
                self.AddListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int RemoveListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData> self = checkSelf<UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>>(l);
                UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> a1;
                checkType(l, 2, out a1);
                self.RemoveListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int Invoke(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData> self = checkSelf<UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>>(l);
                UnityEngine.EventSystems.BaseEventData o;
                checkType(l,2,out o);
                self.Invoke(o);
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
            getTypeTable(l, typeof(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData).FullName);
            addMember(l, AddListener);
            addMember(l, RemoveListener);
            addMember(l, Invoke);
            createTypeMetatable(l, typeof(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData));
        }

        static bool checkType(IntPtr l,int p,out UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            LuaDelegate ld;
            checkType(l, p, out ld);
            if (ld.d != null)
            {
                ua = (UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>)ld.d;
                return true;
            }
            ua = (UnityEngine.EventSystems.BaseEventData v) =>
            {
                int error = pushTry(l);
                pushValue(l, v);
                ld.call(1, error);
                LuaDLL.lua_settop(l,error - 1);
            };
            ld.d = ua;
            return true;
        }
    }
}
