#include <iostream>
using namespace std;

class Computer_components {
protected:
    string model;

public:
    Computer_components(const string& model) : model(model) {}
    string get_model() const { return model; }
};

class Processor : public Computer_components {
private:
    int frequency;

public:
    Processor(const string& model, int frequency) : Computer_components(model), frequency(frequency) {}
    int get_frequency() const { return frequency; }
};

class Memory : public Computer_components {
private:
    int capacity;

public:
    Memory(const string& model, int capacity) : Computer_components(model), capacity(capacity) {}
    int get_capacity() const { return capacity; }
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
        cout << "Memory: " << memory.get_model() << " " << memory.get_capacity() << " GB" << endl;
        cout << "Processor: " << processor.get_model() << " " << processor.get_frequency() << " MHz" << endl;
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
