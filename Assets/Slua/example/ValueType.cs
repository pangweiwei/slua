using UnityEngine;
using System.Collections;
using SLua;

public class ValueType : MonoBehaviour {

    LuaSvr l;
	// Use this for initialization
	void Start () {
        l = new LuaSvr();
		l.init(null, () =>
		{
			l.start("valuetype");
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
