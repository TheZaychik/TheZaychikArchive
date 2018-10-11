#include <iostream>
#include <math.h>
using namespace std;

class kustarnik{
protected:
    double kolvo;
    double price;
    kustarnik (double h, double w){
        cout << "Работа конструктора класса кустарник" << endl;
        this->kolvo = h;
        this->price = w;
    }
    ~kustarnik(){
        cout << "Работа деструктора класса кустарник"<<endl;
    }
    void show();
};
class siren : public kustarnik{
public:
    siren(double h, double w) : kustarnik(h,w){
        cout << "Работа конструктора класса Сирень" << endl;
    }
    void show(){
        cout << "Количество сирени " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
    ~siren(){
        cout<<"Работа деструктора класса Сирень"<<endl;
    }
};

class cheremuha : public kustarnik{
public:
    cheremuha(double h, double w) : kustarnik(h,w){
       cout <<"Работа конструктора класса Черемуха"<<endl;
    }
    void show(){
        cout << "Количество черемухи " << this->kolvo << " кг." << endl;
        cout << "Цена за кг: " << this->price << " руб." << endl;
    }
    ~cheremuha(){cout <<"Работа деструктора класса Черемуха"<<endl;}
};


int main(){
    siren r1(90,5.1);
    cheremuha i1(25,15.8);
    r1.show();
    i1.show();

    return 0;
}

