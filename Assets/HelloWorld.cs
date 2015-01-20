using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld  {

	public void say() {
		Debug.Log ("hello world");
	}


    public Dictionary<string, GameObject> foo()
    {
        return new Dictionary<string, GameObject>();
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
}
