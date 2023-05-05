//#include <iostream>
//using namespace std;
//
//int main() {
//    int size1, size2, size3 = 0;
//    bool found = false;
//
//    cout << "First size : ";
//    cin >> size1;
//
//    int* arr1 = new int[size1];
//    for (int i = 0; i < size1; ++i) {
//        cin >> arr1[i];
//    }
//
//    cout << "Second size : ";
//    cin >> size2;
//
//    int* arr2 = new int[size2];
//    for (int i = 0; i < size2; ++i) {
//        cin >> arr2[i];
//    }
//
//    for (int i = 0; i < size1; ++i) {
//        found = false;
//        for (int j = 0; j < size2; ++j) {
//            if (arr1[i] == arr2[j]) {
//                found = true;
//                break;
//            }
//        }
//        if (!found) {
//            size3++;
//        }
//    }
//
//    if (size3 > 0) {
//        int* arr3 = new int[size3];
//        int index = 0;
//        for (int i = 0; i < size1; ++i) {
//            found = false;
//            for (int j = 0; j < size2; ++j) {
//                if (arr1[i] == arr2[j]) {
//                    found = true;
//                    break;
//                }
//            }
//            if (!found) {
//                arr3[index++] = arr1[i];
//            }
//        }
//        cout << "Third arr : " << endl;
//        for (int i = 0; i < size3; ++i) {
//            cout << arr3[i] << " ";
//        }
//        cout << endl;
//        delete[] arr3;
//    }
//    else {
//        cout << "No unique elements" << endl;
//    }
//
//    delete[] arr1;
//    delete[] arr2;
//    return 0;
//}
//zadanie 2
//#include <iostream>
//
//using namespace std;
//
//int main() {
//    int size1, size2, size3 = 0;
//    cout << "first size : ";
//    cin >> size1;
//    int* arr1 = new int[size1];
//    for (int i = 0; i < size1; ++i) {
//        cin >> arr1[i];
//    }
//    cout << "second size : ";
//    cin >> size2;
//    int* arr2 = new int[size2];
//    for (int i = 0; i < size2; ++i) {
//        cin >> arr2[i];
//    }
//    for (int i = 0; i < size1; ++i) {
//        bool found = false;
//        for (int j = 0; j < size2; ++j) {
//            if (arr1[i] == arr2[j]) {
//                found = true;
//                break;
//            }
//        }
//        if (!found) {
//            size3++;
//        }
//    }
//    for (int i = 0; i < size2; ++i) {
//        bool found = false;
//        for (int j = 0; j < size1; ++j) {
//            if (arr2[i] == arr1[j]) {
//                found = true;
//                break;
//            }
//        }
//        if (!found) {
//            size3++;
//        }
//    }
//    if (size3 > 0) {
//        int* arr3 = new int[size3];
//        int index = 0;
//        for (int i = 0; i < size1; ++i) {
//            bool found = false;
//            for (int j = 0; j < size2; ++j) {
//                if (arr1[i] == arr2[j]) {
//                    found = true;
//                    break;
//                }
//            }
//            if (!found) {
//                arr3[index++] = arr1[i];
//            }
//        }
//        for (int i = 0; i < size2; ++i) {
//            bool found = false;
//            for (int j = 0; j < size1; ++j) {
//                if (arr2[i] == arr1[j]) {
//                    found = true;
//                    break;
//                }
//            }
//            if (!found) {
//                arr3[index++] = arr2[i];
//            }
//        }
//        cout << "third arr : " << endl;
//        for (int i = 0; i < size3; ++i) {
//            cout << arr3[i] << " ";
//        }
//        delete[] arr3;
//    } else {
//        cout << "no unique elements" << endl;
//    }
//    delete[] arr1;
//    delete[] arr2;
//    return 0;
//}