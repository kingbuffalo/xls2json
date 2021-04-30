local function main()
	local jsonP = arg[1]
	local jsonFn = arg[2]
	local luaP = arg[3]
	local fnPrefix = string.sub(jsonFn,0,#jsonFn-5)
	if fnPrefix == "enumConst" then
		return
	end
	if string.find(jsonFn,"_key") ~= nil then
		return
	end
	local f = io.open(jsonP..jsonFn,"r")
	local str = f:read("*a")
	f:close()
	local fldf = io.open(jsonP..fnPrefix.."_key.json","r")
	local fldStr = fldf:read("*a")
	fldf:close()

	local json = require("json")
	local t = json.decode(str)
	local fldt = json.decode(fldStr)
	local level = 1
	for lv=1,#fldt do
		local bHasEqual = false
		for i=1,#t-1 do
			local v = t[i]
			local nv = t[i+1]
			if v[fldt[lv]] == nv[fldt[lv]] then
				bHasEqual = true
				break
			end
		end
		level = lv
		if not bHasEqual then
			break
		end
	end
	local nt = {}
	for _,v in ipairs(t) do
		local levelt = nt
		for i=1,level-1 do
			local fldName = fldt[i]
			local key = v[fldName]
			local prevlevelt = levelt
			levelt = levelt[key]
			if levelt == nil then
				levelt = {}
				prevlevelt[key] = levelt
			end
		end
		levelt[v[fldt[level]]] = v
	end
	local serpent = require("serpent")
	str = serpent.dump(nt)
	f = io.open(luaP..fnPrefix..".lua","w")
	f:write(str)
	f:flush()
	f:close()
end

main()
