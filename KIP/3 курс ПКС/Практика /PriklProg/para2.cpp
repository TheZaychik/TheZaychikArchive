#include <iostream>
using namespace std;

int a, *b, c;
int main(){
    a = 10;
    b = &a;
    c = *b;
    cout << a << endl << *b << endl << c << endl;
    return 0;
}
