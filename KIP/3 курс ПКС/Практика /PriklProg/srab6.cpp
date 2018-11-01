#include <iostream>
#include <string>

using namespace std;

// вар 10 ПП6
class Human {
private:
    string name, family, patron;
public:
    Human(string _name, string _family, string _patron) {
        this->name = _name;
        this->family = _family;
        this->patron = _patron;
    }

    void show() {
        cout << "Obj: " << name << " " << family << " " << patron << endl;
    }

    void show_a();
};

class Buhgalter : public Human {
private:
    int oklad;
public:
    Buhgalter(string _name, string _family, string _patron, int _oklad) : Human(_name, _family, _patron) {
        this->oklad = _oklad;
    }

    void show_a() {
        cout << "Buhgalter with oklad " << oklad << endl;
    }
};

class Svarshik : public Human {
private:
    int razryad;
public:
    Svarshik(string _name, string _family, string _patron, int _razryad) : Human(_name, _family, _patron) {
        this->razryad = _razryad;
    }

    void show_a() {
        cout << "Svarshik with razryad " << razryad << endl;
    }
};

int main() {
    Buhgalter b("Ivan", "Ivanov", "Ivanovich", 200);
    Svarshik s("Anatoly", "Sergeev", "Sergeevich", 1);
    b.show();
    b.show_a();
    s.show();
    s.show_a();
    return 0;
}