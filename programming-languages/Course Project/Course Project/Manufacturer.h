#include <string>
using namespace std;

#ifndef MANUFACTURER_H
#define MANUFACTURER_H

class Manufacturer {
private:
	string name;
	string address;
	__int64 telephone;

public:
	string get_name() { return this->name; }
	void set_name(string name) { this->name = name; }
	string get_address() { return this->address; }
	void set_address(string address) { this->address = address; }
	__int64 get_telephone() { return this->telephone; }
	void set_telephone(__int64 telephone) { this->telephone = telephone; }
	Manufacturer();
	Manufacturer(string, string, __int64);
	Manufacturer(int);

	friend ostream& Manufacturer::operator<<(ostream& output, Manufacturer m) {		
		output << "Manufacturer name: " << m.name << endl;
		output << "Manufacturer address: " << m.address << endl;
		output << "Manufacturer telephone: " << m.telephone << endl;
		return output;
	}
};

#endif