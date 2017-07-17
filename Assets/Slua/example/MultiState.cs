using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

public class MultiState : MonoBehaviour {

	LuaSvr svr;
	LuaState[] ls=new LuaState[10];
	// Use this for initialization
	void Start () {
		svr = new LuaSvr ();
		svr.init (null, complete);
	}

	void complete() {
		// create 10 lua state
		for (int n = 0; n < 10; n++) {
			ls[n] = new LuaState ();
			ls[n].doString (string.Format ("print('this is #{0} lua state')", n));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy() {
		for (int n = 0; n < 10; n++) {
			ls [n].Dispose ();
		}
	}
}
