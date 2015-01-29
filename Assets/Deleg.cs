using UnityEngine;
using System.Collections;
using SLua;
using System;
using System.Collections.Generic;
public class Deleg : MonoBehaviour {

    LuaSvr l;
    // Use this for initialization
    void Start()
    {
        l = new LuaSvr("delegate.lua.txt");
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
