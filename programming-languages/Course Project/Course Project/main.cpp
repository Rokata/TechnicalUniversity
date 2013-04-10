#include "stdafx.h"
#include <iostream>
#include <vector>
#include <fstream>
#include "Book.h"
#include "Manufacturer.h"
#include "ApprovedBook.h"
#include "defs.h"
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int c;
	vector<ApprovedBook> books = ApprovedBook::read_from_file();
	vector<string> manufacturers;
	string book_name;

	for (unsigned int index = 0; index<books.size(); index++) {
		string manu_name = books[index].get_manufacturer().get_name();	
		if (!check_manufacturer(books[index].get_manufacturer(), manufacturers)) manufacturers.push_back(manu_name);
	} 

	do {
		while (true) {
			cout << "Choose an option " << endl;
			cout << "To enter a book and a manufacturer, enter 1" << endl;
			cout << "To order a book from a specific manufacturer, enter 2" << endl;
			cout << "To exit, press 0 ";
			cin >> c;

			if (!cin.good() || (c != 0 && c != 1 && c != 2)) {
				cout << "Invalid input! \n";
			}
			else { clear_input(); break; }
			clear_input();
			cout << endl;
		}

		switch (c) {
		case 0: return 0;
		case 1: {
			bool isInFile = false;

			cout << "What's the name of the new book? ";
			getline(cin, book_name);

			for (unsigned int i=0; i<books.size(); i++) {
				if (books[i].get_heading() == book_name) {
					cout << "Book already in catalogue!\n" << endl;
					isInFile = true;
					break;
				}
			}						

			if (!isInFile) {
				ApprovedBook b(book_name);
				books.push_back(b);

				if (!check_manufacturer(b.get_manufacturer(), manufacturers)) manufacturers.push_back(b.get_manufacturer().get_name());

				ApprovedBook::write_to_file(b);
			}
			break;
				}

		case 2: {
			if (books.size() > 0) {
				double order_total = order_from_manufacturer(books, manufacturers);
				if (order_total > 0.0) {
					cout << "Total: " << order_total << endl;
					cout << "Thanks for your order!\n\n";
				}
				else cout << "Nothing ordered!\n";
				break;
			}
			else cout << "\nList is empty. Please enter new books from the menu.\n\n";
				}
		}
	} while (c != 0);

	return 0; 
}

