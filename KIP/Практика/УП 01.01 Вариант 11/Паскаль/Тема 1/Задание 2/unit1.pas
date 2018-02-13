unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    procedure Button1Click(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var min, sec, hour: integer;
begin
  min:= strtoint(Edit1.text)*60;
  sec:= strtoint(Edit2.text);
  sec:= min + sec;
  hour:= (sec div 3600) mod 24;
  min:= (sec div 60) mod 60;
  showmessage('Время: ' + inttostr(hour) + ' часов ' + inttostr(min) + ' минут.');
end;

end.

