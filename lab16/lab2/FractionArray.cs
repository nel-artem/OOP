using System;
using System.Collections.Generic;

namespace lab2
{  
    internal class FractionArray
    {
        private List<Fraction> _data;

        public FractionArray()
        {
            _data = new List<Fraction>();
        }

        public FractionArray(Fraction[] fractions)
        {
            _data = new List<Fraction>(fractions);
        }

        public FractionArray(FractionArray other)
        {
            _data = new List<Fraction>();
            foreach (var f in other._data)
                _data.Add(new Fraction(f));
        }

        ~FractionArray() { _data.Clear(); }

        public Fraction this[int i]
        {
            get => _data[i];
            set => _data[i] = value;
        }

        public int Count => _data.Count;

        public void Add(Fraction f) => _data.Add(f);
        public void Remove(int i) => _data.RemoveAt(i);

        public void Print()
        {
            Console.Write("A = [ ");
            foreach (var f in _data)
                Console.Write($"{f}  ");
            Console.WriteLine("]");
        }

        public Fraction Sum()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Array is empty");
            Fraction result = new Fraction(0);
            foreach (var f in _data)
                result = result + f;
            return result;
        }

        public Fraction Average()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Array is empty");
            Fraction sum = Sum();
            return sum / new Fraction(_data.Count);
        }
    }
}