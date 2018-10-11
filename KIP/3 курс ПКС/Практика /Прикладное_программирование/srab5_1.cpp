#include <iostream>
#include <math.h>
using namespace std;

class area_cl{
protected:
    double height;
    double width;
    area_cl(double h, double w){
        this->height = h;
        this->width = w;
    }
    double area();
};

class rectangle : public area_cl{
public:
    rectangle(double h, double w) : area_cl(h,w){}
    double area(){
        return this->height*this->width;
    }
};
class isosceles : public area_cl{
public:
    isosceles(double h, double w) : area_cl(h,w){

    }
    double area(){
        return this->height/4 * sqrt(4*this->width - pow(this->height,2));
    }
};


int main(){
    rectangle r1(2.6,2.3);
    isosceles i1(2.5,2.5);
    cout << "Площадь прямоугольника = " << r1.area() << endl;
    cout << "Площадь равнобедренного треугольника = " << i1.area() << endl;
    return 0;
}