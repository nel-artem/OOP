#include "Mathfuncslib.h"
#include "pch.h"
#include <stdexcept>

using namespace std;

namespace Mathfuncs
{
	double Mymathfuncs::Add(double a, double b)
	{
		return a + b;
	}

	double Mymathfuncs::Subtract(double a, double b)
	{
		return a - b;
	}

	double Mymathfuncs::Multiply(double a, double b)
	{
		return a * b;
	}

	double Mymathfuncs::Divide(double a, double b)
	{
		return a / b;
	}
}