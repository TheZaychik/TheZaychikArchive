unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls, Math;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
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

implementation
 procedure Rasch(a,b,x,f : single);
  begin
   f:= power(x,a-1) * power((1-x),b-1) * ln(x) * abs(log10(abs(1-x)));
  end;

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var a,b,x,f : single;
begin
  a:= strtofloat(edit1.text);
  b:= strtofloat(edit2.text);
  x:= strtofloat(edit3.text);
  Rasch(a,b,x,f);
  showmessage('f = ' + floattostr(f));
end;

end.

