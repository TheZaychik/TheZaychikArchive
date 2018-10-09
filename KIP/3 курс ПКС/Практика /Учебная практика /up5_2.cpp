#include <iostream>
#include <math.h>
using namespace std;

class A {
    int *a;
    double *b;
    char *c;
public:
    A(int i){
        a = new int(0);
        b = new double(0);
        c = new char('a');
        *a = --i;
        cout << this << endl;
        cout << *a << endl;

    }
    A(double i){
        a = new int(0);
        b = new double(0);
        c = new char('a');
        *b = --i;
        cout << this << endl;
        cout << *b << endl;

    }
    A(char i){
        a = new int(0);
        b = new double(0);
        c = new char('a');
        *c = --i;
        cout << this << endl;
        cout << *c << endl;
    }
    ~A(){
        delete a;
        delete b;
        delete c;
    }

};


int main(){
    A *obj, *obj1, *obj2;
    obj = new A(5);
    obj1 = new A(6.4);
    obj2 = new A('n');
    cout << "Адрес переменных"<< endl;
    cout << obj << endl;
    cout << obj1 << endl;
    cout << obj2 << endl;
    delete obj;
    delete obj1;
    delete obj2;
    cout << "Адрес переменных"<< endl;
    cout << obj << endl;
    cout << obj1 << endl;
    cout << obj2 << endl;
    return 0;
}