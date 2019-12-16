#include <iostream>
#include <unistd.h>
#include <string>
#include <fstream>
#include <vector>
using namespace std;

int main(){
    string s;
    int counter = 0;
    vector<string> strings;
    strings.push_back("textfiles/file1.txt");
    strings.push_back("textfiles/file2.txt");
    strings.push_back("textfiles/zen.txt");

    for(int i = 0; i < strings.size(); i++){
        int pid = fork();
        if (pid == 0){
            ifstream f(strings[i]);
            while (getline(f,s)) {
                counter += 1;
            }
            cout << strings[i] <<" lines is " << counter << endl;
            ofstream fout("textfiles/lines.txt", ios_base::app);
            fout << counter << endl;
            return 0;
        }
    }
    sleep(1); // что бы дождаться записи в файлы от процессов
    ifstream f("textfiles/lines.txt");
    while (f >> s){
        counter += stoi(s);
    }
    cout << "All line summ is " << counter << endl;
    return 0;
}
