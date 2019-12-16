#include <iostream>
#include <unistd.h>
using namespace std;

int main(){
    fork();
    fork();
    fork();
    cout << ":)" << endl;
    return 0;
}
