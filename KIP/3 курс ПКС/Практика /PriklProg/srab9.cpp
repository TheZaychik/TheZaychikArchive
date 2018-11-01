#include <iostream>
#include <math.h>

using namespace std;

// variant 10
class EXClass {
public:
    double *p;
    double *d;

    EXClass(int i, double x) {
        double sub = 1;
        p = new double[i + 1];
        d = new double[i + 1];
        p[0] = 1;
        d[0] = 1;
        for (int k = 1; k <= i; k++) {
            p[k] = p[k - 1] * x;
            d[k] = d[k - 1] * k;
        }
    }

    ~EXClass() {
        delete[] p;
        delete[] d;
    }
};

int main() {
    int n;
    EXClass *obj;
    double x, s = 0;
    cout << "enter n = ";
    cin >> n;
    cout << "enter x = ";
    cin >> x;
    obj = new EXClass(n, x);
    cout << "Поля:" << endl;
    for (int i = 0; i <= n; i++) {
        s += (obj->p[i] / obj->d[i]);
        cout << "Точка " << i << ": " << s << endl;
        if (i == 3)
            cout << "Контрольная сумма 4-х точек: " << s << endl;
    }
    cout << "Exp(" << x << ") из класса:" << endl;
    cout << s << endl;
    cout << "Exp(" << x << ") из библиотеки:" << endl;
    cout << exp(x) << endl;
    return 0;
}
