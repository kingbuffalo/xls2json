cd /home/cds/work/xls2json/examplePojTest/excel
rm *.xlsx
cd /home/cds/work/svn/document/导表/excelTest
svn up
cp /home/cds/work/svn/document/导表/excelTest/*.xlsx /home/cds/work/xls2json/examplePojTest/excel/
cd /home/cds/work/xls2json
./main examplePojTest
cp /home/cds/work/xls2json/examplePojTest/json/*.json /home/cds/work/svn/document/导表/jsondataTest/
cp /home/cds/work/xls2json/examplePojTest/goenum/enumConst.go /home/cds/work/svn/document/导表/jsondataTest/
cp /home/cds/work/xls2json/examplePojTest/goenum/enumConst.ts /home/cds/work/svn/document/导表/jsondataTest/
cd /home/cds/work/svn/document/导表/jsondataTest/
svn add *
svn ci -m 'json test'
