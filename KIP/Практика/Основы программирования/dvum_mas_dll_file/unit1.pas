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
    Edit3: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
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

function summ_otr(a:dvmas; n,m:integer; fname:string):integer;
external 'libr_summ_otr.dll' name 'summ_otr';
procedure form_dvmas(var a:dvmas; var n,m:integer; var s1 :TStringGrid; var fname:string );
external 'libr_form_dvmas.dll' name 'form_dvmas';
procedure rezmas(var rez:mas; var n,m:integer; var s2 :TStringGrid; var fname:string);
external 'libr_rezmas.dll' name 'rezmas';
{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
 var rez:mas;
     a:dvmas;
     n,m,summ:integer;
     fname:string;
begin
 n:=strtoint(edit1.text);
 m:=strtoint(edit2.text);
 fname:=edit3.text;
 form_dvmas(a,n,m,StringGrid1,fname);
 summ:= summ_otr(a,n,m,fname);
 showmessage('Сумма отрицательных чисел ' + inttostr(summ));
 rezmas(rez,n,m,StringGrid2,fname);
end;




end.

