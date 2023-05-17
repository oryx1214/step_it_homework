#include <iostream>
using namespace std;
int main(){
    int arr[3][3]{{1, 2, 3},{4, 5, 6 },{7, 8, 9}
    };
    int fact[3][3]{{0, 0, 0}, {0, 0, 0}, {0, 0, 0}
    };
    int sum{}, count{};
    int factorial = 1;
    int arr1{}, fsum{};
    int min = arr[0][0], max = arr[0][0];
    for (size_t i = 0; i < 3; i++){
        for (size_t j = 0; j < 3; j++){
            sum += arr[i][j];
            count++;
        }
        for (size_t a = 0; a < 3; a++){
            if (min > arr[i][a]){
                min = arr[i][a];
            }
        }
        for (size_t b = 0; b < 3; b++){
            if (max < arr[i][b]){
                max = arr[i][b];
            }
        }
        for (size_t j = 0; j < 3; j++){
            arr1 = arr[i][j];
            while (arr1 > 1){
                factorial = factorial * arr1;
                arr1--;
            }
            fact[i][j] = factorial;
            fsum += factorial;
            factorial = 1;
        }
    }
    cout << "max: " << max << endl;
    cout << "min: " << min << endl;
    cout << "factorial: " << endl;
    cout << "average: " << (float)sum / count << endl;
    for (size_t i = 0; i < 3; i++){
        for (size_t j = 0; j < 3; j++){
            cout << fact[i][j] << " ";
        }
        cout << endl;
    }
    cout << "factorial sum: " << fsum;
    return 0;
}