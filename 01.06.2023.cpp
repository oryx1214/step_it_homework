#include <iostream>
using namespace std;

//class Circle {
//private:
//    double radius;
//
//public:
//    Circle(double r) : radius(r) {}
//
//    bool operator==(const Circle& circ) const {    //перегрузки
//        return radius == circ.radius;
//    }
//    bool operator>(const Circle& circ) const {
//        return radius > circ.radius;
//    }
//
//    Circle& operator+=(double ans) {
//        radius += ans;
//        return *this;
//    }
//    Circle& operator-=(double ans) {
//        if (radius >= ans) {
//            radius -= ans;
//        } else {
//            radius = 0;
//        }
//        return *this;
//    }
//
//
//    double get_rad() const {
//        return radius;
//    }
//
//
//    double get_lenght() const {
//        return 2 * 3.14 * radius;
//    }
//};
//
//int main() {
//    Circle first_circle(2.0);
//    Circle second_circle(10.0);
//
//    cout << "first circle radius: " << first_circle.get_rad() << endl;
//    cout << "second circle radius: " << second_circle.get_rad() << endl;
//
//    if (first_circle == second_circle) {
//        cout << "first circle and second circle have equal radius" << endl;
//    } else {
//        cout << "first circle and second circle have different radius" << endl;
//    }
//
//    if (first_circle > second_circle) {
//        cout << "first circle has a greater radius than second circle" << endl;
//    } else {
//        cout << "first circle dont have a greater radius than second circle" << endl;
//    }
//
//    first_circle += 5.0;
//    cout << "first circle radius after +=:  " << first_circle.get_rad() << endl;
//
//    second_circle -= 10.0;
//    cout << "second circle radius after -=: " << second_circle.get_rad() << endl;
//
//    return 0;
//}

//class Airplane {
//private:
//    string type;
//    int max;
//    int current;
//
//public:
//    Airplane(const string& t, int limit) : type(t), max(limit), current(0) {}
//
//    bool operator==(const Airplane& reload) const {   // Перегрузка
//        return type == reload.type;
//    }
//
//    Airplane& operator++() {
//        if (current < max) {
//            ++current;
//        }
//        return *this;
//    }
//
//    Airplane& operator--() {
//        if (current > 0) {
//            --current;
//        }
//        return *this;
//    }
//
//    bool operator>(const Airplane& reload) const {
//        return max > reload.max;
//    }
//
//    void add_passanger(int count) {
//        if (current + count <= max) {
//            current += count;
//        }
//        else {
//            cout << "cannot add passengers,exceeds maximum capacity." << endl;
//        }
//    }
//
//    int get_passanger() const {
//        return current;
//    }
//
//    int get_max_passanger() const {
//        return max;
//    }
//
//    string get_plane_type() const {
//        return type;
//    }
//};
//int main() {
//    Airplane first_plane("boeing", 150);
//    Airplane second_plane("airbus", 180);
//
//    cout << "first plane type: " << first_plane.get_plane_type() << endl;
//    cout << "second plane type: " << second_plane.get_plane_type() << endl;
//
//    if (first_plane == second_plane) {
//        cout << "first plane and second plane have the same type." << endl;
//    }
//    else {
//        cout << "first plane and second plane have different types." << endl;
//    }
//
//    ++first_plane;
//    cout << "first plane current passengers after +: " << first_plane.get_passanger() << endl;
//
//    --second_plane;
//    cout << "second plane current passengers after -: " << second_plane.get_passanger() << endl;
//
//    if (first_plane > second_plane) {
//        cout << "first plane can accommodate more passengers than second plane." << endl;
//    }
//    else {
//        cout << "first plane cannot accommodate more passengers than second plane." << endl;
//    }
//
//    return 0;
//}
