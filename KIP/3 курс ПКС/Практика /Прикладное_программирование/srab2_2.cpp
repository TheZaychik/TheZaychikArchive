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
    Data *ud1, *ud2, *ud3;
    ud1 = &d1;
    ud2 = &d2;
    ud3 = &d3;
    ud1->init(5,5,2000);
    (*ud2).init(8,7,1989);
    ud3->init(22,12,1922);
    (*ud1).show();
    ud2->show();
    ud3->show();

}