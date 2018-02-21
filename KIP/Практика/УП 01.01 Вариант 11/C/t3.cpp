#include <iostream>
#include "cmath"
using namespace std;

void zad1(){
    int doll = 0;
    int sum = 0;
    for (int voz = 1; voz < 19; voz++){
        doll = doll*2 + voz;
        sum += doll;
        cout << "На " + to_string(voz) + " день рождения вам подарили " + to_string(doll) + " долларов." << endl;
    }
    cout << "Всего вам подарили " + to_string(sum) + " долларов." << endl;
}

void zad2(){
    int a, b;
    for(int i = 10; i < 100; i++){
        a = i % 10;
        b = i / 10;
        if((a*a + b*b) % 17 == 0){
            cout << i << endl;
        }

    }

}

int main(){
    zad2();
    return 0;
}