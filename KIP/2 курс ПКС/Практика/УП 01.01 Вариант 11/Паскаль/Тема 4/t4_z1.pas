program t4_z1;
type mas = array of single;
var a : mas;
    n, i :integer;
begin
write('Введите размер массива: ');
readln(n);
setlength(a, n);
write('Введите 1-й элемент массива: ');
readln(a[0]);
write('Введите 2-й элемент массива: ');
readln(a[1]);
for i:= 2 to n-1 do
  a[i]:= a[i-1] * a[i-2] *i;
writeln('Сформированный массив');
for i:= 0 to n-1 do
  writeln(a[i]);
end.