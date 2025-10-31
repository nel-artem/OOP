#pragma once

#include <string>

class longlong
{
private:
    long high;
    unsigned long low;
public:

    longlong(long high = 0, unsigned long low = 0);
    longlong(long longValue) : high(longValue / 1000000000), low(longValue % 1000000000) {}
    longlong(const longlong& other) : high(other high) low(other.low) {}

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
