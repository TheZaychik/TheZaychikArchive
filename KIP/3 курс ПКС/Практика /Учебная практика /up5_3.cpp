#include <iostream>
#include <math.h>
using namespace std;
class A {
public:
    void decr(int &i) {
        --i;
    }

    void decr(double &i) {
        --i;
    }

    void decr(char &i) {
        --i;
    }
};

int main(){
    A obj;
    int a = 5;
    double b = 6.3;
    char c = 'n';
    obj.decr(a);
    obj.decr(b);
    obj.decr(c);
    cout << "Значения переменных"<< endl;
    cout << a << endl;
    cout << b << endl;
    cout << c << endl;
    cout << "Адрес переменных"<< endl;
    cout << &a << endl;
    cout << &b << endl;
    cout << &c << endl;
    return 0;
}