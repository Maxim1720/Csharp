using System;

namespace _1V
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double F, a, b, x, c;
            Console.Write("a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("c:");
            c = Convert.ToDouble(Console.ReadLine());

           F = a < 0 && x != 0 && x!=c? -3 * a / (x - c) :  //через тернарный оператор условия
            c < 0 && a == 0? (x - b) / -c :
            c * (b - a) + x;

             /*if(a<0 && x != 0)               //черещз if else
              {
                  F = -3 * a / (x - c);
              }
              else if(c<0 && a == 0)
              {
                  F = (x-b) / -c ;
              }
              else
              {
                  F = c * (b - a) + x;
              }*/

            Console.WriteLine("result = " + F);
        }
    }
}
