using System;

namespace _2V
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // произведение первых n чисел последовательности, исключая каждый элемент кратный 3-ем.
            Console.Write("n=");
            uint n = Convert.ToUInt32(Console.ReadLine());
            double pow = 1;
            for(int k=1; k <= n; k++)
            {
                if (k % 3 != 0)
                {
                    pow *= (k + 1.0) / k;
                }
                else
                    n++;
            }

            Console.WriteLine("result = {0:##.###}",pow);
        
        }
    }
}
