using UnityEngine;
using System.Collections;
using SLua;
public class Perf : MonoBehaviour {

    LuaSvr l;
	// Use this for initialization
	void Start () {
	    l = new LuaSvr("perf.lua.txt");
	}
	
   
}
