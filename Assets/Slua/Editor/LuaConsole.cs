// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
namespace SLua
{
    using System;
    using System.Collections.Generic;
    using LuaInterface;
    using UnityEditor;
    using UnityEngine;

    public class LuaConsole : EditorWindow
    {

        string inputText;
        string outputText;
        List<string> history;
        int historyIndex;
        Vector2 scrollPoition;
        const int MaxLength = 10000;
        static bool regConsoleFunction = false;
        static LuaConsole console;


        [MenuItem("SLua/LuaConsole")]
        public static void openLuaConsole()
        {
            EditorWindow.GetWindow<LuaConsole>();
        }


        LuaConsole()
        {
            inputText = "";
            outputText = "";
            history = new List<string>();
            historyIndex = 0;
            scrollPoition = Vector2.zero;
            console = this;
        }

        void consolePrint(string str)
        {
            outputText += str;
            outputText += "\r\n";
            scrollPoition.y = float.MaxValue;
            Repaint();
        }

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int outputConsole(IntPtr l)
        {
            string err;
            LuaObject.checkType(l, 1, out err);
            if(console!=null)
                console.consolePrint(err);
            return 0;
        }

        void RegConsoleFunction(IntPtr l)
        {
            LuaDLL.lua_pushcfunction(l, outputConsole);
            LuaDLL.lua_setglobal(l, "outputConsole");
        }

        void OnGUI()
        {
            try {
                float totalAreaHeight = Screen.height;
                float outputAreaHeight = totalAreaHeight - 50;

                LuaSvrGameObject lua = FindObjectOfType<LuaSvrGameObject>();
                if (!regConsoleFunction)
                {
                    regConsoleFunction = true;
                    RegConsoleFunction(lua.state.L);
                }

                scrollPoition = GUILayout.BeginScrollView(scrollPoition, GUILayout.ExpandWidth(true), GUILayout.Height(outputAreaHeight));
                if (outputText.Length > MaxLength)
                {
                    outputText = outputText.Substring(outputText.Length - MaxLength);
                }
                if (lua != null)
                    EditorGUILayout.TextArea(outputText, GUILayout.ExpandHeight(true));
                else
                    EditorGUILayout.LabelField("Start game to active this console.", GUILayout.ExpandHeight(true));
                GUILayout.EndScrollView();

                GUI.SetNextControlName("Input");
                if (lua != null)
                    inputText = EditorGUILayout.TextField(inputText, GUILayout.ExpandHeight(true));
                else
                    EditorGUILayout.LabelField("Waiting for lua VM start", GUILayout.ExpandHeight(true));

                if (Event.current.isKey && Event.current.type == EventType.KeyUp)
                {
                    bool refresh = false;
                    if (Event.current.keyCode == KeyCode.Return)
                    {
                        if (inputText != "")
                        {
                            if (history.Count == 0 || history[history.Count - 1] != inputText)
                            {
                                history.Add(inputText);
                            }
                            consolePrint(inputText);
                            doCommand(inputText);
                            inputText = "";
                            refresh = true;
                            historyIndex = history.Count;
                        }
                    }
                    else if (Event.current.keyCode == KeyCode.UpArrow)
                    {
                        if (history.Count > 0)
                        {
                            historyIndex = historyIndex - 1;
                            if (historyIndex < 0)
                            {
                                historyIndex = 0;
                            }
                            else
                            {
                                inputText = history[historyIndex];
                                refresh = true;
                            }
                        }
                    }
                    else if (Event.current.keyCode == KeyCode.DownArrow)
                    {
                        if (history.Count > 0)
                        {
                            historyIndex = historyIndex + 1;
                            if (historyIndex > history.Count - 1)
                            {
                                historyIndex = history.Count - 1;
                            }
                            else
                            {
                                inputText = history[historyIndex];
                                refresh = true;
                            }
                        }
                    }

                    if (refresh)
                    {
                        Repaint();
                        EditorGUIUtility.editingTextField = false;
                        GUI.FocusControl("Input");
                    }
                }
            }
            catch(Exception)
            {
                // ignore
            }
        }

        void doCommand(string str)
        {
            LuaSvrGameObject lua = FindObjectOfType<LuaSvrGameObject>();
            if (lua == null)
                return;

            LuaState luaState = lua.state;
            int index = str.IndexOf(" ");
            string cmd = str;
            if (index > 0)
            {
                cmd = str.Substring(0, index).Trim().ToLower();
            }

            if (cmd == "reload")
            {
                // TODO
            }
            else if (cmd=="cls")
            {
                outputText = "";
            }
            else
            {
                if (!string.IsNullOrEmpty(str))
                {
                    var luaFunc = luaState.getFunction("Slua.ldb.printExpr");
                    if (luaFunc != null)
                        luaFunc.call(str);
                    else
                        consolePrint("do script failed");
                }
            }
        }
    }

}