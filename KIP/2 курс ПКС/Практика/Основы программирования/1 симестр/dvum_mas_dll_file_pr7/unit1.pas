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
    Button2: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    StringGrid1: TStringGrid;
    StringGrid2: TStringGrid;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Edit1Change(Sender: TObject);


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
 var rez:mas;
    a:dvmas;
    n,m,summ:integer;
    fname:string;

//Бинарные
function summ_otr_bin(a:dvmas; n,m:integer; fname:string):integer;
external 'libr_summ_otr.dll' name 'summ_otr_bin';
procedure form_dvmas_bin(var a:dvmas; var n,m:integer; var s1 :TStringGrid; var fname:string );
external 'libr_form_dvmas.dll' name 'form_dvmas_bin';
procedure rezmas_bin(var rez:mas; var n,m:integer; var s2 :TStringGrid; var fname:string);
external 'libr_rezmas.dll' name 'rezmas_bin';

//Текстовые
function summ_otr(a:dvmas; n,m:integer; fname:string):integer;
external 'libr_summ_otr_txt.dll' name 'summ_otr';
procedure form_dvmas(var a:dvmas; var n,m:integer; var s1 :TStringGrid; var fname:string );
external 'libr_form_dvmas_txt.dll' name 'form_dvmas';
procedure rezmas(var rez:mas; var n,m:integer; var s2 :TStringGrid; var fname:string);
external 'libr_rezmas_txt.dll' name 'rezmas';
{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
begin
 n:=strtoint(edit1.text);
 m:=strtoint(edit2.text);
 fname:=edit3.text;
 form_dvmas_bin(a,n,m,StringGrid1,fname);
 summ:= summ_otr_bin(a,n,m,fname);
 showmessage('Сумма отрицательных чисел ' + inttostr(summ));
 rezmas_bin(rez,n,m,StringGrid2,fname);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
 n:=strtoint(edit1.text);
 m:=strtoint(edit2.text);
 fname:=edit4.text;
 form_dvmas(a,n,m,StringGrid1,fname);
 summ:= summ_otr(a,n,m,fname);
 showmessage('Сумма отрицательных чисел ' + inttostr(summ));
 rezmas(rez,n,m,StringGrid2,fname);
end;

procedure TForm1.Edit1Change(Sender: TObject);
begin

end;

end.

