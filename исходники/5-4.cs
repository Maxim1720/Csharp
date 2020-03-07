using System;

namespace _4III
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("strings = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("columns = ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] Arr = new int[n, m];
            double average;

            Random rand = new Random();

            int min;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Arr[i,j] = rand.Next(-50, 100);
                    Console.Write("{0,3}|",Arr[i,j]);
                }
                Console.WriteLine();
            }


            for(int i = 0; i < m; i++)
            {
                min = Arr[0,i];
                for(int j=0; j < n; j++)
                {
                    if (Arr[j, i] < min)
                    {
                        min = Arr[j, i];
                    }
                }
                Console.WriteLine("{0} column = {1}",i+1,min);
            }



            int sum = 0, count = 0;
            foreach (int i in Arr)
            {
                if (i < 0)
                {
                    sum += i;
                    count++;
                }
            }

            average = sum / (double)count;
            Console.Write("\n\n\naverage = {0:F}", average);
        }
    }
}
