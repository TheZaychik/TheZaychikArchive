#include <iostream>
#include <cmath>
using namespace std;

int s;  // a это mas[0][0], т.е x0
double b, h, n;
double **mas = new double *[2];

double Formula(double x, double y) {
    return 3 * sin(2 * y) + x;
}

void Out(){
    cout.setf(ios::left);
    cout.width(8);
    cout << "xi";
    cout.width(8);
    cout << "yi" << endl;
    for (int i = 0; i < n; i++) {
        cout.width(8);
        cout << mas[0][i];
        cout.width(8);
        cout << mas[1][i] << endl;
    }
}
void Input() {
    cout << "a = ";
    cin >> mas[0][0];
    cout << "b = ";
    cin >> b;
    cout << "h = ";
    cin >> h;
    cout << "y0 = ";
    cin >> mas[1][0];
    cout << "a = " << mas[0][0] << ", b = " << b << ", h = " << h << ", y0 = " << mas[1][0] << endl;
    n = (b - mas[0][0]) / h;
}

void EilerMethod() {
    for (int i = 1; i <= n; i++) {
        mas[0][i] = mas[0][0] + i * (h / 2);
        mas[1][i] = mas[1][i - 1] + (h / 2) * Formula(mas[0][i - 1], mas[1][i - 1]);
    }
    Out();
}

void FirstMod() {
    for (int i = 1; i <= n; i++) {
        mas[0][i] = mas[0][0] + i * h;
        mas[1][i] = mas[1][i - 1] + h * Formula(mas[0][i - 1], mas[1][i - 1]);
    }
    Out();
}

void RungeKutt() {
    double k1, k2, k3, k4;
    for (int i = 1; i <= n; i++) {
        k1 = Formula(mas[0][i - 1], mas[1][i - 1]);
        k2 = Formula(mas[0][i - 1] + h / 2, mas[1][i - 1] + h / 2 * k1);
        k3 = Formula(mas[0][i - 1] + h / 2, mas[1][i - 1] + h / 2 * k2);
        k4 = Formula(mas[0][i - 1] + h, mas[1][i - 1] + h * k3);
        mas[0][i] = mas[0][i - 1] + h;
        mas[1][i] = mas[1][i - 1] + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
    }
    Out();

}

void SecondMod() {
    for (int i = 1; i <= n; i++) {
        mas[0][i] = mas[0][0] + i * (h / 2);
        mas[1][i] = mas[1][i - 1] + (h / 2) * (Formula(mas[0][i - 1], mas[1][i - 1])
                + Formula(mas[0][i], mas[1][i - 1] + h * Formula(mas[0][i - 1], mas[1][i - 1])));
    }
    Out();
}

int main() {
    for (int i = 0; i < 100; i++)
        mas[i] = new double[i + 1];
    for (;;) {
        cout << "0 - Выход" << endl;
        cout << "1 - Ввод значений" << endl;
        cout << "2 - Метод Эйлера" << endl;
        cout << "3 - Первый модифицированный" << endl;
        cout << "4 - Второй модифицированный" << endl;
        cout << "5 - Метод Рунге-Кутта" << endl;
        cin >> s;
        switch (s) {
            case 0:
                return 0;
            case 1:
                Input();
                break;
            case 2:
                EilerMethod();
                break;
            case 3:
                FirstMod();
                break;
            case 4:
                SecondMod();
                break;
            case 5:
                RungeKutt();
                break;
            default:
                cout << "Неверный ввод!" << endl;
                break;

        }
    }
}

