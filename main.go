package main

import (
	"fmt"
	"github.com/tealeg/xlsx"
	"io/ioutil"
	"os"
	"strings"
)

var enumNameMapValue map[string]string
var enumNameMapType map[string]string
var enumNameMapDesc map[string]string
var keys []string
var defalutInt = "0"
var defalutStr = ""
var defalutJson = "[]"

func isAllCellEmpty(cells []*xlsx.Cell) bool {
	for _, v := range cells {
		if len(v.String()) > 0 {
			return false
		}
	}
	return true
}

func getValue(value, typeStr string) string {
	if len(value) > 0 {
		return value
	}
	if typeStr == "s" || typeStr == "string" {
		return defalutStr
	}
	if typeStr == "i" || typeStr == "int" {
		return defalutInt
	}
	return defalutJson
}

func writeLua(rootPath string) {
	lines := make([]string, 0)
	for _, k := range keys {
		v := enumNameMapValue[k]
		t := enumNameMapType[k]
		des := "--" + enumNameMapDesc[k]
		vstr := v
		if t == "string" {
			vstr = "\"" + v + "\""
		}
		str := k + " = " + vstr + ","+ des
		lines = append(lines, str)
	}
	allEqStr := strings.Join(lines, "\n")
	allEqStr = `local M = {
` + allEqStr + `
}
return M`

	jsonPf := rootPath + "goenum/cfgEnumConst.lua"
	if err := ioutil.WriteFile(jsonPf, []byte(allEqStr), 0644); err != nil {
		panic(err)
	}
}

func writeGo(rootPath string) {
	lines := make([]string, 0)
	for _, k := range keys {
		v := enumNameMapValue[k]
		t := enumNameMapType[k]
		des := "//" + enumNameMapDesc[k]
		vstr := v
		if t == "string" {
			vstr = "\"" + v + "\""
		}
		str := k + " " + t + " = " + vstr + des
		lines = append(lines, str)
	}
	allEqStr := strings.Join(lines, "\n")
	allEqStr = `package enumErrCode
	const (
		` + allEqStr + `
	)`

	jsonPf := rootPath + "goenum/enumConst.go"
	if err := ioutil.WriteFile(jsonPf, []byte(allEqStr), 0644); err != nil {
		panic(err)
	}
}

func writeCs(rootPath string) {
	ckinglines := make([]string, 0)
	for _, k := range keys {
		v := enumNameMapValue[k]
		t := enumNameMapType[k]
		des := ";//" + enumNameMapDesc[k]
		vstr := v
		if t == "string" {
			vstr = "\"" + v + "\""
		}
		if t == "int32" {
			t = "int"
		}
		if t == "int64" {
			t = "long"
		}
		if t == "float64" {
			t = "double"
		}
		ckstr := "\t\tpublic static " + t + " " + k + "= " + vstr + des
		ckinglines = append(ckinglines, ckstr)
	}

	c_kingEqStr := strings.Join(ckinglines, "\n")
	c_kingEqStr = "namespace game.data.autogen\n{\n\tstatic class EnumConst{\n" + c_kingEqStr + "\n}"

	c_kingjsonPf := rootPath + "goenum/EnumConst.cs"
	if err := ioutil.WriteFile(c_kingjsonPf, []byte(c_kingEqStr), 0644); err != nil {
		panic(err)
	}
}

func writeTs(rootPath string) {
	ckinglines := make([]string, 0)
	for _, k := range keys {
		v := enumNameMapValue[k]
		t := enumNameMapType[k]
		des := ";//" + enumNameMapDesc[k]
		vstr := v
		if t == "string" {
			vstr = "\"" + v + "\""
		}
		ckstr := "public static " + k + "= " + vstr + des
		ckinglines = append(ckinglines, ckstr)
	}

	c_kingEqStr := strings.Join(ckinglines, "\n")
	c_kingEqStr = "class EnumConst{\n" + c_kingEqStr + "\n}"

	c_kingjsonPf := rootPath + "goenum/kingEnumConst.ts"
	if err := ioutil.WriteFile(c_kingjsonPf, []byte(c_kingEqStr), 0644); err != nil {
		panic(err)
	}
}

