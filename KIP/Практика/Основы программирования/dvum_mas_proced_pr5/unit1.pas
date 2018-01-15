unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Grids;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    StringGrid1: TStringGrid;
    StringGrid2: TStringGrid;
    procedure Button1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;

implementation
 type mas = array of integer;
 type dvmas = array [1..15,1..15] of integer;

procedure vvod(var a:dvmas; n,m:integer);
 var i,j:integer;
 begin
 with form1.StringGrid1 do
  begin
    colcount:= m + 1;
    rowcount:= n + 1;
    for i:=1 to rowcount -1 do
    cells[0,i]:= inttostr(i);
    for j:=1 to colcount -1 do
    cells[j,0]:= inttostr(j);
  end;
 randomize;
  for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        a[i,j]:= -50 + random(150);
        form1.stringgrid1.cells[i,j]:= inttostr(a[i,j]);
         end;
       end;
end;

procedure rezmas(var a:dvmas;var rez:mas; var n,m:integer);
 var i,j,k:integer;
 begin
  k:=0;
  setlength(rez,1);
  for i:=1 to n do
    begin
   for j:=1 to m do
       begin
        if(a[i,j] mod 2 > 0) then
         begin
          rez[k]:= a[i,j];
          k:= k+1;
          setlength(rez,k+1);
         end;
       end;
    end;
    for i:=low(rez) to high(rez) do
     begin
       form1.stringgrid2.cells[0,i]:= inttostr(i);
       form1.stringgrid2.cells[1,i]:= inttostr(rez[i]);
       form1.stringgrid2.rowcount:= form1.stringgrid2.rowcount + 1;
      end;
     form1.stringgrid2.rowcount:= form1.stringgrid2.rowcount - 1;
end;
function kol_pol(a:dvmas; n,m:integer):integer;
var i,j:integer;
 begin
  kol_pol:=0;
    for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        if(a[i,j] > 0) then
           kol_pol:= kol_pol + 1;
       end;
    end;
 end;
procedure rezmas2(var a:dvmas;var rez:mas; var n,m:integer);
 var i,j,k, pol:integer;
 begin
  k:=0;
  setlength(rez,1);
  pol:=kol_pol(a,n,m);
  for i:=1 to n do
    begin
   for j:=1 to m do
       begin
        if(a[i,j] > pol) then
         begin
          rez[k]:= a[i,j];
          k:= k+1;
          setlength(rez,k+1);
         end;
       end;
    end;
    for i:=low(rez) to high(rez) do
     begin
       form1.stringgrid2.cells[0,i]:= inttostr(i);
       form1.stringgrid2.cells[1,i]:= inttostr(rez[i]);
       form1.stringgrid2.rowcount:= form1.stringgrid2.rowcount + 1;
      end;
     form1.stringgrid2.rowcount:= form1.stringgrid2.rowcount - 1;
end;
function summ_otr(a:dvmas; n,m:integer):integer;
var i,j:integer;
 begin
  summ_otr:= 0;
    for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        if(a[i,j] < 0) then
           summ_otr:= summ_otr + a[i,j];
       end;
    end;
 end;

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
 var rez:mas;
     a:dvmas;
     n,m,summ:integer;
begin
 n:=strtoint(edit1.text);
 m:=strtoint(edit2.text);
 vvod(a,n,m);
 //summ:= summ_otr(a,n,m);
 //showmessage('Сумма отрицательных чисел ' + inttostr(summ));
 showmessage('Кол-во положительных чисел ' + inttostr(kol_pol(a,n,m)));
 rezmas2(a,rez,n,m);
end;

end.

