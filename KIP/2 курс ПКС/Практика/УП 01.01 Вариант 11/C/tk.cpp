#include <iostream>
#include <curses.h>
using namespace std;
// Текущий контроль за 2 симестр
// Вариант 1

int main(){
    string input;
    cout << "Введите строку со скобками для проверки" << endl;
    cin >> input;
    cout << "Размер строки: " << input.size() << endl;
    int s1 = 0;  // [
    int s2 = 0;  // <
    int s3 = 0;  // {
    int s4 = 0;  // (
    int s1_1 = 0;  // ]
    int s2_2 = 0;  // >
    int s3_3 = 0;  // }
    int s4_4 = 0;  // )

    for (int i = 0; i < input.size(); i++){
        if (input[i] == '['){
            input[i] = ' ';
            s1 +=1;
            for (int j = i+1; j < input.size(); j++){
                if (input[j] == ']') {
                    input[j] = ' ';
                    if (input[j + 1] == '<' && input[j - 1] == '>' || input[j + 1] == '{' && input[j - 1] == '}' || input[j + 1] == '(' && input[j - 1] == ')') {
                        cout << "Error at pos: " << j << endl;
                        break;
                    }
                    s1_1 += 1;
                    break;
                }
            }
        }
        if (input[i] == '<'){
            input[i] = ' ';
            s2 += 1;
            for (int j = i+1; j < input.size(); j++){
                if (input[j] == '>') {
                    input[j] = ' ';
                    if (input[j - 1] == '[' && input[j + 1] == ']' || input[j - 1] == '{' && input[j + 1] == '}' || input[j - 1] == '(' && input[j + 1] == ')') {
                        cout << "Error at pos: " << j << endl;
                        break;
                    }
                    s2_2 += 1;
                    break;
                }
            }
        }
        if (input[i] == '{'){
            input[i] = ' ';
            s3 += 1;
            for (int j = i+1; j < input.size(); j++){
                if (input[j] == '}') {
                    input[j] = ' ';
                    if (input[j - 1] == '[' && input[j + 1] == ']' || input[j - 1] == '<' && input[j + 1] == '>' || input[j - 1] == '(' && input[j + 1] == ')') {
                        cout << "Error at pos: " << j << endl;
                        break;
                    }
                    s3_3 +=1;
                    break;
                }
            }
        }
        if (input[i] == '('){
            input[i] = ' ';
            s4 += 1;
            for (int j = i+1; j < input.size(); j++){
                if (input[j] == ')') {
                    input[j] = ' ';
                    if (input[j - 1] == '[' && input[j + 1] == ']' || input[j - 1] == '{' && input[j + 1] == '}' || input[j - 1] == '<' && input[j + 1] == '>') {
                        cout << "Error at pos: " << j << endl;
                        break;
                    }
                    s4_4 += 1;
                    break;
                }
            }
        }
    }
    if (s1 != s1_1 || s2 != s2_2 || s3 != s3_3|| s4 != s4_4){
        cout << "Status: ERROR" << endl;
        cout << "Cкобки без пары: " << input << endl;
    } else {
        cout << "Status: OK" << endl;
    }

    return 0;
}
