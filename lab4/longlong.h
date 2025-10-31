#pragma once

#include <string>

class longlong
{
private:
    long high;
    unsigned long low;
public:

    longlong(long high = 0, unsigned long low = 0);

    void Init(long high, unsigned long low);
    void Read();
    void Display() const;
    std::string toString() const;

    longlong operator+(const longlong& other) const;
    longlong operator-(const longlong& other) const;
    longlong operator*(const longlong& other) const;
    bool operator==(const longlong& other) const;
    bool operator!=(const longlong& other) const;
    bool operator>(const longlong& other) const;
    bool operator<(const longlong& other) const;
    bool operator>=(const longlong& other) const;
    bool operator<=(const longlong& other) const;
};