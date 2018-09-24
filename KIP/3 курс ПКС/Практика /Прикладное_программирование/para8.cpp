#include <iostream>
using namespace std;

class MyClass{
public:
    int n;
    void show(){
        cout << "n = " << n << endl;
    }
};

int main(){
    MyClass a, b;
    MyClass *p, *q;

    p = &a;
    q = &b;

    p->n = 10;
    (*q).n = 20;

    p->show();
    (*q).show();
    return 0;
}