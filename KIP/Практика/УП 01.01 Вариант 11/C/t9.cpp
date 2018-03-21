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
    for (int q = 0; q < n; q++) {
        for (int w = 0; w < m; w++) {
            a[q][w] = -15 + rand() % 45;
            cout << a[q][w] << " ";
        }
        cout << endl;
    }
    k = m;
    for (int i = 0; i < k; i++){
        max = a[n-1][i];
        num = i;
        for (int j = 0; j < k; j++){
            if (a[n-1][j] > max) {
                max = a[n - 1][j];
                num = j;
            }
        }
        buff = a[n-1][num];
        a[n-1][num] = a[n-1][k-1];
        a[n-1][k-1] = buff;
        for (int s = 0; s < n - 1; s++){
            buff = a[s][num];
            a[s][num] = a[s][k-1];
            a[s][k-1] = buff;
        }
        k -=1;
    }
    cout << "Результирующий массив" << endl;
    for (int q = 0; q < n; q++) {
        for (int w = 0; w < m; w++) {
            cout << a[q][w] << " ";
        }
        cout << endl;
    }

}

int main(){
    zad1();
    return 0;
}

