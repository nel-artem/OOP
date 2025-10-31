// Лабораторна2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "longlong.h"
using namespace std;

int main()
{
	longlong a(1000000000); // Об'єкт, 1 мільярд
	longlong b(2000000000); // Об'єкт, 2 мільярди

	longlong sum = a + b; // Додавання
	longlong difference = b - a; // Віднімання

	cout << "Sum: " << sum.toString() << endl;
	cout << "Difference: " << difference.toString() << endl;


}
