package util

import (
	"os"
	"sort"
	"strings"

	"github.com/tealeg/xlsx"
)

var enumNameMapValue map[string]string
var enumNameMapType map[string]string
var enumNameMapDesc map[string]string
var keys []string

func GetEnumConstF(path string) *strings.Replacer {
	fn := path + "enumConst.xlsx"
	xlFile, err := xlsx.OpenFile(fn)
	if err != nil {
		panic(err)
	}
	if len(xlFile.Sheets) == 0 {
		panic("no sheet")
	}
	sheet := xlFile.Sheets[0]
	enumNameMapValue = make(map[string]string, 0)
	enumNameMapType = make(map[string]string, 0)
	enumNameMapDesc = make(map[string]string, 0)

	d := sheet.Rows[1:]
	keys = make([]string, 0)
	for _, row := range d {
		if len(row.Cells) > 0 {
			key := row.Cells[0].String()
			enumNameMapValue[key] = row.Cells[2].String()
			enumNameMapType[key] = row.Cells[1].String()
			enumNameMapDesc[key] = row.Cells[3].String()
			keys = append(keys, key)
		} else {
			break
		}
	}

	pairArr := [][]string{}
	for k, v := range enumNameMapValue {
		pairArr = append(pairArr, []string{k, v})
	}
	sort.Slice(pairArr, func(i, j int) bool {
		return pairArr[i][0] > pairArr[j][0]
	})
	replaceArr := []string{}
	for _, v := range pairArr {
		replaceArr = append(replaceArr, v[0])
		replaceArr = append(replaceArr, v[1])
	}
	ret := strings.NewReplacer(replaceArr...)
	return ret
}

func WriteLua(rootPath string) {
	lines := make([]string, 0)
	for _, k := range keys {
		v := enumNameMapValue[k]
		t := enumNameMapType[k]
		des := "--" + enumNameMapDesc[k]
		vstr := v
		if t == "string" {
			vstr = "\"" + v + "\""
		}
		str := k + " = " + vstr + "," + des
		lines = append(lines, str)
	}
	allEqStr := strings.Join(lines, "\n")
	allEqStr = `local M = {
` + allEqStr + `
}
return M`

	jsonPf := rootPath + "goenum/cfgEnumConst.lua"
	if err := os.WriteFile(jsonPf, []byte(allEqStr), 0644); err != nil {
		panic(err)
	}
}

func WriteGo(rootPath string) {
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
	if err := os.WriteFile(jsonPf, []byte(allEqStr), 0644); err != nil {
		panic(err)
	}
}

func WriteCs(rootPath string) {
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
	if err := os.WriteFile(c_kingjsonPf, []byte(c_kingEqStr), 0644); err != nil {
		panic(err)
	}
}

func WriteTs(rootPath string) {
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
	if err := os.WriteFile(c_kingjsonPf, []byte(c_kingEqStr), 0644); err != nil {
		panic(err)
	}
}
