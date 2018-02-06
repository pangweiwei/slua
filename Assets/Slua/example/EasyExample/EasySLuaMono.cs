// 作者:轩辕小羽 LafreeZhaZha
// 配套文档:https://lafree317.github.io/2018/02/04/2018-02-04%20-%20Unity%E4%B8%AD%E4%BD%BF%E7%94%A8sLua%E7%9A%84%20%E8%B6%85%E4%B8%B6%E7%AE%80%E5%8D%95%E5%9F%BA%E7%A1%80%E6%95%99%E7%A8%8B(%E4%B8%89)/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SLua;

public class EasySLuaMono : MonoBehaviour {

    private LuaFunction _luaStart = null;
    private LuaFunction _luaUpdate = null;
    private LuaFunction _luaLateUpdate = null;
    private LuaFunction _luaFixedUpdate = null;
    private LuaFunction _luaAwake = null;
    private LuaFunction _luaOnDisable = null;
    private LuaFunction _luaOnDestroy = null;


    private void Awake()
    {
        LuaSvr svr = new LuaSvr();// 如果不先进行某个LuaSvr的初始化的话,下面的mianState会爆一个为null的错误..
        LuaSvr.mainState.loaderDelegate += LuaReourcesFileLoader;
		    svr.init(null, () => // 如果不用init方法初始化的话,在Lua中是不能import的
		    {
            svr.start("EasySLuaMono");
            _luaAwake = LuaSvr.mainState.getFunction("Awake");
            _luaStart = LuaSvr.mainState.getFunction("Start");
            _luaFixedUpdate = LuaSvr.mainState.getFunction("FixedUpdate");
            _luaUpdate = LuaSvr.mainState.getFunction("Update");
            _luaLateUpdate = LuaSvr.mainState.getFunction("LateUpdate");
            _luaOnDisable = LuaSvr.mainState.getFunction("OnDisable");
            _luaOnDestroy = LuaSvr.mainState.getFunction("OnDestroy");
		    });
        if(_luaAwake != null){
            _luaAwake.call();
        }
    }

	  private void Start ()
    {

        if(_luaStart != null)
        {
            _luaStart.call();
        }
	  }

    // SLua Loader代理方法
    private static byte[] LuaReourcesFileLoader(string strFile)
    {
        // 这里为了测试就不先判断为空,开发的时候再加上
        string filename = Application.dataPath + "/Scripts/Lua/" + strFile.Replace('.', '/') + ".txt";
        return File.ReadAllBytes(filename);
    }

    void FixedUpdate()
    {
        if(_luaFixedUpdate != null)
        {
            _luaFixedUpdate.call();
        }
    }
    void Update()
    {
        if(_luaUpdate != null)
        {
            _luaUpdate.call();
        }
    }
    void LateUpdate()
    {
        if(_luaLateUpdate != null)
        {
            _luaLateUpdate.call();
        }
    }
    void OnDisable()
    {
        if(_luaOnDisable != null)
        {
            _luaOnDisable.call();
        }
    }
    void OnDestroy()
    {
        if(_luaOnDestroy == null)
        {
            _luaOnDestroy.call();
        }
    }
}
