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
    class ObjectCache
    {

        public ObjectCache(IntPtr l)
        {
            LuaDLL.lua_newtable(l);
            LuaDLL.lua_newtable(l);
            LuaDLL.lua_pushstring(l, "v");
            LuaDLL.lua_setfield(l, -2, "__mode");
            LuaDLL.lua_setmetatable(l, -2);
            udCacheRef = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
        }

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
                this[i].v = o;
            }
        }

        FreeList cache = new FreeList();

        Dictionary<object, int> objMap = new Dictionary<object, int>();
        int udCacheRef = 0;

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
            ObjectCache oc = new ObjectCache(l);
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
                    objMap.Remove(o);
                }
                cache.del(index);
            }
        }

        internal int add(object o)
        {
            int objIndex = cache.add(o);
            if (isGcObject(o))
            {
                objMap[o] = objIndex;
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

        bool getUDCache(IntPtr l,int index)
        {
            LuaDLL.lua_getref(l, udCacheRef);
            LuaDLL.lua_rawgeti(l, -1, index);
            if (!LuaDLL.lua_isnil(l,-1))
            {
                LuaDLL.lua_remove(l, -2);
                return true;
            }
            LuaDLL.lua_pop(l, 2);
            return false;
        }

        void cacheUD(IntPtr l, int index)
        {
            LuaDLL.lua_getref(l, udCacheRef);
            LuaDLL.lua_pushvalue(l, -2);
            LuaDLL.lua_rawseti(l, -2, index);
            LuaDLL.lua_pop(l, 1);
        }

        internal void push(IntPtr l, object o)
        {
            if (o == null)
            {
                LuaDLL.lua_pushnil(l);
                return;
            }
            int index = -1;

            bool gco = isGcObject(o);
            bool found = gco && objMap.TryGetValue(o, out index);
            if (found)
            {
                if (getUDCache(l,index))
                    return;
            }

            
            index = add(o);
            LuaDLL.luaS_newuserdata(l, index);
            if(gco) cacheUD(l, index);

            
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

