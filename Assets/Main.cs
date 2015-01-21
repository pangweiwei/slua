using UnityEngine;
using System.Collections;
using SLua;

public class Main : MonoBehaviour {

    LuaSvr l;
    // Use this for initialization
    void Start()
    {
        l = new LuaSvr("main.lua.txt");
    }
}
