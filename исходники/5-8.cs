using System;

namespace _8I
{
    class MainClass
    {

        static int[] MaxEl(int[][,] Arr)
        {
            int[] sum = new int[7];
            int l = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].GetLength(1); j++)
                {
                    sum[l] = Arr[i][0, j];
                    for (int k = 0; k < Arr[i].GetLength(0); k++)
                    {
                        if (sum[l] < Arr[i][k, j])
                        {
                            sum[l] = Arr[i][k, j];
                        }
                    }
                    l++;
                }
            }
            return sum;
        }



        public static void Main(string[] args)
        {
            int[][,] Jugged = new int[3][,];

            Jugged[0] = new int[2, 2];
            Jugged[1] = new int[3, 2];
            Jugged[2] = new int[2, 3];

            Random rand = new Random();

            int[] max = new int[7];

            for(int i = 0; i < Jugged.Length; i++)
            {
                for(int j = 0; j < Jugged[i].GetLength(0); j++)
                {
                    for(int k = 0; k < Jugged[i].GetLength(1); k++)
                    {
                        Jugged[i][j, k] = rand.Next(-50, 50);
                        Console.Write("{0,4} ", Jugged[i][j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            max = MaxEl(Jugged);
            int max_sum=0;
            for (int i = 0; i < max.Length; i++)
            {
                max_sum += max[i];
                Console.WriteLine("maximum of {0} column = {1}", i + 1, max[i]);
            }

            Console.Write("\n\nSum of maximum elements = {0}", max_sum);
        }
    }
}
