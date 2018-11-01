#include <iostream>
#include "math.h"
using namespace std;

void zad1(){
    cout << "----Задание 1----" << endl;
    int a = 0;
    for(int i = 2; i < 1025; i*=2){
        if(sin(2*i) < 0)
            a++;
    }
    cout << a << " отрицательных членов" << endl;
}

void zad2(){
    cout << "----Задание 2----" << endl;
    int f1, s1, f2, s2, i2;
    for(int i = 10; i < 100; i++){
        if(i < 50) {
            f1 = i / 10;
            s1 = i % 10;
            i2 = i * 2;
            f2 = i2 / 10;
            s2 = i2 % 10;
            if((f1 + s1) == (f2+s2)){
                cout << i << endl;
            }
        }
    }
}

void zad3(){
    cout << "----Задание 3----" << endl;
    for(int i = 100; i < 1000; i++){
        if(i % 11 == 0){
            if(i % 10 == 3){
                cout << i << endl;
            }
            else if ((i % 100)/10 == 3){
                cout << i << endl;
            }
            else if (i / 100 == 3){
                cout << i << endl;
            }
        }
    }
}

int main(){
    zad1();
    zad2();
    zad3();
    return 0;
}