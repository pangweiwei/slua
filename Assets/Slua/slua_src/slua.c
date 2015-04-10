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


// *** you can remove slua.c file from xcode on build ios project ***

// *** 这个文件仅用于编译libslua.a，ios发布工程时，可以删除这个文件，避免编译错误。


#define MT_VEC2 1
#define MT_VEC3 2
#define MT_VEC4 3
#define MT_Q	4
#define MT_COLOR	5

#define LUA_LIB

#include "lua.h"
#include "lauxlib.h"
#include <stdio.h>
#include <string.h>

#ifdef _WINDOWS
#include <float.h>
#define isnan _isnan
#else
#include <math.h>
#endif

LUA_API void luaS_newuserdata(lua_State *L, int val)
{
	int* pointer = (int*)lua_newuserdata(L, sizeof(int));
	*pointer = val;
}

LUA_API int luaS_rawnetobj(lua_State *L, int index)
{
	int *udata = lua_touserdata(L, index);
	if (udata != NULL) return *udata;
	return -1;
}

LUA_API void* luaS_rawobj(lua_State *L, int index)
{
	void **udata = (void**)lua_touserdata(L, index);
	if (udata != NULL) return *udata;
	return NULL;
}

LUA_API void luaS_pushuserdata(lua_State *L, void* ptr)
{
	void** pointer = (void**)lua_newuserdata(L, sizeof(void*));
	*pointer = ptr;
}


LUA_API const char* luaS_tolstring32(lua_State *L, int index, int* len) {
	size_t l;
	const char* ret = lua_tolstring(L, index, &l);
	*len = (int)l;
	return ret;
}

#if LUA_VERSION_NUM>=503
static int k(lua_State *L, int status, lua_KContext ctx) {
	return status;
}

LUA_API int luaS_yield(lua_State *L, int nrets) {
	int ret = lua_yieldk(L, nrets, 0, k);
	return ret;
}

LUA_API int luaS_pcall(lua_State *L, int nargs, int nresults, int err) {
	return k(L, lua_pcallk(L, nargs, nresults, err, 0, k), 0);
}
#endif



static void getmetatable(lua_State *L, const char* key) {
	char ns[256];
#ifdef _WINDOWS
	_snprintf(ns, 256, "UnityEngine.%s.Instance", key);
#else
	snprintf(ns, 256, "UnityEngine.%s.Instance", key);
#endif

	lua_getfield(L, LUA_REGISTRYINDEX, ns);
}

static void setmetatable(lua_State *L, int p, int what) {

	int ref;

#if LUA_VERSION_NUM>=503
	lua_pushglobaltable(L);
	lua_rawgeti(L, -1, what);
	lua_remove(L, -2);
#else
	lua_rawgeti(L, LUA_GLOBALSINDEX, what);
#endif
	if (!lua_isnil(L, -1)) {
		ref = (int)lua_tointeger(L, -1);
		lua_pop(L, 1);
		if (ref != LUA_REFNIL)
		{
			lua_rawgeti(L, LUA_REGISTRYINDEX, ref);
		}
	}
	else {
		lua_pop(L, 1);

		switch (what) {
		case MT_VEC2:
			getmetatable(L, "Vector2");
			break;
		case MT_VEC3:
			getmetatable(L, "Vector3");
			break;
		case MT_VEC4:
			getmetatable(L, "Vector4");
			break;
		case MT_Q:
			getmetatable(L, "Quaternion");
			break;
		case MT_COLOR:
			getmetatable(L, "Color");
			break;
		}

		lua_pushvalue(L, -1);
		ref = luaL_ref(L, LUA_REGISTRYINDEX);
#if LUA_VERSION_NUM >= 503
		lua_pushglobaltable(L);
		lua_pushinteger(L, ref);
		lua_rawseti(L, -2, what);
		lua_pop(L, 1);
#else
		lua_pushinteger(L, ref);
		lua_rawseti(L, LUA_GLOBALSINDEX, what);
#endif
	}

	lua_setmetatable(L, p);
}



