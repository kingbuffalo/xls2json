package main

import (
	"fmt"
	"os"
	"strings"
	"xls2json/util"

	"github.com/tealeg/xlsx"
)

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

func readOtherF(r *strings.Replacer, path, rootPath string) {
	files, err := os.ReadDir(path)
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
						var fldNames = make([]string, 0)
						for _, v := range keyNames_orig {
							vstr := v.String()
							if len(vstr) > 0 {
								fldNames = append(fldNames, vstr)
							} else {
								break
							}
						}
						keyNameLen := len(fldNames)
						types := sheet.Rows[2].Cells
						checkCells := sheet.Rows[3].Cells
						checkMap := make(map[string]string)
						for i, v := range checkCells {
							vstr := v.String()
							if len(vstr) > 0 {
								checkMap[fldNames[i]] = vstr
							}
						}
						checkStr := ""
						for k, v := range checkMap {
							checkStr += "\"" + k + "\":\"" + v + "\","
						}
						data := sheet.Rows[4:]
						lines := make([]string, 0)
						var preLine []string = nil
						for _, row := range data {
							oneLine := make([]string, keyNameLen)
							if isAllCellEmpty(row.Cells) {
								break
							}
							for i, cell := range row.Cells {
								if i < keyNameLen {
									key := fldNames[i]
									ty := types[i].String()
									cellStr := cell.String()
									if len(cellStr) == 0 {
										oneLine[i] = preLine[i]
									} else {
										value := getValue(cellStr, ty)
										if ty == "s" || ty == "string" {
											value = "\"" + value + "\""
										}
										key = "\"" + key + "\""
										cellStr := key + ":" + value
										oneLine[i] = cellStr
									}
								} else {
									break
								}
							}
							str := strings.Join(oneLine, ",")
							//fmt.Println("str",str)
							preLine = oneLine[:]
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
						if err := os.WriteFile(jsonPf, []byte(allFlieStr), 0644); err != nil {
							panic(err)
						}

						if len(checkStr) > 0 {
							checkPf := rootPath + "json/" + jsonFn + "_check.json"
							checkPFStr := "{" + checkStr + "}"
							if err := os.WriteFile(checkPf, []byte(checkPFStr), 0644); err != nil {
								panic(err)
							}
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
	r := util.GetEnumConstF(path)
	util.WriteGo(rootPath)
	util.WriteTs(rootPath)
	util.WriteCs(rootPath)
	util.WriteLua(rootPath)
	readOtherF(r, path, rootPath)
}
