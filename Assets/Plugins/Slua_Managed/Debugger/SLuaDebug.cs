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
        static string script = @"
do
    local xpcall=xpcall
    Slua=Slua or {}
    rawset(Slua,'ldb',{})

	local Bps={}
	local stepOverDepth = nil
	local stackDepth = 0
	local breakMode = false
	local baseStack = 7

    local function print(str)
    	outputConsole(str)
    end

    local function error(str)
    	outputConsole(str)
    end

	local function closeDebug()
		debug.sethook(nil)
	end

	local function getCallDepth()
		local deep = 2
		local info = nil
		repeat 
			info = debug.getinfo(deep)
			if info then
				deep = deep + 1
			end
		until not(info)
		return deep - 2
	end

	function Slua.ldb.delBreakPoint(index)
		Bps[index] = nil
		if not next(Bps) then
			closeDebug()
		end
	end

	function Slua.ldb.clearBreakPoint()
		breakMode = false
		stepOverDepth = nil
		Bps = {}
		closeDebug()
	end

	function Slua.ldb.showBreakPointList()
		print('break points:')
		for i,v in pairs(Bps)do
			print( string.format('#%d\t%s:%d', i, v.fileName, v.line) )
		end
	end

	function Slua.ldb.stepOver()
		stepOverDepth = stackDepth
	end

	function Slua.ldb.stepIn()
		stepOverDepth = nil
	end

	function Slua.ldb.continue()
		breakMode = false
		stepOverDepth = nil
	end

	function Slua.ldb.bt()
		local tb = debug.traceback('Traceback:',baseStack)
		tb = string.gsub(tb,'\n','\r\n')
		print( tb )
	end

    local function buildEnv()
		local localEnv = setmetatable({}, {__index=_G})
		local setVariable = _G
		if breakMode then
			local level
			if jit then
				level = getCallDepth() - stackDepth + 2
			else
				level = baseStack
			end
			local upvalueIndex = {}
			--copy upvalue
			local info = debug.getinfo(level)
			if info then
				local clouse = info.func
				local i = 1
				while true do
					local varname,varvalue = debug.getupvalue(clouse, i)
					if not varname then
						break
					end
					localEnv[varname] = varvalue
					upvalueIndex[varname] = i
					i = i + 1
				end
			end
			local localIndex = {}
			--copy local var
			local i = 1
			while true do
				local varname,varvalue = debug.getlocal(level, i)
				if not varname then
					break
				end
				localEnv[varname] = varvalue
				localIndex[varname] = i
				i = i + 1
			end

			setVariable = function(t, k, v)
				local i = upvalueIndex[k]
				if i then
					local name = debug.setupvalue(clouse, i, v)
					print(string.format('set upvalue %s = %s', name, tostring(v)))
					return
				end

				i = localIndex[k]
				if i then
					local name = debug.setlocal(level+1, i, v)
					print(string.format('set local %s = %s', name, tostring(v)))
					return
				end

				_G[k] = v
				print(string.format('set global %s = %s', k, tostring(v)))
			end
		end
		local env = setmetatable({}, {__index=localEnv, __newindex=setVariable})
		return env
	end

    local visited = nil
	local function prettyTabToStr(tab, level, path)
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
			print(tostring(value))
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

	local lastbl=nil
	local lastmd5=nil

	local function fileMatch(v,md5,source)
		if md5 and v.fileMd5 then
			return v.fileMd5 == md5 or v.fileName==source
		elseif v.fileName then
			return v.fileName==source
		else
			return false
		end
	end

	local function checkLineBp(info,source,line) 
		if not breakMode then
			source=string.lower(source)
			local md5=LuaDebugger.md5(source)
			for i,v in ipairs(Bps)do
				if fileMatch(v,md5,source) and v.line == line then
					breakMode = true
					lastbl=line
					lastmd5=md5
					stepOverDepth = nil
					LuaDebugger.onBreak(source,info.currentline,lastmd5)
				end
			end
		elseif not(stepOverDepth) or stepOverDepth >= stackDepth then
			if line~=lastbl then
				LuaDebugger.onBreak(source,info.currentline,lastmd5)
				lastbl=line
			end
		end
	end

	local function onJitHook(event, line, count)
		stackDepth = getCallDepth()
		local info = debug.getinfo(2)

		local cfun = (info.what == 'C')
		if cfun then
			return
		end

		local source = info.source
		if source:sub(1,1) ~= '@' then
			return
		end
		source = string.sub(source, 2)
		checkLineBp(info,source,line)
	end

	local function onNormalHook(event, line, count)
		local info = debug.getinfo(2)

		local cfun = (info.what == 'C')
		if cfun then
			return
		end

		local source = info.source
		if source:sub(1,1) ~= '@' then
			return
		end
		source = string.sub(source, 2)

		if event == 'line' then
			checkLineBp(info,source,line)
		elseif event == 'call' or event == 'tail call' and not(breakMode) then
			stackDepth = stackDepth + 1
		elseif event == 'return' or event == 'tail return' and not(breakMode) then
			stackDepth = stackDepth - 1
			if stackDepth < 0 then
				stackDepth = 0
			end
		end
	end

	local function openDebug()
		stepOverDepth = nil
		stackDepth = 0
		if jit then
			debug.sethook(onJitHook,'l')
		else
			debug.sethook(onNormalHook,'lrc')
		end
	end

	function Slua.ldb.bp()
		if not LuaDebugger.isRemoteClient then
			return
		end
		local info = debug.getinfo(2)
		if not info then
			return
		end
		openDebug()
		stepOverDepth = stackDepth+1
		breakMode = true
	end

	function Slua.ldb.watch()
		local level
		if jit then
			level = getCallDepth() - stackDepth + 2
		else
			level = baseStack
		end

		--show upvalue
		print('upvalue:')
		local info = debug.getinfo(level)
		if info then
			local clouse = info.func
			local i = 1
			while true do
				local varname,varvalue = debug.getupvalue(clouse, i)
				if not varname then
					break
				end
				print(varname, varvalue)
				i = i + 1
			end
		end
		--show local var
		print('local:')
		local i = 1
		while true do
			local varname,varvalue = debug.getlocal(level, i)
			if not varname then
				break
			end
			print(varname, varvalue)
			i = i + 1
		end
	end


	function Slua.ldb.addBreakPoint(fn,line)
		table.insert(Bps,{fileName=string.lower(fn),line=line})
		if not debug.gethook() then openDebug() end
	end

	function Slua.ldb.addBreakPointMD5(md5,line)
		table.insert(Bps,{fileMd5=string.lower(md5),line=line})
		if not debug.gethook() then openDebug() end
	end
		

    function Slua.ldb.printExpr(value)
		local env = buildEnv()
		if value:match('^[_%a][_%w]*$') then
			local matchvalue = env[value]
			printVar(matchvalue)
			return true,''
		else
			local ok,err=pcall(function()

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

			end)
			
			return ok,err
		end
	end

	function Slua.ldb.setOutput(output)
		print=output
		error=output
	end	
end
";

        public static void reg(IntPtr l)
        {
			LuaState L = LuaState.get(l);
			L.doString(script);
        }
    }
}
