#include <iostream>
#include <math.h>
using namespace std;

class kustarnik{
protected:
    double kolvo;
    double price;
    kustarnik (double h, double w){
        this->kolvo = h;
        this->price = w;
    }
    void show();
};
class siren : public kustarnik{
public:
    siren(double h, double w) : kustarnik(h,w){

    }
    void show(){
        cout << "Количество сирени " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
};

class cheremuha : public kustarnik{
public:
    cheremuha(double h, double w) : kustarnik(h,w){

    }
    void show(){
        cout << "Количество черемухи " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
};


int main(){
    siren r1(90,5.1);
    cheremuha i1(25,15.8);
    r1.show();
    i1.show();
    return 0;
}

