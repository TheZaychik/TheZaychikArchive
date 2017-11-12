library libr_rezmas;

{$mode objfpc}{$H+}

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Grids, Interfaces;
type dvmas = array [1..15,1..15] of integer;
type mas = array of integer;
procedure rezmas_bin(var rez:mas; var n,m:integer; var s2 :TStringGrid; var fname:string);
 var a:dvmas;
 var i,j,k:integer;
 var tf :File;

 begin
  AssignFile(tf,fname);
  Reset(tf,1);
  k:=0;
  setlength(rez,1);
  for i:=1 to n do
    begin
   for j:=1 to m do
       begin
       Blockread(tf,a[i,j],sizeof(integer));
       end;
    end;
  for i:=1 to n do
    begin
   for j:=1 to m do
       begin
        if(a[i,j] mod 2 <> 0) then
         begin
          rez[k]:= a[i,j];
          k:= k+1;
          setlength(rez,k+1);
         end;
       end;
    end;
  with s2 do
  begin
    for i:=low(rez) to high(rez) do
     begin
       cells[0,i]:= inttostr(i);
       cells[1,i]:= inttostr(rez[i]);
       rowcount:= rowcount + 1;
      end;
    rowcount:= rowcount - 1;
    end;
  Closefile(tf);
  end;
exports rezmas_bin;
begin
end.

