#include <iostream>
using namespace std;

int maxx(int first, int second)
{
    if (second == 0)
        return first;
    else if (first == 0)
        return second;
    if (first > second)
        return maxx(second, first % second);
    else if (second > first)
        return maxx(first, second % first);

}
int main(){
    int num1 = 99, num2 = 55;

    cout << "max: " << maxx(num2, num1 % num2);

}
void bc(int bulls[], int cows[], int i){
    static int nums{}, count{};

    if (bulls[i] == cows[i]){
        nums++;
    }
    if (i == 3){
        if (nums == 4){
            count++;
            cout << "you guessed right in attempts:  " << count;
        }
        else{
            cout << "you gussed number: " << nums << endl;
            cout << "please add again : ";
            for (size_t i = 0; i < 4; i++){
                cout << "add number " << i + 1 << ':';
                cin >> cows[i];
            }
            count++;
            i = -1;
            nums = 0;
        }
    }
    bc(bulls, cows, i + 1);
}

//int main(){
//    int bulls[4]{}, cows[4]{};
//    srand(time(NULL));
//    for (size_t i = 0; i < 4; i++){
//        bulls[i] = rand() % 10 + 1;
//    }
//    for (size_t i = 0; i < 4; i++){
//        cout << "add number " << i + 1 << ' ';
//        cin >> cows[i];
//    }
//    bc(bulls, cows, 0);
//}