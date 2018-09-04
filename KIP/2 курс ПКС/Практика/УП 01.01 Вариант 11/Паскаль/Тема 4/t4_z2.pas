program t4_z2;
type mas = array of single;
var a, b : mas;
    n, i, c :integer;
begin
write('Введите размер массива: ');
readln(n);
setlength(a, n);
setlength(b, n);
for i:= 0 to n-1 do
  readln(a[i]);
write('Введите контрольное число: ');
readln(c);
for i:=0 to n-1 do
  begin
  if(a[i] > c) then
    b[i]:= a[i]*2
  else
    b[i]:= a[i];
  end;
writeln('Исходный массив');
for i:=0 to n-1 do
  writeln(a[i]);
writeln('Результирующий массив');
for i:=0 to n-1 do
  writeln(b[i]);
end.