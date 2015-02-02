using UnityEngine;
using System.Collections;
using SLua;

public class Main : MonoBehaviour {

    LuaSvr l;
    // Use this for initialization
    void Start()
    {
        l = new LuaSvr("main.lua.txt");
        
        object o = l.luaState.getFunction("foo").call(1, 2, 3);
        object[] array = (object[])o;
        for (int n = 0; n < array.Length; n++)
            Debug.Log(array[n]);

        string s = (string)l.luaState.getFunction("str").call( new object[0] );
        Debug.Log(s);
    }
}
