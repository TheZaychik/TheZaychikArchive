#include <iostream>
#include <string>

using namespace std;

int msize = 4;
int size = 0;

void wait() {
    char a;
    cout << "Type 'c' to continue" << endl;
    cin >> a;
    cin >>
}


class Note {
private:
    string family, number;
public:
    Note(string _fam, string _num) {
        family = _fam;
        number = _num;
    }

    string getNumber() {
        return number;
    }

    string getFamiliy() {
        return family;
    }

    void show() {
        cout << "Объект: " << this << endl;
        cout << "Размер объекта: " << sizeof(*this) << endl;
        cout << "Фамилия: " << family << endl;
        cout << "Телефон: " << number << endl;
    }
};

Note *mas[4];

void vvod() {
    string fam, num;
    if (size == 3) {
        cout << "Массив заполнен!" << endl;
        return;
    }
    for (int i = 0; i < msize; i++) {
        cout << "Введите " << i << " элемент:" << endl;
        cout << "Введите телефон:" << endl;
        cin >> num;
        cout << "Введите фамилию:" << endl;
        cin >> fam;
        mas[i] = new Note(fam, num);
        size++;
    }
}

void showAll() {
    if(size == 0){
        cout << "Массив пуст!" << endl;
        return;
    }
    for (int i = 0; i < msize; i++) {
        cout << "- - - - -" << endl;
        mas[i]->show();
        cout << "- - - - -" << endl;
    }
}

void show499() {
    bool showed = false;
    for (int i = 0; i < msize; i++) {
        if ((mas[i]->getNumber().substr(0, 4) == "8499") || (mas[i]->getNumber().substr(0, 4) == "7499")) {
            cout << "- - - - -" << endl;
            mas[i]->show();
            cout << "- - - - -" << endl;
            showed = true;
        }
    }
    if (!showed) {
        cout << "Таких элементов нет!" << endl;
    }
}


int main() {
    int sw = 0;
    cout << "1)Ввести элементы" << endl;
    cout << "2)Вывести все элементы" << endl;
    cout << "3)Вывести все элементы номера которых начинаются на 499" << endl;
    cout << "4)Выход" << endl;
    cin >> sw;
    switch (sw) {
        case 1:{
            cout << "----------------" << endl;
            vvod();
            break;
        }
        case 2: {
            cout << "----------------" << endl;
            showAll();
            break;
        }
        case 3: {
            cout << "----------------" << endl;
            show499();
            break;
        }
        case 4:{
            exit(0);
        }
        default:
            break;
    }
    wait();
    cout << "----------------" << endl;
    main();
    return 0;
}