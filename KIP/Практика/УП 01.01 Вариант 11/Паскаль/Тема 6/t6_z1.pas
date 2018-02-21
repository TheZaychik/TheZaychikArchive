program t6_z1_var1;
type mas = array of array of integer;
var n, m, i, j :integer;
    a: mas;
begin
writeln('Введите n');
readln(n);
writeln('Введите m');
readln(m);
writeln('------------');
randomize;
setlength(a, n);
for i:=0 to n - 1 do
  setlength(a[i], m);
for i:=0 to n - 1 do
begin
  for j:=0 to m - 1 do
  begin
    a[i,j]:= -15 + random(45);
    if i = 2 then
      writeln(a[2,j]);
  end;
end;
  
end.
