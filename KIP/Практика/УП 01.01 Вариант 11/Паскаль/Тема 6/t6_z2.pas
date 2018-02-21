program t6_z2_var1;
type mas = array of array of integer;
var sum, kol, proiz:double;
    i, j, n, m:integer;
    a: mas;
begin
sum:=0;
kol:=0;
proiz:=1;
writeln('Введите m');
readln(m);
writeln('Введите n');
readln(n);
writeln('Заполните массив:');
setlength(a, m);
for i:=0 to m - 1 do
  setlength(a[i], n);
for i:=0 to m - 1 do
begin
  for j:=0 to n - 1 do
  begin
    readln(a[i,j]);
    if a[i,j] mod 2 <> 0 then
    begin
      sum:= sum + a[i,j];
      kol:= kol + 1;
      proiz:= proiz * a[i,j];
    end;
  end;
end;  
writeln('Сумма нечетных элементов массива:', sum);
writeln('Произведение нечетных элементов массива:', proiz);
writeln('Количество нечетных элементов массива:', kol);  
end.