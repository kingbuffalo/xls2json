package main

import (
	"net/http"
	"os/exec"
	"time"
)

var lt int64

func zjssghandle(w http.ResponseWriter, r *http.Request) {
	ct := time.Now().Unix()
	if ct-lt < 10 {
		w.Write([]byte("wait 10 seconds"))
		return
	}
	lt = ct
	c := exec.Command("/bin/sh", "cpexcel.sh")
	out, err := c.Output()
	if err != nil {
		w.Write([]byte(err.Error()))
	} else {
		w.Write(out)
	}

}

func zjssghandleTest(w http.ResponseWriter, r *http.Request) {
	ct := time.Now().Unix()
	if ct-lt < 10 {
		w.Write([]byte("wait 10 seconds"))
		return
	}
	lt = ct
	c := exec.Command("/bin/sh", "cpExcelTest.sh")
	out, err := c.Output()
	if err != nil {
		w.Write([]byte(err.Error()))
	} else {
		w.Write(out)
	}

}

func main() {
	http.HandleFunc("/", zjssghandle)
	http.HandleFunc("/test", zjssghandleTest)
	if err := http.ListenAndServe(":9999", nil); err != nil {
		panic(err)
	}
}
