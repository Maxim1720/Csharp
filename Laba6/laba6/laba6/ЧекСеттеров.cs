using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class ЧекСеттеров
    {
        static void Main()
        {
            IPv4 transfer;
            while (1 > 0)
            {
                try { transfer = new IPv4(UInt64.Parse(Console.ReadLine()), UInt64.Parse(Console.ReadLine()));break; }

                catch 
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("Msg Size = {0}\nPackage size = {1}\nPackage amount = {2}",transfer.GetMsgSize(),transfer.GetPckSize(),transfer.GetPckAmount());
            Console.ReadKey();










        }

       
    }
}
