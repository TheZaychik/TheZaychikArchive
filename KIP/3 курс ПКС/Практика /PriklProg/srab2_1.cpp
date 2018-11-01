#include <iostream>
using namespace std;

class Data{
private:
    int day, month, year;
public:
    static int count;
    void init(int _day = 01, int _month = 01, int _year = 1979){
        count++;
        day = _day;
        month = _month;
        year = _year;
    }
    void show(){
        cout << "Кол-во объектов: " << count << endl;
        cout << day << "." << month << "." << year << endl;
    }
};
int Data::count = 0;

int main(){
    Data d1,d2;
    d1.init(05,02,2000);
    d2.init();
    d1.show();
    d2.show();
}