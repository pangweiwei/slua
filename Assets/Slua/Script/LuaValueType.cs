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

using System;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    class LuaValueType
    {
        static string code = @"
local sqrt=math.sqrt
local rawget=rawget
local sub=string.sub
local acos=math.acos
local sin=math.sin
local cos=math.cos
local error=error
local assert = assert
local debug = debug

---------------------------------------------------CommMath-------------------------------
local PI=3.14159265358979
math.pi = PI
local Deg2Rad=PI*2/360
local Rad2Deg=1/Deg2Rad

local function clamp(v,min,max)
	if v<min then return min end
	if v>max then return max end
	return v
end

---------------------------------------------------Vector3--------------------------------

Vector3_mt={}
Vector3={}

local Vector3=Vector3

local FreeVector3={}
local Vector3_mt=Vector3_mt
local setmetatable=setmetatable
function Vector3Create(x,y,z)
	-- if #FreeVector3>0 then
	-- 	local v=FreeVector3[#FreeVector3]
	-- 	FreeVector3[#FreeVector3]=nil
	-- 	v.x,v.y,v.z=x,y,z
	-- 	setmetatable(v,Vector3_mt)
	-- 	return v
	-- else
		local v={}
		v.x,v.y,v.z=x,y,z
		v.__typename='Vector3'
		setmetatable(v,Vector3_mt)
		return v
	--end
end

local function isFun(name)
	local c=sub(name,1,1)
	if c>='A' and c<='Z' then
		return true
	end
	return false
end

local Vector3Create=Vector3Create
function Vector3_mt.__call(t,x,y,z)
	return Vector3Create(x,y,z)
end

function Vector3_mt.__index( t,k )
	local fun = rawget(Vector3_mt,k)
	if isFun(k) then
		return fun
	else
		if fun then
			return fun(t)
		else
			error('Can not find '..k..debug.traceback())
		end
	end
end

function Vector3_mt.__gc(v)
	--FreeVector3[#FreeVector3+1]=v
end

function Vector3_mt.__add(a,b)
	return Vector3(a.x+b.x,a.y+b.y,a.z+b.z)
end

function Vector3_mt.__div(a,b)
	return Vector3(a.x/b,a.y/b,a.z/b)
end

function Vector3_mt.__sub(a,b)
	return Vector3(a.x-b.x,a.y-b.y,a.z-b.z)
end

function Vector3_mt.__mul(a,b)
	return Vector3(a.x*b,a.y*b,a.z*b)
end

function Vector3_mt.__eq(a,b)
	return a.x==b.x and a.y==b.y and a.z==b.z
end

function Vector3_mt.__unm(a)
	return Vector3(-a.x, -a.y, -a.z)
end

function Vector3_mt.Normalize(t)
	local n = Vector3.Normalize(t)
	t.x = n.x
	t.y = n.y
	t.z = n.z
end

function Vector3_mt.Magnitude(t)
	return Vector3.Magnitude(t)
end

function Vector3_mt.SqrMagnitude(t)
	return Vector3.SqrMagnitude(t)
end

function Vector3_mt.magnitude( t )
	return Vector3.Magnitude(t)
end


function Vector3_mt.normalized(t)
	return Vector3.Normalize(t)
end

function Vector3.Distance(a,b)
	return sqrt((a.x-b.x)^2+(a.y-b.y)^2+(a.z-b.z)^2)
end

setmetatable(Vector3,Vector3_mt)


Vector3.zero=Vector3(0,0,0)
Vector3.one=Vector3(1,1,1)
Vector3.up=Vector3(0,1,0)
Vector3.right=Vector3(1,0,0)
Vector3.forward=Vector3(0,0,1)
Vector3.down=Vector3(0,1,0)
Vector3.kEpsilon=0.00001

function Vector3.Magnitude( t )
	return sqrt(t.x*t.x+t.y*t.y+t.z*t.z)
end

function Vector3.SqrMagnitude(t)
	return t.x*t.x+t.y*t.y+t.z*t.z
end

function Vector3.Normalize(t)
	local mag = Vector3.Magnitude(t)
	if mag>Vector3.kEpsilon then
		return t/mag
	else
		return Vector3(0,0,0)
	end
end

function Vector3.Cross(a,b)
	return Vector3 (
		a.y * b.z - a.z * b.y,
		a.z * b.x - a.x * b.z,
		a.x * b.y - a.y * b.x)
end

function Vector3.Dot(a,b)
	return a.x*b.x+a.y*b.y+a.z*b.z
end

function Vector3.Project(a,b)
	local sqrMag = Vector3.Dot(b,b)
	if sqrMag<Vector3.kEpsilon then
		return Vector3(0,0,0)
	else
		return b*Vector3.Dot(a,b)/sqrMag
	end
end

function Vector3.Lerp(a,b,t)
	local dx = b.x - a.x
	local dy = b.y - a.y
	local dz = b.z - a.z
	return Vector3( a.x+t*dx, a.y+t*dy, a.z+t*dz )
end

function Vector3.Clone(v3)
	return Vector3(v3.x,v3.y,v3.z)
end

function Vector3.Angle(a,b)
	return acos(clamp(Vector3.Dot(a.normalized,b.normalized),-1,1))*Rad2Deg
end

";
        static internal void init(IntPtr l) {

            if (LuaDLL.luaL_dostring(l, code) != 0)
            {
                string err = LuaDLL.lua_tostring(l, -1);
                Debug.LogError(err);
            }
        }
    }
}
