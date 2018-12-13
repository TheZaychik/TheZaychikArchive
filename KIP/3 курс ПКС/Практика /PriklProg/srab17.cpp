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
    cout << "Исходный массив: ";
    for (int i = 0; i < 25; i++) {
        cout << vector1[i] << " ";
    }
    cout << endl;
    cout.width(10);
    cout << "/1";
    cout.width(10);
    cout << "/0";
    cout.width(10);
    cout << "/3" << endl;
    for (int i = 0; i < 24; i +=3){
        cout.width(10);
        cout << vector1[i];
        cout.width(10);
        cout << vector1[i + 1];
        cout.width(10);
        cout << vector1[i + 2];
        cout << endl;
    }
    cout << "-------------------------------------------" << endl;
    for (int i = 0; i < 24; i +=3){
        try {
            vector2.push_back(divide(vector1[i], 1));
            vector2.push_back(divide(vector1[i + 2], 3));
            cout.width(10);
            cout << divide(vector1[i], 1);
            cout.width(10);
            cout << divide(vector1[i + 1], 0);
            cout.width(10);
            cout << divide(vector1[i + 2], 3);
            cout << endl;
        }
        catch (...){
            vector2.push_back(0);
            cout << "zero";
            cout.width(10);
            cout << divide(vector1[i + 2], 3);
            cout << endl;
        }
    }
    FILE *f = fopen("textfiles/srab17.txt", "r+");
    for(int i = 0; i < 25; i++){
        fprintf(f, "%d\n", vector2[i]);
    }
    fclose(f);
}

int zad2() {
    int sum = 0, kol = 0, buff;
    FILE *f = fopen("textfiles/srab17.txt", "r+");
    for (int i = 0; i < 25; i++) {
        fscanf(f, "%d\n", &buff);
        sum += buff;
        if (buff != 0) {
            kol++;
        }
    }
    return sum / kol;
}

int main() {
    zad1();
    cout << "Ср. арифм: " << zad2() << endl;
    return 0;
}