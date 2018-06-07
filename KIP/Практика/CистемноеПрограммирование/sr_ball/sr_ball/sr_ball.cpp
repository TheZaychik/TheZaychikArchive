// sr_ball.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int zad1()
{
	char ots[5] = { 5, 5, 4, 4, 3 }, sum = 0, sr = 0, ost = 0, srd = 0;
	_asm {
		lea esi, ots
		mov cl, 0
		mov al, 0
	cyc:
		cmp cl, 5
		je srnd
		inc cl
		mov al, [esi]
		add esi, 1
		add sum, al
		jmp cyc
	srnd:
	 }
	short ssum = sum;
	_asm {
		mov ax, ssum
		mov bl, 5
		div bl
		mov srd, al
		mov ost, ah
	}
	cout << "Assembler:" << endl;
	printf("sum = %i\n", sum);
	printf("sr = %i\n", srd);
	printf("ost = %i\n", ost);
	cout << "C:" << endl;
	cout << "sr = " << double(sum) / 5 << endl;
	system("pause");
    return 0;
}
void zad2() {
	char sum = 27,kol = 6, sr =0, ost = 0;
	_asm {
		mov al, sum
		mov ah, 0
		div kol
		mov sr, al
		mov ost, ah
	}
	cout << "Assembler:" << endl;
	printf("sum = %i\n", sum);
	printf("kol = %i\n", kol);
	printf("sr = %i\n", sr);
	printf("ost = %i\n", ost);
	cout << "C:" << endl;
	cout << "sr = " << double(sum) / sr << endl;
}

void zad3() {
	char ots[6] = { 8, 9, 4, 5, 7, 6 }, sum = 0;
	_asm {
		lea esi, ots
		mov al, 0
	cyc:
		mov al, [esi]
		cmp al, 7
		je vstr
		add esi, 1
		add sum, al
		jmp cyc
	vstr:
	}
	cout << "Assembler:" << endl;
	printf("sum = %i\n", sum);
}

int main() {
	setlocale(LC_ALL, "rus");
	zad3();
	system("pause");
	return 0;
}

