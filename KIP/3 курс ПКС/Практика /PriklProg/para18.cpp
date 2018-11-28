#include <iostream>

using namespace std;

int main() {
    int a;
    cin >> a;
    FILE *f = fopen("textfiles/s1.txt", "w+");
    fprintf(f, "%d", a);
    fscanf(f, "%d", &a);
    fclose(f);
    f = fopen("textfiles/s2.txt", "w+");;
    a += 3;
    fprintf(f, "%d", a);
    fclose(f);
}