unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, Buttons,
  ExtCtrls, ComCtrls, StdCtrls, Unit2,unit3;

type

  { TForm1 }

  TForm1 = class(TForm)
    Image1: TImage;
    Image2: TImage;
    Label1: TLabel;
    ProgressBar1: TProgressBar;
    Timer1: TTimer;
    procedure FormCreate(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }




procedure TForm1.FormCreate(Sender: TObject);
begin
  Image1.Canvas.Font.Style:=[fsItalic,fsBold];
  Image1.Canvas.Font.Size:=40;
  Image1.Canvas.TextOut(0, 0, 'Практическая работа №9');
  Image2.Canvas.Font.Style:=[fsItalic,fsBold];
  Image2.Canvas.Font.Size:=25;
  Image2.Canvas.TextOut(0, 0, 'Зайцев Н.В. 2ПКС-116');
end;



procedure TForm1.Timer1Timer(Sender: TObject);
begin
  with ProgressBar1 Do
    begin
      position:= position+1;
      Label1.Caption:= inttostr(position);
      if(position = max) then
        begin
          Form2.Show;
          Timer1.Enabled:= False;
          Form1.Hide;
        end;
    end;
end;



end.