func getEnumConstF(path, rootPath string) *strings.Replacer {
	fn := path + "enumConst.xlsx"
	xlFile, err := xlsx.OpenFile(fn)
	if err != nil {
		panic(err)
	}
	for _, sheet := range xlFile.Sheets {
		enumNameMapValue = make(map[string]string, 0)
		enumNameMapType = make(map[string]string, 0)
		enumNameMapDesc = make(map[string]string, 0)

		d := sheet.Rows[1:]
		keys = make([]string, 0)
		for _, row := range d {
			key := row.Cells[0].String()
			enumNameMapValue[key] = row.Cells[2].String()
			enumNameMapType[key] = row.Cells[1].String()
			enumNameMapDesc[key] = row.Cells[3].String()
			keys = append(keys, key)
		}
		break
	}

	replaceArr := []string{}
	for k, v := range enumNameMapValue {
		replaceArr = append(replaceArr, k)
		replaceArr = append(replaceArr, v)
	}
	ret := strings.NewReplacer(replaceArr...)
	return ret
}

func readOtherF(r *strings.Replacer, path, rootPath string) {
	files, err := ioutil.ReadDir(path)
	if err != nil {
		panic(err)
	}

	for _, f := range files {
		if !f.IsDir() {
			fn := path + f.Name()
			xlFile, err := xlsx.OpenFile(fn)
			if err != nil {
				panic(err)
			}
			for _, sheet := range xlFile.Sheets {
				name := sheet.Name
				if len(name) > 7 {
					prefix := name[0:7]
					if prefix == "output_" {
						keyNames_orig := sheet.Rows[1].Cells
						var keyNames = make([]string, 0)
						for _, v := range keyNames_orig {
							vstr := v.String()
							if len(vstr) > 0 {
								keyNames = append(keyNames, vstr)
							} else {
								break
							}
						}
						keyNameLen := len(keyNames)
						types := sheet.Rows[2].Cells
						data := sheet.Rows[3:]
						lines := make([]string, 0)
						for _, row := range data {
							oneLine := make([]string, keyNameLen)
							if isAllCellEmpty(row.Cells) {
								break
							}
							for i, cell := range row.Cells {
								if i < keyNameLen {
									key := keyNames[i]
									ty := types[i].String()
									value := getValue(cell.String(), ty)
									if ty == "s" || ty == "string" {
										value = "\"" + value + "\""
									}
									key = "\"" + key + "\""
									cellStr := key + ":" + value
									oneLine[i] = cellStr
								}else{
									break
								}
							}
							str := strings.Join(oneLine, ",")
							if len(str) == 0 {
								break
							}
							str = "{" + str + "}"
							lines = append(lines, str)
						}
						allFlieStr := strings.Join(lines, ",\n")
						allFlieStr = r.Replace(allFlieStr)
						allFlieStr = "[" + allFlieStr + "]"
						jsonFn := sheet.Name[7:]
						jsonPf := rootPath + "json/" + jsonFn + ".json"
						fmt.Println(jsonPf)
						if err := ioutil.WriteFile(jsonPf, []byte(allFlieStr), 0644); err != nil {
							panic(err)
						}
					}
				}
			}
		}
	}

}

func main() {
	if len(os.Args) < 1 {
		fmt.Println("need project name:eg. ./main examplePoj")
		return
	}
	projPath := os.Args[1]
	path := projPath + "/excel/"
	rootPath := projPath + "/"
	r := getEnumConstF(path, rootPath)
	writeGo(rootPath)
	writeTs(rootPath)
	writeCs(rootPath)
	writeLua(rootPath)
	readOtherF(r, path, rootPath)
}
