// ab_para.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h";
#include  <iostream>;
using namespace std;
int main()
{
	signed char a, b, c, d, e, f;
	a = 5;
	b = 7;
	_asm {
		mov al, a;
		mov bl, b;
		not al;
		mov c, al;
		and al, bl;
		mov d, al;
		or al, bl;
		mov e, al;
		xor al, bl;
		mov f, al;
	}
	printf("\n%i", c);
	printf("\n%i", d);
	printf("\n%i", e);
	printf("\n%i", f);
	cout << endl;
	system("pause");
    return 0;
}

