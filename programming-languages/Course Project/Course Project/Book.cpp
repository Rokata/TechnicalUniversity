#include "stdafx.h"
#include "Book.h"
#include <vector>
#include <iostream>
#include <string>
#include <sstream>
#include "defs.h"
using namespace std;

Book::Book(string heading, vector<string> authors, int edition, long ISBN, Manufacturer m, string date, int circulation, 
		   double price) {
	this->heading = heading;
	this->authors = authors;
	this->edition = edition;
	this->ISBN = ISBN;
	this->m = m;
	this->date = date;
	this->circulation = circulation;
	this->price = price;
}

Book::Book(string heading) {
	int count = 0;
	int day, month, year;

	this->heading = heading;

	while (true) {
		cout << "How many authors are in the book? ";
		cin >> count;
		if (cin.good() && count > 0) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	for (int i=0; i<count; i++) {
		cout << "Enter author: ";
		string author;
		getline(cin, author);
		authors.push_back(author);
	}

	while (true) {
		cout << "Which edition is the book? ";
		cin >> this->edition;
		if (cin.good() && this->edition > 0) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	while (true) {
		cout << "ISBN of the book? ";
		cin >> this->ISBN;
		if (cin.good()) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	while (true) {
		cout << "Circulation of the book? ";
		cin >> this->circulation;
		if (cin.good() && this->circulation > 0) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	while (true) {
		cout << "Price of the book? ";
		cin >> this->price;
		if (cin.good() && this->price > 0) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	while (true) {
		cout << "Enter month of release (provide valid month number): ";
		cin >> month;
		if (cin.good() && month >= 1 && month <= 12) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	while (true) {
		cout << "Enter year of release: ";
		cin >> year;
		if (cin.good() && year >= 1900 && year <= 2012) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	while (true) {
		cout << "Enter day of release (provide valid day number): ";
		cin >> day;
		if (cin.good()) {
			if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) { 
				if (day > 0 && day < 32) { clear_input(); break; }				
			}
			else if (month == 4 || month == 6 || month == 9 || month == 11) {
				if (day > 0 && day < 31) { clear_input(); break; }
			}
			else {
				if (year % 4 == 0) {
					if (day > 0 && day < 30) { clear_input(); break; }
				}
				else {
					if (day > 0 && day < 29) { clear_input(); break; }
				}
			}
		}

		else cout << "Invalid input! ";
		clear_input();	
	}

	this->m = Manufacturer(0);

	stringstream s;
	s << day << "-" << month << "-" << year;
	this->date = s.str();
}