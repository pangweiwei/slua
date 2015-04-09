using UnityEngine;
using System.Collections;
using SLua;
using UnityEngine.UI;


public class Main : MonoBehaviour
{

	LuaSvr l;
	public Text logText;
	// Use this for initialization
	void Start()
	{
#if UNITY_5
		Application.logMessageReceived += this.log;
#else
		Application.RegisterLogCallback(this.log);
#endif
		l = new LuaSvr();

		l.start("main");
		object o = l.luaState.getFunction("foo").call(1, 2, 3);
		object[] array = (object[])o;
		for (int n = 0; n < array.Length; n++)
			Debug.Log(array[n]);

		string s = (string)l.luaState.getFunction("str").call(new object[0]);
		Debug.Log(s);
	}

	void log(string cond, string trace, LogType lt)
	{
		logText.text += (cond + "\n");

	}

}
