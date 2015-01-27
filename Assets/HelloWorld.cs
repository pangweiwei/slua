using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SLua;
using System;
using LuaInterface;

public class HelloWorld   {

    public delegate bool GetBundleInfoDelegate(string path, out string url, out int version, out uint crc,ref int flag);
    public delegate void SimpleDelegate(string path, GameObject g);

	static public void say() {
		Debug.Log ("hello world");
	}


    public Dictionary<string, GameObject> foo()
    {
        return new Dictionary<string, GameObject>();
    }

    public List<GameObject> getList()
    {
        return new List<GameObject> { new GameObject("1"), new GameObject("2") };
    }

    static public void setv(LuaTable t) {
        Debug.Log(t["name"]);
        Debug.Log(t["value"]);
    }

    static public LuaTable getv()
    {
        LuaTable t = new LuaTable(LuaState.main);
        t["name"] = "xiaoming";
        t["age"] = 12;
        return t;
    }

    public GetBundleInfoDelegate d;
    public SimpleDelegate s;

    public void callD()
    {
        string url;
        int ver;
        uint crc;
        int flag = 1;
        if (d != null)
        {
            bool ret = d("/path", out url, out ver, out crc, ref flag);
            Debug.Log(string.Format("{0},{1},{2},{3},{4}", ret, url, ver, crc, flag));
        }
        if(s!=null)
            s("GameObject", new GameObject("SimpleDelegate"));
    }

    // this function exported, but get error to call
    // generic function not support
    public void generic<T>()
    {
        Debug.Log(typeof(T).Name);
    }

    public void perf()
    {
        Profiler.BeginSample("create 1000000 vector3/cs");
        for (int n = 0; n < 1000000; n++)
        {
            Vector3 v = new Vector3(n, n, n);
            v.Normalize();
        }
        Profiler.EndSample();
    }

    static public void testvec3(Vector3 v)
    {
        Debug.Log(string.Format("vec3 {0},{1},{2}", v.x, v.y,v.z));
    }

    static public void testset(GameObject go)
    {
        Transform t= go.transform;
        for (int i = 0; i < 200000; i++)
        {
            t.position = t.position;
        }
    }

    static public void test2(GameObject go)
    {
        Vector3 v = Vector3.one;
        for (int i = 0; i < 200000; i++)
        {
            v.Normalize();
        }
    }

    static public void test3(GameObject go)
    {
        Vector3 v = Vector3.one;
        for (int i = 0; i < 200000; i++)
        {
            v = Vector3.Normalize(v);
        }
    }

    static public void test4(GameObject go)
    {
        Vector3 v = Vector3.one;
        Transform t = go.transform;
        for (int i = 0; i < 200000; i++)
        {
            t.position = v;
        }
    }

    static public void test5(GameObject go)
    {
        Vector3 v;
        for (int i = 0; i < 200000; i++)
        {
            v = new Vector3(i, i, i);
        }
    }
}
