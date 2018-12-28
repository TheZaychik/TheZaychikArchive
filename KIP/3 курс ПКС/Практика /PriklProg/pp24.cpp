#include <iostream>
#include <fstream>
using namespace std;
int main() {
    string buff;
    int sum = 0;
    char mas[5] = {1, 2, 3, 4, 5};
    FILE *f = fopen("textfiles/pp24.txt", "r+");
    for (int i = 0; i < 5; i++){
        fprintf(f, "%d\n", mas[i]);
    }
    fclose(f);
    f = fopen("textfiles/pp24.txt", "r+");
    while (!feof(f)){
        fscanf(f, "%s", &buff);
        sum += stoi(buff);
    }

    cout << sum << endl;

}
