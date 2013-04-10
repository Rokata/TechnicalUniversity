#include "stdafx.h"
#include "Teacher.h"
#include <iostream>
using namespace std;

Teacher::Teacher() : Person() {
	cout << "Enter average monthly horarium: ";
	cin >> avg_horarium;
}

void Teacher::toString() {
	Person::toString();
	cout << "Average monthly horarium: " << avg_horarium;
}