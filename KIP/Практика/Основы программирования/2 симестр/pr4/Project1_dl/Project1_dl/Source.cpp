#include "Source.h"
#include <stdexcept>

namespace Funcs {
	double MyFunc::func(double b, double x, double c) {
		double min, max;
		if (x > 1) {
			return x * sqrt(b*b + c * c);
		}
		else if (x <= 0) {
			min = sqrt(b);
			if (x*x < min)
				min = x * x;
			if (x + c < min)
				min = x + c;
			return min;
		}
		else {
			max = log10(b);
			if (x + c > max)
				max = x + c;
			return max;
		}
	}
}
