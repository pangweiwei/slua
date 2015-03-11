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

}
