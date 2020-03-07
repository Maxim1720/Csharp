using System;
using System.Text;
namespace _7II
{
    class MainClass
    {


         static char  GetRandomChar()
        {
            Random rand = new Random();
            StringBuilder symbols = new StringBuilder("jklmnopqr012345?!;");
            int index = rand.Next(symbols.Length-1);
            return symbols[index];
        }


        public static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            string str1 = new string(' ',l);

            StringBuilder str = new StringBuilder(str1,l);
            for (int i = 0; i < str.Capacity; i++)
            {
                str[i] = GetRandomChar();
            }

            Console.WriteLine(str);

            for (int i = 0; i < str.Capacity; i++)
            {
                if (str[i] == '!')
                    str[i] = '_';
            }
            Console.WriteLine(str);
        }
    }
}
