#include <iostream>
using namespace std;

class A{
public:
    int x;
    int y;
};

class B: public A{
public:
    int z;
    void show(){
        cout << "x = " << x << endl;
        cout << "y = " << y << endl;
        cout << "z = " << z << endl;
    }
};

int main(){
    B obj;
    obj.y = 1;
    obj.z = 2;
    obj.x = 5;
    obj.show();
    return 0;
}