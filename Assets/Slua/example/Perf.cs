using UnityEngine;
using System.Collections;
using SLua;
public class Perf : MonoBehaviour
{

	LuaSvr l;
	// Use this for initialization
	void Start()
	{
		l = new LuaSvr("perf");

#if UNITY_5
		Application.logMessageReceived += this.log;
#else
		Application.RegisterLogCallback(this.log);
#endif
	}

	string logText = "";
	void log(string cond, string trace, LogType lt)
	{
		logText += cond;
		logText += "\n";
	}

	void OnGUI()
	{

		if (GUI.Button(new Rect(10, 10, 120, 50), "Test1"))
		{
			logText = "";
			l.luaState.getFunction("test1").call();
		}

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
			logText = "";
			l.luaState.getFunction("test2").call();
		}

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
			logText = "";
			l.luaState.getFunction("test3").call();
		}

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
			logText = "";
			l.luaState.getFunction("test4").call();
		}

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
			logText = "";
			l.luaState.getFunction("test5").call();
		}

		if (GUI.Button(new Rect(10, 400, 300, 50), "Click here for detail(in Chinese)"))
		{
			Application.OpenURL("http://www.sineysoft.com/post/164");
		}

		GUI.Label(new Rect(200, 200, 300, 50), logText);
	}
}
