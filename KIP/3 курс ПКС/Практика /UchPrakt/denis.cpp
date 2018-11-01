
#include <iostream>
#include <string>
using namespace std;
// 6 вар 3 уп
struct Note{
    string punkt, nomer;
    long time;
    int dob[3];
};

Note mas[2];
int count1 = 0;

void init(){
    mas[1].punkt = "Moscow";
    mas[1].nomer = "132";
    mas[1].time = 1630;
    mas[1].dob[0] = 18;
    mas[1].dob[1] = 06;
    mas[1].dob[2] = 2000;

    mas[0].punkt = "London";
    mas[0].nomer = "255";
    mas[0].time = 1540;
    mas[0].dob[0] = 24;
    mas[0].dob[1] = 05;
    mas[0].dob[2] = 2000;
}

void input(){
    if(count1 >= 2){
        cout << "В базе нет места!" << endl;
    }
    else{
        cout << "Введите место назначения и номер поезда через enter:" << endl;
        cin >> mas[count1].punkt;
        cin >> mas[count1].nomer;
        cout << "Введите время в след. формате: 0000:" << endl;
        cin >> mas[count1].time;
        cout << "Введите дату отправления через enter:" << endl;
        cin >> mas[count1].dob[0];
        cin >> mas[count1].dob[1];
        cin >> mas[count1].dob[2];
        cout << "Поезд добавлен в базу!" << endl;
        count1++;
    }

}

void sort_mas(){
    Note buff;
    for(int i = 0; i < 2; i++){
        for(int j = 0; j < 1; j++){
            if(mas[j].time > mas[j+1].time){
                buff = mas[j];
                mas[j] = mas[j+1];
                mas[j+1] = buff;
            }
        }
    }
}

void show_all(){
    for(int i = 0; i < 2; i++){
        cout << "Поезд:" << endl;
        cout << mas[i].punkt << " " << mas[i].nomer << endl;
        cout << "Время: " << mas[i].time << endl;
        cout << "Дата отправления: " << mas[i].dob[0] << "." << mas[i].dob[1] << "." << mas[i].dob[2] << endl;
    }
}

void searchShow(string _familiy){
    for(int i = 0; i < 2; i++){
        if (_familiy == mas[i].nomer){
            cout << "Поезд:" << endl;
            cout << mas[i].punkt << " " << mas[i].nomer << endl;
            cout << "Время: " << mas[i].time << endl;
            cout << "Дата отправления: " << mas[i].dob[0] << "." << mas[i].dob[1] << "." << mas[i].dob[2] << endl;
            break;
        }
    }
}

int main(){
    int n;
    cout << "----------------" << endl;
    cout << "Выберите действия: " << endl;
    cout << "1) Ввести в массив данные" << endl;
    cout << "2) Показать все данные" << endl;
    cout << "3) Поиск по номеру" << endl;
    cout << "4) Сортировка по времени отправления" << endl;
    cout << "5) Выход" << endl;
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
            cout << "Введите фамилию:" << endl;
            cin >> family;
            searchShow(family);
            main();

        };
        case 4:{
            cout << "----------------" << endl;
            sort_mas();
            cout << "Массив был отсортирован по номеру телефона!" << endl;
            main();

        };
        case 5:{
            exit(0);
        };
        case 6:{
            init();
            main();
        };
    }



    return 0;
}