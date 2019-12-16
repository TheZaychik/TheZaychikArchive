#include <iostream>
#include <unistd.h>
#include <vector>
#include <string>
using namespace std;

int main(){
    vector<string> strings;
    strings.push_back("kek");
    strings.push_back("shmek");
    strings.push_back("lol");

    for(int i = 0; i < strings.size(); i++){
        int pid = fork();
        if (pid == 0) {
            cout << strings[i] << " Len is " << strings[i].size() << endl;
            break;
        }
    }



    return 0;
}
