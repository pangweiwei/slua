using UnityEngine;
using System.Collections;
using SLua;
using System;
using System.Collections.Generic;
public class Deleg : MonoBehaviour {
    

    public delegate bool GetBundleInfoDelegate(string path, out string url, out int ver);
    public delegate void SimpleDelegate(string path, GameObject g);

    static public GetBundleInfoDelegate d;
    static public SimpleDelegate s;

    LuaSvr l;
    // Use this for initialization
    void Start()
    {
        l = new LuaSvr("delegate.lua.txt");
    }

    static public void callD()
    {
        string url;
        int ver;
        if (d != null)
        {
            bool ret = d("/path", out url, out ver);
            Debug.Log(string.Format("{0},{1},{2},{3},{4}", ret, url, ver));
        }
        if (s != null)
            s("GameObject", new GameObject("SimpleDelegate"));
    }

    public static void testFunc(Func<int> f) {
        Debug.Log(string.Format("Func return {0}",f()));
    }

    public static void testAction(Action<int,string> f) {
        f(1024,"caoliu");
    }

    public static void testDAction(Action<int,Dictionary<int,object>> f) {
        f(1024, new Dictionary<int,object>());

    }

    public static void callDAction()
    {
        if (daction != null)
            daction(2048, new Dictionary<int, object>());
    }

    public static Action<int, Dictionary<int, object>> daction;
}
