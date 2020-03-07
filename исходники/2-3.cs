using System;
namespace _3I
{
    class MainClass
    {
        static int UeCount(string str) {
            int Ue = 0;
            for (int i = 0; i < str.Length; i++)
            {
                Ue += str[i] == '+' || str[i] == '-' ? 3 :
                    str[i] == '*' ? 5 :
                    str[i] == '/' ? 7 :
                    str[i] == 'M' ? 13 :
                    str[i] == '=' ? 1 :
                    0;
            }
            return Ue;
        }
        public static void Main(string[] args)
        {
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d=");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("e=");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("m=");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("n=");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("p=");
            double p = Convert.ToDouble(Console.ReadLine());

            double y = Math.Sin(a);
            double k = ( b * c ) * Math.Pow(d, -m); 
            double z = Math.Cos(k);
            double q = (y * y) - (z * z);   //Разность квадратов  


            double x = Math.Pow(2, n) * q /
            (Math.Log10(a + k)/3.0 - (e * Math.Pow(2, -p)));

            Console.WriteLine(x);
            string str = " double y = Math.Sin(a);  double k = ( b * c ) * Math.Pow(d, m);double z = Math.Cos(k); double q = (y * y) - (z * z); double x = Math.Pow(2, n) * q / (Math.Log10(a + k)/3 - (e * Math.Pow(2, p)));";
            Console.WriteLine("После оптимизации (УЕ) = "+UeCount(str));

            x = Math.Pow(2, n) * (Math.Sin(a) + Math.Cos(b * c / Math.Pow(d, m))) * (Math.Sin(a) - Math.Cos(b * c / Math.Pow(d, m))) / 
            (Math.Log10(Math.Pow(a + b * c / Math.Pow(d, m), 1.0 / 3.0)) - (e / Math.Pow(2, p)));

            Console.WriteLine(x);
            str = "x = Math.Pow(2, n) * (Math.Sin(a) + Math.Cos(b * c / Math.Pow(d, m))) * (Math.Sin(a) - Math.Cos(b * c/ Math.Pow(d,m) )) / Math.Log10 (Math.Pow(a+b * c / Math.Pow(d, m),1.0/3.0)) - (e/ Math.Pow(2,p));";
            Console.WriteLine("До оптимизации = " + UeCount(str));
        }
    }
}
