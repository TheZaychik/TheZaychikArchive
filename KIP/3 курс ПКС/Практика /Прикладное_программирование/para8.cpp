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
    // указатели на объект
    MyClass *p, *q;
    // значения указателей
    p = &a;
    q = &b;
    // доступ через указатель
    p->n = 10;
    (*q).n = 20;

    p->show();
    (*q).show();
    return 0;
}