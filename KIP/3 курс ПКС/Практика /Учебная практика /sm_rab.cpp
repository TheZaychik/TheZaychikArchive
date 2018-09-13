#include <iostream>
using namespace std;
class MyClass{
private:
    int n, m;
public:
    void decr(int a);
    void decr(double a);
    void decr(char a);
};

void MyClass::decr(int a) {
    a--;
    cout << "int decr a = " << a << endl;
}

void MyClass::decr(double a) {
    a--;
    cout << "double decr a = " << a << endl;
}

void MyClass::decr(char a) {
    a--;
    cout << "char decr a = " << a << endl;
}

int main(){
    MyClass mc;
    char ch = 'd';
    int it = 248;
    double db = 43.832;
    cout << it;
    mc.decr(it);
    mc.decr(db);
    mc.decr(ch);
    return 0;
}


