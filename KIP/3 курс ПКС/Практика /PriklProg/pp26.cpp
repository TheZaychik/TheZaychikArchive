#include <iostream>
#include <math.h>

using namespace std;

class classA {
private:
    int a;

public:
    void Hello() {
        cin >> a;
        cout << "Hello!" << a << endl;
    }

    void beta(int a, int b);

    void beta(bool b);
};

class classB : public classA {
public:
    void Hello() {
        cout << "Hello from child!" << endl;
    }

    void beta() {
        cout << "Beta" << endl;
    }
};

void zad2() {
    int n = 10;
    double x, q, s = 0;
    cin >> x;
    q = x;
    for (int i = 1; i < n; i++) {
        s += q;
        q *= (-1) * (x * i) / (i + 1);
        cout << "n= " << i << " q= " << q << "s= " << s << endl;
    }
    cout << "ln(" << x << ") = " << s << endl;
    cout << "internal ln(" << x << ") = " << log(x) << endl;
}

int main() {
    classA obj1;
    classB obj2;
    //obj1.a; не работает
//    obj1.Hello();
//    obj2.Hello();
//    obj2.beta();
    zad2();
    return 0;
}
