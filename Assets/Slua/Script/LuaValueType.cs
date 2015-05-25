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
    using LuaInterface;
    class LuaValueType : LuaObject
    {
        static string script = @"
local setmetatable=setmetatable
local clamp=clamp
local acos=math.acos
local sin=math.sin
local cos=math.cos
local sqrt=math.sqrt
local error=error
local min=math.min
local max=math.max
local abs=math.abs
local Time=UnityEngine.Time

local ToAngle=57.29578
local Epsilon=0.00001
local Infinite=1/0
local Sqrt2=0.7071067811865475244008443621048490
local PI=3.14159265358979323846264338327950

function clamp(v,min,max)
	return v>max and max or (v<min and min or v)
end

function  lerpf(a,b,t)
	t=clamp(t,0,1)
	return a+(b-a)*t
end

local Matrix3x3={}
UnityEngine.Matrix3x3=Matrix3x3
local T=Matrix3x3

function Matrix3x3.SetAt(m,row,col,v)
	m[row*3+col+1]=v
end

function Matrix3x3.New()
	local r={1,0,0,0,1,0,0,0,1}
	setmetatable(r,Matrix3x3)
	return r
end

function Matrix3x3.__tostring(m)
	return string.format('Matrix3x3(%f,%f,%f,%f,%f,%f,%f,%f,%f)'
		,m[1],m[2],m[3]
		,m[4],m[5],m[6]
		,m[7],m[8],m[9])
end

function Matrix3x3.SetAxisAngle(m,axis,rad)
	-- This function contributed by Erich Boleyn(erich @uruk.org) */
	-- This function used from the Mesa OpenGL code(matrix.c)  */
	local s, c
    local vx, vy, vz, xx, yy, zz, xy, yz, zx, xs, ys, zs, one_c

    s = sin(rad)
    c = cos(rad)

    vx = axis[1]
    vy = axis[2]
    vz = axis[3]

    xx = vx * vx
    yy = vy* vy
    zz = vz* vz
    xy = vx* vy
    yz = vy* vz
    zx = vz* vx
    xs = vx* s
    ys = vy* s
    zs = vz* s
    one_c = 1.0 - c
    local Set=T.SetAt
    Set(m,0,0, (one_c* xx) + c )
    Set(m,1,0, (one_c* xy) - zs)
    Set(m,2,0, (one_c* zx) + ys)
    Set(m,0,1, (one_c* xy) + zs)
    Set(m,1,1, (one_c* yy) + c )
    Set(m,2,1, (one_c* yz) - xs)
    Set(m,0,2, (one_c* zx) - ys)
    Set(m,1,2, (one_c* yz) + xs)
    Set(m,2,2, (one_c* zz) + c )
end

function Matrix3x3.Mul(m,v)
	local res = Vector3.New(0, 0, 0)
    res[1] = m[1] * v[1] + m[4] * v[2] + m[7] * v[3]
    res[2] = m[2] * v[1] + m[5] * v[2] + m[8] * v[3]
    res[3] = m[3] * v[1] + m[6] * v[2] + m[9] * v[3]
	return res
end


local Raw=UnityEngine.Vector3
local Vector3={__typename='Vector3',__raw=Raw}
_G['UnityEngine.Vector3.Instance']=Vector3
UnityEngine.Vector3=Vector3
local get={ }
        local set = { }

Vector3.__index = function(t, k)
    local f = rawget(Vector3, k)
	if f then return f end
    local f = rawget(get, k)
	if f then return f(t) end
    error('Not found '..k)
end

Vector3.__newindex = function(t, k, v)
    local f = rawget(set, k)
	if f then return f(t, v) end
     error('Not found '..k)
end


Vector3.New=function (x, y, z)
    local v = { x, y, z }
	return setmetatable(v, Vector3)
end

Vector3.__call = function(t, x, y, z)
	return Vector3.New(x,y,z)
end

Vector3.__eq = function(a, b)
	return abs(a[1]-b[1])<Epsilon
         and abs(a[2]-b[2])<Epsilon
         and abs(a[3]-b[3])<Epsilon
end

Vector3.__unm = function(a)
    local ca = Vector3.New(-a[1], -a[2], -a[3])
	return ca
end


Vector3.__tostring = function(self)
	return string.format('Vector3(%f,%f,%f)', self[1], self[2], self[3])
end

Vector3.__mul = function(a, b)
	return Vector3.New(a[1]*b,a[2]*b,a[3]*b)
end

Vector3.__add = function(a, b)
	return Vector3.New(a[1]+b[1],a[2]+b[2],a[3]+b[3])
end

Vector3.__sub = function(a, b)
	return Vector3.New(a[1]-b[1],a[2]-b[2],a[3]-b[3])
end

Vector3.__div = function(a, b)
	return Vector3.New(a[1]/b,a[2]/b,a[3]/b)
end

function Vector3.Mul(self,b)
	self[1],self[2],self[3]=self[1]*b,self[2]*b,self[3]*b
end

function Vector3.Add(self, b)
    self[1],self[2],self[3]=self[1]+b[1],self[2]+b[2],self[3]+b[3]
end

function Vector3.Sub(self, b)
    self[1],self[2],self[3]=self[1]-b[1],self[2]-b[2],self[3]-b[3]
end

function Vector3.Div(self, b)
    self[1],self[2],self[3]=self[1]/b,self[2]/b,self[3]/b
end


function get.back() return Vector3(0,0,-1) end
function get.down() return Vector3(0,-1,0) end
function get.forward() return Vector3(0,0,1) end
function get.left() return Vector3(-1,0,0) end
function get.one() return Vector3(1,1,1) end
function get.right() return Vector3(1,0,0) end
function get.up() return Vector3(0,1,0) end
function get.zero() return Vector3(0,0,0) end

function get:x() return self[1] end
function get:y() return self[2] end
function get:z() return self[3] end
function set:x(v) self[1]=v end
function set:y(v) self[2]=v end
function set:z(v) self[3]=v end
function get:magnitude() return Vector3.Magnitude(self) end
function get:sqrMagnitude() return Vector3.SqrMagnitude(self) end
function get:normalized()
    local cv = self:Clone()
    Vector3.Normalize(cv)
	return cv
end


function Vector3:Clone()
	return Vector3.New(self[1],self[2],self[3])
end

function Vector3:Set(x, y, z)
    self[1],self[2],self[3]=x or 0, y or 0,z or 0
end

function Vector3:ToString()
	return self:__tostring()
end

function Vector3.Angle(a,b)
	local dot = Dot(Vector3.Normalize(a), Vector3.Normalize(b))
	return acos()*ToAngle
end

function Vector3.Normalize(v)
    local m = Vector3.Magnitude(v)
	if m==1 then
		return v
    elseif m>Epsilon then
        v[1],v[2],v[3]=v[1]/m,v[2]/m,v[3]/m
	else
		v:Set(0,0,0)
    end
end

function Vector3.Magnitude(v)
	return sqrt(v[1]^2+v[2]^2+v[3]^2)
end

function Vector3.SqrMagnitude(v)
	return v[1]^2+v[2]^2+v[3]^2
end

function Vector3.Dot(a,b)
	return a[1]*b[1] + a[2]*b[2] + a[3]*b[3]
end

function Vector3.Cross(a, b)
	return Vector3.New((a[2] * b[3]) - (a[3] * b[2])
		, (a[3] * b[1]) - (a[1] * b[3])
		, (a[1] * b[2]) - (a[2] * b[1]))
end

function Vector3.OrthoNormalVector(n)
	local res = Vector3.New(0, 0, 0)
	if abs(n[3]) > Sqrt2 then
        local a = n[2] ^ 2 + n[3] ^ 2
        local k = 1 / sqrt(a)
        res[1],res[2],res[3] = 0,-n[3]*k,n[2]*k
	else
		local a = n[1] ^ 2 + n[2] ^ 2
        local k = 1 / sqrt(a)
        res[1],res[2],res[3] = -n[2]*k,n[1]*k,0
	end
	return res
end

-- reference code from unity
function Vector3.Slerp(a, b, t)
	if t<=0 then return Vector3.Clone(a) end
	if t>=1 then return Vector3.Clone(b) end

	-- if almost is zero
    local ma=Vector3.Magnitude(a)
	local mb = Vector3.Magnitude(b)
	if ma<Epsilon or mb<Epsilon then
		return Vector3.Lerp(a,b,t)
	end

	-- if dir is same
    local dot=Vector3.Dot(a,b)/(ma* mb)
	if dot>1-Epsilon then
		return Vector3.Lerp(a,b,t)
	
	elseif dot<-1+Epsilon then -- dirs are almost opposite
        local lerpedMagnitude = lerpf(ma, mb, t)
        local na = Vector3.__div(a, ma)
        local axis = Vector3.OrthoNormalVector(na)
        local m = Matrix3x3.New()
        Matrix3x3.SetAxisAngle(m, axis, PI* t)
        local slerped = Matrix3x3.Mul(m, na)
        Vector3.Mul(slerped,lerpedMagnitude)
		return slerped

	else -- normal case
		local lerpedMagnitude = lerpf(ma, mb, t)
        local axis = Vector3.Cross(a, b)
        local na = a / ma
        Vector3.Normalize(axis)
		local angle = acos(dot) * t
        local m = Matrix3x3.New()
        Matrix3x3.SetAxisAngle(m,axis,angle)
		local slerped = Matrix3x3.Mul(m, na)
        Vector3.Mul(slerped,lerpedMagnitude)
		return slerped
    end
end

function Vector3.Lerp(a,b,t)
	return Vector3.New(a[1]+(b[1]-a[1])*t
		,a[2]+(b[2]-a[2])*t
		,a[3]+(b[3]-a[3])*t
	)
end

function Vector3.Min(a,b)
	return Vector3.New(min(a[1], b[1])
		,min(a[2], b[2])
		,min(a[3], b[3]))
end

function Vector3.Max(a,b)
	return Vector3.New(max(a[1], b[1])
		,max(a[2], b[2])
		,max(a[3], b[3]))
end

function Vector3.MoveTowards(a,b,adv)
	local v = Vector3.__sub(b, a)
    local m = Vector3.Magnitude(v)
	if m>adv and m ~=0 then
         Vector3.Div(v, m)
        Vector3.Mul(v,adv)
		Vector3.Add(v,a)
		return v
    end
	return Vector3.Clone(b)
end

-- TODO
function Vector3.RotateTowards(a,b,angle,mag)
	return Raw.RotateTowards(a,b,angle,mag)
end

function Vector3.Distance(a,b)
	a=Vector3.Clone(a)
	Vector3.Sub(a,b)
	return Vector3.Magnitude(a)
end

function Vector3.OrthoNormalize(u,v,w)
	Vector3.Normalize(u)

	local dot0 = Vector3.Dot(u, v)
    local tu = Vector3.Clone(u)
    Vector3.Mul(tu,dot0)
	Vector3.Sub(v,tu)
	Vector3.Normalize(v)

	if w then
        local dot1 = Vector3.Dot(v, w)
        local dot0 = Vector3.Dot(u, w)
        local tw = Vector3.__mul(u, dot0)
        local tv = Vector3.__mul(v, dot1)
        Vector3.Add(tv,tw)
		Vector3.Sub(w,tv)
		Vector3.Normalize(w)
	end
end

function Vector3.Scale(a, b)
	return Vector3.New(a[1]*b[1],a[2]*b[2],a[3]*b[3])
end

-- code copy from reflactor of UnityEgnine
function Vector3.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed, deltaTime)
    local deltaTime = deltaTime or Time.deltaTime
    local maxSpeed = maxSpeed or Infinite
    smoothTime = max(Epsilon, smoothTime)
    local float num = 2 / smoothTime
    local float num2 = num * deltaTime
    local float num3 = 1 / (((1 + num2) + ((0.48 * num2) * num2)) + (((0.235 * num2) * num2) * num2))
    local vector = current - target;
        local vector2 = target
    local maxLength = maxSpeed * smoothTime
    vector = Vector3.ClampMagnitude(vector, maxLength)
    target = current - vector
    local vector3 = currentVelocity +  vector* deltaTime * num
   local newv = currentVelocity -  vector3* num3 * num
  local vector4 = target + (vector + vector3) * num3
    if Vector3.Dot(vector2 - current, vector4 - vector2) > 0 then
        vector4 = vector2
        newv = (vector4 - vector2) / deltaTime
    end
    currentVelocity:Set(newv.x, newv.y, newv.z)
    return vector4
end

-- code copy from reflactor of UnityEgnine
function Vector3.ClampMagnitude(vector, maxLength)
    if Vector3.SqrMagnitude(vector) > (maxLength^2) then
        return vector.normalized* maxLength
    end
    return Vector3.Clone(vector)
end

function Vector3.Reflect(dir,nml)
	local dot = Vector3.Dot(nml, dir) * -2
    local v = Vector3.__mul(nml, dot)
    Vector3.Add(v,dir)
	return v
end

-- code copy from reflactor of UnityEgnine
function Vector3.ProjectOnPlane(vector, planeNormal)
	return vector - Vector3.Project(vector, planeNormal)
end

-- code copy from reflactor of UnityEgnine
function Vector3.Project(vector, normal )
    local num = Vector3.Dot(normal, normal)
    if num<Epsilon then
        return Vector3.zero
    end
    return (normal* Vector3.Dot(vector, normal)) / num
end

setmetatable(Vector3, Vector3)

";
        public static void reg(IntPtr l)
        {
            if (LuaDLL.luaL_dostring(l, script) != 0)
            {
                throwLuaError(l);
                return;
            }
        }
    }
}
