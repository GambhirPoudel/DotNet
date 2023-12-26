using Operator_Overloading;
using System.Security.Cryptography.X509Certificates;
class program 
{ 
    public static void Main() 
    { 
        TwoOl a = new TwoOl(1, 2); 
        TwoOl b = new TwoOl(3, 4);
        Console.WriteLine("Object a:"); 
        a.Show(); 
        Console.WriteLine("\nObject b:"); 
        b.Show();
        TwoOl result = a * b;
        Console.WriteLine("\nResult of multiplication:"); 
        result.Show(); 
    }
}