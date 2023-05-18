#include <iostream>
using namespace std;
struct Student {
    char* studentName = new char[30];
    char* studentSurname = new char[30];
    int studentAge{};
    char* faculty = new char[30];
    int GPA{};
    int course{};
    void printOneStudent() {
        cout << "name: " << studentName << endl;
        cout << "surname: " << studentSurname << endl;
        cout << "age: " << studentAge << endl;
        cout << "faculty: " << faculty << endl;
        cout << "average: " << GPA << endl;
        cout << "course: " << course << endl;
    }
};
struct Academy {
    char* academyName = new char[30];
    uint16_t countStudents{};
    uint16_t academyCapacity = 10;
    Student* students{};
    void addStudent() {
        Student* s = new Student{};
        cout << "add student name: ";
        cin.getline(s->studentName, 30);
        cout << "add student surname: ";
        cin.getline(s->studentSurname, 30);
        cout << "add students age: ";
        cin >> s->studentAge;
        getchar();
        cout << "add student faculty: ";
        cin.getline(s->faculty, 30);
        cout << "add student average: ";
        cin >> s->GPA;
        int tmp{};
        cout << "add students course (1-4): ";
        cin >> tmp;
        while (tmp > 4 || tmp < 1) {
            cout << "wrong number! add students course (1-4) again: ";
            cin >> tmp;
        }
        s->course = tmp;
        students[countStudents] = *s;
        countStudents++;
    }

    void deleteStudent() {
        printAllStudents();
        int number{};
        cout << "add student number to delete: ";
        cin >> number;
        cin.ignore();

        students[number - 1].studentName = nullptr;
        students[number - 1].studentSurname = nullptr;
        students[number - 1].studentAge = 0;
        students[number - 1].faculty = nullptr;
        students[number - 1].GPA = 0;
        students[number - 1].course = 0;

        countStudents--;
    }

    void printFacultyStudents() {
        printAllStudents();
        int facult;
        cout << "add faculty to print students: ";
        cin >> facult;

        for (int i = 0; i < academyCapacity; i++) {
            if (students[i].course == facult) {
                students[i].printOneStudent();
            }
        }
    }

    void printAllStudents() {
        for (int i = 0; i < countStudents; i++) {
            cout << "student " << i + 1 << endl;
            students[i].printOneStudent();
        }
    }
};
void createAcademy(Academy*& acad) {
    acad = new Academy{};
    cout << "add name of academy: ";
    cin.getline(acad->academyName, 30);
    cout << "add academy capacity: ";
    cin >> acad->academyCapacity;
    cin.ignore();
    acad->students = new Student[acad->academyCapacity]{};
}
int main() {
    int choice{};
    Academy* acad{};
    createAcademy(acad);
    while (true) {
        cout << "choose: " << endl;
        cout << "1. add student" << endl;
        cout << "2. delete student" << endl;
        cout << "3. print students in one faculty" << endl;
        cin >> choice;
        cin.ignore();

        if (choice == 1) {
            system("cls");
            acad->addStudent();
        }
        else if (choice == 2) {
            system("cls");
            acad->deleteStudent();
        }
        else if (choice == 3) {
            system("cls");
            acad->printFacultyStudents();
        }
    }
    return 0;
}
