#include <iostream>

using namespace std;

template <typename T>
class List {
private:
    struct Ans {
        T data;
        Ans* prev;
        Ans* next;
        Ans(const T& value) : data(value), prev(nullptr), next(nullptr) {}
    };
    Ans* head;
    Ans* tail;
    int count;
public:
    List() : head(nullptr), tail(nullptr), count(0) {}
//Добавить в конец
    void append(const T& value) {
        Ans* NewAns = new Ans(value);
        if (!head) {
            head = tail = NewAns;
        } else {
            NewAns->prev = tail;
            tail->next = NewAns;
            tail = NewAns;
        }
        count++;
    }
//Добавить в начало
    void add_to_begining_lol(const T& value) {
        Ans* NewAns = new Ans(value);
        if (!head) {
            head = tail = NewAns;
        } else {
            NewAns->next = head;
            head->prev = NewAns;
            head = NewAns;
        }
        count++;
    }
//Добавить по индексу
    void insert(int index, const T& value) {
        if (index < 0 || index > count) {
            cout << "invalid index" << endl;
            return;
        }

        if (index == 0) {
            add_to_begining_lol(value);
        } else if (index == count) {
            append(value);
        } else {
            Ans* newNode = new Ans(value);
            Ans* current = head;
            for (int i = 0; i < index; ++i) {
                current = current->next;
            }
            newNode->prev = current->prev;
            newNode->next = current;
            current->prev->next = newNode;
            current->prev = newNode;
            count++;
        }
    }
//Удалить последний(Pop)
    void pop() {
        if (count == 0) {
            return;
        }

        if (count == 1) {
            delete head;
            head = tail = nullptr;
        } else {
            Ans* prevTail = tail->prev;
            delete tail;
            tail = prevTail;
            tail->next = nullptr;
        }
        count--;
    }
//Удалить по индексу.
    void remove(int index) {
        if (index < 0 || index >= count) {
            cout << "invalid index" << endl;
            return;
        }
        if (index == 0) {
            Ans* nextHead = head->next;
            delete head;
            head = nextHead;
            if (head) {
                head->prev = nullptr;
            } else {
                tail = nullptr;
            }
        } else if (index == count - 1) {
            pop();
        } else {
            Ans* current = head;
            for (int i = 0; i < index; ++i) {
                current = current->next;
            }
            current->prev->next = current->next;
            current->next->prev = current->prev;
            delete current;
        }
        count--;
    }
//Удалить по значнию
    void value_remove(const T& value) {
        Ans* current = head;
        while (current) {
            if (current->data == value) {
                if (current == head) {
                    remove(0);
                } else if (current == tail) {
                    pop();
                } else {
                    current->prev->next = current->next;
                    current->next->prev = current->prev;
                    delete current;
                    count--;
                }
                return;
            }
            current = current->next;
        }
    }
    void answer() const {
        Ans* current = head;
        while (current) {
            cout << current->data << " ";
            current = current->next;
        }
        cout << endl;
    }
    ~List() {
        Ans* current = head;
        while (current) {
            Ans* temp = current;
            current = current->next;
            delete temp;
        }
    }
};
int main() {
    List<int> list;
    list.append(2);
    list.append(5);
    list.add_to_begining_lol(7);
    list.insert(6, 77);
    list.answer();
    list.pop();
    list.remove(4);
    list.answer();
    list.append(5);
    list.append(4);
    list.append(23);
    list.value_remove(255);
    list.answer();
    return 0;
}
