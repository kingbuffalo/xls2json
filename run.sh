#!/bin/bash

./main examplePoj
dir=$(ls examplePoj/json | grep .json )
for jsonf in $dir
do
	lua json2lua.lua examplePoj/json/ $jsonf examplePoj/lua/
	#break
done
