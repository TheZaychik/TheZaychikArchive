#include <iostream>

using namespace std;

char my_tolower(char ch)
{
    return static_cast<char>(std::tolower(static_cast<unsigned char>(ch)));
}

class Variant10 {
public:
    string a;

    Variant10(string a) {
        this->a = a;
    }

    void Show() {
        cout << a << endl;
    }

};
//  438592384859fbvyiergvireBEVUEHVORHVEOHUH98349058345

Variant10 operator<<(string str, Variant10 obj) {
    for (int i = 0; i < obj.a.length(); i++) {
        obj.a[i] =  (char)tolower(obj.a[i]);
        if (isdigit(obj.a[i]))
            obj.a[i] = ' ';
    }
    str = obj.a;
    return str;
}

int main() {
    string str;
    cin >> str;
    Variant10 v10(str);
    str << v10;
    cout << str << endl;
    return 0;
}