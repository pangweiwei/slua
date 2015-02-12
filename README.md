#slua
Unity lua binding via static code generating.

QQ group: 15647305

Mail to : sineysan#163.com


##Release Download

[here.](https://github.com/pangweiwei/slua/releases/latest)

##Help

See inner demo for help or [Document](doc.md) (in chinese).

##important

pre-generated file need unity 4.6+, 

If you get many errors on different version:

1)delete all fills in LuaObject folder.

2)waiting for unity building code, you will see Slua menu in main menu if no errors,

3)Click menu, SLua->Make, SLua->Make UI, SLua->Make custom, generate all interface file for your version of unity.



##main feature

static code generating, no reflection, no extra gc alloc, very fast

above 90% UnityEngine interface exported ( remove flash, platform dependented interface )

100% UnityEngine.UI interface ( require Unity4.6+ )

support UnityEvent/UnityAction for event callback via lua function

support delegate via lua function

support custom class exported

export enum as integer

return array as lua table

using raw luajit, can be replaced with lua5.3/lua5.1, link with slua.c, if you switch to lua5.1/5.3, add LUA_5_3 macro in build setting.

##usage

copy Assets/Plugins Assets/Slua to your $Project$/Assets folder, you will see Slua menu, 

click Make, regenerate UnityEngine interface for lua

click Make UI, regenerate UnityEngine.UI interface for lua

click Make custom , generate custom class interface for lua

Clear custom, delete all generated custom interface

Slua/LuaObject contain pre-generated file for exported interface.

Precompiled slua library in Plugins only included x86(32bit)/macosx(32bit)/iOS(armv7,armv7s,arm64)/Android(armv7-a) platform using luajit, you should compile other platform/lua5.1/luajit by yourself, see build.txt for help.


## usage at a glance

~~~~~~~~~~lua

-- import
import "UnityEngine"

function main()

	-- create gameobject
	local cube = GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube)

	-- find gameobject
	local go = GameObject.Find("Canvas/Button")
	
	-- get component by type name
	local btn = go:GetComponent("Button")
	
	-- add event listener
	btn.onClick:AddListener(function()
		local go = GameObject.Find("Canvas/Text")
		local label = go:GetComponent("Text")
		label.text="hello world"
	end)
	
	-- use vector3
	local pos = Vector3(10,10,10)+Vector3(1,1,1)
	cube.transform.position = pos
	
	-- use coroutine
	local c=coroutine.create(function()
		print("coroutine start")
		
		WaitForFixedUpdate()
		print("coroutine WaitForFixedUpdate")

		WaitForSeconds(2)
		print("coroutine WaitForSeconds 2")
		
		WaitForEndOfFrame()
		print("coroutine WaitForEndOfFrame")
	end)
	coroutine.resume(c)

	-- add delegate
	Deleg.daction = {"+=",self.actionD}
	
	-- remove delegate
	Deleg.daction = {"-=",self.actionD}
	
	-- set delegate
	Deleg.daction = function() print("callback") end
	
	-- remove all
	Deleg.daction = nil
end

~~~~~~~~~~

##export custom class

find code "static public void Custom()", add your custom class type into exports list, like HelloWorld, see below:

~~~~~~~~~~c#

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
~~~~~~~~~~
    
or

Add [CustomLuaClass] attribute to your class.

###benchmark

see http://www.sineysoft.com/post/164 for detail (in chinese), compared with ulua/Cstolua/raw mono.

**with luajit**


        test1	                test2	             test3	            test4 	         test5 
		propery get and set		member method call   static func call   property set     create valuetype return
				
    slua	0.85		            0.19			   0.62				   0.081			0.62

    cstolua	3.8	                    0.98	           not support	        0.89	        2.3

    ulua	5.16	                0.93	           4.39	                1.72	        5.89
 
    mono	0.064	                0.011	           0.01	                0.03	        0.0025

unit is secend, run 200k times / test, more smarller more better.

