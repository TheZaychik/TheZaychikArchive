#include <iostream>
#include "cmath"
using namespace std;

int step(int x, int m){
   if (m == 0)
       return 1;
   else
       return x * step(x, m - 1);
}

void zad1(){
    int x, m;
    double s;
    cout << "Введите x и m" << endl;
    cin >> x >> m;
    s = step(x, m) + tan(x);
    cout << "S = " << s << endl;

}

int factorial(int p){
    if (p == 0)
        return 1;
    else
        return p * factorial(p - 1);

}

void zad2(){
    int p, p_rez;
    cout << "Введите кол-во натуральных чисел" << endl;
    cin >> p;
    p_rez = factorial(p);
    cout << "Кол-во перестановок = " << p_rez << endl;
}

int main() {
    zad2();
    return 0;
}

