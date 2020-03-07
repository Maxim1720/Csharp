using System;

namespace _1IV
{
    class MainClass
    {
        static void Factorials(uint n)
        {
            int pow;
            for (int i = 1; i <= n; i++)
            {
                pow = 1;
                for (int j = 1; j <= i; ++j)
                {
                    pow *= j;
                }
                Console.WriteLine("{0}!={1}",i,pow);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("n:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Factorials(n);
        }
    }
}
