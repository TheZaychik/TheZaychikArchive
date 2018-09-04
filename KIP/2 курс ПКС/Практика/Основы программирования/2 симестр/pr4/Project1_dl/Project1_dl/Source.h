#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

namespace Funcs {
	class MyFunc {
	public:
		static MATHLIBRARY_API double func(double b, double x, double c);
	};
}
