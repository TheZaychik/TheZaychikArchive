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
    Edit4: TEdit;
    Edit5: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
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
      tf:textfile;
      fname:string;

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
  var i:integer;
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
procedure udal_slovo(var row,slovo:tstr);
begin
 delete(row,pos(slovo,row),length(slovo));
end;

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var row_old,slovo:tstr;
begin
 fname:=edit4.text;
 assignfile(tf,fname);
 rewrite(tf);
 row:= unicodestring(Edit1.text);
 simvol:= unicodestring(Edit2.text)[1];
 an_simvol:= unicodestring(Edit3.text)[1];
 slovo:= unicodestring(edit5.text);
 if(combobox1.ItemIndex = 0) then
  begin
    showmessage('Кол-во символов: ' + inttostr(kol_simv(row,simvol)));
    writeln(tf,'Количество символов');
    writeln(tf,'Строка: '+ansistring(row));
    writeln(tf,'Искомый символ: '+ansistring(simvol));
    writeln(tf,'Количество символов: '+inttostr(kol_simv(row,simvol)));
  end
 else if(combobox1.ItemIndex = 1) then
  begin
    row_old:=row;
    zamena(row,simvol,an_simvol);
    showmessage('Старая строка: '+ ansistring(row_old) + '; Новая строка: ' + ansistring(row));
    writeln(tf,'Замена символов');
    writeln(tf,'Старая строка: '+ ansistring(row_old));
    writeln(tf,'Заменяемый символ: ' + ansistring(simvol));
    writeln(tf,'Новый символ: ' + ansistring(an_simvol));
    writeln(tf,'Новая строка: ' + ansistring(row));
  end
 else if(combobox1.ItemIndex = 2) then
  begin
    row_old:=row;
    showmessage('Старая строка: '+ ansistring(row_old) + '; Новая строка: ' + ansistring(ins(row,simvol,an_simvol)));
    writeln(tf,'Вставка символов');
    writeln(tf,'Старая строка: '+ ansistring(row_old));
    writeln(tf,'Вставляемый символ: ' + ansistring(an_simvol));
    writeln(tf,'Предыдущий символ: ' + ansistring(simvol));
    writeln(tf,'Новая строка: ' + ansistring(row));
  end
 else if(combobox1.ItemIndex = 3) then
 begin
   row_old:= row;
   rem(row,simvol);
   showmessage('Старая строка: '+ ansistring(row_old) + '; Новая строка: ' + ansistring(row));
   writeln(tf,'Удаление символов');
   writeln(tf,'Старая строка: '+ ansistring(row_old));
   writeln(tf,'Удаляемый символ: ' + ansistring(simvol));
   writeln(tf,'Новая строка: ' + ansistring(row));
 end
  else
  begin
   row_old:= row;
   udal_slovo(row,slovo);
   showmessage('Старая строка: '+ ansistring(row_old) + '; ' + 'Подстрока: ' + ansistring(slovo)+'; ' + 'Новая строка: ' + ansistring(row));
   writeln(tf,'Удаление слова');
   writeln(tf,'Старая строка: '+ ansistring(row_old));
   writeln(tf,'Удаляемая подстрока: ' + ansistring(slovo));
   writeln(tf,'Новая строка: ' + ansistring(row));
  end;

 closefile(tf);
end;

end.
