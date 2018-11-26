#include <iostream>

using namespace std;

class Point {
private:
    int x, y;
public:
    Point(int _x, int _y) {
        x = _x;
        y = _y;
    }

    int getX() {
        return x;
    }

    int getY() {
        return y;
    }
};


int main() {
    Point pt(3, 6);
    cout << "x = " << pt.getX() << " y = " << pt.getY() << endl;
}