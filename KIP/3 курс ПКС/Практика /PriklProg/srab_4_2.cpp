#include <iostream>
using namespace std;
// Вариант 10 функция f1( )  должна взять декремент x и 5* y  и найти к сумму значений
class B;

class A{
    friend class B;
private:
    double x;
public:
    A(double z){
        x = z;
    }

};
class B{
private:
    double y;
public:
    B(double z){
        y = z;
    }
    double f1(A obj1){
        return (--obj1.x) + 5*y;
    }
};



int main(){
    A obj1(5.7);
    B obj2(3.2);
    cout << obj2.f1(obj1) << endl;

    return 0;
}