library libr_summ_otr;

{$mode objfpc}{$H+}

uses
Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
Grids, Interfaces;
type dvmas = array [1..15,1..15] of integer;
function summ_otr(a:dvmas; n,m:integer; fname:string):integer;
var i,j,zps:integer;
var tf :TextFile;
 begin
  AssignFile(tf,fname);
  Append(tf);
  summ_otr:= 0;
    for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        if(a[i,j] < 0) then
           summ_otr:= summ_otr + a[i,j];
       end;
    end;
    writeln(tf,'Сумма отрицательных чисел = ' + inttostr(summ_otr));
    closefile(tf);
 end;
exports summ_otr;
begin
end.

