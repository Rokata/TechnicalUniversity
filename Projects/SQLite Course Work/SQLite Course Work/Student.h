#include "Person.h"

#ifndef STUDENT_H
#define STUDENT_H

class Student : public Person {
private:
	double avg_grade;
public:
	Student();
	double get_avg_grade() { return avg_grade; }
	void toString();
};

#endif