#include <iostream>

using std::cout, std::endl;

class Base {
public:
    int first;

    Base() {
        first = 1;
        second = 2;
        third = 3;
    }

private:
    int second;
protected:
    int third;
};

class child_pub : public Base {
    void show() {
        cout << first << endl;
       // cout << second << endl;
        cout << third << endl;
    }
};
class child_priv : private Base {
    void show() {
        cout << first << endl;
      //  cout << second << endl;
        cout << third << endl;
    }
};

class child_prot : protected Base {
    void show() {
        cout << first << endl;
       // cout << second << endl;
        cout << third << endl;
    }
};


int main() {
    Base b;
    cout << b.first << endl;
    //cout << b.second << endl;
    //cout << b.third << endl;
    child_pub cpub;
    cout << cpub.first << endl;
    //cout << cpub.second << endl;
    //cout << cpub.third << endl;
    child_priv cpriv;
    //cout << cpriv.first << endl;
    //cout << cpriv.second << endl;
    //cout << cpriv.third << endl;
    child_prot cprot;
    //cout << cprot.first << endl;
    //cout << cprot.second << endl;
    //cout << cprot.third << endl;
    return 0;
}