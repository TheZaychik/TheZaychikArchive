#include <iostream>

using namespace std;

void zad1(){
    string str;
    cout << "Zadanie 1" << endl;
    FILE *f = fopen("textfiles/srab13-1.txt", "r+");
    fprintf(f, "%s", "Hello World!");
    fseek(f,0,SEEK_SET);
    for (int i = 0; i < 12; i++){
        str += fgetc(f);
    }
    cout << str << endl;
    fclose(f);
}

void zad2(){
    cout << "Zadanie 2" << endl;
    int a = 10;
    cout << a << endl;
    FILE *f = fopen("textfiles/srab13-2.txt", "r+");
    fprintf(f, "%d", a);
    fscanf(f, "%d", &a);
    a += 3;
    cout << a << endl;
    fclose(f);
}

int main() {
   zad1();
   zad2();
}