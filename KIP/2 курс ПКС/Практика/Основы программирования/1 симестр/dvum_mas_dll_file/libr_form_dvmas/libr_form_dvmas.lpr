library libr_form_dvmas;

{$mode objfpc}{$H+}

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Grids, Interfaces;
type dvmas = array [1..15,1..15] of integer;
procedure form_dvmas(var a:dvmas; var n,m:integer; var s1 :TStringGrid; var fname:string);
 var i,j :integer;
 var tf :TextFile;
 begin
  AssignFile(tf,fname);
  Rewrite(tf);
  randomize;
  for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        a[i,j]:= -10 + random(55);
       end;
    end;
  for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        writeln(tf,inttostr(a[i,j]))
       end;
    end;
  CloseFile(tf);
  with s1 do
  begin
    colcount:= m + 1;
    rowcount:= n + 1;
    for i:=1 to rowcount -1 do
     cells[0,i]:= inttostr(i);
    for j:=1 to colcount -1 do
     cells[j,0]:= inttostr(j);
    for i:=1 to n do
     for j:=1 to m do
      cells[i,j]:= inttostr(a[i,j]);
  end;
end;
exports form_dvmas;
begin
end.

