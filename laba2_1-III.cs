using System;
class Sanek
{
    static void Main()
    {
        Console.Write("enter the num:");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 3; i++, x *= x) ;
        Console.WriteLine("x^8 = " + x);
    }
}

