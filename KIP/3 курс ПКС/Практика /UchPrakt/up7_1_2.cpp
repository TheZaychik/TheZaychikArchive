#include <iostream>

using namespace std;

void wait() {
    char a;
    cout << "Type 'c' to continue" << endl;
    cin >> a;
}

class Item {
    int info; // имя переменной
    Item *next;// ссылка на следующий элемент
    Item
};
Item *first = nullptr, *p;
int m;

int main() {
    int sw;
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
            wait();
            main();
        }
        case 6: {
            exit(0);
        }
    }
    return 0;
}