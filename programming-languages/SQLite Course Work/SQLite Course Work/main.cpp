// main.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "DatabaseManager.h"
#include "Teacher.h"
#include <iostream>
#include <vector>
#include <string>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int choice;
	DatabaseManager m;
	vector<vector<string>> results;
	
	do {
		do {
			cout << "To add a record to the database, press 1 \n";
			cout << "To view records from the database, press 2 \n";
			cout << "To exit, press 3 ";
			cin >> choice;
		} while (choice < 1 && choice > 3);

		switch (choice) {
		case 1:
			m.insert_entry_into_database(); 
			break;
		case 2:
			results = m.select_entry(); 
			cout << "\nResults: " << endl;
			for (int i=0; i<results.size(); i++) {
				for (int j=0; j<results[i].size(); j++)  {
					cout << results[i][j] << " | ";
				}
				cout << endl;
			}
			cout << endl;
			break;

		case 3: return 0;
		default: cout << "\nInvalid choice! \n\n"; break;
		}
	} while (choice != 3);

	return 0;
}




