#include <iostream>
using namespace std;

struct Computer_components {
    string model;

    Computer_components(const string& model) : model(model) {}
};

struct Processor : public Computer_components {
    int frequency;

    Processor(const string& model, int frequency) : Computer_components(model), frequency(frequency) {}
};

struct Memory : public Computer_components {
    int capacity;

    Memory(const string& model, int capacity) : Computer_components(model), capacity(capacity) {}
};

class Computer {
private:
    string make;
    string model;
    Processor processor;
    Memory memory;

public:
    Computer(const string& brand, const string& model, const Processor& processor, const Memory& memory)
            : make(brand), model(model), processor(processor), memory(memory) {}

    void info() const {
        cout << "Brand: " << make << endl;
        cout << "Model: " << model << endl;
        cout << "Memory: " << memory.model << " " << memory.capacity << " GB" << endl;
        cout << "Processor: " << processor.model << " " << processor.frequency << " MHz" << endl;
    }
};

int main() {
    string make, model, processorModel;
    int processorFrequency, memoryCapacity;

    cout << "Add computer brand: ";
    cin >> make;
    cout << "Add computer model: ";
    cin >> model;
    cout << "Add processor model: ";
    cin >> processorModel;
    cout << "Add processor frequency (MHz): ";
    cin >> processorFrequency;
    cout << "Add memory capacity (GB): ";
    cin >> memoryCapacity;

    Processor processor(processorModel, processorFrequency);
    Memory memory(processorModel, memoryCapacity);
    Computer computer(make, model, processor, memory);
    cout << "Computer data:" << endl;
    computer.info();
    return 0;
}