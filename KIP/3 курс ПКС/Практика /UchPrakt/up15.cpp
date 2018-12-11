#include <iostream>
#include <regex>
#include <string.h>

using namespace std;

int main(){
    int kol = 0;
    string str, ipt, buff = "";
    FILE *f =  fopen("textfiles/up15_1.txt", "r+");
    while (!feof(f)){
        str += fgetc(f);
    }
    cout << "Считанная строка: " << str << endl;
    cout << "Введите слово для поиска кол-во совпадений" << endl;
    cin >> ipt;
    for (int i = 0; i < str.length(); i++){
        if(str[i] == ' '){
            if(buff == ipt) {
                kol++;
            }
            buff = "";
            continue;
        }
        str[i] = tolower(str[i]);
        buff += str[i];
    }
    cout << "Ков-во слов: " << kol << endl;
}
