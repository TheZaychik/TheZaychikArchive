#include <iostream>
#include <string>
using namespace std;

class Cat {
protected:
    string color;
public:
    string name;

    void showColor(){
        cout << "Цвет: " << color << endl;
        cout << "Имя: " << name << endl;
    }

};

int main()
{
    return 0;
}
