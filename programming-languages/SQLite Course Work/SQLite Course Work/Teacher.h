#include "Person.h"

#ifndef TEACHER_H
#define TEACHER_H

class Teacher : public Person {
private:
	int avg_horarium;

public:
	Teacher();
	void toString();

	int get_avg_horarium() {
		return avg_horarium;
	}
};

#endif