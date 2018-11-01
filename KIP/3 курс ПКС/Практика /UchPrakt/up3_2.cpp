#include <iostream>
#include <string>
using namespace std;
// 10 вар 3 уп
class Note{

private:
    string name, family;
    long telephone;
    int dob[3];
public:
    void show(){
        cout << "ФИО:" << endl;
        cout << this->name << " " << this->family << endl;
        cout << "Телефон: " << this->telephone << endl;
        cout << "Дата рождения: " << this->dob[0] << "." << this->dob[1] << "." << this->dob[2] << endl;
    }
    void input(){
        cout << "Введите имя и фамилию через enter:" << endl;
        cin >> this->name;
        cin >> this->family;
        cout << "Введите номер телефона в след. формате: 0000000000:" << endl;
        cin >> this->telephone;
        cout << "Введите дату рождения через enter:" << endl;
        cin >> this->dob[0];
        cin >> this->dob[1];
        cin >> this->dob[2];
        cout << "Человек добавлен в базу!" << endl;
    }
    long show_tel(){
        return this->telephone;
    }
    string show_fam(){
        return this->family;
    }

    void init1(){
        this->name = "Денис";
        this->family = "Гивчак";
        this->telephone = 89031160132;
        this->dob[0] = 18;
        this->dob[1] = 06;
        this->dob[2] = 2000;
    }
    void init2(){
        this->name = "Анатолий";
        this->family = "Алкоголий";
        this->telephone = 89165376820;
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

