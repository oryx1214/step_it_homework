#include <iostream>
using namespace std;
struct My_boiler {
    char* brand = new char[15];
    char* color = new char[15];
    unsigned short int power{};
    unsigned short int dimension{};
    unsigned short int temperature{};
    void NewBoiler(){
        cout << "add brand: ";
        cin.getline(brand,30);
        cout << "add color: ";
        cin.getline(color,30);
        cout << "add power: ";
        cin >> power;
        cout << "add dimension: ";
        cin >> dimension;
        cout << "add temperature: ";
        cin >> temperature;
    }
    void Cout_Boiler(){
        cout << "brand: " << brand << endl;
        cout << "color: " << color << endl;
        cout << "power: " << power << endl;
        cout << "dimension: " << dimension << endl;
        cout << "temperature: " << temperature << endl;
    }
};
int main() {
    My_boiler *boiler = new My_boiler{};
    boiler->NewBoiler();
    boiler->Cout_Boiler();
    return 0;
}