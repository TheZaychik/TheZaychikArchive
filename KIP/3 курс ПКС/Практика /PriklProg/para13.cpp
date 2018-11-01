
#include <iostream>
using namespace std;

class Base
{
public:
    Base() {cout << "Работа конструктора базового класса"<<endl;}
    ~Base(){cout << "Работа деструктора базового класса"<<endl;}
};

class Deriver : public Base
{
public:
    Deriver(){cout <<"Работа конструктора производного класса"<<endl;}
    ~Deriver(){cout <<"Работа деструктора производного класса"<<endl;}
};

int main(){
    Deriver obj;
    return 0;
}