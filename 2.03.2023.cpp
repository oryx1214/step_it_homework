#include <iostream>
using namespace std;
//
//zadanie 1
//int main(){
//	short int arr{};
//	cout << "add your arr: ";
//    cin >> arr;
//	int *numbers = (int*)calloc(arr, sizeof(int) * arr);
//	int number = arr;
//	for (size_t i = 0; i < arr; i++){
//		numbers[i] = number;
//        number *= 2;
//	}
//	for (size_t i = 0; i < arr; i++){
//		cout << numbers[i] << ' ';
//	}
//	return 0;
//}

//zadanie 2
//int main()
//{
//	int arr{};
//	cout << "add your arr: ";
//    cin >> arr;
//	int *numbers = (int*)calloc(arr, sizeof(int) * arr);
//	int number = arr;
//	for (size_t i = 0; i < arr; i++){
//		numbers[i] = number;
//		number++;
//	}
//	for (size_t i = 0; i < arr; i++){
//		cout << numbers[i] << ' ';
//	}
//	return 0;
//}
//zadanie 3
//int main() {
//    short arrays[2][10]{
//            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
//
//            { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }
//    };
//    short newarrays[2][10]{};
//    short int sign = 10;
//    short int move{};
//    short int choice{};
//    for (size_t i = 0; i < 10; i++) {
//        cout << arrays[0][i] << ' ';
//    }
//    cout << endl;
//    for (size_t i = 0; i < 10; i++) {
//        cout << arrays[1][i] << ' ';
//    }
//    cout << endl;
//    cout << "choose operation: " << endl;
//    cout << "1 right" << endl;
//    cout << "2 left" << endl;
//    cout << "3 left up" << endl;
//    cout << "4 down" << endl;
//    cin >> choice;
//    cout << "choose move: " << endl;
//    cin >> move;
//    if (move > 10) {
//        move = move % 10;
//    }
//    if (choice == 1) {
//        for (size_t i = 0; i < 10; i++) {
//            if (i + move <= 9) {
//                newarrays[0][i + move] = arrays[0][i];
//                newarrays[1][i + move] = arrays[1][i];
//            }
//            else if (i + move > 9) {
//                newarrays[0][i + move - sign] = arrays[0][i];
//                newarrays[1][i + move - sign] = arrays[1][i];
//            }
//        }
//    }
//    else if (choice == 2) {
//        for (size_t i = 0; i < 10; i++) {
//            int j = i - move;
//            if (j < 0) {
//                newarrays[0][j + sign] = arrays[0][i];
//                newarrays[1][j + sign] = arrays[1][i];
//            }
//            else if (j >= 0) {
//                newarrays[0][j] = arrays[0][i];
//                newarrays[1][j] = arrays[1][i];
//            }
//        }
//    }
//    else if (choice == 3) {
//        for (int i = 0; i < 10; ++i) {
//            newarrays[0][i] = arrays[0][i];
//            newarrays[1][i] = arrays[1][i];
//        }
//        for (int i = 0; i < move; ++i) {
//            for (int j = 0; j < 10; ++j) {
//                arrays[0][j] = newarrays[0][j];
//                newarrays[0][j] = newarrays[1][j];
//                newarrays[1][j] = arrays[0][j];
//            }
//        }
//    }
//    else if (choice == 4) {
//        for (int i = 0; i < 10; ++i) {
//            newarrays[0][i] = arrays[0][i];
//            newarrays[1][i] = arrays[1][i];
//        }
//        for (int i = 0; i < move; ++i) {
//            for (int j = 0; j < 10; ++j) {
//                arrays[1][j] = newarrays[0][j];
//                newarrays[0][j] = newarrays[1][j];
//                newarrays[1][j] = arrays[1][j];
//            }
//        }
//    }
//    for (size_t i = 0; i < 10; i++) {
//        cout << newarrays[0][i] << ' ';
//    }
//    cout << endl;
//    for (size_t i = 0; i < 10; i++) {
//        cout << newarrays[1][i] << ' ';
//    }
//    return 0;
//}
