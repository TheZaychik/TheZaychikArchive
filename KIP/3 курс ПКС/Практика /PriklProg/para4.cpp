#include <iostream>
using namespace std;

int func1(int a = 5){ // значение по умолчанию

    return a + 5;
}

void func2(int a, int b = 4);

int main(){
    cout << func1() << endl;
    func2(15);
    return 0;
}

void func2(int a, int b){
    cout << a << " " << b << endl;
}