#include "longlong.h"
#include <iostream>
using namespace std;

longlong::longlong(long high, unsigned long low) {
    this->high = high;
    this->low = low;
}

void longlong::Init(long high, unsigned long low) {
    this->high = high;
    this->low = low;
}

void longlong::Display() const {
    cout << "High: " << high << " Low: " << low << endl;
}

void longlong::Read() {
    cout << "������ �������� ������ �������: ";
    cin >> high;
    cout << "������ �������� ������ �������: ";
    cin >> low;
}

string longlong::toString() const {
    return "High: " + to_string(high) + ", Low: " + to_string(low);
}

longlong longlong::operator+(const longlong& other) const {
    unsigned long newLow = low + other.low;
    long newHigh = high + other.high + (newLow < low);
    return longlong(newHigh, newLow);
}

longlong longlong::operator-(const longlong& other) const {
    unsigned long newLow = low - other.low;
    long newHigh = high - other.high - (newLow < low);
    return longlong(newHigh, newLow);
}

longlong longlong::operator*(const longlong& other) const {
    unsigned long newLow = low * other.low;
    long newHigh = (high * other.low) + (low * other.high) + (high * other.high);
    newHigh += (newLow < low) ? 1 : 0;
    return longlong(newHigh, newLow);
}

bool longlong::operator==(const longlong& other) const {
    return (high == other.high && low == other.low);
}

bool longlong::operator!=(const longlong& other) const {
    return (high != other.high && low != other.low);
}

bool longlong::operator<(const longlong& other) const {
    if (high < other.high) return true;
    if (high > other.high) return false;
    return low < other.low;
}

bool longlong::operator>(const longlong& other) const {
    if (high > other.high) return true;
    if (high < other.high) return false;
    return low > other.low;
}

bool longlong::operator<=(const longlong& other) const {
    return !(*this > other);
}

bool longlong::operator>=(const longlong& other) const {
    return !(*this < other);
}