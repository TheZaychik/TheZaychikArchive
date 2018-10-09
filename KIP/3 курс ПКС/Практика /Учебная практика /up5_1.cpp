#include <iostream>
#include <math.h>
using namespace std;

class MySin {
public:
    double *p;

    MySin(int i, double x) {
        p = new double[i + 1];
        p[0] = x;
        p[1] = (p[0] * x * x) / (1 * 2 * 3);
        for (int k = 2; k <= i ; k++) {
            p[k] = (p[k - 1] * x * x) / ((k + k) * (2*k + 1));
        }
    }

    ~MySin() {
        delete[] p;
    }
};
int main() {
    int n;
    MySin *obj;
    double x, s = 0;
    cout << "enter n = ";
    cin >> n;
    cout << "enter x = ";
    cin >> x;
    obj = new MySin(n, x);
    cout << "Поля:" << endl;
    for (int i = 0; i <= n; i++) {
        cout << "Точка " << i << ": " <<  obj->p[i] << endl;
        if (i % 2 == 0)
            s += obj->p[i];
        else
            s -= obj->p[i];
        if(i==3)
            cout << "Контрольная сумма 4-х точек: " << s << endl;
    }
    cout << "Sin(x) из класса:" << endl;
    cout << s << endl;
    cout << "Sin(x) из библиотеки:" << endl;
    cout << sin(x) << endl;

    return 0;
}
