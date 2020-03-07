using System;
namespace _3V
{
    class MainClass
    { 
        static uint Fact(uint n)
        {
            uint r = 1;
            for (uint i = 2; i <= n; ++i)
                r *= i;
            return r;
        }

        public static void Main(string[] args)
        {
            Console.Write("n=");
            uint n = Convert.ToUInt32(Console.ReadLine());
            uint sum = 0;
            for(uint i = 1; i <= n; i++)
            {
                sum += Fact(i);
            }

            Console.WriteLine("result=" + sum);
        }
    }
}
