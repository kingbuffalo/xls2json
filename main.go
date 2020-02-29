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
var defalutInt = "0"
var defalutStr = ""
var defalutJson = "[]"

func isAllCellEmpty([]xxx cells) {
	for _,v := range(cells){
		if len(v.String()) > 0{
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

func getEnumConstF(path, rootPath string) *strings.Replacer {
	fn := path + "enumConst.xlsx"
	xlFile, err := xlsx.OpenFile(fn)
	if err != nil {
		panic(err)
	}
	var keys []string
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
	lines := make([]string, 0)
	//clines := make([]string, len(enumNameMapType))
	ckinglines := make([]string, 0)
	for _, k := range keys {
		v := enumNameMapValue[k]
		t := enumNameMapType[k]
		des := ";//" + enumNameMapDesc[k]
		vstr := v
		if t == "string" {
			vstr = "\"" + v + "\""
		}
		str := k + " " + t + " = " + vstr
		//str := k + " = " + vstr
		lines = append(lines, str)
		//clines[i] = "\"" + k + "\" : " + vstr
		//ckinglines[i] = "public static " + k + "= " + vstr + des
		ckstr := "public static " + k + "= " + vstr + des
		ckinglines = append(ckinglines, ckstr)

		//public static TAR_IDX_SELF= 1
		//"TAR_IDX_TEAMER_PLATFORM" : 2,

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

	c_kingEqStr := strings.Join(ckinglines, "\n")
	c_kingEqStr = "class EnumConst{\n" + c_kingEqStr + "\n}"

	//c_allEqStr := strings.Join(clines, ",\n")
	//c_allEqStr = ` class EnumConst {
	//public static ConstValue = {
	//` + c_allEqStr + `
	//}
	//}`
	c_kingjsonPf := rootPath + "goenum/kingEnumConst.ts"
	if err := ioutil.WriteFile(c_kingjsonPf, []byte(c_kingEqStr), 0644); err != nil {
		panic(err)
	}
	//c_jsonPf := rootPath + "goenum/enumConst.ts"
	//if err := ioutil.WriteFile(c_jsonPf, []byte(c_allEqStr), 0644); err != nil {
	//panic(err)
	//}

	c_jsonPf := rootPath + "goenum/enumConst.ts"
	if err := ioutil.WriteFile(c_jsonPf, []byte(c_kingEqStr), 0644); err != nil {
		panic(err)
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
							oneLine := make([]string, len(row.Cells))
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
	readOtherF(r, path, rootPath)
}
