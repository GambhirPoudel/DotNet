using System;

public class NRB
{
    public int Rupees { get; private set; }

    public NRB(int rupees = 0)
    {
        Rupees = rupees;
    }

    public static NRB operator +(NRB nrb1, NRB nrb2)
    {
        return new NRB(nrb1.Rupees + nrb2.Rupees);
    }

    public static NRB operator -(NRB nrb1, NRB nrb2)
    {
        return new NRB(nrb1.Rupees - nrb2.Rupees);
    }

    public override string ToString()
    {
        return $"{Rupees} Rupees";
    }
}
class Program
{
    static void Main()
    {
        NRB amount1 = new NRB(500);
        NRB amount2 = new NRB(300);

        NRB resultAddition = amount1 + amount2;
        NRB resultSubtraction = amount1 - amount2;

        Console.WriteLine("Amount 1: " + amount1);
        Console.WriteLine("Amount 2: " + amount2);
        Console.WriteLine("Result of addition: " + resultAddition);
        Console.WriteLine("Result of subtraction: " + resultSubtraction);
    }
}
