#pragma once
struct complex
{
private:
	double first, second;
public:
	complex Init(double r, double f);
	void Read();
	void Display();
	complex Multiply(complex M);
};

