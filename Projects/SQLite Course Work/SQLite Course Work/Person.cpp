#include "stdafx.h"
#include "Person.h"
#include <iostream>
using namespace std;

Person::Person() {
	cout << "Enter first name: ";
	cin >> firstName;
	cout << "Enter last name: ";
	cin >> lastName;
	cout << "Enter NID: ";
	cin >> NID;
}

void Person::toString() {
	cout << "First name: " << firstName << endl;
	cout << "Last name: " << lastName << endl;
	cout << "NID: " << NID << endl;
}