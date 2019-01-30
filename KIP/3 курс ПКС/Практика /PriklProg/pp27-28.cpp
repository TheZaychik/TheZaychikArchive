#include <iostream>

using namespace std;

// 1
class Month {
private:
    int m;
public:
    Month(int _m) {
        m = _m;
    }

    void Show() {
        cout << "Месяц " << m << endl;
    }

    void AddMonth(int _m) {
        m += _m;
        if (m > 12) {
            m -= 12;
        }
    }
};

// 2
class Figure {
public:
    virtual double Square();
};

class Parallp : Figure {
public:
    double Square(int a, int b, int c) {
        return a * b * c;
    }
};

class Sphere : Figure {
public:
    double Square(int r) {
        return 4 * 3.14 * (r * r);
    }
};

int main() {
    //1
    Month obj1(6);
    obj1.Show();
    obj1.AddMonth(8);
    obj1.Show();
    //2
    Parallp obj2;
    cout << obj2.Square(5, 5, 5) << endl;
    Sphere obj3;
    cout << obj3.Square(5) << endl;
    return 0;
}