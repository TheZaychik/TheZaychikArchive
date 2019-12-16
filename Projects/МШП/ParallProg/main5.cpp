#include <iostream>
#include <cstdlib>
#include <unistd.h>

using namespace std;

int main() {
    for (int i = 0; i < 3; i++) {
        int v = fork();
        if (v == 0) {
            cout << "*" << endl;
        }
    }
    return 0;
}
