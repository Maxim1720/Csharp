using System;

namespace _6II
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool flag = false;
            int word_count = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    flag = false;
                }
                else if(flag == false)
                {
                    flag = true;
                    word_count++;
                }
            }
            Console.WriteLine(word_count);
        }
    }
}
