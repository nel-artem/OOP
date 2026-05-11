using System;

namespace lab2
{
    internal class Program
    {
        static void Main()
        {
            // Масив А дробів
            var A = new FractionArray(new[]
            {
                new Fraction(1, 2),
                new Fraction(3, 4),
                new Fraction(2, 3),
                new Fraction(5, 6),
            });

            A.Print();

            Console.WriteLine($"Sum     = {A.Sum()}");
            Console.WriteLine($"Average = {A.Average()}");

            // Арифметика
            var a = new Fraction(3, 4);
            var b = new Fraction(1, 3);

            Console.WriteLine($"\n{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a}^3    = {a.Pow(3)}");

            // Порівняння
            Console.WriteLine($"\n{a} == {b}: {a == b}");
            Console.WriteLine($"{a} >  {b}: {a > b}");
            Console.WriteLine($"{a} <= {b}: {a <= b}");

            // Конструктор копіювання
            var copy = new Fraction(a);
            copy.SetP(7);
            Console.WriteLine($"\nOriginal: {a}, Copy after SetP(7): {copy}");
        }
    }
}