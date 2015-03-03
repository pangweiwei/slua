/* 
* This file is based off of MonoLuaInterface's wrapping: https://github.com/stevedonovan/MonoLuaInterface
*/

#define LUA_LIB
#include "lua.h"
#include "lauxlib.h"
#include <stdio.h>

/*  LUA INTERFACE SUPPORT  */
#ifndef _WIN32
#define __stdcall
#endif
typedef int (__stdcall *lua_stdcallCFunction) (lua_State *L);

static int stdcall_closure(lua_State *L) 
{
    lua_stdcallCFunction fn = (lua_stdcallCFunction)lua_touserdata(L, lua_upvalueindex(1));
    int r = fn(L);
    return r;
}


LUA_API void lua_pushstdcallcfunction(lua_State *L, lua_stdcallCFunction fn)
{
    lua_pushlightuserdata(L, fn);
    lua_pushcclosure(L, stdcall_closure, 1);
}


LUA_API void luaS_newuserdata(lua_State *L, int val)
{
  int* pointer=(int*)lua_newuserdata(L,sizeof(int));
  *pointer=val;
}

LUA_API int luaS_rawnetobj(lua_State *L,int index) 
{
  int *udata=lua_touserdata(L,index);
  if(udata!=NULL) return *udata;
  return -1;
}

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


LUA_API const char* luaS_tolstring32(lua_State *L, int index, int* len) {
    size_t l;
    const char* ret = lua_tolstring(L,index, &l);
    *len = (int)l;
    return ret;
}

#if LUA_VERSION_NUM==503
static int k (lua_State *L, int status, lua_KContext ctx) {
	return status;
}

LUA_API int luaS_yield(lua_State *L,int nrets) {
	int ret = lua_yieldk(L,nrets,0,k);
	return ret;
}

LUA_API int luaS_pcall(lua_State *L,int nargs,int nresults,int err) {
	return k(L,lua_pcallk(L,nargs,nresults,err,0,k),0);
}
#endif
