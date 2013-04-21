#include "stdafx.h"
#include "Student.h"
#include <iostream>
using namespace std;

Student::Student() : Person() {
	cout << "Enter average grade: ";
	cin >> avg_grade;
}

void Student::toString() {
	Person::toString();
	cout << "Average grade: " << avg_grade;
}