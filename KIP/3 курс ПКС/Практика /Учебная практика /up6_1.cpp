#include <iostream>
#include <math.h>
using namespace std;

class travi{
protected:
    double kolvo;
    double price;
    travi(double h, double w){
        cout << "Работа конструктора класса Травы" << endl;
        this->kolvo = h;
        this->price = w;
    }
    ~travi(){
        cout << "Работа деструктора класса Травы" << endl;
    }

    void show();
};
class petrushka : public travi{
public:
    petrushka(double h, double w) : travi(h,w){
        cout << "Работа конструктора класса Петрушка" << endl;
    }
    void show(){
        cout << "Количество петрушки " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
    ~petrushka(){
        cout << "Работа деструктора класса Петрушка" << endl;
    }
};

class ukrop : public travi{
public:
    ukrop(double h, double w) : travi(h,w){
        cout << "Работа конструктора класса Укроп" << endl;
    }
    void show(){
        cout << "Количество укропа " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
    ~ukrop(){
        cout << "Работа деструктора класса Укроп" << endl;
    }
};


int main(){
    petrushka r1(70,5.1);
    ukrop i1(25,15.8);
    r1.show();
    i1.show();
    return 0;
}