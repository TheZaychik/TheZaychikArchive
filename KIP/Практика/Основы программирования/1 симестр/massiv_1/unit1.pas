unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, Grids,
  StdCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    StringGrid1: TStringGrid;
    StringGrid2: TStringGrid;
    StringGrid3: TStringGrid;
    procedure Button1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;
  type mas = array of integer;
  type rezmas = array of integer;
implementation
procedure GenMas(var a:mas);  // генерация массива
var i,n:integer;
 begin
   randomize;
   n:= 5 + random(10);   // рандомим размер массива (от 5 до 15)
   Setlength(a,n);
   for i:= low(a) to high(a) do
    begin
     a[i]:= -10 + random(45);
    end;
 end;
procedure VivMas(var a:mas; var b:rezmas);  //вывод двух массивов
var i:integer;
 begin
   for i:=low(a) to high(a) do
    begin
     form1.StringGrid1.Cells[0,i]:= inttostr(i);
     form1.StringGrid1.Cells[1,i]:= inttostr(a[i]);
     form1.StringGrid1.RowCount:=  form1.StringGrid1.RowCount + 1;
    end;
   form1.StringGrid1.RowCount:=  form1.StringGrid1.RowCount - 1;
   for i:=low(b) to high(b) do
    begin
     form1.StringGrid2.Cells[0,i]:= inttostr(i);
     form1.StringGrid2.Cells[1,i]:= inttostr(b[i]);
     form1.StringGrid2.RowCount:= form1.StringGrid2.RowCount + 1;
    end;
   form1.StringGrid2.RowCount:=  form1.StringGrid2.RowCount - 1;
 end;
procedure sort_vivod(var a:mas);     // сортировка
 var i,j,buf,min:integer;
 begin
  for i:=low(a) to high(a) do
   begin
    min:=i;
    for j:= i + 1 to high(a) do
     begin
      if(a[j] < a[min]) then
       min:=j;
      buf:=a[i];
      a[i]:=a[min];
      a[min]:=buf;
     end;
   end;
   for i:=low(a) to high(a) do  // вывод отсортированного массива
    begin
     form1.StringGrid3.Cells[0,i]:= inttostr(i);
     form1.StringGrid3.Cells[1,i]:= inttostr(a[i]);
     form1.StringGrid3.RowCount:=  form1.StringGrid3.RowCount + 1;
    end;
   form1.StringGrid3.RowCount:=  form1.StringGrid3.RowCount - 1;
 end;

function Nechet(a:mas):integer;  // функция в библиотеке
external 'mas_function.dll' name 'Nechet';

procedure SostMasPoUsl(var a:mas; var b:rezmas; var kol_nechet : integer); // составление рез массива
var i,n:integer;
 begin
   kol_nechet:= Nechet(a);
   n:=0;
   setlength(b,1);
   for i:= low(a) to high(a) do
     begin
      if(a[i] = kol_nechet) then
       begin
         b[n]:=a[i];
         n:=n+1;
         setlength(b,n+1);
       end;
     end;
 end;

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var a:mas;
var b:rezmas;
var kol_nechet : integer;
begin
 kol_nechet:= 0;
 GenMas(a);
 SostMasPoUsl(a,b,kol_nechet);
 VivMas(a,b);
 sort_vivod(a);
 showmessage('Кол-во нечечтных чисел - ' + inttostr(kol_nechet));
end;

end.

