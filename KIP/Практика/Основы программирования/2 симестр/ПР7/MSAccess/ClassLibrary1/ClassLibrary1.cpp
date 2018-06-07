#include "stdafx.h"
#include "ClassLibrary1.h"
#include <random>
#include <time.h>

namespace ClassLibrary1 {
	void ClassLib::genmas(int* mas, int len) {
		srand(time(NULL));
		for (int i = 0; i < len; i++)
			mas[i] = -20 + rand() % 45;
	}
	 int ClassLib::setrezmas(int* mas, int* rezmas, int len) {
		int j = 0;
		for (int i = 0; i < len; i++) {
			if ((mas[i] % 2 == 0) && (mas[i] % 3 != 0)) {
				rezmas[j] = mas[i];
				j++;
			}
		}
		return j;
	}
}

