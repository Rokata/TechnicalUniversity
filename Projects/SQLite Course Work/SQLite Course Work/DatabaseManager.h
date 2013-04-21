#include "sqlite3.h"
#include "Teacher.h"
#include <vector>
using namespace std;

#ifndef DATABASEMANAGER_H
#define DATABASEMANAGER_H

class DatabaseManager {
private:
	sqlite3 *database;
	sqlite3_stmt *statement;

public:
	void insert_entry_into_database();
	void create_database();
	vector<vector<string>> select_entry();
};

#endif