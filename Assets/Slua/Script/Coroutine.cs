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
	using UnityEngine;
	using System.Collections;
	using LuaInterface;
	using SLua;
	using System;

	public class LuaCoroutine : LuaObject
	{

		static MonoBehaviour mb;

		static public void reg(IntPtr l, MonoBehaviour m)
		{
			mb = m;
			reg(l, Yieldk, "UnityEngine");

			string yield =
@"
local Yield = UnityEngine.Yieldk
UnityEngine.Yield = function(x)
	local co,ismain=coroutine.running()
	if ismain then error('Can not yield in main thread') end

	Yield(x,function()
		coroutine.resume(co)
	end)
	coroutine.yield()
end
return yield
";
            // overload resume function for report error
			if(LuaDLL.lua_dostring(l, yield)!=0)
				LuaObject.lastError(l);
			LuaDLL.lua_pop(l, 1);
		}

		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		static public int Yieldk(IntPtr l)
		{
			try
			{
				if (LuaDLL.lua_pushthread(l) == 1)
				{
					LuaDLL.luaL_error(l, "should put Yield call into lua coroutine.");
					return 0;
				}
				object y = checkObj(l, 1);
				LuaFunction f;
				checkType(l, 2, out f);

				mb.StartCoroutine(yieldReturn(y, f));
				return 0;
			}
			catch (Exception e)
			{
				LuaDLL.luaL_error(l, e.ToString());
				return 0;
			}
		}

		static public IEnumerator yieldReturn(object y, LuaFunction f)
		{
			if (y is IEnumerator)
				yield return mb.StartCoroutine((IEnumerator)y);
			else
				yield return y;
			f.call();
		}

	}
}
