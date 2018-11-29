#include <iostream>

using namespace std;

struct Note {
    string fname, sname, number;
    int dob[3];

} nt[3];

void outfile() {
    FILE *f = fopen("textfiles/up11.txt", "r+");
    for (int i = 0; i < 3; i++) {
        fprintf(f, "%s", nt[i].fname.c_str());
        fprintf(f, "%s", nt[i].sname.c_str());
        fprintf(f, "%s", nt[i].number.c_str());
        fprintf(f, "%d.%d.%d", nt[i].dob[0], nt[i].dob[1], nt[i].dob[2]);
    }
    fclose(f);
}

void intfile() {
    FILE *f = fopen("textfiles/up11.txt", "r+");
    for (int i = 0; i < 3; i++) {
        fscanf(f, "%s", nt[i].fname.c_str());
        fprintf(f, "%s", nt[i].sname.c_str());
        fprintf(f, "%s", nt[i].number.c_str());
        fprintf(f, "%d.%d.%d", nt[i].dob[0], nt[i].dob[1], nt[i].dob[2]);
    }
    fclose(f);
}

void input() {
    for (int i = 0; i < 3; i++) {
        cout << "Введите имя:" << endl;
        cin >> nt[i].fname;
        cout << "Введите фамилию:" << endl;
        cin >> nt[i].sname;
        cout << "Введите номер телефона:" << endl;
        cin >> nt[i].number;
        cout << "Введите дату рождение через Enter:" << endl;
        cin >> nt[i].dob[0];
        cin >> nt[i].dob[1];
        cin >> nt[i].dob[2];
    }
}


void show(Note nt) {
    cout << nt.fname << endl;
    cout << nt.sname << endl;
    cout << nt.number << endl;
    cout << nt.dob[0] << "." << nt.dob[1] << "." << nt.dob[2] << endl;
}

void show_all() {
    for (int i = 0; i < 3; i++) {
        show(nt[i]);
    }
}

void searchByMonth() {
    int month;
    cout << "Введите месяц для поиска" << endl;
    cin >> month;
    for (int i = 0; i < 3; i++) {
        if (month == nt[i].dob[1]) {
            cout << "Человек найден:" << endl;
            show(nt[i]);
            return;
        }
    }
    cout << "Человек не найден!" << endl;
}

int main() {
    input();
    searchByMonth();
    show_all();
    return 0;
}