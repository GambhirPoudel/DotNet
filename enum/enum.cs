using System;

class Enumeration
{
    
    enum Days
    {
        Sunday = 1,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }

    static void Main()
    {
        Console.WriteLine(" 1 dekhi 7 haal ");

        
        if (int.TryParse(Console.ReadLine(), out int x) && x >= 1 && x <= 7)
        {
            
            Days y = (Days)x;

            
            Console.WriteLine($"{x} no ma {y} parxa");
        }
        else
        {
            Console.WriteLine(" 1 dekhi 7 vnya bujdinas ");
        }
    }
}
