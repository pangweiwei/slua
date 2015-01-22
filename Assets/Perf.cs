using UnityEngine;
using System.Collections;
using SLua;
public class Perf : MonoBehaviour {

    LuaSvr l;
	// Use this for initialization
	void Start () {
	    l = new LuaSvr("perf.lua.txt");
	}


    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 120, 50), "Test1"))
        {
            l.luaState.getFunction("test1").call();
        }

        if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
        {
            l.luaState.getFunction("test2").call();
        }

        if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
        {
            l.luaState.getFunction("test3").call();
        }

        if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
        {
            l.luaState.getFunction("test4").call();
        }

        if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
        {
            l.luaState.getFunction("test5").call();
        }

        if (GUI.Button(new Rect(10, 400, 300, 50), "Click here for detail(in Chinese)"))
        {
            
        }
    }
}
