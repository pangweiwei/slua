﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using SLua;
using System;

[CustomLuaClassAttribute]
public class Custom : MonoBehaviour {

	int v=520;
    static string vs = "xiaoming & hanmeimei";
    LuaSvr l;
    static Custom c;
	void Start () {
        c = this;
        l = new LuaSvr("custom");
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
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[StaticExport]
    static public int staticCustom(IntPtr l) {
        LuaDLL.lua_pushstring(l,vs);
        LuaObject.pushObject(l, c);
        return 2;
    }
    public int this[string key]
    {
        get 
        {  if(key == "test") 
                return v;
            return 0;
        }
        set
        {
            if(key == "test")
            {
                v = value;
            }
        }
    }
    public string getTypeName(Type t)
    {
        return t.Name;
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    [StaticExport]
    static public int loadstring(IntPtr l)
    {
        string filePath = LuaDLL.lua_tostring(l, 1);
        TextAsset ta = Resources.Load(filePath, typeof(TextAsset)) as TextAsset;
        if(ta == null)
        {
            Debug.LogError("the loadstring filePath not exist:" + filePath);
            return -1;
        }
        
        LuaDLL.lua_pushlstring(l, ta.bytes, ta.bytes.Length);

        return 1;
    }
}
