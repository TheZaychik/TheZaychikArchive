#include <iostream> // не работает
#include <random>
#include "cmath"
using namespace std;

int n, m, buff, pos;
void sort_mas(int a[100][100], int left, int right) {

    int buf;
    int i = left, j = right;
    int pivot = a[n-1][(left+right)/2];

    while (i<=j){
        while (a[n-1][i] < pivot)
            i++;
        while (a[n-1][j] > pivot)
            j--;
        if (i<=j){
            buf=a[n-1][i];
            a[n-1][i]=a[n-1][j];
            a[n-1][j]=buf;
            for (int s = 0; s < n - 1; s++){
                buff = a[s][i];
                a[s][i] = a[s][j];
                a[s][j] = buff;
            }
            i++;
            j--;
        }
    }

    if (left<j)
        sort_mas(a,left,j);
    if (i<right)
        sort_mas(a,i,right);

}
void zad1(){
    srand(time(NULL));
    cout << "Введите n и m" << endl;
    cin >> n;
    cin >> m;
    cout << "Первчиный массив:" << endl;
    int a[100][100];
    for (int q = 0; q < n; q++) {
        for (int w = 0; w < m; w++) {
            a[q][w] = -20 + rand() % 45;
            cout << a[q][w] << " ";
        }
        cout << endl;
    }
    sort_mas(a,0, m - 1);
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




