#include <iostream>
#include <math.h>
using namespace std;
// var 2
class circle{
private:
    friend class dot;
    int r;
public:
    circle(int _r){
        this->r = _r;
        cout << "Объект класса точка создан с адресом: " << this;
        cout << " и параметром r = " << this->r << endl;
    }
    ~circle(){
        cout << "Объект класса круг с адресом  " << this << " удален! ";
        cout << "с параметром r = " << this->r << endl;
    }
};

class dot{
private:
    int x, y;
public:
    dot(int _x, int _y){
        this->x = _x;
        this->y = _y;
        cout << "Объект класса точка создан с адресом: " << this;
        cout << " и параметрами x = " << this->x << " y = " << this->y << endl;
    }

    ~dot(){
        cout << "Объект класса точка с адресом " << this << " удален!";
        cout << " c параметрами x = " << this->x << " y = " << this->y << endl;
    }

    void isBelongs(circle &obj){
        if((x*x + y*y) <= obj.r * obj.r){
            cout << "Точка " << &obj << " принадлежит кругу " << this << endl;
        } else{
            cout << "Точка " << &obj << " НЕ принадлежит кругу " << this << endl;
        }
    }
};

int main(){
    dot d[3] = {dot(5,5),dot(2,3), dot(7,2)};
    circle c[3] = {4,10,45};
    cout << "---------------" << endl;
    for (int i = 0; i < 3; i++){
        d[i].isBelongs(c[i]);
    }
    cout << "---------------" << endl;
    return 0;
}