#include <iostream>
#include <string>
// 10 вар 3 уп
using namespace std;

struct Note{
    string name, family;
    long telephone;
    int dob[3];
};

Note mas[2];
int count1 = 0;

void init(){
    mas[1].name = "Денис";
    mas[1].family = "Гивчак";
    mas[1].telephone = 89031160132;
    mas[1].dob[0] = 18;
    mas[1].dob[1] = 06;
    mas[1].dob[2] = 2000;

    mas[0].name = "Анатолий";
    mas[0].family = "Алкоголий";
    mas[0].telephone = 89165376820;
    mas[0].dob[0] = 24;
    mas[0].dob[1] = 05;
    mas[0].dob[2] = 2000;
}

void input(){
    if(count1 >= 2){
        cout << "В базе нет места!" << endl;
    }
    else{
        cout << "Введите имя и фамилию через enter:" << endl;
        cin >> mas[count1].name;
        cin >> mas[count1].family;
        cout << "Введите номер телефона в след. формате: 0000000000:" << endl;
        cin >> mas[count1].telephone;
        cout << "Введите дату рождения через enter:" << endl;
        cin >> mas[count1].dob[0];
        cin >> mas[count1].dob[1];
        cin >> mas[count1].dob[2];
        cout << "Человек добавлен в базу!" << endl;
        count1++;
    }

}

void sort_mas(){
    Note buff;
    for(int i = 0; i < 2; i++){
        for(int j = 0; j < 1; j++){
            if(mas[j].telephone > mas[j+1].telephone){
                buff = mas[j];
                mas[j] = mas[j+1];
                mas[j+1] = buff;
            }
        }
    }
}

void show_all(){
    for(int i = 0; i < 2; i++){
        cout << "ФИО:" << endl;
        cout << mas[i].name << " " << mas[i].family << endl;
        cout << "Телефон: " << mas[i].telephone << endl;
        cout << "Дата рождения: " << mas[i].dob[0] << "." << mas[i].dob[1] << "." << mas[i].dob[2] << endl;
    }
}

void searchShow(string _familiy){
    for(int i = 0; i < 2; i++){
        if (_familiy == mas[i].family){
            cout << "ФИО:" << endl;
            cout << mas[i].name << " " << mas[i].family << endl;
            cout << "Телефон: " << mas[i].telephone << endl;
            cout << "Дата рождения: " << mas[i].dob[0] << "." << mas[i].dob[1] << "." << mas[i].dob[2] << endl;
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
    cout << "3) Поиск по фамилии" << endl;
    cout << "4) Сортировка по номеру" << endl;
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