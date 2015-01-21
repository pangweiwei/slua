using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    class ObjectCache
    {
        static Dictionary<IntPtr, ObjectCache> multiState = new Dictionary<IntPtr, ObjectCache>();

        class ObjSlot
        {
            public int freeslot;
            public object v;
            public ObjSlot(int slot, object o)
            {
                freeslot = slot;
                v = o;
            }
        }

        class FreeList : List<ObjSlot>
        {
            public FreeList()
            {
                this.Add(new ObjSlot(0, null));
            }

            public int add(object o)
            {
                ObjSlot free = this[0];
                if (free.freeslot == 0)
                {
                    Add(new ObjSlot(this.Count, o));
                    return this.Count - 1;
                }
                else
                {
                    int slot = free.freeslot;
                    free.freeslot = this[slot].freeslot;
                    this[slot].v = o;
                    this[slot].freeslot = slot;
                    return slot;
                }
            }

            public void del(int i)
            {
                ObjSlot free = this[0];
                this[i].freeslot = free.freeslot;
                this[i].v = null;
                free.freeslot = i;
            }

            public bool get(int i, out object o)
            {
                if (i < 1 || i > this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                o = this[i].v;
                return true;
            }

            public object get(int i)
            {
                object o;
                if (get(i, out o))
                    return o;
                return null;
            }

            public void set(int i, object o)
            {
                if (i < 1 || i > this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this[i].v = o;
            }
        }

        FreeList cache = new FreeList();
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

        static IntPtr oldl = IntPtr.Zero;
        static internal ObjectCache oldoc = null;

        internal static ObjectCache get(IntPtr l)
        {
            if (oldl == l)
                return oldoc;
            ObjectCache oc;
            if (multiState.TryGetValue(l, out oc))
            {
                oldl = l;
                oldoc = oc;
                return oc;
            }
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
            oldl = l;
            oldoc = oc;
        }

        internal void gc(int index)
        {
            object o;
            if (cache.get(index, out o))
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
                            cache.del(index);       
                            objMap.Remove(o);
                        }
                    }
                }
                else
                    cache.del(index);
            }
        }

        internal int add(object o)
        {
            int objIndex = cache.add(o);
            if (isGcObject(o))
            {
                objMap[o] = new ObjPair(objIndex,1);
            }
            return objIndex;
        }

        internal object get(IntPtr l,int p)
        {
            int index=LuaDLL.luaS_rawnetobj(l, p);
            object o;
            if (index!=-1 && cache.get(index, out o))
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
				cache.set(index, o);
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
                LuaDLL.lua_pop(l, 1);
                LuaDLL.luaL_getmetatable(l, "LuaVarObject");
            }

            LuaDLL.lua_setmetatable(l, -2);
            
        }


        static Dictionary<Type, string> aqnameMap = new Dictionary<Type, string>();
        static string getAQName(object o)
        {
            Type t = o.GetType();
            return getAQName(t);
        }

        internal static string getAQName(Type t)
        {
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

