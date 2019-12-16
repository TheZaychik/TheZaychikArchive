#include <iostream>
using namespace std;

void function_one(int *a){
    *a += 1;

}

int main(){
    int *a = new int(5);

    cout << a << endl;
    cout << &a << endl;
    cout << *a << endl;

    return 0;
}

