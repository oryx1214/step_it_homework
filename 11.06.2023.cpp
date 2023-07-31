#include <iostream>
#include <vector>
using namespace std;
template<typename templ>
class Vector {
private:
    templ* arr{};
    size_t capacity{};
    size_t length{};
public:
    Vector(initializer_list<templ> list) {
        this->length = list.size();
        this->capacity = list.size() * 3;
        this->arr = new templ[this->capacity]{};

        for (auto i = list.begin(); i < list.end(); ++i) {
            this->arr[i - list.begin()] = *i;
        }
    }
    void reverse() {
        for (size_t i = 0; i < length / 2; ++i) {
            templ temp = arr[i];
            arr[i] = arr[length - i - 1];
            arr[length - i - 1] = temp;
        }
    }
    void pop() {
        if (length > 0) {
            length--;
        }
    }
    templ& operator[](size_t index) {
        if (index < this->length) {
            return this->arr[index];
        }
    }
    friend ostream& operator<<(ostream& os, Vector<templ>& v) {
        for (size_t i = 0; i < v.length; ++i) {
            os << v.arr[i] << ' ';
        }
        return os;
    }
};
int main() {
    Vector<int> final_arr{1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    cout << "array: " << final_arr << endl;
    final_arr.pop();
    cout << "pop: " << final_arr << endl; //удаление с конца списка
    final_arr.reverse();
    cout << "reverse: " << final_arr << endl; // список в обратном прорядке
    return 0;
}
