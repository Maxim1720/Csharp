using System;

namespace _4II
{
    class MainClass
    {
        // recursive function to negative exponentiation.
        static double NegativePow(double a, int n)
        {
            if (n == 0)
                return 1;
            else if(n<0)
                return 1.0/(a*NegativePow(1.0 / a, n+1));
            return a * NegativePow(a, n - 1);
        }


        public static void Main(string[] args)
        {
            Console.Write("a:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("negative degree:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result = " + NegativePow(a,n));
        }


    }
}
