
#include <iostream>
#include"complex.h"
using namespace std;

int main()
{
    complex a, b, c;
    a = a.Init(2, 5);
    a.Display();
    b.Read();
    b.Display();
    c = a.Multiply(b);
    c.Display();
    system("pause");
}
