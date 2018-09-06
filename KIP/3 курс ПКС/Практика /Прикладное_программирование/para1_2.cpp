#include "iostream"

using namespace std;

class SimpleClass{
public:
//private:
    int n = 0, m = 0;
//public:
    void set(int a, int b){
        n = a;
        m = b;
    }
    int summa(){
        return n + m;

    }
    void show(){
        cout << "----------" << endl;
        cout << "n = " << n << endl;
        cout << "m = " << m << endl;
        cout << "----------" << endl;
    }
    void mult(int k) {
        n *= k;
        m *= k;
    }
};

int main(){
    SimpleClass myobj1, myobj2, myobj3;
    myobj1.n = 5; myobj1.m = 5; // public
    myobj2.n = 1; myobj2.m = 3;
    myobj3.n = 9; myobj3.m = 7;
    myobj1.show();
    myobj2.show();
    myobj3.show();
    myobj3.mult(5);
    myobj3.show();
    /*myobj1.set(5,5);  // private
    myobj1.show();
    myobj1.mult(5);
    myobj1.show(); */

}