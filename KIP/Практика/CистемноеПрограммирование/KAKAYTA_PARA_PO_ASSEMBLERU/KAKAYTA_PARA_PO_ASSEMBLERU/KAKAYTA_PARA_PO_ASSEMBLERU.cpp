#include "stdafx.h"
#include <iostream>
using namespace System;
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");
	int a = 88, b = 2, c = 6, rez;
	_asm {
		mov eax, a
		mov ebx, b
		imul ebx
		push eax

		mov eax, b
		mov ebx, c
		imul ebx
		add eax, a
		push eax

		pop eax
		pop ebx
		idiv ebx
		mov rez, eax

	}
	cout << "(a+b*c)/(a*b) = " << rez << endl;
	system("pause");
    return 0;
}
