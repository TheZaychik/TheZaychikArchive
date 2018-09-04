program t13;
uses crt;
type mas = array of array of double;
type odmas = array of double;
var a : mas;
    c : odmas;
    n,m,switch : integer;
 
procedure viv_mas();
var i, j : integer;
begin
for i:=0 to n-1 do
  begin
    for j:=0 to m-1 do
      begin
        write(floattostr(a[i,j]) + ' ');
      end;
    writeln(' ');
  end;
end; 
 
procedure vvod_rnd();
var i, j : integer;
begin
randomize();
for i:=0 to n-1 do
  for j:=0 to m-1 do
    a[i,j]:= -15 + random(45);
for i:=0 to m-1 do
  c[i]:= -15 + random(45);
viv_mas();
end;

procedure vvod_manual();
var i, j : integer;
begin
randomize();
for i:=0 to n-1 do
  for j:=0 to m-1 do
    readln(a[i,j]);
for i:=0 to m-1 do
  readln(c[i]);
viv_mas();
end;

procedure vvod_file();
var i, j :integer;
    f : text;
begin
assign(f,'text_vvod.txt');
reset(f);
for i:=0 to n-1 do
  for j:=0 to m-1 do
    readln(f,a[i,j]);
viv_mas();
end;

procedure viv_file();
var i, j :integer;
    f : text;
begin
assign(f,'text_viv.txt');
rewrite(f);
for i:=0 to n-1 do
  for j:=0 to m-1 do
    writeln(f,a[i,j]);
end;

procedure setlen();
var i, j :integer;
begin
setlength(c,m);
setlength(a,n);
for i:=0 to n-1 do
  for j:=0 to m-1 do
    setlength(a[i], m);
end;
// обработка данных (11 вариант)
procedure zad1();
var i, j, k :integer;
    s, p, e, b : double;
begin
s:= 0;
p:= 1;
b:= 2;
for i:=0 to n-1 do
  for j:=0 to m-1 do
    if i = j then 
       s:= s + 1;
for i:=0 to m-1 do
  begin
  for k:=0 to m-1 do
    e:= 1/a[i,k] + c[i]*c[i];
  p:= s*c[i]/s * e;
  writeln(p)
  end;
viv_mas();
viv_file();
end;

// main по паскальски
begin 
writeln('Введите размер массива (NxM)');
readln(n, m);
setlen();
writeln('Выберете тип заполнения массива');
writeln('1 - Рандомный, 2 - Ручной ввод, 3 - Считывание из файла');
readln(switch);
case switch of
 1:vvod_rnd();
 2:vvod_manual();
 3:vvod_file();
 else writeln('Введите корректные данные!');
end;
zad1();
viv_mas();
viv_file();
end.