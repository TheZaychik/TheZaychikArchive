#include <iostream>
#include "cmath"
using namespace std;

int main() {
    double b, x, c, min, max;
    cout << "Введите b" << endl;
    cin >> b;
    cout << "Введите x" << endl;
    cin >> x;
    cout << "Введите c" << endl;
    cin >> c;
    if(x > 1){
        cout << "(1) z = " + to_string(x*sqrt(b*b + c*c)) << endl;
    } else if(x <= 0){
        min = sqrt(b);
        if (x*x < min)
            min = x*x;
        if(x+c < min)
            min = x+c;
        cout << "(2) z = " + to_string(min) << endl;
    } else{
        max = log10(b);
        if(x + c > max)
            max = x+c;
        cout << "(3) z = " + to_string(max) << endl;
    }
    return 0;
}