library mas_function;

{$mode objfpc}{$H+}

uses
  Classes
  { you can add units after this };
type mas = array of integer;
function Nechet(a:mas):integer;
 var i:integer;
   begin
     Nechet:=0;
     for i:=Low(a) to High(a) do
      begin
       if(a[i] mod 2 <> 0) then
        Nechet:= Nechet + 1;
      end;
   end;
 exports Nechet;

begin
end.

