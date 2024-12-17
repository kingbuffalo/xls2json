package util

import (
	"sort"
	"strings"
	"testing"
)

func TestReplace(t *testing.T) {
	replaceArr := []string{
		"aa", "2",
		"a", "1",
	}
	rp := strings.NewReplacer(replaceArr...)
	str := "aa"
	str = rp.Replace(str)
	_ = str

	xx := []string{"aa", "a"}
	sort.Slice(xx, func(i, j int) bool { return xx[i] > xx[j] })
	_ = xx
}
