#include <iostream>
#include "cmath"
using namespace std;

void zad1(){
    int buy_year, curr_year, price, period, price_when_bought;
    int IZNOS = 10;
    int INFLATION = 30;

    cout << "Введите текущий год: ";
    cin >> curr_year;
    cout << "Введите год покупки объекта: ";
    cin >> buy_year;
    cout << "Введите цену покупки: ";
    cin >> price_when_bought;
    price = price_when_bought;
    period = curr_year - buy_year;
    price -= ((price_when_bought/100)*IZNOS)*period;
    price += ((price_when_bought/100)*INFLATION)*period;
    cout << "Цена продукта на текущий год = " + to_string(price) << endl;
}

void zad2(){
    int len;
    double kvad, okrug;
    cout << "Введите длинну: ";
    cin >> len;
    kvad = pow(len, 2);
    okrug = 3.14*pow(len,2);
    if (kvad > okrug) {
        cout << "Площадь квадрата больше";
    } else{
        cout << "Площадь окружности больше";
    }
}

void zad3(){
    int a, b;
    cout << "Введите 2 числа: " << endl;
    cin >> a;
    cin >> b;
    if (a % 2 == 0 && b % 2 == 0){
        cout << "(Оба четные) Сумма: " + to_string(a + b) << endl;
    } else if (a % 2 != 0 && b % 2 != 0){
        cout << "(Оба нечетные) Произведение: " + to_string(a * b) << endl;
    }else {
        cout << "(Один четный, другой нечетный) Увелечение в 5 раз: " + to_string(a * 5) + " и " + to_string(b * 5) << endl;
    }
}

void zad5(){
    int rouble, ost;
    cout << "Введите кол-во рублей: ";
    cin >> rouble;
    ost = rouble % 10;
    if (ost == 1){
        cout <<  to_string(rouble) + " рубль";
    } else if (ost > 1 && ost < 5){
        cout <<  to_string(rouble) + " рубля";
    } else if (ost == 0 || (ost > 4 && ost < 10)){
        cout <<  to_string(rouble) + " рублей";
    }
}

int main() {
    zad5();
    return 0;
}

