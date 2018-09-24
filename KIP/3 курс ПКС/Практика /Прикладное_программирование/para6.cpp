#include <iostream>
using namespace std;

double sqr(double x){
    return x*x;
}

double cube(double x){
    return x*x*x;
}

void myfunc(double x, double(*f)(double)){
    cout << f(x) << endl;
}

int main(){
    double z;
    // Указатель на функцию
    double (*p)(double);
    cout << "z = ";
    cin >> z;
    // указателю присваивается значение
    p = cube;
    // использование указателя и имени функции
    myfunc(z,sqr);
    myfunc(z,p);
    cout << p(z) << endl;
    // адрес функции
    cout << sqr << endl;
    cout << cube << endl;
    cout << p << endl;
    return 0;
}