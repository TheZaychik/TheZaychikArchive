#include <iostream>  // v2
#include "cmath"
using namespace std;

double func(double b, double x, double c);

int main() {
    double b, x, c;
    cout << "Введите b" << endl;
    cin >> b;
    cout << "Введите x" << endl;
    cin >> x;
    cout << "Введите c" << endl;
    cin >> c;
    cout << " z = " + to_string(func(b,x,c)) << endl;
    return 0;
}

double func(double b, double x, double c){
    double min, max;
    if(x > 1){
        return x*sqrt(b*b + c*c);
    } else if(x <= 0){
        min = sqrt(b);
        if (x*x < min)
            min = x*x;
        if(x+c < min)
            min = x+c;
        return min;
    } else{
        max = log10(b);
        if(x + c > max)
            max = x+c;
        return max;
    }
}