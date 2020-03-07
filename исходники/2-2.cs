using System;

namespace _2III
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int num;
            Console.WriteLine("enter the natural num:");
            num = Convert.ToInt32(Console.ReadLine());
            num /= 10;
            num %= 10;
            Console.WriteLine(num);



            







            // Второе задание - III
            /*float x =(float)Convert.ToDouble(Console.ReadLine());
            int y = 0;
            x *= 10;
            y = (int)x % 10;
            Console.WriteLine(y);*/


            //Второе задание - II
            /*Console.WriteLine("Enter three-digit num:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);*/
        
        }
    }
}
