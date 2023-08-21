#include <iostream>
#include <string>
#include <vector>
#include <regex>
using namespace std;
class User {
public:
    string username;
    string password;

    User(const string& user_name, const string& password_) : username(user_name), password(password_) {}
};

class Log {
private:
    vector<User> users;
    bool Username(const string& username) const {
        regex usname("^[a-zA-Z0-9_-]{3,16}$");
        return regex_match(username, usname);
    }
    bool Password(const string& password) const {
        regex pass("^[a-zA-Z0-9_]{6,20}$");
        return regex_match(password, pass);
    }

public:
    void Reg() {
        string username, password;

        cout << "Enter username: ";
        cin >> username;

        if (!Username(username)) {
            cout << "Invalid username format. Usernames must be 3-16 characters long and can only contain letters, numbers, underscores, and hyphens" << endl;
            return;
        }

        cout << "Enter password: ";
        cin >> password;

        if (!Password(password)) {
            cout << "Invalid password format. Passwords must be 6-20 characters long and can only contain letters, numbers, and underscores" << endl;
            return;
        }
        users.push_back(User(username, password));
        cout << "Registration successful" << endl;
    }

    bool Login() {
        string username, password;

        cout << "Enter username: ";
        cin >> username;

        cout << "Enter password: ";
        cin >> password;

        for (const auto& user : users) {
            if (user.username == username && user.password == password) {
                cout << "Login successful " << username << "!" << endl;
                return true;
            }
        }

        cout << "Login failed. Invalid username or password" << endl;
        return false;
    }
};

int main() {
    Log log;
    while (true) {
        cout << "1 Register\n2 Login\n3 Exit\n";
        int choice;
        cin >> choice;
        cout << endl;
        switch (choice) {
            case 1:
                log.Reg();
                break;
            case 2:
                log.Login();
                break;
            case 3:
                cout << "Bye " << endl;
                return 0;
            default:
                cout << "Invalid choice. Try again" << endl;
        }
    }

    return 0;
}
