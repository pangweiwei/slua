using System.Collections.Generic;
using System;

public class CustomExport {

	public static void OnAddCustomClass(LuaCodeGen.ExportGenericDelegate add)
    {
        add(typeof(System.Func<int>),null);
        add(typeof(System.Action<int,string>),null);
        add(typeof(System.Action<int, Dictionary<int, object>>),null);
		add(typeof(List<int>), "ListInt");
		add(typeof(Dictionary<int,string>), "DictIntStr");
		add(typeof(string), "String");
        // add your custom class here
		// add( type, typename)
		// type is what you want to export
		// typename used for simplify generic type name or rename, like List<int> named to "ListInt", if not a generic type keep typename as null or rename as new type name
    }

    public static void OnAddCustomAssembly(ref List<string> list)
    {
        // add your custom assembly here
        // you can build a dll for 3rd library like ngui titled assembly name "NGUI", put it in Assets folder
        // add it's name into list, slua will generate all exported interface automatically for you

        //list.Add("NGUI");
    }

	// if uselist return a white list, don't check noUseList(black list) again
	public static void OnGetUseList(out List<string> list)
	{
		list = new List<string>
		{
		};
	}

	// black list if white list not given
	public static void OnGetNoUseList(out List<string> list)
	{
		list = new List<string>
        {      
            "HideInInspector",
            "ExecuteInEditMode",
            "AddComponentMenu",
            "ContextMenu",
            "RequireComponent",
            "DisallowMultipleComponent",
            "SerializeField",
            "AssemblyIsEditorAssembly",
            "Attribute", 
            "Types",
            "UnitySurrogateSelector",
            "TrackedReference",
            "TypeInferenceRules",
            "FFTWindow",
            "RPC",
            "Network",
            "MasterServer",
            "BitStream",
            "HostData",
            "ConnectionTesterStatus",
            "GUI",
            "EventType",
            "EventModifiers",
            "FontStyle",
            "TextAlignment",
            "TextEditor",
            "TextEditorDblClickSnapping",
            "TextGenerator",
            "TextClipping",
            "Gizmos",
             "ADBannerView",
            "ADInterstitialAd",            
            "Android",
            "jvalue",
            "iPhone",
            "iOS",
            "CalendarIdentifier",
            "CalendarUnit",
            "CalendarUnit",
            "FullScreenMovieControlMode",
            "FullScreenMovieScalingMode",
            "Handheld",
            "LocalNotification",
            "NotificationServices",
            "RemoteNotificationType",      
            "RemoteNotification",
            "SamsungTV",
            "TextureCompressionQuality",
            "TouchScreenKeyboardType",
            "TouchScreenKeyboard",
            "MovieTexture",
            "UnityEngineInternal",
            "Terrain",                            
            "Tree",
            "SplatPrototype",
            "DetailPrototype",
            "DetailRenderMode",
            "MeshSubsetCombineUtility",
            "AOT",
            "Social",
            "Enumerator",       
            "SendMouseEvents",               
            "Cursor",
            "Flash",
            "ActionScript",
            "OnRequestRebuild",
			"Ping",
            "ShaderVariantCollection",
        };
	}

}
