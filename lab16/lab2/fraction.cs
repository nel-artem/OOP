using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab2
{
    internal class Fraction
    {
        public int P { get; private set; }
        public int Q { get; private set; }

        public Fraction(int p = 0, int q = 1)
        {
            if (q == 0)
                throw new ArgumentException("Denominator cannot be zero");
            P = p; Q = q;
            Reduce();
        }

        public Fraction(Fraction other)
        {
            P = other.P; Q = other.Q;
        }

        ~Fraction() { }

        public void SetP(int p) { P = p; Reduce(); }
        public void SetQ(int q)
        {
            if (q == 0) throw new ArgumentException("Q != 0");
            Q = q; Reduce();
        }

        private void Reduce()
        {
            int g = GCD(Math.Abs(P), Q);
            P /= g;
            Q /= g;

            if (Q < 0)
            {
                P = -P;
                Q = -Q;

            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public Fraction Pow(int n)
        {
            if (n < 1) throw new ArgumentException("n must be >= 1");
            int newP = (int)Math.Pow(P, n);
            int newQ = (int)Math.Pow(Q, n);
            return new Fraction(newP, newQ);
        }

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.P * b.Q + b.P * a.Q, a.Q * b.Q);
        public static Fraction operator -(Fraction a, Fraction b)
            => new Fraction(a.P * b.Q - b.P * a.Q, a.Q * b.Q);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.P * b.P, a.Q * b.Q);
        public static Fraction operator /(Fraction a, Fraction b)
            => new Fraction(a.P * b.Q, a.Q * b.P);

        public static bool operator ==(Fraction a, Fraction b)
            => a.P * b.Q == b.P * a.Q;
        public static bool operator !=(Fraction a, Fraction b)
            => !(a == b);
        public static bool operator <(Fraction a, Fraction b)
            => a.P * b.Q < b.P * a.Q;
        public static bool operator >(Fraction a, Fraction b)
            => a.P * b.Q > b.P * a.Q;
        public static bool operator <=(Fraction a, Fraction b)
            => !(a > b);
        public static bool operator >=(Fraction a, Fraction b)
            => !(a < b);

        public int CompareTo(Fraction other)
            => (this < other) ? -1 : (this == other) ? 0 : 1;

        public override bool Equals(object obj)
            => obj is Fraction f && this == f;
        public override int GetHashCode()
            => HashCode.Combine(P, Q);

        public override string ToString()
            => Q == 1 ? $"{P}" : $"{P}/{Q}";
    }
}
