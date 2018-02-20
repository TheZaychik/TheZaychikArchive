#include <iostream>
#include "cmath"
using namespace std;

int main() {
    int a, b, x, c;
    cout << "Введите a" << endl;
    cin >> a;
    cout << "Введите b" << endl;
    cin >> b;
    cout << "Введите x" << endl;
    cin >> x;
    cout << "Введите c" << endl;
    cin >> c;
    cout << "z = " + to_string(exp(-c*x)*(x + sqrt(x + a))/(x - sqrt(abs(x - b)))) + " f = " + to_string(log10(a + pow(x, 2)) + pow(sin(x/b), 2)) << endl;
    return 0;
}