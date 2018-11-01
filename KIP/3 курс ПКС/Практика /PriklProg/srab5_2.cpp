#include <iostream>
#include <math.h>
using namespace std;

class travi{
protected:
    double kolvo;
    double price;
    travi(double h, double w){
        this->kolvo = h;
        this->price = w;
    }
    void show();
};
class petrushka : public travi{
public:
    petrushka(double h, double w) : travi(h,w){

    }
    void show(){
        cout << "Количество петрушки " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
};

class ukrop : public travi{
public:
    ukrop(double h, double w) : travi(h,w){

    }
    void show(){
        cout << "Количество укропа " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
};


int main(){
    petrushka r1(70,5.1);
    ukrop i1(25,15.8);
    r1.show();
    i1.show();

    return 0;
}