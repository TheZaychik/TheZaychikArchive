#include <iostream>
using namespace std;

int main() {
    int a;
    cout << "Hello, World!" << endl;
    cin >> a;
    cout << "Ввведенное число " + to_string(a) << endl;
    return 0;
}