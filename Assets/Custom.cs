using UnityEngine;
using System.Collections;
using LuaInterface;
using SLua;
using System;

public class Custom : MonoBehaviour {

	int v=520;
    static string vs = "xiaoming & hanmeimei";
    LuaSvr l;
    static Custom c;
	void Start () {
        c = this;
        l = new LuaSvr("custom.lua.txt");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // this exported function don't generate stub code if it had MonoPInvokeCallbackAttribute attribute, only register it
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int instanceCustom(IntPtr l) {
        Custom self = (Custom)LuaObject.checkSelf(l);
        LuaDLL.lua_pushstring(l,"xiaoming");
        LuaDLL.lua_pushstring(l,"hanmeimei");
        LuaDLL.lua_pushinteger(l,self.v);
        return 3;
    }

    // this exported function don't generate stub code, only register it
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction),false)]
    static public int staticCustom(IntPtr l) {
        LuaDLL.lua_pushstring(l,vs);
        LuaObject.pushObject(l, c);
        return 2;
    }
}
