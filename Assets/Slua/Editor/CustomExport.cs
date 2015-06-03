using System.Collections.Generic;
using System;
using UnityEngine;

#if SLUA
using SLua;
#endif

#if SLUA
public class CustomExport {

    static private string[] ms_UnityTypes = new string[]        
    {
       "UnityEngine.Color",
       "UnityEngine.Vector3",
       "UnityEngine.Vector4",
       "UnityEngine.Rect",
       "UnityEngine.Quaternion",
       "UnityEngine.MonoBehaviour",
       "UnityEngine.Behaviour",
       "UnityEngine.Component",
       "UnityEngine.Object",
    };

    static private string[] ms_3rdPartyTypes = new string[]
    {
       "Protocol.MessageType",
    };

    static private string[] ms_ApplicationTypes = new string[]
    {
        "UI_RaderMap",

        // static member begins
        "ClientAPP",
        "LC_DBManager",
        "LC_WorldManager",
        "UI_Main",
        "UT_AudioManager",
        "NW_Helper",
        "UT_PrefabPoolManager",
        "LC_Actor_NetNPCManager",
        "LC_Actor_GameWarriorManager",
        "NGUITools",
        "UI_Helper",
        // static member ends

        // enum begins
        "UI_Main+Type",
        "UT_AudioManager+AudioChannelType",
        "Protocol+MessageType",
        "UT_PrefabPoolManager+PrefabType",
        // enum ends
    };

    public static void OnAddCustomClass(ref List<string> list)
    {
        //list.Add(typeof(System.Func<int>));
        //list.Add(typeof(System.Action<int, string>));
        //list.Add(typeof(System.Action<int, Dictionary<int, object>>));
        // add your custom class here

        list = new List<string>();
        list.AddRange(ms_ApplicationTypes);
    }

    public static void OnAdd3rdPartyClass(ref List<string> list)
    {
        list = new List<string>();
        list.AddRange(ms_3rdPartyTypes);
    }

    public static void OnAdd3rdPartyAssembly(ref List<string> list)
    {
        // add your custom assembly here
        // you can build a dll for 3rd library like ngui titled assembly name "NGUI", put it in Assets folder
        // add it's name into list, slua will generate all exported interface automatically for you

        list.Add("GamePBufLib");
        //list.Add("System");
        //list.Add("System.Core");

        //list.Add("NGUI");
    }

	// if uselist return a white list, don't check noUseList(black list) again
	public static void OnGetUseList(ref List<string> list)
	{
        //return;
        list = new List<string>();
        list.AddRange(ms_UnityTypes);
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
#endif