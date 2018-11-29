#include <iostream>

using namespace std;

int main(){
    int a = 5, b = 5;
    FILE *f = fopen("textfiles/srab16-1.txt", "r+");
    fprintf(f, "%d\n%d",a,b);
    fseek(f,0,SEEK_SET);
    a = 0; b = 0;
    fscanf(f, "%d\n", &a);
    fscanf(f, "%d", &b);
    fclose(f);
    int ** mas = new int*[a];
    for (int i = 0; i < a; i++ ){
        mas[i] = new int[b];
    }
    f = fopen("textfiles/srab16-2.txt", "r+");
    for (int i = 0; i < a; i++ ) {
        for (int j = 0; j < b; j++ ){
            mas[i][j] = 10 + rand() % 50;
            fprintf(f, "%d ", mas[i][j]);
            cout << mas[i][j] << " ";
        }
        fprintf(f,"\n");
        cout << endl;
    }

    return 0;
}