#include <iostream>
using namespace std;

class Base
{int i;
public:
    Base(int n){
        cout <<"Работа когструктора базового класса"<<endl;
        this->i = n;
    }
    ~Base (){cout<<"Работа деструктора базового класса"<<endl; }
    void showi(){cout <<"i="<<i<<endl;}
};
class Deriver : public Base{
    int j;
public:
    Deriver (int n, int m) :Base(m){
        cout <<"Работа конструктора производного класса"<<endl;

    }
    ~Deriver(){cout<<"Работа деструктора производного класса"<<endl;}
    void showj(){cout <<"j ="<<j<<endl;}
};
int main(){
    Deriver obj(10,20);
    obj.showi();
    obj.showj();
}