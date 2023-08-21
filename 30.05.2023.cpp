#include <iostream>
using namespace std;

class Fraction {
private:
    int first;
    int second;

public:
    Fraction(int num, int denom) : first(num), second(denom) {
        if (second == 0) {
            cout << "Error: Denominator cannot be zero. Only > 0" << endl;
            second = 1;
        }
    }

    void print() const {
        cout << first << "/" << second;
    }

    void input() {
        cout << "Enter the first: ";
        cin >> first;

        cout << "Enter the second: ";
        cin >> second;

        if (second == 0) {
            cout << "Error: Denominator cannot be zero. Setting second to 1." << endl;
            second = 1;
        }
    }

    Fraction add(const Fraction& other) const {
        int new_first = first * other.second + other.first * second;
        int new_second = second * other.second;
        return Fraction(new_first, new_second);
    }

    Fraction minus(const Fraction& other) const {
        int new_first = first * other.second - other.first * second;
        int new_second = second * other.second;
        return Fraction(new_first, new_second);
    }

    Fraction multiply(const Fraction& other) const {
        int new_first = first * other.first;
        int new_second = second * other.second;
        return Fraction(new_first, new_second);
    }

    Fraction delenie(const Fraction& other) const {
        int new_first = first * other.second;
        int new_second = second * other.first;
        return Fraction(new_first, new_second);
    }


    Fraction operator+(const Fraction& other) const {
        int new_first = first * other.second + other.first * second;
        int new_second = second * other.second;
        return Fraction(new_first, new_second); //plus
    }


    Fraction operator-(const Fraction& other) const {
        int new_first = first * other.second - other.first * second;
        int new_second = second * other.second;
        return Fraction(new_first, new_second); // minus
    }


    Fraction operator*(const Fraction& other) const {
        int new_first = first * other.first;
        int new_second = second * other.second;
        return Fraction(new_first, new_second); //umnojenie
    }


    Fraction operator/(const Fraction& other) const {
        int new_first = first * other.second;
        int new_second = second * other.first;
        return Fraction(new_first, new_second); //delenie
    }


    friend ostream& operator<<(ostream& ans, const Fraction& fraction) {
        ans << fraction.first << "/" << fraction.second; //<<
        return ans;
    }
};

int main() {
    Fraction first_f(3, 5);
    Fraction second_f(4, 7);

    cout << "Fraction1: " << first_f << endl;
    cout << "Fraction2: " << second_f << endl;

    Fraction sum = first_f + second_f;
    cout << "Sum: " << sum << endl;

    Fraction difference = first_f - second_f;
    cout << "Difference: " << difference << endl;

    Fraction product = first_f * second_f;
    cout << "Multiply: " << product << endl;

    Fraction quotient = first_f / second_f;
    cout << "Quotient: " << quotient << endl;

    return 0;
}
