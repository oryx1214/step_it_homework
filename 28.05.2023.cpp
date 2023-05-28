#include <iostream>
#include <string>
using namespace std;
class Student{
private:
    string name;
    string surname;
    string patronymic;
    string birthday;
    string phonenumber;
    string city;
    string country;
    string universityname;
    string universitycity;
    string universitycountry;
    string groupnumber;
public:
    Student(){}
    void add(){
        cout << "add student details:\n";
        cout << "first Name: ";
        cin >> name;
        cout << "surname: ";
        cin >> surname;
        cout << "patronymic";
        cin >> patronymic;
        cout << "date of birth: ";
        cin >> birthday;
        cout << "contact phone number: ";
        cin >> phonenumber;
        cout << "city: ";
        cin >> city;
        cout << "country: ";
        cin >> country;
        cout << "university name: ";
        cin >> universityname;
        cout << "university city: ";
        cin >> universitycity;
        cout << "university country: ";
        cin >> universitycountry;
        cout << "group number: ";
        cin >> groupnumber;
    }
    void print(){
        cout << "student details:\n";
        cout << "name: " << name << endl;
        cout << "surname: " << surname << endl;
        cout << "patronymic: " << patronymic << endl;
        cout << "date of birth: " << birthday << endl;
        cout << "contact phone number: " << phonenumber << endl;
        cout << "city: " << city << endl;
        cout << "country: " << country << endl;
        cout << "university name: " << universityname << endl;
        cout << "university city: " << universitycity << endl;
        cout << "university country: " << universitycountry << endl;
        cout << "group Number: " << groupnumber << endl;
    }
    string getname() const{return name; }
    string getsurname() const{return surname; }
    string getpatronymic() const{return patronymic; }
    string getbirthday() const{return birthday; }
    string getphonenumber() const{return phonenumber; }
    string getcity() const{return city; }
    string getcountry() const{return country; }
    string getuniversityname() const{return universityname; }
    string getuniversitycity() const{return universitycity; }
    string getuniversitycountry() const{return universitycountry; }
    string getgroupnumber() const{return groupnumber; }
};
int main() {
    Student student;
    student.input();
    student.display();
    return 0;
}
