local function main()
	local jsonP = arg[1]
	local jsonFn = arg[2]
	local luaP = arg[3]
	local f = io.open(jsonP..jsonFn,"r")
	local fnPrefix = string.sub(jsonFn,0,#jsonFn-5)
	if fnPrefix == "enumConst" then
		return 
	end
	local str = f:read("*a")
	f:close()
	local json = require("json")
	local t = json.decode(str)
	local serpent = require("serpent")
	local str = serpent.dump(t)
	f = io.open(luaP..fnPrefix..".lua","w")
	f:write(str)
	f:flush()
	f:close()
end

main()
