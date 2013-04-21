#include "stdafx.h"
#include "ApprovedBook.h"
#include "Manufacturer.h"
#include <fstream>
#include <string>
#include <string.h>
#include <iostream>
#include <sstream>
#include <vector>
#include "defs.h"
using namespace std;

ApprovedBook::ApprovedBook(string heading, vector<string> authors, int edition, long ISBN, Manufacturer m, string date,  string approval_date, int circulation, bool isApproved, 
						   double price) :
Book(heading, authors, edition, ISBN,  m, date, circulation, price) {
	this->isApproved = isApproved;
	this->approval_date = approval_date;
}

ApprovedBook::ApprovedBook(string heading) : Book(heading) {
	int day, month, year;

	while (true) {
		cout << "Is the book approved by the Ministry? ";
		cin >> this->isApproved;
		if (cin.good() && ((this->isApproved == 0) || (this->isApproved == 1))) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	if (this->isApproved == 1) {
		while (true) {
			cout << "Enter month of approval (provide valid month number): ";
			cin >> month;
			if (cin.good() && month >= 1 && month <= 12) { clear_input(); break; }
			else cout << "Invalid input! ";
			clear_input();
		}

		while (true) {
			cout << "Enter year of approval: ";
			cin >> year;
			if (cin.good() && year >= 1900 && year <= 2012) { clear_input(); break; }
			else cout << "Invalid input! ";
			clear_input();
		}

		while (true) {
			cout << "Enter day of approval (provide valid day number): ";
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

		stringstream s;
		s << day << "-" << month << "-" << year;
		this->approval_date = s.str();
	}		
	else this->approval_date = "N/A";
}

vector<ApprovedBook> ApprovedBook::read_from_file() {
	fstream file;
	string heading, date, approval_date;
	int edition, circulation; 
	long ISBN; 
	bool isApproved; // temp values for each book
	double price;
	string name, address; 
	__int64 telephone; // temp values for manufacturer of the book

	vector<string> authors; // temp vector for authors of the book	
	string line;
	vector<ApprovedBook> books;

	file.open("books.txt", ios::in);
	getline(file, line);
	while (line != "") {
		heading = line;

		file >> edition >> ISBN >> isApproved >> date >> approval_date >> circulation >> price;

		getline(file, line); // SKIP the rest of the line

		getline(file, line); 
		while (line != "======") {
			authors.push_back(line);
			getline(file, line);
		}

		getline(file, line);
		name = line;
		getline(file, line);
		address = line;
		getline(file, line);
		telephone = _atoi64(line.c_str()); 

		getline(file,line); // SKIP ************** line

		Manufacturer m(name, address, telephone);
		ApprovedBook a(heading, authors, edition, ISBN, m,  date, approval_date, circulation, isApproved, price);
		books.push_back(a);
		getline(file, line); 
		authors.clear(); 
	} 

	file.close();
	return books;
}

void ApprovedBook::write_to_file(ApprovedBook book) {
	fstream file;

	file.open("books.txt", ios::out | ios::end | ios::app);

	file << book.get_heading() << endl;
	file << book.get_edition() << " " << book.get_ISBN() << " " << book.get_isApproved() << 
		" " << book.get_date() << " " << book.get_approval_date() << " " << book.get_circulation() <<
		" " << book.get_price() << endl;

	vector<string> authors = book.get_authors();

	for (unsigned int index = 0; index<authors.size(); index++) {
		file << authors[index] << endl;
	}
	file << "======" << endl;
	file << book.get_manufacturer().get_name() << endl << book.get_manufacturer().get_address() << endl;
	file << book.get_manufacturer().get_telephone() << endl;
	file << "*****************" << endl;

	file.close();
}

