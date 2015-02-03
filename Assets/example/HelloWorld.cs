using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SLua;
using System;
using LuaInterface;

[CustomLuaClass]
public class HelloWorld   {

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


    static public void ofunc(Type t) {
        Debug.Log(t.Name);
    }

    static public void ofunc(GameObject go) {
        Debug.Log(go.name);
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

    // test variant number for arguments passed in
    static public void func6(string str, params object[] args)
    {
        Debug.Log(str);
        for (int n = 0; n < args.Length; n++)
        {
            Debug.Log(args[n]);
        }
    }

    [DoNotToLua]
    static public void dontexport()
    {

    }

    [DoNotToLua]
    public int a;

    [DoNotToLua]
    public int A
    {
        get
        {
            return a;
        }
    }

    internal int b;
}
