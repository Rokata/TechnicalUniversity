#include "stdafx.h"
#include "Manufacturer.h"
#include <string>
#include "defs.h"
using namespace std;

Manufacturer::Manufacturer() {
	this->name = "";
	this->address = "";
	this->telephone = 0L;
}

Manufacturer::Manufacturer(int dummy) {
	cout << "Name of manufacturer? ";
	getline(cin, this->name);

	cout << "Address of manufacturer? ";
	getline(cin, this->address);

	while (true) {
		cout << "Manufacturer telephone? ";
		cin >> this->telephone;
		if (cin.good()) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}
}

Manufacturer::Manufacturer(string name, string address, __int64 telephone) {
	this->name = name;
	this->address = address;
	this->telephone = telephone;
}