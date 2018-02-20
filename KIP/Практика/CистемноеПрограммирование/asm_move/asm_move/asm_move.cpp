// asm_move.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
void assembler1() {
	setlocale(LC_ALL, "rus");
	char a, b, sum;
	char *p, *q, *g;
	printf("Введите а ");
	scanf_s("%i", &a);
	printf("Введите b ");
	scanf_s("%i", &b);
	sum = a + b;
	p = &a; q = &b; g = &sum;
	cout << p << endl;
	cout << q << endl;
	cout << g << endl;
	cout << "sum = " << a + b << endl;
	_asm {
		mov al, a
		add al, b
		mov sum, al
	}
	cout << "a = " << a << " b = " << b << " sum = " << sum << endl;
	system("pause");
}

void assembler2() {
	char res;
	_asm {
		mov al, 5
		add al, 7
		mov res, al
	}
	cout << res;
}

int main()
{
	assembler2();
    return 0;
}

