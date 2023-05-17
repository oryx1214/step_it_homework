#include <iostream>
using namespace std;
uint16_t ccount{};
struct Student
{
    char* name = new char[25];
    char* surname = new char[25];
    char* fathername = new char[25];
    int grades[10]{};
    void printI(){
        cout << "student name: " << name << endl;
        cout << "student surname: " << surname << endl;
        cout << "student father name: " << fathername << endl;
        for (size_t i = 0; i < 10; i++)
        {
            cout << "grades " << i + 1 << ":" << grades[i] << endl;
        }
    }

    void average(){
        int a{};
        for (size_t i = 0; i < 10; i++)
        {
            a += grades[i];
        }
        cout << "average rating this student: " << a / 10;
    }
};

struct create{
    char* name = new char[21];
    uint16_t capacity{ 20 };
    Student* students{};

    void creates(){
        if (ccount < capacity){
            Student* s = new Student{};
            getchar();
            cout << "add student name: "; cin.getline(s->name, 24);
            cout << "add student surname: "; cin.getline(s->surname, 24);
            cout << "add student surname: "; cin.getline(s->fathername, 24);

            students[ccount] = *s;
            ccount++;
        }
        else
            cout << "class full";
    }

    void addg(){
        for (size_t i = 0; i < 10; i++){
            cout << "add grades " << i + 1 << ":"; cin >> students->grades[i];
        }
    }

    void prints(){
        for (size_t i = 0; i < ccount; i++){
            cout << i + 1 << students[i].name << endl;
        }
    }

    void printi(){
        for (size_t i = 0; i < ccount; i++){
            students[i].printI();
        }
    }
};

void crs(create*& s){
    s = new create{};
    cout << "add name: "; cin.getline(s->name, 24);
    s->students = new Student[s->capacity];
}

int main(){
    create* students{};
    crs(students);
    while (true){
        int choice{};
        cout << "1 add student" << endl;
        cout << "2 rate" << endl;
        cout << "3 display a list of students" << endl;
        cout << "4 print student grades" << endl;
        cin >> choice;
        if (choice == 1) {
            students->creates();
        }
        else if (choice == 2) {
            system("cls");
            students->prints();
            cin >> choice;
            students[choice].addg();
        }
        else if (choice == 3) {
            system("cls");
            students->prints();
        }
        else if (choice == 4) {
            system("cls");
            students->prints();
            cin >> choice;
            students[choice].printi();
        }
        else {
            cout << "error";
        }
    }
}