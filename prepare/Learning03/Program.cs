using System;

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Welcome to Fractions!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetDeci());

        Fraction f2 = new Fraction(7);
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetDeci());

        Fraction f3 = new Fraction(4,16);
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetDeci());

        Fraction f4 = new Fraction(9,6);
        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetDeci());
    }
}