#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;
using namespace System;

struct Mark {
	int score;
	string date;
	Mark *next;

};

struct Student {
	string name;
	Mark *lesson1;
	Mark *lesson2;
	Mark *lesson3;
	Mark *lesson4;
	Mark *lesson5;
	Student *next;
};

struct Group {
	string group_num;
	Student *student;
	Group *next;
};

struct High {
	int num = 0;
	Group *grHigh;
	Mark *mrHigh;
	Student *stHigh;
};

High *h_obj = new High();
void stash() {
	if (h_obj->num == 0) {
		h_obj->num += 1;
		h_obj->grHigh = new Group();
		cout << "Введите номер группы студента <КурсФакультет-НомерГруппы>"<< endl;
		cin >> h_obj->grHigh->group_num;
	}
}

void pop() {

}

int main()
{
	return 0;
}

