cd /home/cds/work/xls2json/examplePoj/excel
rm *.xlsx
sleep 1
cd /home/cds/work/svn/document/导表/excelEx
svn up
sleep 1
cp /home/cds/work/svn/document/导表/excelEx/*.xlsx /home/cds/work/xls2json/examplePoj/excel/
cd /home/cds/work/xls2json
./main examplePoj
cp /home/cds/work/xls2json/examplePoj/json/*.json /home/cds/work/svn/document/导表/jsondata/
cp /home/cds/work/xls2json/examplePoj/goenum/enumConst.go /home/cds/work/svn/document/导表/jsondata/
cp /home/cds/work/xls2json/examplePoj/goenum/enumConst.ts /home/cds/work/svn/document/导表/jsondata/
cd /home/cds/work/svn/document/导表/jsondata/
svn add *
svn ci -m 'json'

