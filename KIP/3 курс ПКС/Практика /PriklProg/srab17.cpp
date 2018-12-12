#include <iostream>
#include <vector>
#include <time.h>

using namespace std;
vector<int> vector1;
vector<int> vector2;

int divide(int a, int b) {
    if (b == 0)
        throw "Division by zero!";
    return a / b;
}

void zad1() {
    for (int i = 0; i < 25; i++) {
        vector1.push_back(1 + rand() % 99);
    }
    for (int i = 0; i < 25; i++) {
        try {
            vector2.push_back(divide(vector1[i], 1));
            vector2.push_back(divide(vector1[i], 0));
            vector2.push_back(divide(vector1[i], 3));

        }
        catch (...) {
            vector2.push_back(0);
            vector2.push_back(divide(vector1[i], 3));
        }
    }
    cout << "mas1 | mas2" << endl;
    for (int i = 0; i < 25; i++) {
        cout << vector1[i] << " | " << vector2[i] << endl;
    }
}

int zad2() {
    int sum = 0, kol = 0;
    for (int i = 0; i < 25; i++) {
        sum += vector2[i];
        if (vector2[i] != 0) {
            kol++;
        }
    }
    return sum / kol;
}

int main() {
    zad1();
    cout << "Ср. арифм " << zad2() << endl;

    return 0;
}