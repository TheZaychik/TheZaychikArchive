program t13;
uses crt;
type mas = array [0..99, 0..99] of double;
var a : mas;
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
viv_mas();
end;

procedure vvod_manual();
var i, j : integer;
begin
randomize();
for i:=0 to n-1 do
  for j:=0 to m-1 do
    readln(a[i,j]);
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
// обработка данных (11 вариант)
procedure zad1();
var i, j, kol :integer;
    r, dist, sr_a : double;
    
begin
kol:= 0;
sr_a:= 0;
writeln('Введите радиус R:');
readln(r);
for i:=0 to n-1 do
  for j:=0 to m-1 do
  begin
    dist:= sqrt(i * i - j * j);
    sr_a:= sr_a + dist;
    if(dist <= r) then
      kol:= kol + 1;
  end;
  sr_a:= sr_a / (n * m);
  writeln('Количество точек, которые находятся в пределах круга c радиусом ' + floattostr(r) + ':',kol);
  writeln('Среднее арифметическое расстояния от начала координат для всех заданных точек: ', sr_a);
  viv_mas();
  viv_file();
end;

procedure zad2();
var i, kol :integer;
begin
kol:= 0;
for i:=0 to n-1 do
  begin
    if (a[i,0] = a[i,1]) then
    begin
      kol:= kol + 1;
      writeln('Строка ' + inttostr(i) + ' имеет совпадающие элементы!');
    end;
  end;
  writeln('Общее кол-во строчек с совпадающими элемнтами', kol);
end;

// main по паскальски
begin 
writeln('Введите размер массива (NxM)');
readln(n, m);
writeln('Выберете тип заполнения массива');
writeln('1 - Рандомный, 2 - Ручной ввод, 3 - Считывание из файла');
readln(switch);
case switch of
 1:vvod_rnd();
 2:vvod_manual();
 3:vvod_file();
 else writeln('Введите корректные данные!');
end;
writeln('Выберете задание:');
writeln('1 - Радиус круга, 2 - Совпадающие элемнты');
readln(switch);
case switch of
 1:zad1();
 2:zad2();
 else writeln('Введите корректные данные!');
end;
 viv_mas();
 viv_file();
end.
