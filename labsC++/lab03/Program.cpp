#include <iostream>

class Rectangle {
private:
    double x1, y1; 
    double x2, y2; 

public:
   
    Rectangle() : x1(0), y1(0), x2(1), y2(1) {}

    
    Rectangle(double x1, double y1, double x2, double y2) : x1(x1), y1(y1), x2(x2), y2(y2) {}

    
    Rectangle(const Rectangle& rect) : x1(rect.x1), y1(rect.y1), x2(rect.x2), y2(rect.y2) {}

    
    double area() const {
        return (x2 - x1) * (y2 - y1);
    }

    
    double perimeter() const {
        return 2 * ((x2 - x1) + (y2 - y1));
    }

    
    Rectangle operator+(const Rectangle& rect) {
        return Rectangle(this->x1 + rect.x1, this->y1 + rect.y1, this->x2 + rect.x2, this->y2 + rect.y2);
    }

    
    Rectangle operator*(const Rectangle& rect) {
        return Rectangle(this->x1 * rect.x1, this->y1 * rect.y1, this->x2 * rect.x2, this->y2 * rect.y2);
    }

   
    void display() {
        std::cout << "Rectangle: [(" << x1 << ", " << y1 << "), (" << x2 << ", " << y2 << ")]";
        std::cout << ", Area: " << area() << ", Perimeter: " << perimeter() << std::endl;
    }
};

int main() {
    Rectangle Q1(2, 3, 5, 7);
    Rectangle Q2(1, 1, 4, 4);

    
    Rectangle Q3 = Q2 + Q1;
    Rectangle Q4 = Q3 * Q2;

    
    Q1.display();
    Q2.display();
    Q3.display();
    Q4.display();

    return 0;
}
