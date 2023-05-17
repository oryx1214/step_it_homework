#include <iostream>
using namespace std;

char* cezar(char word[], int move, int direction){
    for (size_t i = 0; i < 11; i++){
        if (word[i] == '\0')
            break;
        if (direction == 1){
            if ((int)word[i] > 64 && (int)word[i] < 91){
                int r = (int)word[i] + move;
                while (r > 90){
                    r = r - 90 + 64;
                }
                word[i] = (char)r;
            }
            else if ((int)word[i] > 96 && (int)word[i] < 123){
                int z = (int)word[i] + move;

                while (z > 122){
                    z = z - 122 + 96;
                }
                word[i] = (char)z;
            }
        }
        else if (direction == 2){
            int r = (int)word[i] - move;
            if ((int)word[i] > 64 && (int)word[i] < 91){
                while (r < 65){
                    r = 64 - r;
                    r = 90 - r;
                }
                word[i] = (char)r;
            }
            else if ((int)word[i] > 96 && (int)word[i] < 123){
                int a = (int)word[i] - move;

                while (a < 97){
                    a = 96 - a;
                    a = 122 - a;
                }
                word[i] = (char)a;
            }
        }
        else{
            cout << "you can choose only one or two";
        }
    }
    return word;
}
int main(){
    char word[11]{};
    int move{};
    int direction{};

    cout << "add word: "; cin.getline(word, 10);
    cout << "add move: "; cin >> move;
    cout << "1. right" << endl;
    cout << "2. left" << endl;
    cout << "choose direction:";
    cin >> direction;

    cout << cezar(word, move, direction) << endl;
    cout << word;

    char** words = new char* [3];
    words[0] = new char[11] {};
    words[1] = new char[11] {};
    words[2] = new char[11] {};

    for (size_t i = 0; i < 3; i++){
        cout << "add word " << i + 1 << ": ";
        cin.getline(words[i], 10);
    }
    for (size_t i = 0; i < 3; i++){
        for (size_t j = 0; j < 3; j++){
            if ((int*)words[i] < (int*)words[j]){
                char* r = words[i];
                words[i] = words[j];
                words[j] = r;
            }
        }
    }
    int i, key, j;
    for (i = 1; i < 3; i++){
        key = (int)words[i][0];
        j = i - 1;
        while (j >= 0 && (int)words[j][0] > key){
            words[j + 1] = words[j];
            j = j - 1;
        }
        words[j + 1] = words[i];
    }
    for (size_t i = 0; i < 3; i++){
        cout << words[i];
    }
}