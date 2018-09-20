#include <iostream>
#include <string>
using namespace std;

class Student{
private:
    string group;
    string family;
public:
    void add(string family, string group = "3ПКС-116"){
        this->family = family;
        this->group = group;
    }

    void show(){
        cout << "Фамилия: " << this->family << " " << "Группа: " << this->group << endl;
    }


};

int main(){
    Student a, b, c, d;
    a.add("Гивчак");
    b.add("Абдулов", "2ИБАС-517");
    c.add("Сухин");
    d.add("Петренко");
    a.show();
    b.show();
    c.show();
    d.show();

    return 0;
}