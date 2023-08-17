#include <iostream>

using namespace std;

template <typename T>
class Myqueue {
public:
    T data;
    Myqueue<T>* next;

    Myqueue(T value) : data(value), next(nullptr) {}
};
template <typename T>
class Queue {
private:
    Myqueue<T>* fgueue;
    Myqueue<T>* rgueue;

public:
    Queue() : fgueue(nullptr), rgueue(nullptr) {}

    bool empty() {
        return fgueue == nullptr;
    }

    void enqueue(T value) {
        Myqueue<T>* newNode = new Myqueue<T>(value);
        if (empty()) {
            fgueue = rgueue = newNode;
        } else {
            rgueue->next = newNode;
            rgueue = newNode;
        }
    }

    T dequeue() {
        if (empty()) {
            throw runtime_error("Queue is empty.");
        }
        T value = fgueue->data;
        Myqueue<T>* temp = fgueue;
        fgueue = fgueue->next;
        delete temp;
        return value;
    }

    T check() {
        if (empty()) {
            throw runtime_error("Queue is empty.");
        }
        return fgueue->data;
    }

    ~Queue() {
        while (!empty()) {
            dequeue();
        }
    }
};

int main() {
    Queue<int> queue;
    queue.enqueue(11);
    queue.enqueue(23);
    queue.enqueue(56);

    cout << "Queue elements:" << endl;
    while (!queue.empty()) {
        cout << queue.dequeue() << " ";
    }
    cout << endl;

    return 0;
}