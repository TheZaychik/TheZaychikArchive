#include <iostream>
#include <math.h>
using namespace std;

class MyClass{

public:
    double x,y;

    double f1(MyClass obj){ // передача объекта
        this->x = obj.x;
        this->y = obj.y;
        return pow(this->x++,2) + this->y;
    }
    MyClass f2(MyClass obj){
        this->x = obj.x;
        this->y = obj.y;
        return *this;
    }

    void show(){
        cout << "x = " << this->x << "\ny = " << this->y << endl;
    }

};

int main(){
    MyClass obj,obj1;
    obj1.x = 5;
    obj1.y = 7;
    obj = obj1.f2(obj1);
    cout << "f1" << endl;
    cout << obj.f1(obj1) << endl;
    cout << "f2" << endl;
    obj.show();
    obj1.show();
    return 0;
}
