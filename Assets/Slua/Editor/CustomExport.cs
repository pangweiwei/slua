using System.Collections.Generic;
using System;

public class CustomExport {

    public static void OnAddCustomClass(ref List<Type> list)
    {
        list.Add(typeof(System.Func<int>));
        list.Add(typeof(System.Action<int,string>));
        list.Add(typeof(System.Action<int, Dictionary<int, object>>));
        // add your custom class here
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
            "Motion",   
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
            "Mathf",
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
