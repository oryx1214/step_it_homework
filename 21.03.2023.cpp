#include <iostream>
using namespace std;
//int main(){
//    int product_value[4]{1150, 100, 70 , 575};
//    char** product_name = new char* [4] {};;
//    product_name[0] = new char[25] {"videocard"};
//    product_name[1] = new char[25] {"ssd"};
//    product_name[2] = new char[25] {"hdd"};
//    product_name[3] = new char[25]{"monitor"};
//    for (size_t i = 0; i < 4; i++){
//        for (size_t j = 0; j < 4; j++){
//            if ((int)product_name[i][0] < (int)product_name[j][0]){
//                char* first_product = product_name[i];
//                product_name[i] = product_name[j];
//                product_name[j] = first_product;
//                int second_product = product_value[i];
//                product_value[i] = product_value[j];
//                product_value[j] = second_product;
//            }
//        }
//    }
//    int max = product_value[0], min = product_value[0], maximum{}, minimum{};
//    for (size_t i = 0; i < 4; i++){
//        if (product_value[i] > max){
//            max = product_value[i];
//            maximum = i;
//        }
//        else if (product_value[i] < min){
//            min = product_value[i];
//            minimum = i;
//        }
//        else if (product_value[i] == 0){
//            cout << "free product";
//        }
//    }
//    cout << "min: " << product_name[minimum] << endl << "max: " << product_name[maximum] << endl;
//    for (size_t i = 0; i < 4; i++){
//        cout << product_name[i] << " " << product_value[i] << endl;
//    }
//    return 0;
//
//}
