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

    class SLuaDebug : LuaObject
    {
#if UNITY_EDITOR
        static string script = @"
do
    local xpcall=xpcall
    Slua=Slua or {}
    rawset(Slua,'ldb',{})

    local function print(str)
    	outputConsole(str)
    end

    local function error(str)
    	outputConsole(str)
    end

    local function buildEnv()
		local localEnv = setmetatable({}, {__index=_G})
		local setVariable = _G
		local env = setmetatable({}, {__index=localEnv, __newindex=setVariable})
		return env
	end

    local visited = nil
	function prettyTabToStr(tab, level, path)
		local result = ''
		if level == nil then
			visited = {}
			level = 0
			path = '(self)'
		end

		if visited[tab] then
			return string.format( '%s%s\n', string.rep('\t', level), visited[tab] )
		end
		visited[tab] = path

		result = result .. string.format('%s{\n', string.rep('\t', level))
		local ignore = {}
		for i,v in ipairs(tab)do
			ignore[i] = true
			if type(v) == 'table' then
				local newPath = path .. '.' .. tostring(k)
				if visited[v] then
					local existPath = visited[v]
					local _,count1 = string.gsub(existPath, '%.', function()end)
					local _,count2 = string.gsub(newPath, '%.', function()end)
					if count2 < count1 then
						visited[v] = newPath
					end
					result = result .. string.format('%s%s\n', string.rep('\t', level+1), visited[v])
				else
					result = result .. string.format('%s\n', string.rep('\t', level+1))
					result = result .. prettyTabToStr(v, level+1, newPath)
				end
			else
				result = result .. string.format('%s%s,\n', string.rep('\t', level+1), tostring(v))
			end
		end
		for k,v in pairs(tab)do
			if not ignore[k] then
				local typeOfKey = type(k)
				local kStr = k
				if typeOfKey == 'string' then
					if not k:match('^[_%a][_%w]*$') then
						kStr = '[\'' .. k .. '\'] = '
					else
						kStr = tostring(k) .. ' = '
					end
				else
					kStr = string.format('[%s] = ', tostring(k))
				end

				if type(v) == 'table' then
					local newPath = path .. '.' .. tostring(k)
					if visited[v] then
						local existPath = visited[v]
						local _,count1 = string.gsub(existPath, '%.', function()end)
						local _,count2 = string.gsub(newPath, '%.', function()end)
						if count2 < count1 then
							visited[v] = newPath
						end
						result = result .. string.format('%s%s%s\n', string.rep('\t', level+1), tostring(kStr), visited[v])
					else
						result = result .. string.format('%s%s\n', string.rep('\t', level+1), tostring(kStr))
						result = result .. prettyTabToStr(v, level+1, newPath)
					end
				else
					result = result .. string.format('%s%s%s,\n', string.rep('\t', level+1), tostring(kStr), tostring(v))
				end
			end
		end
		result = result .. string.format('%s}\n', string.rep('\t', level))
		return result
	end

    local function printVar(value)
		local tstr = type(value)
		if tstr == 'table' then
			print( prettyTabToStr(value) )
		elseif tstr == 'userdata' then
			print(value)
		else
			print(tostring(value))
		end
	end

    local function compile(str,env)
        if loadstring then
			local func,err = loadstring(str,'=console')
			if not func then
				return func,err
			end
			setfenv(func, env)
            return func,err
        else
            local func,err = load(str,'@console','t',env)
            return func,err
        end
    end

    function Slua.ldb.printExpr(value)
		local env = buildEnv()
		if value:match('^[_%a][_%w]*$') then
			local matchvalue = env[value]
			printVar(matchvalue)

		else
			xpcall(function()

                local env = buildEnv()
                local iscmd=false
                local func,err = compile('return '..value,env)
                if not func then
			        func,err = compile(value,env)
                    iscmd=true
		        end

		        if not func then
			        error(err)
			        return
		        end
                
		        local result={func()}
                if not iscmd then 
                    if #result==0 then
                        printVar(nil) 
                    elseif #result==1 then
                        printVar(result[1])
                    else
                        printVar(result)
                    end
                end

			end,
			function(err)
				error( err )
			end)

		end
	end

    
    
end
";
#endif

        public static void reg(IntPtr l)
        {
#if UNITY_EDITOR
            // lua console only be available in editor
            if (LuaDLL.luaL_dostring(l, script) != 0)
            {
                lastError(l);
                return;
            }
#endif
        }
    }
}
