#include <iostream>
#include <math.h>
using namespace std;

class MyClass{

public:
    double x,y;

    double f1(MyClass obj){ // передача объекта
        obj.x++;
        obj.y++;
        return sqrt(pow(sin(obj.x),2) + pow(cos(obj.y),2));
    }

    double f2(MyClass &obj){ // ссылка на объект
        obj.x++;
        obj.y++;
        return sqrt(pow(sin(obj.x),2) + pow(cos(obj.y),2));
    }

    void show(){
        cout << "x = " << x << "\ny = " << this->y << endl;
    }

};

int main(){
    MyClass obj,obj1;
    obj1.x = 5;
    obj1.y = 7;
    cout << "f1" << endl;
    cout << obj.f1(obj1) << endl;
    obj1.show();
    cout << "f2" << endl;
    cout << obj.f2(obj1) << endl;
    obj1.show();
    return 0;
}
