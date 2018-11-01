#include <iostream>
#include <string>

using namespace std;


void wait() {
    char a;
    cout << "Type 'c' to continue" << endl;
    cin >> a;
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

struct Item {
    Note *item = nullptr; // имя переменной
    Item *next;// ссылка на следующий элемент
};

Item *first = nullptr, *p;
int m;
int sw;


void add() {
    string fam, num;
    cout << "----------ADD-----------" << endl;
    if (first == nullptr) { // создание начала стека (если не создан)
        first = new (Item);
        p = first;
    }
    while (true) {
        // Вводить числа, пока не введем 0
        cout << "Input 0 for stop" << endl;
        cout << "Input number:" << endl;
        cin >> num;
        if (num == "0")
            break;
        cout << "Input family:" << endl;
        cin >> fam;
        p->item = new Note(fam, num);
        p->next = new (Item);
        p = p->next;
    }
}


void delitem() {
    Item *iter = first;
    first = iter->next;
    cout << "---------DELETE---------" << endl;
    iter->item->show();
    cout << "Was deleted!" << endl;
    delete iter;
}

void delspis() {
    Item *iter;
    cout << "-------DELETE-ALL-------" << endl;
    while (first->item != nullptr) {
        iter = first;
        first = iter->next;
        delete iter;
        iter->item->show();
    }
}

void show() {
    Item *iter = first;
    cout << "----------SHOW----------" << endl;
    if (iter->item == nullptr) {
        cout << "Nothing to show!" << endl;
        return;
    }
    while (iter->item != nullptr) {
        iter->item->show();
        iter = iter->next;
    }
}

void SearchAndDelete(string &fam) {
    cout << "----SEARCH-N-DELETE-----" << endl;
    Item *iter = first;
    Item *s_iter = nullptr;
    if (iter->item == nullptr) {
        cout << "Nothing to search!" << endl;
        return;
    }
    while (iter->item != nullptr) {
        if (iter->item->getFamiliy() == fam) {
            cout << "Element was founded and removed!" << endl;
            if (s_iter != nullptr) {
                s_iter->next = iter->next;
                delete iter;
            } else {
                first = iter->next;
                delete iter;
            }
            break;
        }
        s_iter = iter;
        iter = iter->next;
    }
}

void Search(string &fam) {
    cout << "---------SEARCH---------" << endl;
    Item *iter = first;
    if (iter->item == nullptr) {
        cout << "Nothing to search!" << endl;
        return;
    }
    while (iter != nullptr) {
        if (iter->item->getFamiliy() == fam) {
            cout << "Element was founded!" << endl;
            iter->item->show();
            break;
        }
        iter = iter->next;
    }

}


int main() {
    sw = 0;
    cout << "List of Notes menu: " << endl;
    cout << "1) Add (create) list of Notes" << endl;
    cout << "2) Show list" << endl;
    cout << "3) Delete first item" << endl;
    cout << "4) Delete all list" << endl;
    cout << "5) Search element" << endl;
    cout << "6) Search and delete" << endl;
    cout << "7) Exit" << endl;
    cin >> sw;
    switch (sw) {
        case 1: {
            add();
            break;
        }
        case 2: {
            show();
            break;
        }
        case 3: {
            delitem();
            break;
        }
        case 4: {
            delspis();
            break;
        }
        case 5: {
            string *fam = new string();
            cout << "Enter the search value:" << endl;
            cin >> *fam;
            Search(*fam);
            delete fam;
            break;

        }
        case 6: {
            string *fam = new string();
            cout << "Enter the search value:" << endl;
            cin >> *fam;
            SearchAndDelete(*fam);
            delete fam;
            break;
        }
        case 7: {
            exit(0);
        }
        default:
            break;
    }
    wait();
    main();
    return 0;
}