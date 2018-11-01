#include <iostream>
using namespace std;

float mathfunc(int a, int b);
float mathfunc(int a, int b, int c);

int main() {
    cout << mathfunc(5,2) << endl;
    cout <<  mathfunc(3,4,5) << endl;
    return 0;
}

float mathfunc(int a, int b){
    return a + b;
}

float mathfunc(int a, int b, int c){
    return a*b*c;
}