#include <iostream>
using namespace std;
 // Вариант 10 функция f1( )  должна взять декремент x и 5* y  и найти к сумму значений
class B;

class A{
    friend double f1(A obj1, B obj2);
    friend void show(A obj1, B obj2);
private:
    double x;
public:
    A(double z){
        x = z;
    }

};

class B{
    friend double f1(A obj1, B obj2);
    friend void show(A obj1, B obj2);
private:
    double y;
public:
    B(double z){
        y = z;
    }
};

double f1(A obj1, B obj2){
    return (--obj1.x) + 5*obj2.y;
}

void show(A obj1, B obj2){
    cout << "a = " << obj1.x << endl;
    cout << "a = " << obj2.y << endl;
}

int main(){
    A obj1(5.7);
    B obj2(3.2);
    cout << f1(obj1,obj2) << endl;
    show(obj1, obj2);

    return 0;
}