/* 
* Copyright (C) polynation games ltd - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
* Written by Christopher Redden, December 2013
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

#define SLuaCallback "SLuaCallback"
LUA_API int luaS_checkcallback(lua_State *L, int index) 
{
	int r;
	lua_Debug ar;

	if(lua_type(L,index)!=LUA_TFUNCTION)
		return -1;
	
	index = index > 0 ? index : lua_gettop(L) + index + 1;

	lua_pushvalue(L, index);
	lua_getinfo(L, ">S", &ar);

	char funcinfo[260];
#ifdef _WINDOWS
	_snprintf(funcinfo, 260, "%s:%d", ar.source, ar.linedefined);
#else
	snprintf(funcinfo, 260, "%s:%d", ar.source, ar.linedefined);
#endif
	lua_getfield(L, LUA_REGISTRYINDEX, SLuaCallback);
	if (lua_isnil(L, -1)) {
		lua_pop(L, 1);
		lua_createtable(L, 0, 0);
		lua_pushvalue(L, -1);
		lua_setfield(L, LUA_REGISTRYINDEX, SLuaCallback);
	}

	lua_getfield(L, -1, funcinfo);
	if (lua_isnil(L, -1)) {
		lua_pop(L, 1);
		lua_pushvalue(L, index);
		r =luaL_ref(L, LUA_REGISTRYINDEX);
		lua_pushinteger(L, r);
		lua_setfield(L, -2, funcinfo);
	}
	else {
		r = (int) lua_tointeger(L, -1);
		lua_pop(L, 1);
	}
	lua_pop(L, 1); // pop SLuaCallback table

	return r;
}
