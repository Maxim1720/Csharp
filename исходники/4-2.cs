using System;

namespace _2V
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("a:");
            int a,b=0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                {
                    b = a;
                }
            } while (a != 0);
            if (b < 0)
            {
                Console.WriteLine("result = " + b);
            }
            else
                Console.WriteLine("Нет отрицательных чисел");
        }
    }
}
