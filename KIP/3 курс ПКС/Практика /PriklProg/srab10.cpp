#include <iostream>

using namespace std;

class coord {
public:
    int x, y;

    coord(int _x, int _y) {
        this->x = _x;
        this->y = _y;
    }

    void show() {
        cout << this->x << " " << this->y << endl;
    }

};

coord operator+(coord a, coord b) {
    return coord(a.x + b.x, a.y + b.y);
}

coord operator+(coord a) {
    if(a.x < 0)
        a.x = -a.x;
    return a;
}

int main() {
    coord cd1(-5, -7), cd2(4, 2);
    coord cd3 = cd1 + cd2;
    cd3.show();
    coord cd4 = +cd3;
    cd4.show();
    coord cd7(5,5);
    coord cd8 = +cd7;
    cd8.show();
    return 0;
}