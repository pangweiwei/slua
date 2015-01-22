# slua
Unity lua binding via static code generating.

QQ group: 15647305

#important

pre-generated file need unity 4.6+, 

If you get many errors on different version:

1)delete all fills in LuaObject folder.

2)waiting for unity building code, you will see Slua menu in main menu if no errors,

3)Click menu, SLua->Make, SLua->Make UI, SLua->Make custom, generate all interface file for your version of unity.



#main feature

static code generating, no reflection, no extra gc alloc, very fast

above 90% UnityEngine interface exported ( remove flash, platform dependented interface )

100% UnityEngine.UI interface ( require Unity4.6+ )

support UnityEvent/UnityAction for event callback via lua function

support delegate via lua function

support custom class exported

export enum as integer

return array as lua table

using raw lua 5.3, can be replaced with luajit/lua5.1, link with slua.c, if you switch to lua5.1/luajit, remove LUA_5_3 macro in build setting.

#usage

copy Assets/Plugins Assets/Slua to your $Project$/Assets folder, you will see Slua menu, 

click Make, regenerate UnityEngine interface for lua

click Make UI, regenerate UnityEngine.UI interface for lua

click Make custom , generate custom class interface for lua

Clear , not complete yet

Slua/LuaObject contain pre-generated file for exported interface.

Precompiled slua library in Plugins only included x86/macosx(32bit) platform using lua5.3, you should compile other platform/lua5.1/luajit by yourself, see build.txt for help.

###export custom class

find code "static public void Custom()", add your custom class type into exports list, like HelloWorld, see below:

    [MenuItem("SLua/Make custom")]
    static public void Custom()
    {
        List<Type> exports = new List<Type>{
			typeof(HelloWorld),
			// your custom class here
		};

        foreach (Type t in exports)
        {
            Generate(t);
        }

        GenerateBind(exports,"LuaCustom");
        AssetDatabase.Refresh();
    }

###help

open helloworld.unity and run, see lua/main.lua.txt for simple tutorials.

###benchmark

see http://www.sineysoft.com/post/164 for detail (in chinese), compared with ulua/Cstolua/raw mono.


        test1	                test2	             test3	            test4 	         test5 
		propery get and set		member method call   static func call   property set     create valuetype return
				
    slua	0.85		            0.19			   0.62				   0.081			0.82

    cstolua	3.8	                    0.98	           not support	        0.89	        2.3

    ulua	5.16	                0.93	           4.39	                1.72	        5.89
 
    mono	0.064	                0.011	           0.01	                0.03	        0.0025

unit is secend, run 200k times / test, more smarller more better.

