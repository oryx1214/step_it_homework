#include <iostream>
using namespace std;
short int min(int* A, int* B, int first, int second) {
    int min = A[0];
    for(int i = 0; i < first; i++) {
        if (A[i] < min)
            min = A[i];
    }
    for(int i = 0; i < second; i++) {
        if (B[i] < min)
            min = B[i];
    }
    return min;
}
short int max(int* A, int* B, int fist, int second) {
    int max = A[0];
    for(int i = 0; i < fist; i++) {
        if (A[i] > max)
            max = A[i];
    }
    for(int i = 0; i < second; i++) {
        if (B[i] > max)
            max = B[i];
    }
    return max;
}

float avg(int* A, int* B, int first, int second) {
    float avg = 0;
    for(int i = 0; i < first; i++) {
        avg += A[i];
    }
    for(int i = 0; i < second; i++) {
        avg += B[i];
    }
    avg /= first + second;
    return avg;
}
int Action(int* A, int* B, int first, int second) {
    int choice = 0;
    cout << "\nadd your choice:\n";
    cout << "1 avg\n";
    cout << "2 min\n";
    cout << "3 max\n";
    cout <<"\n";
    cin >> choice;
    cout << "\n";
    cout << choice <<" is your choice";
    cout <<"\nanswer: ";
    if (choice == 1) {
        return avg(A, B, first, second);
    }
    else if (choice == 2) {
        return min(A, B, first, second);
    }
    else if (choice == 3) {
        return max(A, B, first, second);
    }
    else {
        cout << "error, unknown operation.\n";
        return -1;
    }
}
int main() {
    int first, second;
    cout << "add the length of the first array: ";
    cin >> first;
    int A[first];
    for(int i = 0; i < first; i++) {
        cout << "add element " << i + 1 << " of the first array: ";
        cin >> A[i];
    }
    cout << "first array: ";
    for(int i = 0; i < first; i++) {
        cout  << A[i] << " ";

    }
    cout << "\nadd the length of the second array: ";
    cin >> second;
    int B[second];
    for(int i = 0; i < second; i++) {
        cout << "add element " << i + 1 << " of the second array: ";
        cin >> B[i];
    }
    cout << "second array: ";
    for(int i = 0; i < second; i++){
        cout << B[i] << " ";
    }    cout << Action(A, B, first, second) << endl;
    return 0;
}
