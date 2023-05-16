#include <iostream>
using namespace std;
//void space_func(char* line) {
//    for (int arr = 0; line[arr] != '\0'; arr++) {
//        if (line[arr] == ' ') {
//            line[arr] = '\t';
//        }
//        else {
//            cout << "error";
//        }
//    }
//}
//int main(){
//    char* line = new char[100]{};
//    cout << "add your text ";
//    cin.getline(line, 100);
//    space_func(line);
//}
//

//zadanie 2
//
//int definition_func(char* line){
//    short int arr{};
//    short int letter{};
//    short int symbol{};
//    short int number{};
//    while(line[arr] != '\0'){
//        if ((int) line[arr] >= 48 && (int) line[arr] <= 57){
//            number++;
//        }
//        else if ((int) line[arr] >= 65 && (int) line[arr] <= 90){
//            letter++;
//        }
//        else if ((int) line[arr] >= 97 && (int) line[arr] <= 122){
//            letter++;
//        }
//        else
//            symbol++;
//        arr++;
//    }
//    cout << "letters quantity: " << letter << endl;
//    cout << "symbols quantity: " << symbol << endl;
//    cout << "numbers quantity: " << number;
//    return 0;
//}
//int main(){
//    char* line = new char[100];
//    cout << "add your text "; cin.getline(line, 50);
//    definition_func(line);
//}
//zadanie 3
//int word_func(char* line){
//    short int arr{};
//    short int text{};
//    while(line[arr] != '\0'){
//        if (line[arr - 1] != ' ' && (line[arr] == ' ' || line[arr + 1] == '\0'))
//            text++;
//        arr++;
//    }
//    cout << "quantity of words: " << text;
//    return 0;
//}
//int main(){
//    char* line = new char[100];
//    cout << "add your text: ";
//    cin.getline(line, 50);
//    word_func(line);
//}