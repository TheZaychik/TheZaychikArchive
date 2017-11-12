unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  LazUTF8;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    ComboBox1: TComboBox;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;
  type tstr = unicodestring;
  type tschr = unicodechar;
  var row:tstr;
      simvol:tschr;
      an_simvol:tschr;
      buff:string;

implementation
function kol_simv(row:tstr;simvol:tschr):byte;
var i:byte;
 begin
  kol_simv:=0;
  for i:=1 to length(row) do
   if row[i] = simvol then
      kol_simv:=kol_simv+1;
 end;
procedure Zamena(var row:tstr; var simv1:tschr;simv2:tschr);
  var i:byte;
 begin
   for i:=1 to length(row) do
    if row[i] = simv1 then
     row[i]:= simv2;
 end;
function ins(row:tstr;simv1,simv2:tschr):unicodestring;
var x,i :integer;
begin
 x:= length(row)+1;
 for i:=1 to x do
 if(row[i] = simv1) then
  insert(simv2,row,i+1);
 ins:= row;
end;
procedure rem(var row:tstr; var simv1:tschr);
var i:integer;
begin
 for i:=1 to length(row)+1 do
  if(row[i] = simv1) then
   delete(row,i,1);
end;

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var row_old:tstr;
begin
 row:= unicodestring(Edit1.text);
 simvol:= unicodestring((Edit2.text))[1];
 an_simvol:= unicodestring((Edit3.text))[1];
 if(combobox1.ItemIndex = 0) then
  begin
    showmessage('Кол-во символов: ' + inttostr(kol_simv(row,simvol)));
  end
 else if(combobox1.ItemIndex = 1) then
  begin
    row_old:=row;
    zamena(row,simvol,an_simvol);
    showmessage('Старая строка: '+ ansistring(row_old) + '; Новая строка: ' + ansistring(row));
  end
 else if(combobox1.ItemIndex = 2) then
  begin
    row_old:=row;
    showmessage('Старая строка: '+ ansistring(row_old) + '; Новая строка: ' + ansistring(ins(row,simvol,an_simvol)));
  end
 else
 begin
   row_old:= row;
   rem(row,simvol);
   showmessage('Старая строка: '+ ansistring(row_old) + '; Новая строка: ' + ansistring(row));
 end;

end;

end.
