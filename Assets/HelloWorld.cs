using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld   {

    public delegate bool GetBundleInfoDelegate(string path, out string url, out int version, out uint crc,ref int flag);
    public delegate void SimpleDelegate(string path, GameObject g);

	static public void say() {
		Debug.Log ("hello world");
	}


    public Dictionary<string, GameObject> foo()
    {
        return new Dictionary<string, GameObject>();
    }

    public GetBundleInfoDelegate d;
    public SimpleDelegate s;

    public void callD()
    {
        string url;
        int ver;
        uint crc;
        int flag = 1;
        if (d != null)
        {
            bool ret = d("/path", out url, out ver, out crc, ref flag);
            Debug.Log(string.Format("{0},{1},{2},{3},{4}", ret, url, ver, crc, flag));
        }
        if(s!=null)
            s("GameObject", new GameObject("SimpleDelegate"));
    }

    // this function exported, but get error to call
    // generic function not support
    public void generic<T>()
    {
        Debug.Log(typeof(T).Name);
    }

    public void perf()
    {
        Profiler.BeginSample("create 1000000 vector3/cs");
        for (int n = 0; n < 1000000; n++)
        {
            Vector3 v = new Vector3(n, n, n);
            v.Normalize();
        }
        Profiler.EndSample();
    }

    static public void testvec3(Vector3 v)
    {
        Debug.Log(string.Format("vec3 {0},{1},{2}", v.x, v.y,v.z));
    }

    static public void testset(GameObject go)
    {
        float time = Time.realtimeSinceStartup;
        for (int i = 0; i < 200000; i++)
        {
            go.transform.position = Vector3.one;
        }
    }
}
