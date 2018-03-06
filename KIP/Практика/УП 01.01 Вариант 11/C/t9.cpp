#include <iostream>
#include <random>
#include "cmath"
using namespace std;

void zad1(){
    int n, m, buff, max, num, k;
    cout << "Введите n и m" << endl;
    cin >> n;
    cin >> m;
    cout << "Первчиный массив:" << endl;
    int a[n][m];
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            a[i][j] = -15 + rand() % 45;
            cout << a[i][j] << " ";
        }
        cout << endl;
    }
    k = m;
    for (int i = 0; i < k; i++){
        max = a[n][i];
        num = i;
        for(int j = 1; j < k; j++){
            if (a[n][j] > max){
                max = a[n][j];
                num = j;
            }
        }
        buff = a[n][num];
        a[n][num] = a[n][m];
        a[n][m] = buff;
        m -=1;
    }
    cout << "Результирующий массив" << endl;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cout << a[i][j] << " ";
        }
        cout << endl;
    }
}

int main(){
    zad1();
    return 0;
}

