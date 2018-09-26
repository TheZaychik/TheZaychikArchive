#include <iostream>
using namespace std;

class Data{
private:
    int day, month, year;
public:
    void init(int _day, int _month, int _year){
        this->day = _day;
        this->month = _month;
        this->year = _year;
    }
    void show(){
        cout << day << "." << month << "." << year << endl;
    }
};

int main(){
    Data d1,d2,d3;
    d1.init(05,02,2000);
    d2.init(07,08,1989);
    d3.init(05,05,1980);
    d1.show();
    d2.show();
    d3.show();

}