LUA_API int luaS_checkluatype(lua_State *L, int p, const char *t) {
	int top;
	const char* b;

	if (lua_type(L, p) != LUA_TTABLE)
		return 0;
	top = lua_gettop(L);
	if (lua_getmetatable(L, p) == 0)
		return 0;

	lua_pushstring(L, "__typename");
	lua_rawget(L, -2);
	if (lua_isnil(L, -1))
	{
		lua_settop(L, top);
		return 0;
	}
	if (t != NULL) {
		b = lua_tostring(L, -1);
		lua_settop(L, top);
		return strcmp(t, b) == 0;
	}
	return 1;
}


LUA_API void luaS_checkVector4(lua_State *L, int p, float* x, float *y, float *z, float *w) {
	luaL_checktype(L, p, LUA_TTABLE);
	lua_getfield(L, p, "x");
	*x = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "y");
	*y = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "z");
	*z = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "w");
	*w = (float)lua_tonumber(L, -1);
	lua_pop(L, 4);
}

LUA_API void luaS_pushVector4(lua_State *L, float x, float y, float z, float w) {
	lua_newtable(L);
	lua_pushnumber(L, x);
	lua_setfield(L, -2, "x");
	lua_pushnumber(L, y);
	lua_setfield(L, -2, "y");
	lua_pushnumber(L, z);
	lua_setfield(L, -2, "z");
	lua_pushnumber(L, w);
	lua_setfield(L, -2, "w");

	setmetatable(L, -2, MT_VEC4);
}

LUA_API void luaS_checkVector3(lua_State *L, int p, float* x, float *y, float *z) {
	luaL_checktype(L, p, LUA_TTABLE);
	lua_getfield(L, p, "x");
	*x = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "y");
	*y = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "z");
	*z = (float)lua_tonumber(L, -1);
	lua_pop(L, 3);
}

LUA_API void luaS_pushVector3(lua_State *L, float x, float y, float z) {
	lua_newtable(L);
	lua_pushnumber(L, x);
	lua_setfield(L, -2, "x");
	lua_pushnumber(L, y);
	lua_setfield(L, -2, "y");
	lua_pushnumber(L, z);
	lua_setfield(L, -2, "z");


	setmetatable(L, -2, MT_VEC3);
}

LUA_API void luaS_checkVector2(lua_State *L, int p, float* x, float *y) {
	luaL_checktype(L, p, LUA_TTABLE);
	lua_getfield(L, p, "x");
	*x = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "y");
	*y = (float)lua_tonumber(L, -1);
	lua_pop(L, 2);
}

LUA_API void luaS_pushVector2(lua_State *L, float x, float y) {
	lua_newtable(L);
	lua_pushnumber(L, x);
	lua_setfield(L, -2, "x");
	lua_pushnumber(L, y);
	lua_setfield(L, -2, "y");

	setmetatable(L, -2, MT_VEC2);
}

LUA_API void luaS_checkQuaternion(lua_State *L, int p, float* x, float *y, float *z, float* w) {
	luaL_checktype(L, p, LUA_TTABLE);
	lua_getfield(L, p, "x");
	*x = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "y");
	*y = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "z");
	*z = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "w");
	*w = (float)lua_tonumber(L, -1);
	lua_pop(L, 4);
}

LUA_API void luaS_checkColor(lua_State *L, int p, float* x, float *y, float *z, float* w) {
	luaL_checktype(L, p, LUA_TTABLE);
	lua_getfield(L, p, "r");
	*x = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "g");
	*y = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "b");
	*z = (float)lua_tonumber(L, -1);
	lua_getfield(L, p, "a");
	*w = (float)lua_tonumber(L, -1);
	lua_pop(L, 4);
}

