#include <iostream>
#include "cmath"
using namespace std;

int func1() {
    int a, b, x, c;
    cout << "Введите a" << endl;
    cin >> a;
    cout << "Введите b" << endl;
    cin >> b;
    cout << "Введите x" << endl;
    cin >> x;
    cout << "Введите c" << endl;
    cin >> c;
    cout << "z = " + to_string(exp(-c*x)*(x + sqrt(x + a))/(x - sqrt(abs(x - b)))) + " f = " + to_string(log10(a + pow(x, 2)) + pow(sin(x/b), 2)) << endl;
    return 0;
}

void Zad3(){
    int min, max;
    int a[10] = {1,2,3,4,5,6,7,8,9,10};
    min = 9999999;
    max = -9999999;
    for(int i : a){
        if (i < min){
            min = i;
        }
        else if(i > max){
            max = i;
        }
    }
    cout << "Максимальный/минимальный элемент массива " + to_string(max) + "/" + to_string(min) << endl;
}

void Zad4(){
    int sum = 0;
    int a[10] = {1,2,3,4,5,6,7,8,9,10};
    for (int i : a){
        sum += i;
    }
    cout << "Сумма элементов массива " + to_string(sum) << endl;
}

void Zad2(int n){
    long long buff = 1;
    for (int i = 1; i < n + 1; i++){
        buff *= i;
    }
    cout << buff;
}

int main(){
    func1();
    return 0;
}