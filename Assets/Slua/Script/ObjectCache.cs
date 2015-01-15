using System;
using System.Collections.Generic;
using LuaInterface;

namespace SLua
{
    class ObjectCache
    {
        static Dictionary<IntPtr, ObjectCache> multiState = new Dictionary<IntPtr, ObjectCache>();

        Dictionary<int, object> cache = new Dictionary<int, object>();
        Dictionary<object, int> objMap = new Dictionary<object, int>();
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
			cache.Remove(index);
        }

        internal int add(object o)
        {
            cache[objIndex] = o;
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
            bool found = isGcObject(o) && objMap.TryGetValue(o, out index);
            if (found)
            {
                // TODO
            }
            index = add(o);

            LuaDLL.luaS_newudata(l, index);

            Type t = o.GetType();
            string name = t.AssemblyQualifiedName;
            LuaDLL.luaL_getmetatable(l, name);
            if (LuaDLL.lua_isnil(l, -1))
            {
				LuaDLL.luaL_error(l,string.Format("{0} not registerd, can't push to lua vm.",t.Name));
            }

            LuaDLL.lua_setmetatable(l, -2);
            
        }


        bool isGcObject(object obj)
        {
            return obj.GetType().IsValueType;
        }
    }
}

