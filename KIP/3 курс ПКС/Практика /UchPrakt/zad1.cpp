#include <iostream>
#include "cmath"
using namespace std;

static class Ryad{
private:
    double x,q,s = 0;
public:
    void init(){
        cout << "Введите x:" << endl;
        cin >> x;
        q = x;
    }
    void start(){
        int a = 2;
        for(int i = 1; i < 11; i++){
            s += q;
            q *= 1 - (pow(x,2)/fact(2)) + (pow(x,a)/fact(a));
            cout << "----| n = " << i << " |----" << endl;
            cout << "q = " << q <<  endl;
            cout << "sin(" << x << ") = " << s ;
            cout << "   sin(" << x << ")=" << sin(x) << endl;
            a *=2;

        }
    }

private:
    long double fact(int N) {
        if(N < 0)
            return 0;
        if (N == 0)
            return 1;
        else
            return N * fact(N - 1);
    }


};

int main() {
    Ryad obj;
    obj.init();
    obj.start();


    return 0;
}