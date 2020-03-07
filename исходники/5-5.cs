using System;

namespace _5I
{
    class MainClass
    {

        public static void PrintArr(int[,] Arr)
        {
            for (int str_pos = 0; str_pos < Arr.GetLength(0); str_pos++)
            {
                Console.WriteLine();
                for (int col_pos = 0; col_pos < Arr.GetLength(1); col_pos++)
                {
                    Console.Write("|{0,3}|", Arr[str_pos, col_pos]);
                }
            }


        }
        public static void FillingArr(int [,] Arr)
        {
            Random rand = new Random();

            for (int str_pos = 0; str_pos < Arr.GetLength(0); str_pos++)
            {
                for (int col_pos = 0; col_pos < Arr.GetLength(1); col_pos++)
                {
                    Arr[str_pos, col_pos] = rand.Next(-20, 20);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("strings=");
            int str_size = Convert.ToInt32(Console.ReadLine());
            Console.Write("columns=");
            int col_size = Convert.ToInt32(Console.ReadLine());

            int[,] Matrix = new int[str_size, col_size];

            MainClass.FillingArr(Matrix);
            MainClass.PrintArr(Matrix);

            Console.WriteLine();


            int[] index = new int[Matrix.GetLength(1)];
            int[] charact = new int[index.Length];

            int tmp_var;

            for (int i = 0; i < Matrix.GetLength(1); i++)
            {

                tmp_var = 0;
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (Matrix[j, i] < 0  && Matrix[j, i] % 2 != 0)
                    {
                        tmp_var += Math.Abs(Matrix[j, i]);
                    }
                }

                charact[i] = tmp_var;
                index[i] = i;
                Console.WriteLine("Характеристика {0} столбца = {1}", i+1, charact[i]);
            }

            Array.Sort(charact,index);

           
            int[,] TmpMatrix = new int[str_size, col_size];
       
            for (int col_pos = 0; col_pos < Matrix.GetLength(1); col_pos++)
            {
                for (int str_pos = 0; str_pos < Matrix.GetLength(0); str_pos++)
                {
                    TmpMatrix[str_pos, col_pos] = Matrix[str_pos, index[col_pos]];
                }
            }
            Console.Write("\n");

            MainClass.PrintArr(TmpMatrix);


        }
    }
}
