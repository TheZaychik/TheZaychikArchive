#include <iostream> // не работает
#include <random>
#include "cmath"
using namespace std;

void zad1(){
    int n, m, buff, pos;
    srand(time(NULL));
    cout << "Введите n и m" << endl;
    cin >> n;
    cin >> m;
    cout << "Первчиный массив:" << endl;
    int a[n][m];
    for (int q = 0; q < n; q++) {
        for (int w = 0; w < m; w++) {
            a[q][w] = -20 + rand() % 45;
            cout << a[q][w] << " ";
        }
        cout << endl;
    }
    for (int i = 1; i < n ; i++) {
        buff = a[n-1][i];
        pos = i - 1;
        while ((pos >= 0) && (a[n-1][pos] > buff)){
            a[n-1][pos + 1] = a[n-1][pos];
            a[n-1][pos] = buff;
            pos--;
        }
        a[n-1][pos + 1] = buff;
    }
    cout << "Результирующий массив" << endl;
    for (int q = 0; q < n; q++) {
        for (int w = 0; w < m; w++) {
            cout << a[q][w] << " ";
        }
        cout << endl;
    }

}

void zad2(){
    int n, buff, pos;
    cout << "Введите n" << endl;
    cin >> n;
    cout << "Первчиный массив:" << endl;
    int a[n];
    for (int q = 0; q < n; q++) {
        a[q] = -20 + rand() % 45;
        cout << a[q] << " ";
    }
    cout << endl;
    for (int i = 1; i < n; i++) {
        buff = a[i];
        pos = i - 1;
        while ((pos >= 0) && (a[pos] > buff)){
            a[pos + 1] = a[pos];
            a[pos] = buff;
            pos--;
        }
        a[pos] = buff;
    }
    cout << "Результирующий массив" << endl;
    for (int q = 0; q < n; q++) {
        cout << a[q] << " ";
    }
}

int main(){
    zad1();
    return 0;
}


