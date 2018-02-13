unit Unit2;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls, Unit3;

type

  { TForm2 }

  TForm2 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Shape1: TShape;
    Shape2: TShape;
    Shape3: TShape;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var CloseAction: TCloseAction);
    procedure FormCreate(Sender: TObject);
    procedure FormPaint(Sender: TObject);
  private

  public

  end;

var
  Form2: TForm2;
  var i,mode:integer;

implementation
procedure per_svetofor();
begin
    if mode = 0 then
      begin
         Form2.Shape1.Brush.Color:=clRed;
         Form2.Shape2.Brush.Color:=clBlack;
         Form2.Shape3.Brush.Color:=clBlack;
         mode:=1;
      end
    else if mode = 1 then
      begin
         Form2.Shape1.Brush.Color:=clBlack;
         Form2.Shape2.Brush.Color:=clYellow;
         Form2.Shape3.Brush.Color:=clBlack;
         mode:=2;
      end
    else if mode = 2 then
      begin
         Form2.Shape1.Brush.Color:=clBlack;
         Form2.Shape2.Brush.Color:=clBlack;
         Form2.Shape3.Brush.Color:=clGreen;
         mode:=0;
      end;
end;

{$R *.lfm}

{ TForm2 }

procedure TForm2.FormClose(Sender: TObject; var CloseAction: TCloseAction);
begin
  Application.Terminate()
end;

procedure TForm2.FormCreate(Sender: TObject);
begin
  i:=0;
  mode:=0;
  per_svetofor()
end;

procedure TForm2.Button1Click(Sender: TObject);
begin
 Form3.Show;
 Form2.Hide;
end;

procedure TForm2.Button2Click(Sender: TObject);
begin
 per_svetofor()
end;

procedure TForm2.FormPaint(Sender: TObject);
var a,b,c,i:integer;
begin
  a:=70;
  b:=60;
  c:=120;
  with canvas do
    begin
      Brush.Color:=RGBToColor(196,220,216);
      FillRect(50,90,650,420);
      Brush.Color:=RGBToColor(128,172,221);
      for i:=1 to 8 do
       begin
        fillrect(b,100,c,200);
        b:=b+a;
        c:=c+a;
       end;
      b:=60;
      c:=120;
       for i:=1 to 8 do
       begin
        fillrect(b,220,c,320);
        b:=b+a;
        c:=c+a;
       end;
       Brush.Color:=RGBToColor(150,90,19);
       fillrect(480,330,540,420);
       Brush.Color:=RGBToColor(25,25,238);
       Font.Style:=[fsItalic,fsBold];
       Font.Color:= clWhite;
       Font.Size:=8;
       TextOut(100, 340, 'Колледж Информатики и программирования');
    end;
end;






end.

