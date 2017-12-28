// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net / blueuee lailongwei@126.com
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

#if !SLUA_STANDALONE

using UnityEngine;

namespace SLua
{
    /// <summary>
    /// Singleton monobehaviour support.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    T[] curInstance = FindObjectsOfType<T>();
                    if (curInstance != null && curInstance.Length > 0)
                        for (int i = 0; i < curInstance.Length; i++)
                            Object.Destroy(curInstance[i].gameObject);

                    GameObject tmpGo = new GameObject(typeof(T).Name);
                    Object.DontDestroyOnLoad(tmpGo);
                    _instance = tmpGo.AddComponent<T>();
                }

                return _instance;
            }
        }

        protected void OnDestroy()
        {
            if (_instance == this)
                _instance = null;
        }

        protected static T _instance;
    }
}

#endif // !SLUA_STANDALONE
