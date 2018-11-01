#include <iostream>
using namespace std;

void zad1(){
    char a[4][5];
    char k='a';
    char *p;
    for (int i=0; i < 4; i++) {
        for (int j = 0; j < 5; j++) {
            a[i][j] = k;
            k += 1;
            p = &a[i][j];
            cout << *p << "  ";
        }
        cout << endl;
    }
    for (int i=0; i < 4; i++) {
        for (int j = 0; j < 5; j++) {
            cout << &a[i][j] << "  ";
        }
        cout << endl;
    }
}

void zad2(){
    int a[4][5];
    int k = 1;
    int *p;
    for (int i=0; i < 4; i++) {
        for (int j = 0; j < 5; j++) {
            a[i][j] = k;
            k += 1;
            p = &a[i][j];
            cout << *p << "  ";
        }
        cout << endl;
    }
    for (int i=0; i < 4; i++) {
        for (int j = 0; j < 5; j++) {
            cout << &a[i][j] << "  ";
        }
        cout << endl;
    }
}




int main(){
    //zad1();
    zad2();
    return 0;
}

