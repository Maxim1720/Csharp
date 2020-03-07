using System;
namespace _1I
{
    class MainClass
    {

        static int MultipleOf3(int[] Arr)
        {
            int count = 0;
            foreach(int i in Arr)
            {
                if (i % 3 == 0)
                {
                    ++count;
                }
            }
            return count;
        }
        static int Sum_Positive(int[] Arr)
        {
            int sum = 0;
            foreach (int i in Arr)
            {

                if (i > 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        static int FindMaxPos(int[] Arr)
        {
            int max=0,max_i=0;
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                    max_i = i;
                }
            }
            return max_i;
        }
        static bool NullValue(int[] Arr)
        {
            foreach(int i in Arr)
            {
                if (i == 0)
                    return true;
            }
            return false;
        }
        static int EvenNumb(int[] Arr)
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Arr[{0}] = {1}", i, Arr[i]);
            }
            return 0;
        }

        public static void Main(string[] args)
        {
            Random rand = new Random();

            int[] Arr = new int [15];
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rand.Next(-50, 50);
                Console.Write(Arr[i]+" ");
            }

            Console.WriteLine("\n\n1.The Count Multiple of 3 = " + MultipleOf3(Arr));
            Console.WriteLine("2.Positive num's sum = "+Sum_Positive(Arr));
            Console.WriteLine("3.The max positive element = " + FindMaxPos(Arr));
            if (NullValue(Arr))
            {
                Console.WriteLine("4.there is a null element in the array");
            }
            else
                Console.WriteLine("4.There is no null element in the array");
            Console.WriteLine("5.output elements with even numbers:"); EvenNumb(Arr);

        }
    }
}
