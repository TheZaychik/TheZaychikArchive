#include <iostream>

using namespace std;

void wait() {
    char a;
    cout << "Type 'c' to continue" << endl;
    cin >> a;
}

struct Item {
    int info; // имя переменной
    Item *next;// ссылка на следующий элемент
};

Item *first = nullptr, *p;
int m;
int sw;


void add() {
    cout << "----------ADD-----------" << endl;
    if (first == nullptr) { // создание начала стека (если не создан)
        first = new (Item);
        p = first;
    }
    while (true) {
        // Вводить числа, пока не введем 0
        cout << "Input number (0 for stop input) " << endl;
        cin >> m;
        if (m == 0)
            break;
        p->info = m;
        p->next = new (Item);
        p = p->next;
    }
}

void delitem() {
    Item *iter = first;
    first = iter->next;
    cout << "---------DELETE---------" << endl;
    cout << "info = " << iter->info << " (address is " << iter << ") was deleted" << endl;
    delete iter;
}

void delspis() {
    Item *iter;
    cout << "-------DELETE-ALL-------" << endl;
    while (first != nullptr) {
        iter = first;
        first = iter->next;
        delete iter;
        cout << "info = " << iter->info << " (address is " << iter << ") was deleted" << endl;
    }
}

int show() {
    Item *iter = first;
    cout << "----------SHOW----------" << endl;
    if (iter == nullptr) {
        cout << "Nothing to show!" << endl;
        return 0;
    }
    while (iter != nullptr) {
        cout << "info = " << iter->info << " (address is " << iter << ")" << endl;
        iter = iter->next;
    }
    return 0;
}

int search(int s) {
    cout << "---------SEARCH---------" << endl;
    Item *iter = first;
    if (iter == nullptr) {
        cout << "Nothing to search!" << endl;
        return 0;
    }
    while (iter != nullptr) {
        if (iter->info == s) {
            cout << "Element was founded!" << endl;
            cout << "info = " << iter->info << " (address is " << iter << ")" << endl;
            break;
        }
        iter = iter->next;
    }
    return 0;
}

int main() {
    sw = 0;
    cout << "List of elements menu: " << endl;
    cout << "1) Add (create) list" << endl;
    cout << "2) Show list" << endl;
    cout << "3) Delete first item" << endl;
    cout << "4) Delete all list" << endl;
    cout << "5) Search element" << endl;
    cout << "6) Exit" << endl;
    cin >> sw;
    switch (sw) {
        case 1: {
            add();
            wait();
            main();
        }
        case 2: {
            show();
            wait();
            main();
        }
        case 3: {
            delitem();
            wait();
            main();
        }
        case 4: {
            delspis();
            wait();
            main();
        }
        case 5: {
            cout << "Enter the search value:" << endl;
            cin >> sw;
            search(sw);
            sw = 0;
            wait();
            main();
        }
        case 6: {
            exit(0);
        }
        default:{
            main();
        }
    }
    return 0;
}