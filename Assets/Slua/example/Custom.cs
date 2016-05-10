using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using SLua;
using System;

[CustomLuaClassAttribute]
public class Custom : MonoBehaviour
{

	int v = 520;
	static string vs = "xiaoming & hanmeimei";
	LuaSvr l;
	static Custom c;
	void Start()
	{
		c = this;
		l = new LuaSvr();
		l.init(null, () =>
		{
			l.start("custom");
		});
	}

	// Update is called once per frame
	void Update()
	{

	}

	// this exported function don't generate stub code if it had MonoPInvokeCallbackAttribute attribute, only register it
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int instanceCustom(IntPtr l)
	{
		Custom self = (Custom)LuaObject.checkSelf(l);
		LuaObject.pushValue(l, true);
		LuaDLL.lua_pushstring(l, "xiaoming");
		LuaDLL.lua_pushstring(l, "hanmeimei");
		LuaDLL.lua_pushinteger(l, self.v);
		return 4;
	}

	// this exported function don't generate stub code, only register it
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[StaticExport]
	static public int staticCustom(IntPtr l)
	{
		LuaObject.pushValue(l, true);
		LuaDLL.lua_pushstring(l, vs);
		LuaObject.pushObject(l, c);
		return 3;
	}
	public int this[string key]
	{
		get
		{
			if (key == "test")
				return v;
			return 0;
		}
		set
		{
			if (key == "test")
			{
				v = value;
			}
		}
	}
	public string getTypeName(Type t)
	{
		return t.Name;
	}
}
