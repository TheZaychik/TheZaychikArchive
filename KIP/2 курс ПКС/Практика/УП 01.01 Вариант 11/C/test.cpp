#include <iostream>
#include "cmath"
using namespace std;

void func1(int &a){
    a +=10;

}

int main() {
    int a = 5;
    cout << a << endl;
    func1(a);
    cout << a;
    return 0;
}
