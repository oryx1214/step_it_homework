//#include <iostream>
//using namespace std;
//#include <time.h>
//zadanie 1
//void first_1(unsigned first[], unsigned second[]){
//    unsigned years{};
//    unsigned summa{};
//    unsigned month[12]
//    { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//	if (first[1] > second[1]){
//		int j;
//		j = first[1];
//        first[1] = second[1];
//        second[1] = j;
//	}
//	if (first[2] > second[2]){
//		int a;
//        a = first[2];
//        first[2] = second[2];
//        second[2] = a;
//	}
//	if (first[2] == second[2]){
//		for (size_t i = first[1]; i < second[1] - 1; i++){
//            summa += month[i];
//		}
//        summa += ((month[first[1] - 1] - first[0]) + second[0]);
//		for (size_t i = first[2]; i < second[2] + 1; i++){
//			if (i % 4 == 0)
//                years += 1;
//		}
//		cout << summa;
//	}
//	else if (first[2] != second[2]){
//		for (size_t i = first[1]; i < second[1] - 1; i++){
//            summa += month[i];
//		}
//        summa += ((month[first[1] - 1] - first[0]) + second[0]);
//        years = (second[2] - first[2]) * 365 + summa;
//		for (size_t i = first[2]; i < second[2] + 1; i++){
//			if (i % 4 == 0)
//                years += 1;
//		}
//		cout << years;
//	}
//}
//int main(){
//	unsigned int first_date[3]{};
//	unsigned int second_date[3]{};
//	cout << "add the day of first date: ";
//    cin >> first_date[0];
//	cout << "add the month of first date: ";
//    cin >> first_date[1];
//	cout << "add the year of first date: ";
//    cin >> first_date[2];
//	cout << "add the day of second date: ";
//    cin >> second_date[0];
//	cout << "add the month of second date: ";
//    cin >> second_date[1];
//	cout << "add the year of second date: ";
//    cin >> second_date[2];
//    first_1(first_date, second_date);
//	return 0;
//}

//zadanie 2
//double func(double arr1[]){
//	double sum{};
//	for (size_t i = 0; i < 50; i++){
//		sum += arr1[i];
//	}
//	return sum / 50;
//}
//int main(){
//	double arr2[50]{};
//	srand(time(0));
//	for (size_t j = 0; j < 50; j++){
//        arr2[j] = rand() % 100 + 1;
//		cout << arr2[j] << ' ';
//	}
//	double result = func(arr2);
//    cout << "average = ";
//	cout << result;
//	return 0;
//}

//zadanie 3
//void nums(int numbers[]) {
//    unsigned short int null{};
//    short int negative{};
//    short int positive{};
//    for (size_t i = 0; i < 10; i++) {
//        if (numbers[i] > 0)
//            positive++;
//        else if (numbers[i] < 0)
//            negative++;
//        else
//            null++;
//    }
//    cout << "\nnumbers equal to 0: " << null << endl;
//    cout << "numbers greater than 0: " << positive << endl;
//    cout << "numbers less than 0: " << negative << endl;
//}
//void bubble_sort(int arr1[], size_t n) {
//    for (size_t i = 0; i < n - 1; i++) {
//        for (size_t j = 0; j < n - i - 1; j++) {
//            if (arr1[j] > arr1[j + 1]) {
//                int temp = arr1[j];
//                arr1[j] = arr1[j + 1];
//                arr1[j + 1] = temp;
//            }
//        }
//    }
//}
//int main() {
//    int arr2[10];
//    srand(time(0));
//    for (size_t i = 0; i < 10; i++) {
//        arr2[i] = rand() % 21 - 10;
//    }
//    bubble_sort(arr2, 10);
//    cout << "array: ";
//    for (size_t i = 0; i < 10; i++) {
//        cout << arr2[i] << " ";
//    }
//    nums(arr2);
//    return 0;
//}