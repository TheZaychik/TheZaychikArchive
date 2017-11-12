unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Grids;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    StringGrid1: TStringGrid;
    StringGrid2: TStringGrid;
    procedure Button1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;

implementation
 type mas = array of integer;
 type dvmas = array [1..15,1..15] of integer;

function summ_otr(a:dvmas; n,m:integer):integer;
external 'libr_summ_otr.dll' name 'summ_otr';
procedure form_dvmas(var a:dvmas; var n,m:integer; var s1 :TStringGrid );
external 'libr_form_dvmas.dll' name 'form_dvmas';
procedure rezmas(var a:dvmas;var rez:mas; var n,m:integer; var s2 :TStringGrid);
external 'libr_rezmas.dll' name 'rezmas';
{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
 var rez:mas;
     a:dvmas;
     n,m,summ:integer;
begin
 n:=strtoint(edit1.text);
 m:=strtoint(edit2.text);
 form_dvmas(a,n,m,StringGrid1);
 summ:= summ_otr(a,n,m);
 showmessage('Сумма отрицательных чисел ' + inttostr(summ));
 rezmas(a,rez,n,m,StringGrid2);
end;

end.

