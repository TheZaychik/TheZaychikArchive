#include <iostream>

using namespace std;

class A {
private:
    int a = 2;
public:
    int b;

    void show(){
        cout << a << endl;
    }
};

int main(){
    A obj;
    obj.show();
    obj.b = 10;
    cout << obj.b << endl;
}