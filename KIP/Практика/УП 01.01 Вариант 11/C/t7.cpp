#include <iostream>
#include <random>
#include "cmath"
using namespace std;

void zad1(){
    int n, m;
    cout << "Введите n и m" << endl;
    cin >> n >> m;
    cout << "-------------" << endl;
    double a[n][m];
    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            a[i][j] =  -15 + rand() % 45;
            if (i == 1)
                cout << a[i][j] << " ";
        }
    }
}

int main(){
    zad1();
    return 0;
}
