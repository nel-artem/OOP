// Лабораторна2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "longlong.h"
using namespace std;

int main()
{
    longlong num1(5, 1000000000);
    longlong num2(7, 2000000000);

    num1.Display();
    num2.Display();

    longlong sum = num1 + num2;
    sum.Display();

    longlong dif = num1 - num2;
    dif.Display();

    longlong mult = num1 * num2;
    mult.Display();

    if (num1 > num2) {
        cout << "num1 greater than num2";
    }
    else if (num1 < num2) {
        cout << "num2 greater than num1";
    }

}

