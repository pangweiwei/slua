using UnityEngine;
using System.Collections;
using SLua;

public class Circle : MonoBehaviour {


	LuaSvr svr;
	LuaTable self;
	LuaFunction update;
	void Start () {
		svr = new LuaSvr();
		self=(LuaTable)svr.start("circle/circle");
		update = (LuaFunction)self["update"];
	}
	
	void Update () {
		update.call(self);
	}
}
