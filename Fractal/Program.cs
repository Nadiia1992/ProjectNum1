using System;

struct Fraction
{
    private int numerator;
    private int denominator;

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero");

            denominator = value; }
    }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public void Print()
    {
        Console.WriteLine($"{numerator} / {denominator} ");
    }

    public void Reduce()
    {
        int a = Math.Abs(numerator);
        int b = Math.Abs(denominator);

        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        numerator /= a;
        denominator /= a;
    }
}

    static class FractionCalculator
    {
        public static Fraction Add(Fraction f1, Fraction f2)
        {
            int num = f1.Numerator * f2.Denominator +
                f2.Numerator * f1.Denominator;

            int den = f1.Denominator * f2.Denominator;

            Fraction result = new Fraction(num, den);
            result.Reduce();
            return result;
        }

        public static Fraction Subtract(Fraction f1, Fraction f2)
        {
            int num = f1.Numerator * f2.Denominator -
                f2.Numerator * f1.Denominator;

            int den = f1.Denominator * f2.Denominator;

            Fraction result = new Fraction(num, den);
            result.Reduce();
            return result;
        }

        public static Fraction Multiply(Fraction f1, Fraction f2)
        {
            int num = f1.Numerator * f2.Numerator;
            int den = f1.Denominator * f2.Denominator;

            Fraction result = new Fraction(num, den);
            result.Reduce();
            return result;
        }

        public static Fraction Divide(Fraction f1, Fraction f2)
        {
        if (f2.Numerator == 0)
            throw new DivideByZeroException("Cannot divide by zero");

            int num = f1.Numerator * f2.Denominator;
            int den = f1.Denominator * f2.Numerator;

            Fraction result = new Fraction(num, den);
            result.Reduce();
            return result;
        }
    }

class Program
{
    static void Main()
    {
        try
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);

            Console.WriteLine("Fraction 1: ");
            f1.Print();

            Console.WriteLine("Fraction 2: ");
            f2.Print();

            Console.WriteLine("\nSum: ");
            Fraction sum = FractionCalculator.Add(f1, f2);
            sum.Print();

            Console.WriteLine("\nSubtract: ");
            Fraction sub = FractionCalculator.Subtract(f1, f2);
            sub.Print();

            Console.WriteLine("\nMultiply: ");
            Fraction mul = FractionCalculator.Multiply(f1, f2);
            mul.Print();

            Console.WriteLine("\nDivide: ");
            Fraction div = FractionCalculator.Divide(f1, f2);
            div.Print();
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
    
