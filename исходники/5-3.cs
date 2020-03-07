using System;

class MainClass
{
    static void Randomize_Print(int[] Arr)
    {
        Random rand = new Random();

        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = rand.Next(1, 10);
            Console.Write(Arr[i] + " ");
        }
    }

    static bool Cheking(int[] Arr, int num, int position)
    {
        for(int i=0;i<position;i++)
        {
            if(Arr[i] == num)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        Console.Write("Enter the array's size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] Arr = new int[size];
        Randomize_Print(Arr);

        int[] TmpArr = new int[Arr.Length];
        Console.WriteLine();

        for(int i = 0; i < Arr.Length; i++)
        {
            TmpArr[i] = 0;
            if (Cheking(Arr, Arr[i], i) == true)
            {
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[j] == Arr[i])
                    {
                        TmpArr[i]++;
                    }
                }
                Console.Write(TmpArr[i] + " ");
            }
            else
                Console.Write("  ");
           
        }


    }
}
