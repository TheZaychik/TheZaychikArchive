unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;

implementation
function summ(x,y:integer):integer;
external 'sum_lib.dll' name 'summ';

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var rez : integer;
begin
  rez:= summ(50,100);
  messagedlg('Result of function is ' + inttostr(rez),mtWarning,[mbok,mbcancel],0)
end;

end.

