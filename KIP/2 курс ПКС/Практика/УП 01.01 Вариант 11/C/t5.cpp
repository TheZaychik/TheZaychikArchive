#include <iostream>
#include "cmath"
using namespace std;


void zad1(){
    int n;
    cout << "Введите размер массива: ";
    cin >> n;
    double mas[n];
    cout << "Введите 1-й элемент массива: ";
    cin >> mas[0];
    cout << "Введите 2-й элемент массива: ";
    cin >> mas[1];
    for (int i = 2; i < n; i++){
        mas[i] = mas[i-1] * mas[i-2] *i;
    }
    cout << "Сформированный массив" << endl;
    for(double item : mas){
        cout << item << endl;
    }
}

void zad2(){
    int n, con;
    cout << "Введите размер массива: ";
    cin >> n;
    double mas[n], rezmas[n];
    cout << "Введите элементы массива: " << endl;
    for (int i = 0; i < n; i++){
       cin >> mas[i];
    }
    cout << "Введите контрольное число: ";
    cin >> con;
    for (int i = 0; i < n; i++){
        if(mas[i] > con){
            rezmas[i] = 2*mas[i];
        } else{
            rezmas[i] = mas[i];
        }
    }
    cout << "Исходный массив: " << endl;
    for (double item : mas){
        cout << item << endl;
    }
    cout << "Результирующий массив: " << endl;
    for (double item : rezmas){
        cout << item << endl;
    }
}

int main(){
    zad1();
    return 0;
}
