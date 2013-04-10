#include <string>
#ifndef PERSON_H
#define PERSON_H
using namespace std;

class Person {
private:
	string firstName;
	string lastName;
	__int64 NID;

public:
	Person();
	void toString();

	string get_firstName() {
		return firstName;
	}

	string get_lastName() {
		return lastName;
	}

	__int64 get_NID() {
		return NID;
	}
};

#endif