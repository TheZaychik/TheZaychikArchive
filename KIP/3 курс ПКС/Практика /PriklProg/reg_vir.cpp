#include <iostream>
#include <regex>

using namespace std;

int main() {
    string str = "its = string object with words";
    cmatch result;
    regex regualar("([\\w\\s])");
    if (regex_match(str.c_str(), result, regualar))
        cout << "True" << endl;
    for (int i = 0; i < result.size(); i++)
        cout << result[i++] << endl;
    return 0;
}