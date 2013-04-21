#include "stdafx.h"
#include "Teacher.h"
#include "Student.h"
#include <iostream>
#include "DatabaseManager.h"
#include <sstream>
#include <vector>
#include <string>
using namespace std;

void DatabaseManager::insert_entry_into_database() {
	ostringstream first_query, second_query;
	int choice;

	do {
		cout << "Press 1 to add a teacher or 2 for student";
		cin >> choice;
	} while (choice != 1 && choice != 2);

	if (choice == 1) {
		Teacher t;
		first_query << "INSERT INTO Teachers VALUES ('" << t.get_NID() << "', '" << t.get_avg_horarium() << "');";
		second_query << "INSERT INTO People VALUES ('" << t.get_NID() << "', '" << t.get_firstName() << "', '" << t.get_lastName() << 
			"');";
	}
	else {
		Student s;
		first_query << "INSERT INTO Students VALUES ('" << s.get_NID() << "', '" << s.get_avg_grade() << "');"; 
		second_query << "INSERT INTO People VALUES ('" << s.get_NID() << "', '" << s.get_firstName() << "', '" << s.get_lastName() << 
			"');";
	} 

	const string first_tmp = first_query.str();
	const char* query_one = first_tmp.c_str();
	const string second_tmp = second_query.str();
	const char* query_two = second_tmp.c_str();

	sqlite3_open("test.db", &database);
	if (sqlite3_prepare_v2(database, query_one, -1, &statement, 0) == SQLITE_OK) {
		sqlite3_step(statement);
	}
	else {
		cout << "Error: " << sqlite3_errmsg(database) << endl;
	}

	if (sqlite3_prepare_v2(database, query_two, -1, &statement, 0) == SQLITE_OK) {
		sqlite3_step(statement);
		cout << "A new record has been added to the database! \n\n";
	}
	else {
		cout << "Error: " << sqlite3_errmsg(database) << endl;
	}
	sqlite3_finalize(statement);
	sqlite3_close(database); 
}

vector<vector<string>> DatabaseManager::select_entry() {
	int choice, sort_choice;
	vector<vector<string>> results;
	char* query;

	do {
		cout << "What information would like to get: teachers(1) or students(2) ";
		cin >> choice;
	} while (!isdigit(choice) && choice != 1 && choice != 2);

	do {
		if (choice == 1) {
			cout << "Sort by: horarium(1) or name(2) ";
			cin >> sort_choice;
		}
		else {
			cout << "Sort by: average grade(1) or name(2) ";
			cin >> sort_choice;
		}
	} while (!isdigit(sort_choice) && sort_choice != 1 && sort_choice != 2);

	sqlite3_open("test.db", &database);

	if (choice == 1) {
		if (sort_choice == 1) 
			query = "SELECT People.firstName, People.lastName, People.person_NID, Teachers.avg_horarium FROM People JOIN Teachers ON People.person_NID = Teachers.NID ORDER BY Teachers.avg_horarium COLLATE NOCASE DESC;";

		else query = "SELECT People.firstName, People.lastName, People.person_NID, Teachers.avg_horarium FROM People JOIN Teachers ON People.person_NID = Teachers.NID ORDER BY People.firstName COLLATE NOCASE ASC;";
	}
	else {
		if (sort_choice == 1) query = "SELECT People.firstName, People.lastName, People.person_NID, Students.avg_grade FROM People JOIN Students ON People.person_NID = Students.NID ORDER BY Students.avg_grade COLLATE NOCASE DESC;";
		else query = "SELECT People.firstName, People.lastName, People.person_NID, Students.avg_grade FROM People JOIN Students ON People.person_NID = Students.NID ORDER BY People.firstName COLLATE NOCASE ASC;";
	}

	if (sqlite3_prepare_v2(database, query, -1, &statement, 0) == SQLITE_OK) {
		int cols = sqlite3_column_count(statement);
		int result = 0;

		while (true) {
			result = sqlite3_step(statement);

			if (result == SQLITE_ROW) {
				vector<string> values;
				for (int i=0; i<cols; i++) {
					values.push_back((char*)sqlite3_column_text(statement, i));
				}
				results.push_back(values);
			}
			else break;
		}
	}	
	sqlite3_finalize(statement);
	sqlite3_close(database);
	return results;
}