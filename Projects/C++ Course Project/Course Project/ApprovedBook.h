#include "Book.h"
#include <string>
#include <vector>
#include <ostream>
using namespace std;

#ifndef APPROVEDBOOK_H
#define APPROVEDBOOK_H

class ApprovedBook : public Book {
private:
	bool isApproved;
	string approval_date;

public:
	ApprovedBook(string, vector<string>, int, long, Manufacturer, string, string, int, bool, double);
	ApprovedBook(string);
	~ApprovedBook() { } 
	bool get_isApproved() {return this->isApproved;}
	void set_isApproved(bool isApproved) { this->isApproved = isApproved; }
	string get_approval_date() { return this->approval_date; }
	void set_approval_date(string approval_date) { this->approval_date = approval_date; }
	static vector<ApprovedBook> read_from_file();
	static void write_to_file(ApprovedBook);

	friend ostream& ApprovedBook::operator<<(ostream& output, ApprovedBook book) {
		output << "Name: " << book.get_heading() << endl;
		output << "Authors: " << endl;
		vector<string> authors = book.get_authors();

		for (unsigned int i = 0; i<authors.size(); i++) {
			output << authors[i] << " | ";
		}
		output << endl << endl;

		output << "Edition: " << book.get_edition() << endl;
		output << "ISBN: " << book.get_ISBN() << endl;
		output << "Date released: "  << book.get_date() << endl;
		output << "Circulation: " << book.get_circulation() << endl;
		output << "Approved: " << ((book.isApproved == 1) ? "yes" : "no") << endl;
		output << "Date approved: " << book.approval_date << endl;
		output << "Price: " << book.get_price() << endl;
		output << book.get_manufacturer();

		return output;
	} 
};

#endif

