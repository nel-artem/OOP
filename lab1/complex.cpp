#include "complex.h"
#include<iostream>
using namespace std;

complex complex::Init(double r, double f)
{
    complex tmp;
    tmp.first = r;
    tmp.second = f;
    return tmp;
}

void complex::Read()
{
    cout << "first = ";
    cin >> first;
    cout << endl;
    cout << "second = ";
    cin >> second;
    cout << endl;
}

void complex::Display()
{
    cout << first << " * " << second << " i" << endl;
}

complex complex::Multiply(complex M)
{
    complex tmp;
    tmp.first = this->first * M.first;
    tmp.second = this->second * M.second;
    return tmp;
}
