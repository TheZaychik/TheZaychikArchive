#include <iostream>
#include "cmath"
using namespace std;

void zad1(){
    double kg_KP, kg_AP, kg_CH, gr_KP, gr_AP, gr_CH;
    cin >> kg_KP;
    cin >> kg_AP;
    cin >> kg_CH;
    cin >> gr_KP;
    cin >> gr_AP;
    cin >> gr_CH;
    cout << "Стоимость набора = " + to_string(kg_KP*gr_KP/1000 + kg_AP*gr_AP/1000 + kg_CH*gr_CH/1000);
}
void zad2(){
    int min, sec, hour;
    cin >> min;
    cin >> sec;
    sec = min*60 + sec;
    hour = (sec / 3600) % 24;
    min = (sec / 60) % 60;
    cout << "Время: " + to_string(hour) + " часов " + to_string(min) + " минут.";
}



int main() {
    //zad1();
    zad2();
    return 0;
}