function hook()
end


local function f()
end

--debug.sethook(hook,"c" )

local s = os.clock()
for i=1,1000000 do
    f()
end
print("time:",os.clock()-s)
