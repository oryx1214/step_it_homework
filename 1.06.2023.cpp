#include <iostream>
using namespace std;
struct Memory {
    int cap;
};
struct Processor {
    string model;
    int frequency;
};
class computer {
private:
    string make;
    string model;
    Processor processor;
    Memory memory;
public:
    computer(const string& brand, const string& model, const Processor& processor, const Memory& memory) {
        this->make = brand;
        this->model = model;
        this->processor = processor;
        this->memory = memory;
    }
    void info() const {
        cout << "brand: " << make << endl;
        cout << "model: " << model << endl;
        cout << "memory: " << memory.cap << " gb" << endl;
        cout << "processor: " << processor.model << processor.frequency << " MHz" << endl;

    }
};
int main() {
    string make, model, processorModel;
    int processorFrequency, memoryCapacity;
    cout << "add computer brand: ";
    cin >> make;
    cout << "add computer model: ";
    cin >> model;
    cout << "add processor model: ";
    cin >> processorModel;
    cin.ignore();
    cout << "add processor frequency MHz: ";
    cin >> processorFrequency;
    cin.ignore();
    cout << "add memory cap gb: ";
    cin >> memoryCapacity;
    cin.ignore();
    cout <<"press enter to continue";
    cin.ignore();
    Processor processor{processorModel, processorFrequency};
    Memory memory{memoryCapacity};
    computer computer(make, model, processor, memory);
    cout << "computer data:" << endl;
    computer.info();
    return 0;
}

