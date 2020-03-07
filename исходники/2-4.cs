using System;
namespace II
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double h, S;
            Console.WriteLine("Enter the highest point (meters):");
            h = Convert.ToDouble(Console.ReadLine())+1.78;

            S = Math.Pow((Math.Pow((6371000 + h), 2) - Math.Pow(6371000, 2)), 1 / 2.0);

            Console.WriteLine("\ndistance to the horizon: {0:f2} km", S/1000);
            if (S > 600000)
            {
                Console.WriteLine("\nYes,Captain Jack Sparrow will see land from the highest point.");
            }
            else
            {
                Console.WriteLine("No, He won't see land");
            }

        }
    }
}
