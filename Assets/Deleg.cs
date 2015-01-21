using UnityEngine;
using System.Collections;
using SLua;
public class Deleg : MonoBehaviour {

    LuaSvr l;
    // Use this for initialization
    void Start()
    {
        l = new LuaSvr("delegate.lua.txt");
    }
}
