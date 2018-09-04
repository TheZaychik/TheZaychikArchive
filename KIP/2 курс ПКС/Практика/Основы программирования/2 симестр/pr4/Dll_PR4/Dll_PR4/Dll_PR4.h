#ifndef MYDLLH
#define MYDLLH

#include <iostream>
#include <stdio.h>
#include <windows.h> 

extern "C" _declspec(dllexport) double func(double b, double x, double c);

#endif