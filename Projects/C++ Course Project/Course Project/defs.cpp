#include "defs.h"

void clear_input() {
	cin.clear();
	cin.ignore(100000, '\n');
}

double order_from_manufacturer(vector<ApprovedBook> books, vector<string> manufacturers) {
	vector<int> manu_books;
	vector<struct order> orders;
	unsigned int m_choice, b_choice;
	cout << "To view books of a manufacturer, press the number next to it." << endl << endl;
	for (unsigned int i=0; i<manufacturers.size(); i++) {
		cout << i << ". " << manufacturers[i] << endl;
	}

	while (true) {
		cin >> m_choice;
		if (cin.good() && m_choice >= 0 && m_choice < manufacturers.size()) { clear_input(); break; }
		else cout << "Invalid input! ";
		clear_input();
	}

	cout << endl;
	// books from manufacturer
	for (unsigned int i=0; i<books.size(); i++) {
		if (books[i].get_manufacturer().get_name() == manufacturers[m_choice]) {
			cout << "#" << i << " " << books[i].get_heading() << endl;
			manu_books.push_back(i);
		}
	}

	// order
	cout << "\nEnter the numbers of the books you like to order (type 100 to exit): \n";
	do {
		while (true) {
			cin >> b_choice;
			if (cin.good()) { clear_input(); break; }
			else cout << "Invalid input! ";
			clear_input();
		}

		bool valid_choice = false;

		if (b_choice == 100) break;

		for (unsigned int i=0; i<manu_books.size(); i++) {
			if (b_choice == manu_books[i]) {
				valid_choice = true;
				break;
			}
		}

		if (!valid_choice) cout << "Invalid choice!! \n";
		else {
			int quantity;

			cout << "Enter quantity: ";
			cin >> quantity;

			struct order new_order(b_choice, quantity);
			orders.push_back(new_order);
			cout << "Order added to basket! Waiting for input... ";
		}
	}
	while (b_choice != 100);

	double total = 0.0;
	double subtotal = 0.0;

	if (orders.size() > 0) {
		cout << "\nYou ordered: \n";
		for (unsigned int i=0; i<orders.size(); i++) {
			subtotal = books[orders[i].index].get_price() * orders[i].count;
			total += subtotal;
			cout << books[orders[i].index].get_heading() << " x" << orders[i].count << "  Subtotal: " << 
				subtotal << endl << endl;
		}
	}

	return total;
}

bool check_manufacturer(Manufacturer m, vector<string> manufacturers) {
	bool exists = false;
	string manu_name = m.get_name();

	for (unsigned int m_index = 0; m_index<manufacturers.size(); m_index++) {
		if (manufacturers[m_index] == manu_name) {
			exists = true;
			break;
		}
	}

	return exists;
}