#include <iostream>
using namespace std;

//zadanie 1
//
//    int func_for_degree(int num, int degre){
//    if (degre == 0 or degre < 0) {
//		return 1;
//	}
//	return num * func_for_degree(num, degre - 1);
//}
//int main(){
//	int number{};
//	int degree{};
//	cout << "add number: ";
//    cin >> number;
//	cout << "add degree: ";
//    cin >> degree;
//	int result = func_for_degree(number, degree);
//	cout << "your number " << number << " to the power " << degree << " equals " << result;
//	return 0;
//}

//zadanie 2

//char func_for_stars(int number){
//	if (number == 0 or number < 0){
//		return 1;
//	}
//	cout << '*';
//	return func_for_stars(number - 1);
//}
//int main() {
//    int number{};
//    cout << "add number: ";
//    cin >> number;
//    func_for_stars(number);
//    return 0;
//}

//zadanie 3

//long int summ_for_range(int first_num, int second_num){
//	if (first_num == second_num){
//		return first_num;
//	}
//	return first_num + summ_for_range(first_num + 1, second_num);
//}
//int main(){
//	int first_number{};
//	int second_number{};
//	cout << "add first number: ";
//    cin >> first_number;
//	cout << "add second number: ";
//    cin >> second_number;
//	cout << summ_for_range(first_number, second_number);
//	return 0;
//}

//zadanie 4
//int summ[3]{0, 1000, 0 };
//void func(int numbers[], int num){
//	for (size_t j = num; j < num + 10; j++){
//        summ[0] += numbers[j];
//	}
//	if (summ[1] > summ[0]){
//        summ[1] = summ[0];
//        summ[2] = num;
//	}
//    summ[0] = 0;
//	if (num == 90){
//		cout << "min: " << summ[2];
//		return;
//	}
//    return func(numbers, num + 1);
//}
