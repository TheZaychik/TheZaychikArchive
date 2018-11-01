#include <iostream>
#include <iomanip>
#include <math.h>
using namespace std;

class Iteration {
    int n, m, i, j, checker, iteration;
    double **a, *b, *x, *xn, eps;

    void enter() {
        cout << "<Заполнение коэффициентов>\n";
        for (i = 0;i<n;i++)
            for (j = 0;j<m;j++) {
                cout << "Введите элемент [" << i + 1 <<
                     "][" << j + 1 << "]: ";
                cin >> a[i][j];
            }

        cout << "<Заполнение свободных членов>\n";
        for (i = 0;i<n;i++) {
            cout << "Введите элемент [" << i + 1 << "]: ";
            cin >> b[i];
            x[i] = 0;
        }

    }

    void show() {
        cout << "\nИсходная матрица:\n";
        for (i = 0;i<n;i++) {
            cout << "\n";
            for (j = 0;j<m;j++)
                cout << setw(5) << a[i][j];
            cout << "|" << setw(5) << b[i];
        }
        cout << "\n";
    }

    void method_iteration() {
        iteration = 0;
        while (true) {
            xn[0] = (b[0] - (a[0][1] * x[1] + a[0][2] * x[2] + a[0][3] * x[3])) / a[0][0];
            xn[1] = (b[1] - (a[1][0] * x[0] + a[1][2] * x[2] + a[1][3] * x[3])) / a[1][1];
            xn[2] = (b[2] - (a[2][0] * x[0] + a[2][1] * x[1] + a[2][3] * x[3])) / a[2][2];
            if (n == 4)
                xn[3] = (b[3] - (a[3][0] * x[0] + a[3][1] * x[1] + a[3][2] * x[2])) / a[3][3];
            checker = 0;
            for (i = 0;i<4;i++)
                if (fabs(xn[i] - x[i])<eps)
                    checker++;
            if (checker == 4)
                break;
            for (int i = 0;i<4;i++)
                x[i] = xn[i];
            cout << "\nИтерация №" << iteration + 1 << ":\nx1 = " << xn[0] << "\nx2 = " << xn[1] << "\nx3 = " << xn[2] << "\n";
            if (n == 4)
                cout << "x4 = " << xn[3] << "\n";
            iteration++;
        }
        for (i = 0;i<4;i++)
            x[i] = xn[i];
        cout << "\n-------------------\nИтераций всего: " << iteration + 1;
        for (i = 0;i<n;i++)
            cout << "\n" << x[i];

    }
public:
    void start() {
        cout << "Введите погрешность: "; cin >> eps;
        cout << "Введите n = "; cin >> n;
        cout << "Введите m = "; cin >> m;
        a = new double *[m];
        for (i = 0;i<n;i++)
            a[i] = new double[n];
        b = new double[m];
        x = new double[m];
        xn = new double[m];
        enter();
        show();
        method_iteration();
        cout << "\n";
    }
};

int main() {
    Iteration iter;
    iter.start();
    return 0;
}