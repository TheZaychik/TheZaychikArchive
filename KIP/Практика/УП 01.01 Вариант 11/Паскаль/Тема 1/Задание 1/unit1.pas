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
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
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
var kg_KP, kg_AP, kg_CH, gr_KP, gr_AP, gr_CH : integer;
begin
  kg_KP:= strtoint(Edit1.Text);
  kg_AP:= strtoint(Edit2.Text);
  kg_CH:= strtoint(Edit3.Text);
  gr_KP:= strtoint(Edit4.Text);
  gr_AP:= strtoint(Edit5.Text);
  gr_CH:= strtoint(Edit6.Text);
  showmessage('Стоимость набора = ' + floattostr(kg_KP*gr_KP/1000 + kg_AP*gr_AP/1000 + kg_CH*gr_CH/1000));
end;

end.

