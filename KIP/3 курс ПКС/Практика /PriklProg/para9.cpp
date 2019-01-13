#include <iostream>
using namespace std;

class ClassA{
public:
    double a, b;

    ClassA(){
        a = 0;
        b = 0;
    }
    ClassA(double _a){
        a = _a;
        b = _a;
    }
    ClassA(int _a, int _b){
        a = _a;
        b = _b;
    }
    ~ClassA(){
        cout << this << "has been deleted" << endl;
    }

    void show(){
        cout << a << " " << b << endl;
    }
};

int main(){
    ClassA obj1, obj2(5.2), obj3(8,1);
    obj1.show();
    obj2.show();
    obj3.show();
}