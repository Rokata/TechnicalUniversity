#include <vector>
#include "Manufacturer.h"
using namespace std;

#ifndef BOOK_H
#define BOOK_H

class Book {
private:
	string heading;
	vector<string> authors;
	int edition;
	long ISBN;
	Manufacturer m;
	string date;
	int circulation;
	double price;

public:
	Book(string, vector<string>, int, long, Manufacturer, string, int, double);
	Book(string);
	~Book() { } 
	string get_heading() { return this->heading; }
	void set_heading(string heading) { this->heading = heading; }
	vector<string> get_authors() { return this->authors; }
	void set_authors(vector<string> authors) { this->authors = authors; }
	int get_edition() { return this->edition; }
	void set_edition(int edition) { this->edition = edition; }
	long get_ISBN() { return this->ISBN; }
	void set_ISBN(long ISBN) { this->ISBN = ISBN; }
	Manufacturer get_manufacturer() { return this->m; }
	void set_manufacturer(Manufacturer m) { this->m = m; }
	string get_date() { return this->date; }
	void set_date(string date) { this->date = date; }
	int get_circulation() { return this->circulation; }
	void set_circulation(int circulation) { this->circulation = circulation; }
	double get_price() { return this->price; }
	void set_price(double price) { this->price = price; }
};

#endif