LUA_API void luaS_pushQuaternion(lua_State *L, float x, float y, float z, float w) {
	lua_newtable(L);
	lua_pushnumber(L, x);
	lua_setfield(L, -2, "x");
	lua_pushnumber(L, y);
	lua_setfield(L, -2, "y");
	lua_pushnumber(L, z);
	lua_setfield(L, -2, "z");
	lua_pushnumber(L, w);
	lua_setfield(L, -2, "w");

	setmetatable(L, -2, MT_Q);
}

LUA_API void luaS_pushColor(lua_State *L, float x, float y, float z, float w) {
	lua_newtable(L);
	lua_pushnumber(L, x);
	lua_setfield(L, -2, "r");
	lua_pushnumber(L, y);
	lua_setfield(L, -2, "g");
	lua_pushnumber(L, z);
	lua_setfield(L, -2, "b");
	lua_pushnumber(L, w);
	lua_setfield(L, -2, "a");

	setmetatable(L, -2, MT_COLOR);
}



static void setelement(lua_State* L, int p, float v, const char* key) {
	if (!isnan(v)) {
		lua_pushstring(L, key);
		lua_pushnumber(L, v);
		lua_settable(L, p);
	}
}


LUA_API void luaS_setData(lua_State *L, int p, float x, float y, float z, float w) {
	setelement(L, p, x, "x");
	setelement(L, p, y, "y");
	setelement(L, p, z, "z");
	setelement(L, p, w, "w");
}

LUA_API void luaS_setColor(lua_State *L, int p, float x, float y, float z, float w) {
	setelement(L, p, x, "r");
	setelement(L, p, y, "g");
	setelement(L, p, z, "b");
	setelement(L, p, w, "a");
}

static void cacheud(lua_State *l, int index, int cref) {
	lua_rawgeti(l, LUA_REGISTRYINDEX, cref);
	lua_pushvalue(l, -2);
	lua_rawseti(l, -2, index);
	lua_pop(l, 1);
}


LUA_API void luaS_pushobject(lua_State *l, int index, const char* t, int gco, int cref) {
	luaS_newuserdata(l, index);
	if (gco) cacheud(l, index, cref);


	luaL_getmetatable(l, t);
	if (lua_isnil(l, -1))
	{
		lua_pop(l, 1);
		luaL_getmetatable(l, "LuaVarObject");
	}

	lua_setmetatable(l, -2);
}

LUA_API int luaS_getcacheud(lua_State *l, int index, int cref) {
	lua_rawgeti(l, LUA_REGISTRYINDEX, cref);
	lua_rawgeti(l, -1, index);
	if (!lua_isnil(l, -1))
	{
		lua_remove(l, -2);
		return 1;
	}
	lua_pop(l, 2);
	return 0;
}

LUA_API int luaS_subclassof(lua_State *l, int p, const char* t) {
	
  const char* tname;
  int ok;
  int top = lua_gettop(l);

	lua_pushvalue(l, p);
	while (lua_istable(l, -1))
	{
		lua_pushstring(l, "__base");
		lua_rawget(l, -2);
	}

	if (lua_isnil(l, -1)) {
		lua_settop(l, top);
		return 0;
	}

	if (t != NULL) {
		lua_getmetatable(l, -1);
		lua_getfield(l, -1, "__typename");
		tname = lua_tostring(l, -1);
		ok = strcmp(tname, t);
		lua_settop(l, top);
		return ok == 0;
	}
	return 1;
}


#if LUA_VERSION_NUM>=502
LUALIB_API int luaS_rawlen(lua_State *L, int idx)
{
	size_t ret = lua_rawlen(L, idx);
	return (int)ret;
}
#else
LUALIB_API int luaS_objlen(lua_State *L, int idx)
{
	size_t ret = lua_objlen(L, idx);
	return (int)ret;
}
#endif


LUALIB_API void  luaS_pushlstring(lua_State *L, const char *s, int l)
{
	lua_pushlstring(L, s, (size_t)l);
}

LUALIB_API int luaLS_loadbuffer(lua_State *L, const char *buff, int sz, const char *name)
{
	return luaL_loadbuffer(L, buff, (size_t)sz, name);
}

