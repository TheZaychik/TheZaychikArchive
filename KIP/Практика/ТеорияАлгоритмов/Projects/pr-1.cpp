#include <iostream>
using namespace std;

void zad1(){
    int n, p, i;
    p = 2;
    cout << "Введите раземр массива" << endl;
    cin >> n;
    bool mas[n];
    for (i = 0; i < n; i++){
        mas[i] = true;
    }
    while (p*p <= n){
        if (mas[p]){
            i = p*p;
            while (i <= n){
                mas[i] = false;
                i = i + p;
            }
        }
        p += 1;
    }
    for (i = 0; i < n; i++){
        if(mas[i]){
            cout << i << endl;
        }
    }
}

void zad2(){
    int n, count, j;
    count = 0;
    j = 0;
    cout << "Введите раземр массива" << endl;
    cin >> n;
    cout << "Элементы массива которые длеятся на 2 и на 3" << endl;
    int mas[n];
    for (int i = 0; i < n; i++){
        mas[i] = i;
    }
    for (int i = 0; i < n; i++){
        if ((mas[i] % 2 == 0) && (mas[i] % 3 == 0)){
            count += 1;
        }
    }
    int rezmas[count];
    for (int i = 0; i < n; i++){
        if ((mas[i] % 2 == 0) && (mas[i] % 3 == 0)){
            rezmas[j] = mas[i];
            j += 1;
        }
    }
    for (int i = 0; i < count; i++){
        cout << rezmas[i] << endl;
    }

}

int main() {
    zad2();
    return 0;
}

