#include <iostream>
using namespace std;
struct student{
    char* group = new char[25] {};
    char* surname = new char[25] {};
    int performance[5]{};

    void printf(){
        cout << "surname: " << surname << endl;
        cout << "group: " << group << endl;
        for (size_t i = 0; i < 5; i++){
            cout << "grade " << i + 1 << ":" << performance[i] << endl;
        }
    }
};
struct info{
    char* faculty = new char[25] {};
    uint16_t capacity{};
    uint16_t count{};
    student* students{};

    void create(){
        student* s = new student{};
        getchar();
        cout << "add surname: "; cin.getline(s->surname, 20);
        cout << "add group: "; cin.getline(s->group, 20);
        for (size_t i = 0; i < 5; i++){
            cout << "add grade " << i + 1 << ":"; cin >> s->performance[i];
        }

        students[count] = *s;
        count++;
    }

    void edit(){
        cout << "add new capacity: "; cin >> capacity;
        student* r = new student[capacity]{};
        for (size_t i = 0; i < count; i++){
            student* r1 = new student{};
            r1->surname = students[i].surname;
            r1->group = students[i].group;
            for (size_t j = 0; j < 5; j++){
                r1->performance[j] = students[i].performance[j];
            }
            r[i] = *r1;
            delete r1;
        }
        delete students;
        students = new student[capacity]{};

        for (size_t i = 0; i < count; i++){
            student* r2 = new student{};

            r2->surname = r[i].surname;
            r2->group = r[i].group;
            for (size_t j = 0; j < 5; j++){
                r2->performance[j] = r[i].performance[j];
            }

            students[i] = *r2;
            delete r2;
        }
        delete r;
    }
    void print(){
        for (size_t i = 0; i < count; i++){
            students[i].printf();
        }
    }
};
void creates(info*& name){
    name = new info{};
    cout << "add faculty: "; cin.getline(name->faculty, 20);
    cout << "add capacity: "; cin >> name->capacity;

    name->students = new student[name->capacity]{};
}
int main(){
    info* fbms{};
    creates(fbms);
    while (true){
        int choice{};
        cout << "1. add student" << endl;
        cout << "2. print info" << endl;
        cout << "3. edit capacity" << endl;
        cin >> choice;
        if (choice == 1){
            system("cls");
            fbms->create();
        }
        else if (choice == 2){
            system("cls");
            fbms->print();
        }
        else if (choice == 3){
            system("cls");
            fbms->edit();
        }
        else{
            break;
        }
    }
    return 0;
}

