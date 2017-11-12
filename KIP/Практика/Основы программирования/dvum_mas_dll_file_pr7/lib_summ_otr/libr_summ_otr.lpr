library libr_summ_otr;

{$mode objfpc}{$H+}

uses
Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
Grids, Interfaces;
type dvmas = array [1..15,1..15] of integer;
function summ_otr_bin(a:dvmas; n,m:integer; fname:string):integer;
var i,j:integer;
var tf :File;
 begin
  AssignFile(tf,fname);
  Reset(tf,1);
  summ_otr_bin:= 0;
    for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        if(a[i,j] < 0) then
           summ_otr_bin:= summ_otr_bin + a[i,j];
       end;
    end;
    blockwrite(tf,summ_otr_bin,sizeof(integer));
    closefile(tf);
 end;
exports summ_otr_bin;
begin
end.

