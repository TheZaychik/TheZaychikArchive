library libr_summ_otr;

{$mode objfpc}{$H+}

uses
  Classes
  { you can add units after this };
type dvmas = array [1..15,1..15] of integer;
function summ_otr(a:dvmas; n,m:integer):integer;
var i,j:integer;
 begin
  summ_otr:= 0;
    for i:=1 to n do
    begin
     for j:=1 to m do
       begin
        if(a[i,j] < 0) then
           summ_otr:= summ_otr + a[i,j];
       end;
    end;
 end;
exports summ_otr;
begin
end.

