#include <iostream>
#include <string>
#include <fstream>
using namespace std;
// 6 вар 3 уп
class Note{

private:
    string punkt, nomer;
    long time;
    int dob[3];
public:
    void print(ofstream &f){
        f << "Поезд:" << endl;
        f << this->punkt << " " << this->nomer << endl;
        f << "Телефон: " << this->time << endl;
        f << "Дата : " << this->dob[0] << "." << this->dob[1] << "." << this->dob[2] << endl;
        f << "-----------" << endl;
    }
    void show(){
        cout << "Поезд:" << endl;
        cout << this->punkt << " " << this->nomer << endl;
        cout << "Телефон: " << this->time << endl;
        cout << "Дата : " << this->dob[0] << "." << this->dob[1] << "." << this->dob[2] << endl;
    }
    void input(){
        cout << "Введите место назначения и номер через enter:" << endl;
        cin >> this->punkt;
        cin >> this->nomer;
        cout << "Введите время в след. формате: 0000:" << endl;
        cin >> this->time;
        cout << "Введите дату отправления через enter:" << endl;
        cin >> this->dob[0];
        cin >> this->dob[1];
        cin >> this->dob[2];
        cout << "Поезд добавлен в базу!" << endl;
    }
    long show_tel(){
        return this->time;
    }
    string show_fam(){
        return this->nomer;
    }

    void init1(){
        this->punkt = "London";
        this->nomer = "2015";
        this->time = 1840;
        this->dob[0] = 18;
        this->dob[1] = 06;
        this->dob[2] = 2000;
    }
    void init2(){
        this->punkt = "Moscow";
        this->nomer = "2018";
        this->time = 1930;
        this->dob[0] = 24;
        this->dob[1] = 05;
        this->dob[2] = 2000;
    }
};

Note mas[2];
int count1 = 0;

void init(){
    mas[0].init2();
    mas[1].init1();
}

void input(){
    if(count1 >= 2){
        cout << "В базе нет места!" << endl;
    }
    else{
        mas[count1].input();
        count1++;
    }

}

void sort_mas(){
    Note buff;
    for(int i = 0; i < 2; i++){
        for(int j = 0; j < 1; j++){
            if(mas[j].show_tel() > mas[j+1].show_tel()){
                buff = mas[j];
                mas[j] = mas[j+1];
                mas[j+1] = buff;
            }
        }
    }
}

void write_all(){
    ofstream f("textfiles/denis2.txt", ofstream::out);
    for(int i = 0; i < 2; i++){
        mas[i].print(f);
    }
    f.close();
}

void show_all(){
    for(int i = 0; i < 2; i++){
        mas[i].show();
    }
}

int searchShow(string _familiy){
    for(int i = 0; i < 2; i++){
        if (_familiy == mas[i].show_fam()){
            mas[i].show();
            return 0;
        }
    }
    cout << "Таких данных нету!" << endl;
}

int main(){
    int n;
    cout << "----------------" << endl;
    cout << "Выберите действия: " << endl;
    cout << "1) Ввести в массив данные" << endl;
    cout << "2) Показать все данные" << endl;
    cout << "3) Поиск по номеру" << endl;
    cout << "4) Сортировка по времени отправления" << endl;
    cout << "5) Запись в файл" << endl;
    cout << "6) Выход" << endl;
    cin >> n;
    switch(n){
        case 1:{
            cout << "----------------" << endl;
            input();
            main();

        };
        case 2:{
            cout << "----------------" << endl;
            show_all();
            main();

        };
        case 3:{
            cout << "----------------" << endl;
            string family;
            cout << "Введите номер:" << endl;
            cin >> family;
            searchShow(family);
            main();

        };
        case 4:{
            cout << "----------------" << endl;
            sort_mas();
            cout << "Массив был отсортирован по времени отправления!" << endl;
            main();

        };
        case 5:{
            cout << "----------------" << endl;
            write_all();
            cout << "Массив был записан в файл!" << endl;
            main();
        }
        case 6:{
            exit(0);
        };
        case 7:{
            init();
            main();
        };
    }



    return 0;
}

