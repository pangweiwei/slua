# slua
Unity lua binding via static code generating.

QQ group: 15647305


#main feature

static code generating, no reflection, no extra gc alloc, very fast

above 90% UnityEngine interface exported ( remove flash, platform dependented interface )

100% UnityEngine.UI interface ( require Unity4.6+ )

support UnityEvent/UnityAction for event callback via lua function

support custom class exported

export enum as integer

return array as lua table

#usage

copy Assets/Plugins Assets/Slua to your $Project$/Assets folder, you will see Slua menu, 

click Make, regenerate UnityEngine interface for lua

click Make UI, regenerate UnityEngine.UI interface for lua

click Make custom , generate custom class interface for lua

Clear , not complete yet

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
