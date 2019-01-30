#include <iostream>
using namespace std;




int main(){
    int sum = 0;
    string name, family;
    int ots[17];
    cout << "Введите имя" << endl;
    cin >> name;
    cout << "Введите фамилию" << endl;
    cin >> family;
    for (int i = 0; i < 17; i++){
        cout << "Введите оценку по УП номер " << i + 1 << endl;
        cin >> ots[i];
        sum += ots[i];
    }
    FILE *f = fopen("textfiles/srab20.txt", "r+");
    fprintf(f, "Name: %s\n", name.c_str());
    fprintf(f, "Family: %s\n", family.c_str());
    fprintf(f, "Marks:\n");
    for (int i = 0; i < 17; i++){
        fprintf(f, "%d ", ots[i]);
    }
    fprintf(f, "\nMid. mark: %d\n", sum/17);
    fclose(f);
    return 0;
}