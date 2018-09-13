#include <iostream>
using namespace std;

class SimpleClass {
int a, b;
public:
    void setab(int _a, int _b){
        a = _a;
        b = _b;
    }
    void setab(int _i){
        a = _i;
        b = _i;
    }

    void show(){
        cout << "a = " << a << endl;
        cout << "b = " << b << endl;
    }

};

int main(){
    SimpleClass obj1, obj2;
    obj1.setab(5,9);
    obj2.setab(10);
    obj1.show();
    obj2.show();
}
