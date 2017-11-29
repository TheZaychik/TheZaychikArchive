unit Unit3;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ExtCtrls;

type

  { TForm3 }

  TForm3 = class(TForm)
    Image1: TImage;
    procedure FormClose(Sender: TObject; var CloseAction: TCloseAction);
    procedure FormPaint(Sender: TObject);

  private

  public

  end;

var
  Form3: TForm3;

implementation

{$R *.lfm}

{ TForm3 }

procedure TForm3.FormClose(Sender: TObject; var CloseAction: TCloseAction);
begin
  Application.Terminate();
end;



procedure TForm3.FormPaint(Sender: TObject);
begin
  With canvas do
   begin
    Arc(50, 50, 250, 350, 250, 150,50,150);
    MoveTo(50,150);
    LineTo(250,150);

    MoveTo(245,150);
    LineTo(150,20);
    LineTo(159,20);
    MoveTo(150,20);
    LineTo(150,29);

    MoveTo(245,90);
    LineTo(100,20);
    LineTo(109,20);
    MoveTo(100,20);
    LineTo(100,29);

    MoveTo(180,60);
    LineTo(150,150);
    MoveTo(122,100);
    LineTo(122,91);
    MoveTo(122,100);
    LineTo(131,100);


    MoveTo(180,60);
    LineTo(52,150);
    MoveTo(160,120);
    LineTo(169,120);
    MoveTo(160,120);
    LineTo(155,111);

    Arc(10, 120, 80, 180, 80, 150, 100, 120);

     Font.Style:=[fsItalic,fsBold];
     Font.Color:= clBlack;
     Font.Size:=8;
     TextOut(200,160,'a');
     TextOut(100,160,'n');
     TextOut(90,130,'φ');
     TextOut(100,100,'r');
     Font.Size:=6;
     TextOut(165,90,'Wa');
     TextOut(150,70,'Wb');
     TextOut(120,30,'Wq');
     TextOut(170,40,'Wz');

   end;
end;





end.

