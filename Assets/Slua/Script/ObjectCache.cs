using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    class ObjectCache
    {
        static Dictionary<IntPtr, ObjectCache> multiState = new Dictionary<IntPtr, ObjectCache>();

        Dictionary<int, object> cache = new Dictionary<int, object>();
        class ObjPair
        {
            public int index=0;
            public int count=0;
            public ObjPair(int i, int c)
            {
                this.index = i;
                this.count = c;
            }
        }
        Dictionary<object, ObjPair> objMap = new Dictionary<object, ObjPair>();
        int objIndex = 0;
        internal static ObjectCache get(IntPtr l)
        {
            ObjectCache oc;
            if (multiState.TryGetValue(l, out oc))
                return oc;
            return null;
        }

        internal static void del(IntPtr l)
        {
            multiState.Remove(l);
        }

        internal static void make(IntPtr l)
        {
            ObjectCache oc = new ObjectCache();
            multiState[l] = oc;
        }

        internal void gc(int index)
        {
            object o;
            if (cache.TryGetValue(index, out o))
            {
                if (isGcObject(o))
                {
                    ObjPair pair;
                    if (objMap.TryGetValue(o, out pair))
                    {
                        System.Diagnostics.Debug.Assert(pair.index == index, "Cached object missed");
                        pair.count--;
                        System.Diagnostics.Debug.Assert(pair.count >= 0);
                        if (pair.count == 0)
                        {
                            cache.Remove(index);       
                            objMap.Remove(o);
                        }
                    }
                }
                else
                    cache.Remove(index);
            }
        }

        internal int add(object o)
        {
            cache[objIndex] = o;
            if (isGcObject(o))
            {
                objMap[o] = new ObjPair(objIndex,1);
            }
            return objIndex++;
        }

        internal object get(IntPtr l,int p)
        {
            int index=LuaDLL.luaS_rawnetobj(l, p);
            object o;
            if (index!=-1 && cache.TryGetValue(index, out o))
            {
                return o;
            }
            return null;
        }

        internal void setBack(IntPtr l, int p, object o)
        {
			int index = LuaDLL.luaS_rawnetobj(l,p);
			if (index != -1)
			{
				cache[index] = o;
			}
        }

        internal void push(IntPtr l, object o)
        {
            if (o == null)
            {
                LuaDLL.lua_pushnil(l);
                return;
            }
            int index = -1;
            ObjPair pair=null;
            bool found = isGcObject(o) && objMap.TryGetValue(o, out pair);
            if (found && pair!=null)
            {
                index = pair.index;
                pair.count++;
            }
            else
                index = add(o);

            LuaDLL.luaS_newuserdata(l, index);

            
            LuaDLL.luaL_getmetatable(l, getAQName(o));
            if (LuaDLL.lua_isnil(l, -1))
            {
				LuaDLL.luaL_error(l,string.Format("{0} not registerd, can't push to lua vm.",o.GetType().Name));
            }

            LuaDLL.lua_setmetatable(l, -2);
            
        }


        Dictionary<Type, string> aqnameMap = new Dictionary<Type, string>();
        string getAQName(object o)
        {
            Type t = o.GetType();
            string name;
            if (aqnameMap.TryGetValue(t, out name))
            {
                return name;
            }
            name = t.AssemblyQualifiedName;
            aqnameMap[t] = name;
            return name;
        }


        bool isGcObject(object obj)
        {
            return obj.GetType().IsValueType==false;
        }
    }
}

