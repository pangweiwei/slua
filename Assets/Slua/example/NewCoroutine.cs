using System.Collections;
using UnityEngine;
using SLua;

[CustomLuaClass]
public class NewCoroutine : MonoBehaviour
{
    public static IEnumerator MyMethod(string test, float time)
    {
        Debug.Log(test);
        yield return new WaitForSeconds(time);
    }

	void Start () {
		var svr = new LuaSvr();
		svr.init(null, () =>
		{
            var func = (LuaFunction)svr.start("new_coroutine");
			
            func.call(this);
		});
	}
	
}