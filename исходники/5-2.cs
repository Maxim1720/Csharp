using System;

namespace _2II
{
    class MainClass
    {
        static void Randomize_Print(int[] Arr)
        {
            Random rand = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rand.Next(-50, 50);
                Console.Write("{0,5}|",Arr[i]);
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter array's size: ");
            int size = Int16.Parse(Console.ReadLine());
            int[] Arr = new int[size];
            Randomize_Print(Arr);

            int tmp = Arr[size - 1];
            for(int i = size-1; i>0; --i)
            {
                Arr[i] = Arr[i - 1];
            }
            Arr[0] = tmp;
            foreach(int i in Arr)
            {
                Console.Write("{0,5}|",i);
            }
        }
    }
}
