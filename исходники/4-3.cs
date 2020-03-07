using System;
namespace _3I
{
    class MainClass
    {
        //searching max digit of number.
        static int MaxDigit(int n)
        {
            int max = 0;
            while (n != 0)
            {
                if (n % 10 > max)
                {
                    max = n % 10;
                }
                n /= 10;
            }
            return max;
        }

        static long CurrTimeInMilliseconds()
        {
            DateTime time = DateTime.Now;
            return ((time.Hour * 60 + time.Minute) * 60 + time.Second) * 1000 + time.Millisecond;
        }


        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int max_digit = MaxDigit(n);

            long executionTime = CurrTimeInMilliseconds();
            for (int i = 0; i < 1000000; i++)
            {
                MaxDigit(n);
            }

            executionTime = CurrTimeInMilliseconds() - executionTime;
            if (max_digit != 0)
            {
                Console.WriteLine("максимальная цифра: {0}", max_digit);
            }
            else
            {
                Console.WriteLine("число не натуральное");
            }

            Console.WriteLine("Время выполнения 1 000 000 повторов: {0} мс", executionTime);
            Console.ReadKey();
        }
    }
}
