#include <iostream>
using namespace std;

class Data{
private:
    int day, month, year;
public:
    static int count;
    void init(int _day, int _month, int _year){
        count++;
        this->day = _day;
        this->month = _month;
        this->year = _year;
    }
    void show(){
        cout << "Кол-во объектов: " << count << endl;
        cout << day << "." << month << "." << year << endl;
    }
};
int Data::count = 0;

int main(){
    Data d1,d2,d3;
    d1.init(05,02,2000);
    d2.init(07,02,1956);
    d3.init(05,05,1980);
    d1.show();
    d2.show();
    d3.show();
}