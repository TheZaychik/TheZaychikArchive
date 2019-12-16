#include <iostream>
#include <unistd.h>
using namespace std;

int main(){
    int counter = 0;
    int a = fork();
    if(a == -1){
        cout << "Cant fork" << endl;
        return 1;
    }
    if(a == 0) {
        // child processs
        counter += 3;
    } else {
        counter += 5;
    }
    cout << counter << endl;

    return 0;
}
