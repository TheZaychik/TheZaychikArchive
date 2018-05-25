// Tema16.cpp: определяет точку входа для консольного приложения.
//


#include "stdafx.h"  // Больше внешних зависимостей богу внешних зависимотсей! 
#include <iostream>
#include <string>
#include <conio.h>
#include <stdio.h>
#include <Windows.h>
#include <fstream>
#include <random>
#include <time.h>
#include <iomanip>
using namespace System;
using namespace std;

double mas[100][100];
int n, m;
string menu[] = { "Ввод строки:", "Ручной", "Из файла", "Выход" };
string menu1[] = { "Меню задач:", "Задача 1", "Задача 2", "Назад" };
int code, l, l1;
string inpt;

COORD position;										// Объявление необходимой структуры
HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);	// Получение дескриптора устройства стандартного вывода

int print_menu(string menu[], int l)
{
	char ch;
	int i, m;
	system("cls");
	position.X = 5;										// Установка координаты X
	position.Y = 1;										// Установка координаты Y
	SetConsoleCursorPosition(hConsole, position);		// Перемещение каретки по заданным координатам
	cout << menu[0];										// Вывод сообщения
	position.X = 3;

	for (i = 1; i <l; i++)
	{
		position.Y = i + 1;
		SetConsoleCursorPosition(hConsole, position);
		cout << menu[i];
	}
	position.X = 2;
	do
	{
		ch = _getch();
		code = static_cast<int>(ch);
		SetConsoleCursorPosition(hConsole, position);
		puts(" ");
		switch (code) {
		case 80: if (position.Y<l) position.Y++;
				 else position.Y = 2;
				 SetConsoleCursorPosition(hConsole, position);
				 puts(">");
				 break;
		case 72: if (position.Y>2) position.Y--;
				 else position.Y = l;
				 SetConsoleCursorPosition(hConsole, position);
				 puts(">");
				 break;
		}
	} while (code != 13);
	return position.Y;
}

void vvod_file() {
	system("cls");
	string line;
	ifstream file("str_input.txt", ios::in);
	getline(file, line);
	inpt = atoi(line.c_str());
	file.close();
	cout << inpt << endl;
}

void out_file() {
	system("cls");
	string line;
	ofstream file("str_out.txt", ios::out);
	if (file.is_open())
		file << inpt << endl;
	cout << "Результат записан в файл!" << endl;
}


void zad1() {
	system("cls");
	
}

void zad2() {
	system("cls");

}
void menu_1();
void menu_2() {
	l = print_menu(menu1, 4);
	switch (l)
	{
	case 2: zad1();
		break;
	case 3: zad2();
		break;
	case 4: menu_1();
		break;
	default:
		break;
	}
}

void menu_1() {
	l = print_menu(menu, 4);
	switch (l)
	{
	case 2: 
		system("cls");
		cout << "Введите строку: " << endl;
		cin >> inpt;
		menu_2();
		break;
	case 3:
		system("cls");
		cout << "Поместите файл со строкой под названием str_input.txt в папку с приложения, затем нажмите enter" << endl;
		system("pause");
		vvod_file();
		menu_2();
		break;
	case 4: exit(0);
		break;
	default:
		break;
	}
}

int main() {
	setlocale(LC_ALL, "Russian");
	menu_1();
	system("pause");
	return 0;
}
