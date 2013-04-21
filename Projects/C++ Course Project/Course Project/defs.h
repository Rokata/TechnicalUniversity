#include "stdafx.h"
#include <iostream>
#include <vector>
#include "ApprovedBook.h"
using namespace std;

#ifndef CLEARINPUT_H
#define CLEARINPUT_H

struct order {
	int index;
	int count;

	order(int i, int q) {
		index = i;
		count = q;
	}
};

void clear_input();
double order_from_manufacturer(vector<ApprovedBook> books, vector<string> manufacturers);
bool check_manufacturer(Manufacturer m, vector<string> manufacturers);

#endif