#include <iostream>
#include <string>
#include <fstream>
#include <vector>
// вар 9
using namespace std;
string s;
int sw;

void wait() {
    char a;
    cout << "Type 'c' to continue" << endl;
    cin >> a;
}

void search_fam() {
    ifstream f("textfiles/text.txt", ios_base::out);
    char b;
    cout << "Введите 1 букву фамилии" << endl;
    cin >> b;
    while (getline(f, s)) {
        if (s.c_str()[0] == b) {
            cout << s << endl;
        }
    }
    f.close();
}

void search_tesk() {
    string name;
    int pos, sb;
    ifstream f("textfiles/text.txt", ios_base::out);
    cout << "Ведите имя для поиска тезки" << endl;
    cin >> name;
    while (getline(f, s)) {
        pos = -1;
        for (int i = 0; i < s.length(); i++) {
            if (s[i] == ' ') {
                if (pos == -1) {
                    pos = i + 1;
                } else {
                    sb = i - pos;
                }
            }
        }
        if (s.substr(pos, sb) == name) {
            cout << s << endl;
        }
    }
    f.close();
}

void search_odnofam() {
    string fam, name;
    int n = 0;
    vector<string> mas;
    ifstream f("textfiles/text.txt", ios_base::out);
    while (getline(f, s)) {
        mas.push_back(s);
    }
    for (int i = 0; i < mas.size(); i++) {
        for (int j = 0; j < mas[i].length(); j++) {
            if (mas[i][j] == ' ') {
                name = mas[i];
                fam = mas[i].substr(0, j);
                break;
            }

        }
        for (int j = 0; j < mas.size(); j++) {
            for (int k = 0; k < mas[j].length(); k++) {
                if (mas[j][k] == ' ') {
                    if ((fam == mas[j].substr(0, k)) && (mas[j] != name)) {
                        cout << mas[j] << endl;
                        break;
                    }
                    break;
                }
            }
        }
    }

}

int main() {
    sw = 0;
    cout << "Меню:" << endl;
    cout << "1) Посик по 1 букве фамилии" << endl;
    cout << "2) Поиск по имени" << endl;
    cout << "3) Поиск однофамильцев" << endl;
    cout << "4) Выход" << endl;
    cin >> sw;
    switch (sw) {
        case 1: {
            search_fam();
            wait();
            main();
        }
        case 2: {
            search_tesk();
            wait();
            main();
        }
        case 3: {
            search_odnofam();
            wait();
            main();
        }
        case 4: {
            exit(0);

        }
        default: {
            main();
        }
    }
    return 0;
}