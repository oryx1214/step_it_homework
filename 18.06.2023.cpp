#include <iostream>
#include <string>
using namespace std;
//1
//class Student {
//private:
//    string name;
//    string surname;
//    int age;
//    string university;
//    int course;
//public:
//    Student(string name,string surname, int age, string university,int course) {
//        this->name = name;
//        this->surname = university;
//        this->age = age;
//        this->university = university;
//        this->course = course;
//    }
//    void Information() {
//        cout << "Name: " << name << endl;
//        cout << "Surname: " << surname << endl;
//        cout << "Age: " << age << endl;
//        cout << "University: " << university << endl;
//        cout << "Course: " << course << endl;
//    }
//};
//class Aspirant : public Student {
//private:
//    string Research_subject;
//public:
//    Aspirant(string name, string surname, int age, string university, int course, string researchTopic)
//            : Student(name, surname, age, university, course){
//        this->Research_subject = researchTopic;
//    }
//    void Information() {
//        Student::Information();
//        cout << "Research Topic: " << Research_subject << endl;
//    }
//};
//
//int main() {
//    Student student("Arnold", "Aslanov", 21, "ADBTIA", 4);
//    student.Information();
//    cout << endl;
//    Aspirant aspirant("Manuel", "Aliev", 25, "UNEC", 4, "OOP");
//    aspirant.Information();
//    return 0;
//}
//


//2
//
//using namespace std;
//class Passport {
//protected:
//    string Name;
//    string surname;
//    string middle_name;
//    string nationality;
//    string Passport_number;
//
//public:
//    Passport(string name, string middleName, string surname, string nationality, string passportNumber) {
//        this->Name = name;
//        this->surname = surname;
//        this->middle_name = middleName;
//        this->nationality = nationality;
//        this->Passport_number = passportNumber;
//    }
//
//    void Information() {
//        cout << "Name: " << Name << endl;
//        cout << "Surname: " << surname << endl;
//        cout << "Middle Name: " << middle_name << endl;
//        cout << "Nationality: " << nationality << endl;
//        cout << "Passport Number: " << Passport_number << endl;
//    }
//};
//
//class Foreign_passport : public Passport {
//private:
//    string info;
//    string Fireing_pasport;
//
//public:
//    Foreign_passport(string name, string middleName, string surname, string nationality, string passportNumber,
//                     string visaInformation, string foreing_passport)
//            : Passport(name, middleName, surname, nationality, passportNumber) {
//        this->info = visaInformation;
//        this->Fireing_pasport = foreing_passport;
//    }
//
//    void Information() {
//        Passport::Information();
//        cout << "Visa Information: " << info << endl;
//        cout << "Foreign Passport Number: " << Fireing_pasport << endl;
//    }
//};
//
//int main() {
//    Foreign_passport F_passport("Name", "Middle Name", "Surname", "Azerbaijanian", "2109233",
//                                "Valid visa: Student Visa", "40662923");
//
//    F_passport.Information();
//
//    return 0;
//}
