#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <climits>
#include <unordered_map>
#include <cstdlib>
#include <unistd.h>
#include <fcntl.h>
#include <fstream>
using namespace std;

vector<string> files = {"/var/log/corecaptured.log","test.txt","/etc/passwd",};
int words_count(string s) {
    int count = 0;
    fstream f;
    f.open(s,ios::in);
    string tmp;
    while (f >> tmp) {
        count++;
    }
    f.close();
    return count;
}

int main() {
    for (string s: files) {
        int pid = fork();
        if (pid == 0) {
            cout << "File: " << s << ": ";
            cout << words_count(s) << endl;
            string tmp = "wc -w " + s;
            system(tmp.c_str());
            break;
        }
    }
    int status = 0;
    int res = 1;
    while (res > 0) {
        res = wait(&status);
        cout << "-------" << endl;
        cout << res << endl;
        cout << status << endl;
    }
    return 0;
}