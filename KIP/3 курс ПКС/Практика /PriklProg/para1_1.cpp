#include "iostream"

using namespace std;

class SimpleClass{
public:
    int number;
};

int main(){
    SimpleClass myobj, myobj1;
    myobj.number = 5;
    cout << "myobj.number = " <<myobj.number << endl;
    myobj1.number = 2 + myobj.number;
    cout << "myobj1.number = " << myobj1.number << endl;
    return 0;
}
