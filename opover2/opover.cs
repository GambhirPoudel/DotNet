using System;

class Fraction
{
    private int num;
    private int den;

    public Fraction(int num, int den)
    {
        this.num = num;
        this.den = den;
    }

    
    public static Fraction operator --(Fraction f)
    {
        return new Fraction(f.num - 1, f.den);
    }

    
    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        int commonDenominator = f1.den * f2.den;
        int resultNumerator = (f1.num * f2.den) - (f2.num * f1.den);

        return new Fraction(resultNumerator, commonDenominator);
    }

    
    public override string ToString()
    {
        return $"{num}/{den}";
    }
}

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(6, 9);
        Fraction fraction2 = new Fraction(5, 8);


        Fraction resultDecrement = --fraction1;
        Console.WriteLine($"Unary Operator Overloading (--): {resultDecrement}");

        
        Fraction resultSubtraction = fraction1 - fraction2;
        Console.WriteLine($"Binary Operator Overloading (-): {fraction1} - {fraction2} = {resultSubtraction}");
    }
}
